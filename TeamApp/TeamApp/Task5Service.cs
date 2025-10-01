using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamApp
{
    public static class Task5Service
    {
        public static void Init()
        {
            bool checker = true;
            while (checker)
            {
                try
                {
                    Console.WriteLine("Enter Number 1: ");
                    int num1 = 0;
                    string sNum1 = Console.ReadLine();
                    if (!Int32.TryParse(sNum1, out num1)) {
                        throw new Exception("Number-1 is not number!"); 
                    }

                    Console.WriteLine("Select: +, -, *, /: ");
                    string sAction = Console.ReadLine();

                    Console.WriteLine("Enter Number 2: ");
                    int num2 = 0;
                    string sNum2 = Console.ReadLine();
                    if (!Int32.TryParse(sNum2, out num2))
                    {
                        throw new Exception("Number-2 is not number!");
                    }

                    double result = 0;
                    switch(sAction)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            result = num1 / num2;
                            break;
                        default:
                            throw new Exception("Invalid action!");
                    }

                    checker = false;
                    break;
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
        }
    }
}
