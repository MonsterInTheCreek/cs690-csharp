using System;

namespace src.blocks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Will improve this UI a bit with time, simple for now

            Console.WriteLine("Enter a codeblock to call: ");
            string blockName = Console.ReadLine();

            switch (blockName.ToLower())
            {
                case "example":
                    Example.Run();
                    break;
                case "classes":
                    Classes.Run();
                    break;
                case "association":
                    Association.Run();
                    break;
            }
        }
    }
}