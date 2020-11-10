namespace MethodOverriding
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a circle");
        }
    }
    public class Rectangle: Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("draw a rectangle");
        }
    }
    public class Tiangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("draw triangle");
        }
    }
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {

        }
    }
}
