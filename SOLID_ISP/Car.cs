using System;

namespace SOLID_ISP
{
    public class Car : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Kör våran bil");
        }
    }
}