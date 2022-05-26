using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Entities;

namespace OdeToFood.OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id);
    }




    public class InMemoryRestaurantData : IRestaurantData
    {
        //Declaring this the data type and structure of the List
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Scott's Pizza", Location = "Fort Collins", Cuisine=CuisineType.Itilian},
                new Restaurant { Id = 2, Name = "Tacohuaches", Location = "Huston", Cuisine=CuisineType.Mexican},
                new Restaurant { Id = 3, Name = "Pollo Curry", Location = "New York", Cuisine=CuisineType.Indian}
            };

        }


        public Restaurant GetById(int id){
            return restaurants.SingleOrDefault(r => r.Id == id);
        }


        public IEnumerable<Restaurant> GetRestaurantsByName(string name =  null)
        {
           return from r in restaurants
           where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                  orderby r.Name
                  select r;
        }
    }
}
