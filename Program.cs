using System;

// struct demo
namespace Demo
{
    interface IEquatable<T>
    {
        bool Equals(T obj);
    }

    class Car:IEquatable<Car>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public bool Equals(Car car)
        {
            return this.Make == car.Make && 
                   this.Model == car.Model && 
                   this.Year == car.Year;
        }
    }
    class Program
    {
        static void Main()
        {
            Car car1 = new Car { Make = "Toyota Innova", Model = "2.0G", Year = "2020" };
            Car car2 = new Car { Make = "Toyota Innova", Model = "2.0GX", Year = "2020" };

            if (car1.Equals(car2))
                Console.WriteLine("Both are same");
            else
                Console.WriteLine("Both are not same");
        }
    }
}