using System;

namespace Constructors2
{
    public class Vehicle
    {
        private readonly string _registrationNumber;
        //public Vehicle()
        //{
        //    Console.WriteLine("vehicle being init");
        //}
        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("vehicle bein inited with {0} RN", registrationNumber);
        }
    }
}
