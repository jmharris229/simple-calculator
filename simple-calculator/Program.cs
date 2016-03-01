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
               int result = runExp.calculate();
                Console.WriteLine(result);

            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }
            Console.ReadLine();
        }
    }
}
