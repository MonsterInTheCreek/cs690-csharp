using System;
using System.IO;
using System.Text.RegularExpressions;

namespace src.blocks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Files currently available for call:");

            // Use IO and regex to get all files in ./blocks dir
            string[] files = Directory.GetFiles("./blocks/");
            string pattern = @"\.\/blocks\/(\w+).cs";
            Regex regex = new Regex(pattern);
            int fileCount = files.Count();
            for (int i = 0; i < fileCount; i++)
            {
                Match match = regex.Match(files[i]);
                if (i == fileCount - 1)
                {
                    Console.Write(match.Groups[1] + "\n");
                } else {
                    Console.Write(match.Groups[1] + ", ");
                }
            }

            Console.WriteLine("\nEnter a codeblock to call: ");
            string blockName = Console.ReadLine();

            // call specific ./blocks codeblock entered
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
                case "instanceversusstatic":
                    InstanceVersusStatic.Run();
                    break;
                case "interface":
                    Interface.Run();
                    break;
                case "badinheritance":
                    BadInheritance.Run();
                    break;
            }
        }
    }
}