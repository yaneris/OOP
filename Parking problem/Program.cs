using System;
using System.Collections.Generic;

namespace Parking_problem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("CarPark Problem");
            Carpark carpark = new Carpark(new List<Car>());
            
            Car car1 = new Car("Purple Car", 3);
            Car car2 = new Car("Yellow Car", 14); 
            Car car3 = new Car("Blue Car", 24);
            Car car4 = new Car("Red Car", 5);
            
            carpark.AddCar(car1);
            carpark.AddCar(car2);
            carpark.AddCar(car3);
            carpark.AddCar(car4);
            

            foreach (var car in carpark.Cars)
            {
                car.CarDisplay();
            }
            carpark.Display();

        }
    }
}