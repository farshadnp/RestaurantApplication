using RestaurantApplication.Entities;
using RestaurantApplication.Management.UI;
using System;

FoodManagement management = new FoodManagement();

Food food1 = new Food(1,"Kabab",200-000);
Food food2 = new Food(2,"Ghorme Sabzi",180-000);
Food food3 = new Food(3,"Mahi",390-000);
Console.WriteLine("3 Food Initialized");
Console.ReadLine();


management.Add(food1);
management.Add(food2);
management.Add(food3);
Console.WriteLine("3 Food Added By Admin");
Console.ReadLine();

management.DisplayAll();
Console.WriteLine("Display All Foods");
Console.ReadLine();

management.DisplayById(food1.Id);
Console.WriteLine("Display Food By Id");
Console.ReadLine();

management.DisplayById(food2.Id);
Console.WriteLine("Display Food By Id");
Console.ReadLine();

management.DisplayById(food3.Id);
Console.WriteLine("Display Food By Id");
Console.ReadLine();

management.DeleteById(food1.Id);
Console.WriteLine("Deleting Food By Id");
Console.ReadLine();

management.DisplayAll();
Console.WriteLine("Display All Food After Deleting");
Console.ReadLine();`