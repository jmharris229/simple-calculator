using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluate runExp = new Evaluate();
            Stack dictionary = new Stack();
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
                else if (expression.Contains('='))
                {
                    dictionary.setDictionary(expression);
                    counter++;
                }
                else
                {
                    double result = runExp.calculate(expression);
                    counter++;
                    Console.WriteLine("= {0}", result);
                }
            }
            /* try
             {
                 double result = runExp.calculate("2+4");
                 Console.WriteLine("= "+result);
                 Console.WriteLine(runExp.calculate("lastq"));
                 Console.ReadKey();
             }
             catch (Exception ex)
             {
                 Console.WriteLine("{0} Exception caught.", ex);
             }*/
        }
    }
}
