using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class Evaluate
    {
        public Evaluate()
        {
            collection = new Expression();
            opers = new Operators();     
        }
        private Expression collection;
        Operators opers;
        public int calculate(string exp)
        {
                ParsedExp parsedExp = collection.collectTerms(exp);
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
        }

    }
