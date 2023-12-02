using BA.DietTrackApp.BLL.Services;
using BA.DietTrackApp.DAL.Abstract;
using BA.DietTrackApp.DAL.Repository;
using BA.DietTrackApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.DietTrackApp.BLL.Managers
{
    public class FoodMealManager : BaseManager<FoodMeal>, IFoodMealService
    {
        FoodMealRepository mealRepository;
        public FoodMealManager(GenericRepository<FoodMeal> repository) : base(repository)
        {
            _repository = repository;
            mealRepository = (FoodMealRepository?)_repository;
        }
        public List<FoodMeal> GetAllTable()
        {
            return mealRepository.GetAllTable();
        }

        public List<FoodMeal> GetTablewFT()
        {
            return mealRepository.GetTablewFT();
        }
        public List<FoodMeal> GetTablewMT()
        {
            return mealRepository.GetTablewMT();
        }
    }
}
