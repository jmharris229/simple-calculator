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
            try
            {
                double result = runExp.calculate("2+4");
                Console.WriteLine(result);
                Console.WriteLine(runExp.calculate("lastq"));
               // Console.WriteLine(runExp.calculate("lastq"));
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }
        }
    }
}
