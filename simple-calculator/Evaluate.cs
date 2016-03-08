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
            Prevterms = new Stack();   
        }
        private Expression collection;
        private Operators opers;
        private Stack Prevterms;
        public int calculate(string exp)
        {
            ParsedExp parsedExp = collection.collectTerms(exp);

            //determines the command to run based on the input
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
                Prevterms.lastq = exp;
                parsedExp = collection.collectTerms(exp);
                
            }

            //runs the operator function passed
            if (parsedExp.oper == '+')
            {
                int result = opers.add(parsedExp.term1, parsedExp.term2);
                Prevterms.last = result;
                return result;
            }
            else if (parsedExp.oper == '-')
            {
                int result = opers.subtract(parsedExp.term1, parsedExp.term2);
                Prevterms.last = result;
                return result;
            }
            else if (parsedExp.oper == '*')
            {
                int result = opers.multiply(parsedExp.term1, parsedExp.term2);
                Prevterms.last = result;
                return result;
            }
            else if (parsedExp.oper == '/')
            {
                int result = opers.divide(parsedExp.term1, parsedExp.term2);
                Prevterms.last = result;
                return result;
            }
            else
            {
                int result = opers.modulo(parsedExp.term1, parsedExp.term2);
                Prevterms.last = result;
                return result;
            }
         }
      }
}
