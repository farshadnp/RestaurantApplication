using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApplication.Entities
{
    public class Customer
    {
        public Customer(int id, string fullName, string phoneNumber, List<Food> foods)
        {
            Id = id;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Foods = foods;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public List<Food> Foods { get; set; }

    }
}
