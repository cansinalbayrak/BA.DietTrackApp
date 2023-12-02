using BA.DietTrackApp.BLL.Managers;
using BA.DietTrackApp.Entity.Entities;
using BA.DietTrackApp.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
using BA.DietTrackApp.DAL.Context;

namespace BA.DietTrackApp.PL.Forms
{
    public partial class Breakfast : Form
    {
        public MainForm mainForm;

        // Yöneticiler ve veritabanı işlemleri için gereken nesneler oluşturuluyor.
        MealManager mealmanager = new MealManager(new GenericRepository<Meal>(new AppDbContext()));
        FoodMealManager foodMealManager = new FoodMealManager(new FoodMealRepository(new AppDbContext()));
        FoodManager foodManager = new FoodManager(new GenericRepository<Food>(new AppDbContext()));
        List<FoodMeal> data2 = new List<FoodMeal>();

        public Breakfast()
        {
            InitializeComponent();
        }

        private void Breakfast_Load(object sender, EventArgs e)
        {
            // Kahvaltı düğmesi devre dışı bırakılıyor.
            mainForm.buttonBreakfast.Enabled = false;

            // Tarih etiketi ayarlanıyor.
            labelDate.Text = (mainForm.monthCalendar1.SelectionStart.Date.ToShortDateString() + "'de yediklerim.");

            // Yemek nesnesi oluşturuluyor ve veritabanına ekleniyor.
            Meal meal = new Meal()
            {
                Date = mainForm.monthCalendar1.SelectionStart.Date,
                MealTypeId = 1,
                UserId = mainForm.tempint,
            };
            mealmanager.Add(meal);

            // Combobox yemeklerle dolduruluyor.
            var data = foodManager.GetAll();
            foreach (var item in data)
            {
                comboBox1.Items.Add(item.FName);
            }

            // Veritabanından kullanıcıya ait yemekler alınıyor.
            data2 = foodMealManager.GetTablewMT().Where(x => x.Meal.UserId == mainForm.tempint && x.Meal.Date == mainForm.monthCalendar1.SelectionStart.Date && x.Meal.MealType.Id == 1).ToList();
            listBox1.Items.Clear();

            // Listbox'a veriler ekleniyor.
            foreach (var item in data2)
            {
                listBox1.Items.Add(item.Food.FName + "\t\t" + item.Food.Calori + "Kalori\t\t" + item.Portion + " porsiyon");
            }

            // Toplam kalori hesaplanıyor ve etikete ekleniyor.
            var data3 = foodMealManager.GetTablewMT().Where(x => x.Meal.UserId == mainForm.tempint && x.Meal.Date == mainForm.monthCalendar1.SelectionStart.Date && x.Meal.MealType.Id == 1).Sum(x => x.Food.Calori);
            label3.Text = "Toplam kalori= " + data3;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Combobox seçimi değiştiğinde tetiklenen olay.
            int temp = comboBox1.SelectedIndex;
            if (temp < 0)
            {
                return;
            }
            // Resim yükleniyor.
            using (Image resim = Image.FromFile($"{mainForm.soldir.ToString()}\\BA.YemekTakip.PL\\Images\\{temp + 1}.jpg"))
            {
                pictureBox1.Image = new Bitmap(resim);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mainForm.monthCalendar1.SelectionStart.Date > DateTime.Now)
            {
                MessageBox.Show("İleri tarihe ekleme yapılamaz.");
                return;
            }
            // Yemek ekleme düğmesine tıklandığında yapılacak işlemler.
            var data = mealmanager.GetAll().OrderByDescending(x => x.Id).First();

            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Lütfen yemek seçiniz.");
                return;
            }
            if (textBox1.Text == string.Empty)
            {
                textBox1.Text = "1";
            }

            // Yemek öğünü oluşturuluyor ve veritabanına ekleniyor.
            FoodMeal foodMeal = new FoodMeal()
            {
                FoodId = comboBox1.SelectedIndex + 1,
                Portion = Convert.ToInt32(textBox1.Text),
                MealId = data.Id,
            };
            foodMealManager.Add(foodMeal);

            data2 = foodMealManager.GetTablewMT().Where(x => x.Meal.UserId == mainForm.tempint && x.Meal.Date == mainForm.monthCalendar1.SelectionStart.Date && x.Meal.MealType.Id == 1).ToList();
            listBox1.Items.Clear();

            // Listbox'a veriler ekleniyor.
            foreach (var item in data2)
            {
                listBox1.Items.Add(item.Food.FName + "\t\t" + item.Food.Calori + "\t\t" + item.Portion);
            }

            // Toplam kalori hesaplanıyor ve etikete ekleniyor.
            var data3 = foodMealManager.GetTablewMT().Where(x => x.Meal.UserId == mainForm.tempint && x.Meal.Date == mainForm.monthCalendar1.SelectionStart.Date && x.Meal.MealType.Id == 1).Sum(x => x.Food.Calori);
            label3.Text = "Toplam kalori= " + data3;
        }

        private void Breakfast_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Kahvaltı penceresi kapatıldığında ana formdaki kahvaltı düğmesi etkinleştiriliyor.
            mainForm.buttonBreakfast.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Seçilen yemeği silme düğmesine tıklandığında yapılacak işlemler.
            FoodMealManager foodMealManager = new FoodMealManager(new FoodMealRepository(new AppDbContext()));
            foodMealManager.Delete(data2[listBox1.SelectedIndex]);
            data2.Remove(data2[listBox1.SelectedIndex]);
            listBox1.Items.Clear();

            // Listbox'a veriler ekleniyor.
            foreach (var item in data2)
                listBox1.Items.Add(item.Food.FName + "\t\t" + item.Food.Calori + "\t\t" + item.Portion);

            // Toplam kalori hesaplanıyor ve etikete ekleniyor.
            var data3 = foodMealManager.GetTablewMT().Where(x => x.Meal.UserId == mainForm.tempint && x.Meal.Date == mainForm.monthCalendar1.SelectionStart.Date && x.Meal.MealType.Id == 1).Sum(x => x.Food.Calori);
            label3.Text = "Toplam kalori= " + data3;
        }
    }
}
