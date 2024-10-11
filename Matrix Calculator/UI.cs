using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Calculator
{
    internal class UI
    {
        public static void MenuSelection()
        {   
            int choice = 0;
            bool validInput = false;
            do
            {
                Console.WriteLine("What Calculation would you like to do?");
                Console.WriteLine("1. Matrix Determinant");
                //add more when complete
#pragma warning disable CS8600
                string input = Console.ReadLine();
#pragma warning restore CS8600
                
                
                if (input == null || input.Length == 0)
                {
                    Console.WriteLine("Invalid input");
                }else
                {
                    input.Trim();
                    if(input.Length == 0)
                    {
                        Console.WriteLine("invalid input");
                    }
                    else
                    {
                        bool parsed = int.TryParse(input, out choice);
                        if (!parsed)
                        {
                            Console.WriteLine("Invalid input");
                        }
                        if (choice > 1)
                        {
                            Console.WriteLine("invalid input");
                        }
                        validInput = true;
                    }
                    
                }

            } while (!validInput);
            switch (choice)
            {
                case 1:
                    Determinant();
                    break;
                case 2:
                    Cofactor();
                    break;
                default:
                    Console.WriteLine("invalid Input");
                    break;
            }
        }
        private static void Determinant()
        {
            Console.WriteLine("What size of array?");
            Console.WriteLine("1. 2x2");
            Console.WriteLine("2. 3x3");
        }
        private static void Cofactor()
        {

            //MatrixMath.Cofactor3x3();
        }
    }
}
