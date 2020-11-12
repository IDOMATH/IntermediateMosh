namespace MultipleInheritance
{
    public class TextBox : UiControl, IDraggable, IDroppable
    {
        public void Drag()
        {
            throw new System.NotImplementedException();
        }

        public void Drop()
        {
            throw new System.NotImplementedException();
        }
    }
    public class UiControl
    {
        public string Id { get; set; }
        public Size Size { get; set; }
        public Position TopLeft { get; set; }

        public virtual void Draw()
        {

        }
        public void Focus()
        {
            System.Console.WriteLine("Received focus");
        }
    }
}
