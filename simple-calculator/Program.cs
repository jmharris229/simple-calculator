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
           Console.WriteLine("What would you like to evaluate?");
           string expression = Console.ReadLine();
            Evaluate runExp = new Evaluate();
            int result = runExp.calculate(expression);
            Console.WriteLine(result.ToString());
        }
    }
}
