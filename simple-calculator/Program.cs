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
                Console.WriteLine("[{0}]", counter);
                string expression = Console.ReadLine();

                if (expression == "exit" || expression == "quit")
                {
                    exiter = 1;
                    Console.WriteLine("Bye!");
                }
                else
                {
                    double result = runExp.calculate(expression, dictionary);
                    counter++;

                    if(expression.IndexOfAny( new char['=']) > -1)
                    {
                        Console.WriteLine("= {0}", result);
                    }
                }
            }
        }
    }
}
