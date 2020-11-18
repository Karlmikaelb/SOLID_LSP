using System;

namespace SOLID_ISP
{
    public class Airplane : IAirplane
    {
        public void Fly()
        {
            Console.WriteLine("Flyger vårat flygplan");
        }
    }
}