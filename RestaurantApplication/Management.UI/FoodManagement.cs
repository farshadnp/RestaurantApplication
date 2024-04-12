using RestaurantApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApplication.Management.UI
{
    public class FoodManagement
    {
        public FoodManagement()
        {
            FoodList = new List<Food>();
        }

        public List<Food> FoodList { get; set; }

        public void Add(Food food)
        {
            FoodList.Add(food);
            Console.WriteLine($"The food added with this Details: {food.Id} - {food.Name} - {food.Price} - {food.Description}");
        }

        public void Remove(Food food)
        {
            FoodList.Remove(food);
            Console.WriteLine($"The food added with this Details: {food.Id} - {food.Name}");
        }


        public void Update() 
        { }

        public void DeleteById(int id) 
        {
            var FindedFood = FoodList.FirstOrDefault(x => x.Id == id);
            if (FindedFood != null)
            {
                Console.WriteLine($"Deleted {FindedFood.Id}: {FindedFood.Name}");
                FoodList.Remove(FindedFood);
            }
            else
            {
                Console.WriteLine("There is no Food By This Id for Deleting.");
            }
        }

        public void DisplayAll() 
        { 
            foreach (var item in FoodList) 
            { 
                Console.WriteLine($"{item.Id}: {item.Name} - {item.Price}");
            }
        }
        
        
        public void DisplayById(int id) 
        { 
            var FindedFood = FoodList.FirstOrDefault(x=>x.Id == id);
            if ( FoodList.Count == 0 ) { Console.WriteLine("There is no food"); }
            if ( FindedFood == null ) { Console.WriteLine("There is no food with this Id"); }
            else 
            {
                Console.WriteLine($"{FindedFood.Id}: {FindedFood.Name} - {FindedFood.Price} - {FindedFood.Description}");
            }
        }
    }
}
