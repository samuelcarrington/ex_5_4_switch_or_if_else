using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_5_4_switch_or_if_else
{
    class Program
    {
        static void Main()
        {
            /*5-4	Write a program that applies bonus points to given scores 
            in the range [1…9] by the following rules: 
            -  If the score is between 1 and 3, the program multiplies it by 10. 
            -  If the score is between 4 and 6, the program multiplies it by 100. 
            -  If the score is between 7 and 9, the program multiplies it by 1000. 
            -  If the score is 0 or more than 9, the program prints an error message. 
            (Chapter 5, Execise 10)*/

            Console.WriteLine("Enter a score in the range of [1...9].");
            int firstScore = int.Parse(Console.ReadLine());
            int bonusPoints = firstScore;
            switch (firstScore)
            {
                case 1:
                case 2:
                case 3:
                    bonusPoints = (firstScore * 10);
                    Console.WriteLine("Your bonus points are: {0}", bonusPoints); break;
                case 4:
                case 5:
                case 6:
                    bonusPoints = (firstScore * 100);
                    Console.WriteLine("Your bonus points are: {0}", bonusPoints); break;
                case 7:
                case 8:
                case 9:
                    bonusPoints = (firstScore * 1000);
                    Console.WriteLine("Your bonus points are: {0}", bonusPoints); break;
                default:
                    Console.WriteLine("Error, Unknown number!"); break;
            }
            Console.ReadKey();
        }
    }
}
