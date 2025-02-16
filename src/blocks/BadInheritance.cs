namespace src
{
    public static class BadInheritance
    {
        // Example of inheritance that breaks Liskov Substitution Principle

        public static void Run()
        {
            
            void SetRectangleDimensions(Rectangle rect)
            {
                rect.Width = 5;
                rect.Height = 10;
                Console.WriteLine($"Area = {rect.GetArea()}");
            }

            Rectangle r = new Rectangle();
            SetRectangleDimensions(r);

            Rectangle s = new Square();
            SetRectangleDimensions(s);

        }

        public class Rectangle
        {
            // Using virtual keyword to allow subclasses to override parent definition
            public virtual int Width { get; set; }
            public virtual int Height { get; set; }

            public int GetArea()
            {
                return Width * Height;
            }
        }

        public class Square : Rectangle
        // Square child breaks inheritance from Rectangle parent
        {
            public override int Width
            {
                set { base.Width = base.Height = value; }
            }
            public override int Height
            {
                set { base.Width = base.Height = value; }
            }
        }
    }
}