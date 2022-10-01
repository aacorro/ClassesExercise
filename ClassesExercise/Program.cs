using System;

namespace ClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Make = "Toyota";
            car.Model = "Solara";
            car.Year = 2005;

            Console.WriteLine($"My car is a {car.Year} {car.Make} {car.Model}");

        }
    }
}
