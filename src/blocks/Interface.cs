namespace src
{
    public static class Interface
    {
        public static void Run()
        {
            Console.WriteLine("Instantiate without interface:");
            Circle circle = new Circle();
            Square square = new Square();
            circle.Draw();
            square.Draw();

            Console.WriteLine("Instantiate with interface:");
            IShape circleInt = new CircleInt();
            IShape squareInt = new SquareInt();
            circleInt.Draw();
            squareInt.Draw();

            Console.WriteLine("Instantiate using interface array:");
            IShape[] shapes = { new CircleInt(), new SquareInt() };
            foreach (IShape shape in shapes) {
                shape.Draw();       // No predicate used to differ between two types, .Draw() works for both.
            }

        }

        public interface IShape
        {
            void Draw();
        }


        public class Circle
        {
            public void Draw()
            {
                Console.WriteLine("Drawing a Circle (without interface)");
            }
        }

        public class CircleInt : IShape
        {
            public void Draw()
            {
                Console.WriteLine("Drawing a Circle (with interface)");
            }
        }

        public class Square
        {
            public void Draw()
            {
                Console.WriteLine("Drawing a Square (without interface)");
            }
        }

        public class SquareInt : IShape
        {
            public void Draw()
            {
                Console.WriteLine("Drawing a Square (with interface)");
            }
        }
    }
}