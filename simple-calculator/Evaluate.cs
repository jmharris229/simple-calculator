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
        private Stack Prevterms = new Stack();
        public int calculate(string exp)
        {
            try
            {
                //determines what command the user is calling
                ParsedExp parsedExp = new ParsedExp();
                if (exp.Equals("last"))
                {
                    parsedExp = collection.collectTerms(Prevterms.last.ToString());
                }
                else if (exp.Equals("lastq"))
                {
                    parsedExp = collection.collectTerms(Prevterms.lastq);
                }
                else
                {
                    parsedExp = collection.collectTerms(exp);
                }
                //ParsedExp parsedExp = collection.collectTerms(exp);

                //evaluates expression
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
               return  this.calculate(exp);
            }
        }

    }
}
