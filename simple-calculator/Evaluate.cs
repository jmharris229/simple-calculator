using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class Evaluate
    {

        private Expression collection = new Expression();
        Operators opers = new Operators();
        public int calculate()
        {
            try
            {
                ParsedExp parsedExp = collection.collectTerms();
                if (parsedExp.oper == '+')
                {
                    return opers.add(parsedExp.term1, parsedExp.term2);
                }
                else if (parsedExp.oper == '-')
                {
                    return opers.subtract(parsedExp.term1, parsedExp.term2);
                }
                else if (parsedExp.oper == '*')
                {
                    return opers.multiply(parsedExp.term1, parsedExp.term2);
                }
                else if (parsedExp.oper == '/')
                {
                    return opers.divide(parsedExp.term1, parsedExp.term2);
                }
                else
                {
                    return opers.modulo(parsedExp.term1, parsedExp.term2);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               return  this.calculate();
            }
        }

    }
}
