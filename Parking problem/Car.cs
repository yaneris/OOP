using System;

namespace Parking_problem
{
    public class Car
    {
        public int Hours { get; set; }

        public double Charges = 2;

        public double maxCharges = 10;
        
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
                Charges = maxCharges;
                return maxCharges;
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