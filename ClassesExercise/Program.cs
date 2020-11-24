using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();

            myCar.Make = "Chevrolet";
            myCar.Model = "Classic";
            myCar.Year = 2004;

            Console.WriteLine($"{myCar.Year} {myCar.Make} {myCar.Model}");
        }
    }
}
