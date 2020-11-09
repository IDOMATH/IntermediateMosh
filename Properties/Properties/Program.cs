using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1996, 10, 17));
            Console.WriteLine(person.Age);
        }
    }
}
