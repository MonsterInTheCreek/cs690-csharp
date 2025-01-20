namespace src
{
    public static class InstanceVersusStatic
    {
        public static void Run()
        {
            // from Oreilly reference book
            Panda p1 = new Panda("Pan Dee");
            Panda p2 = new Panda("Pan Dah");

            Console.WriteLine(p1.Name);             // Access Name from a specific instance
            Console.WriteLine(p2.Name);

            Console.WriteLine(Panda.Population);    // Access Population from class itself, not an instance

        }

        public class Panda
        {
            public string Name;             // Implicit part of a specific instance
            public static int Population;   // Explicit part of class itself
            public Panda (string name)
            {
                this.Name = name;
                Population++;               // Does not use 'this' keyword, because 'this' implies a specific instance
            }
        }
    }
}