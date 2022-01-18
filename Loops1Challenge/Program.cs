using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops1Challenge
{
    internal class Program
    {
        static string scoreEntry;
        static int score;

        static int sum;
        static int result;
        static int lenght = 0;

        static bool success;

        static void Main(string[] args)
        {
            Console.WriteLine("Let's caculate some grades!");
            StoreScores();

            Console.Read();
        }

        static void StoreScores()
        {
            do
            {
                Console.WriteLine("Enter a grade or type '-1' to see the result");
                scoreEntry = Console.ReadLine();
                

                if (scoreEntry != "-1")
                {
                    success = Int32.TryParse(scoreEntry, out score);
                    lenght++;
                }
                else
                {
                    break;
                }
                sum += score;

                if (!success || score > 20)
                {
                    Console.WriteLine("Invalid value! Please restart");
                    sum = 0;
                    lenght = 0;

                    continue;
                }

            } while (score >= 0);

            CalculateAvarege();
        }

        static void CalculateAvarege()
        {
            result = sum / lenght;

            Console.WriteLine("The average is: {0}", result);
            Console.ReadLine();

            Console.WriteLine("If you want to check another student type 'other', or just press enter to quit ");
            string choice = Console.ReadLine();

            if (choice.Equals("other"))
            {
                StoreScores();
            }
            else
            {
                Console.WriteLine("See you next time!");
            }
        }
    }
}
