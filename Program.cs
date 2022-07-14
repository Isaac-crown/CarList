
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace CONSOLEUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<car> cars = CarProducts.CarProduct();

            var GroupOfCars = from n in cars
                              group n by n.Maker into g
                              select (Car: g.Key, carspro: g);




            foreach (var orderGroup in GroupOfCars)
            {
                Console.WriteLine($"Products of {orderGroup.Car} category:  and the total {orderGroup.Car.Count()} " );
                foreach (var product in orderGroup.carspro)
                {
                    Console.WriteLine(product.Brand);
                }
            }











            Console.ReadLine();
        }

      

   
    }


    public class car
    {
        public string? Brand { get; set; }
        public string? Maker { get; set; }
    }

    public static class CarProducts
    {
       public static List<car> CarProduct()
        {
            List<car> products = new List<car>();

                products.Add(new car { Brand = "Camry", Maker = "Toyota" });
                products.Add(new car { Brand = "Venza", Maker = "Toyota" });
                products.Add(new car { Brand = "Corrola", Maker = "Toyota" });
                products.Add(new car { Brand = "Avalon", Maker = "Toyota" });
                products.Add(new car { Brand = "Yaris", Maker = "Toyota" });
                products.Add(new car { Brand = "Sienna", Maker = "Toyota" });
                products.Add(new car { Brand = "Benz", Maker = "Mercedes" });
                products.Add(new car { Brand = "AMG", Maker = "Mercedes" });
                products.Add(new car { Brand = "Maybach", Maker = "Mercedes" });
                products.Add(new car { Brand = "EQ", Maker = "Mercedes" });



            return products;
        }

    }

}
