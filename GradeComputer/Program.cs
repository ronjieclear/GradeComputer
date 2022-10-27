using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GradeComputer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double highestgrade = 1.0;
            double lowestgrade = 5.0;
            int totalnoofitems = 100;
            int rawscore = 0;
            double grade = 5.0;

            Console.WriteLine("Welcome to Grade Computer!");
            Console.Write("Enter your raw score: ");
            rawscore = int.Parse(Console.ReadLine());

            grade = (((highestgrade - lowestgrade) / totalnoofitems) * rawscore)+lowestgrade;
            if (grade < 3.04)
            {
                Console.WriteLine($"Congratulations the score {rawscore} is equivalent to {grade}");
            }
            else
            {
                Console.WriteLine($"Sorry the score {rawscore} is equivalent to {grade}");
                Console.WriteLine("Yari ka boi, see you next year....");
            }
            
            Console.ReadLine();
        }
    }
}
