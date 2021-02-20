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

    public class Car
    {
        public int Hours { get; set; }

        public double Charges = 2;
        
        public string Name { get; set; }
        
        public Car(string _name, int _hours)
        {
            Hours = _hours;
            Name = _name;
        }

        public double CalculateCharges()
        {
            if (Hours < 3)
                return Charges;
            if (Hours == 24)
            {
                Charges = 10;
                return Charges;
            }
            Charges += 0.5 * Hours;
            return Charges;
        }

        public void CarDisplay()
        {
            Console.WriteLine("Name: {0}", Name);
            CalculateCharges();
            Console.WriteLine("Hours: {0} h", Hours);
            Console.WriteLine("Charges: {0} €", Charges);
            Console.WriteLine("--------------");
            Charges = 2;
        }
    }
}