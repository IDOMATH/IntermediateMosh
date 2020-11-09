using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Blane";
            Console.WriteLine(cookie["name"]);
        }
    }
}
