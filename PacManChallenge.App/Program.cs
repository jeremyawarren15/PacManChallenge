using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManChallenge.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\DotNetProjects\PacManChallenge\PacManChallenge.App\KataPacman-seq.txt";

            var file = File.ReadAllText(path);

            var elements = new List<string>(file.Split(',').ToList());

            var pacMan = new PacMan();

            foreach (var element in elements)
            {
                if (pacMan.isAlive)
                    pacMan.Eat(element);
                else
                    break;
            }

            Console.WriteLine($"Total points:{pacMan.Points} Lives gained:{pacMan.NewLivesGained}");
        }
    }
}
