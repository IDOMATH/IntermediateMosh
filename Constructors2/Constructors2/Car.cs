using System;

namespace Constructors2
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            :base(registrationNumber)
        {
            Console.WriteLine("Car bein inited with {0} RN", registrationNumber);
        }
    }
}
