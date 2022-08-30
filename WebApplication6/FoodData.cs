using System.Linq;
using System.IO;

namespace WebApplication6
{
    public static class FoodData
    {
        /* public static IEnumerable<Food> Foods = new List<Food>
         {
             new Food { Name = "Cake", Price = 2.00m, ExpiationDate = "12.12.12", Quantity = 1 },
             new Food { Name = "Cookie", Price = 1.00m, ExpiationDate = "12.12.12", Quantity = 1 },
             new Food { Name = "Candy", Price = 0.50m, ExpiationDate = "12.12.12", Quantity = 1 },
             new Food { Name = "Ice Cream", Price = 0.50m, ExpiationDate = "12.12.12", Quantity = 1 },
             new Food { Name = "Chocolate", Price = 0.50m, ExpiationDate = "12.12.12", Quantity = 1 },
             new Food { Name = "Chips", Price = 0.50m, ExpiationDate = "12.12.12", Quantity = 1 },
             new Food { Name = "Bread", Price = 0.50m, ExpiationDate = "12.12.12", Quantity = 1 },
             new Food { Name = "Cake", Price = 0.50m, ExpiationDate = "12.12.12", Quantity = 1 },
             new Food { Name = "Cookie", Price = 0.50m, ExpiationDate = "12.12.12", Quantity = 1 }
         };
        */


        public static IEnumerable<Food> GetFoods()
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\lehovhan\source\repos\WebApplication6\WebApplication6\Repository\Food.txt"))
            {
                string? line = "";

                while ((line = sr.ReadLine()) != null)
                {
                    string[] items = line.Split(',');

                    Food food = new Food()
                    {
                        Name = items[0],
                        Price = decimal.Parse(items[1]),
                        ExpiationDate = items[2],
                        Quantity = int.Parse(items[3])
                    };

                    yield return food;
                }
            }
        }
    }
}
