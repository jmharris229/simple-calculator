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
        public int calculate(string express)
        {
           parsedExp parsedExp = collection.collectTerms(express);
           if(parsedExp.oper == '+')
            {
                return opers.add(parsedExp.term1, parsedExp.term2);
            }
           else if(parsedExp.oper == '-')
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
            else if (parsedExp.oper == '%')
            {
                 return opers.modulo(parsedExp.term1, parsedExp.term2);
            }
        }

    }
}
