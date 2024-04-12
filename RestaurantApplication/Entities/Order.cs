using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApplication.Entities
{
    public class Order
    {

        public int Id { get; set; }
        public DateTime OrderDateTime { get; set; } = DateTime.Now;
        public int TotalPrice 
        { get 
            {

                foreach(var item in Foods)
                {
                    item.Price += TotalPrice;
                }
                return TotalPrice;
            }
        }
        public List<Food> Foods { get; set; }
    }
}
