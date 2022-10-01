using System;
using System.Collections.Generic;


namespace ClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car();
            car1.Make = "Toyota";
            car1.Model = "Solara";
            car1.Year = 2005;

            Car car2 = new Car()
            {
                Make = "Honda",
                Model = "Civic",
                Year = 2008
            };

            Car car3 = new Car( "Chevy", "Silverado", 2010 );


            var inventory = new List<Car>() { car1, car2, car3 };
            {
                foreach (var car in inventory)
                {
                    Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
                }

            }
                 

            
        }
    }
}
