using System;
using System.Collections.Generic;

namespace Parking_problem
{
    public class Carpark
    {
        public double TotalCharges = 0;
        public List<Car> Cars;

        public Carpark(List<Car> _cars)
        {
            Cars = _cars;
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void YesterdayReceipt()
        {
            foreach (var car in Cars)
            {
                car.CalculateCharges();
                TotalCharges += car.Charges;
            }
        }

        public void Display()
        {
            YesterdayReceipt();
            Console.WriteLine("Yesterday Receipt: {0} €", TotalCharges);
        }
    }
}