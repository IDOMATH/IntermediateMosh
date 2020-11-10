﻿using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Does not compile becuase Shape is abstract
            // var shape = new Shape();

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}