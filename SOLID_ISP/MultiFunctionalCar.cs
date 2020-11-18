using System;

namespace SOLID_ISP
{
    public class MultiFunctionalCar : IMultiFunctionalVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Kör en multifunktionel bil");
        }

        public void Fly()
        {
            Console.WriteLine("Flyger våran multifunktionella bil");
        }
    }
}