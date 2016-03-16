using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace simple_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluate runExp = new Evaluate();
            Stack dictionary = new Stack();
            //Dictionary<char, int> constants = new Dictionary<char, int>();
            int exiter = 0;
            int counter = 1;

            while (exiter == 0)
            {
                Console.Write("[{0}]", counter);
                string expression = Console.ReadLine();
                try {
                    if (expression == "exit" || expression == "quit")
                    {
                        exiter = 1;
                        Console.WriteLine("Bye!");
                    }
                    else if (expression.IndexOfAny(new char['=']) > -1)
                    {
                        int constantValue = dictionary.constantsDictionary(expression);
                        Console.WriteLine("= {0}", constantValue);
                    }
                    else
                    {
                        double result = runExp.calculate(expression, dictionary);
                        counter++;
                        if (!expression.Contains("="))
                        {
                            Console.WriteLine("= {0}", result);
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("{0} Exception caught.", ex);
                }
            }
        }
    }
}
