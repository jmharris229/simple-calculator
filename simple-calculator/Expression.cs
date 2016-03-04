using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
   public class Expression
    {
        public string RecieveEquation()
        {
            string equation = "1 + 2";
            equation = equation.Replace(" ", "");
            return equation;
        }

        public ParsedExp collectTerms(string exp)
        {
            Console.WriteLine("Write expression");
            string input = exp;          
            input = input.Replace(" ", "");
            int operatorIndex = input.IndexOfAny(new char[] { '+', '-', '/', '*' });

            if(operatorIndex == -1)
            {
                throw new NoOperatorException("Need an operator!");
            }

            char op = input[operatorIndex];
            string[] terms = input.Split(op);
           
            if(terms.Length != 2 || terms[1].Equals("") || terms[0].Equals(""))
            {
                throw new InvalidTermException("Not right terms.");
            }

            ParsedExp expression = new ParsedExp();
            expression.oper = op;
            expression.term1 = int.Parse(terms[0]);
            expression.term2 = int.Parse(terms[1]);
            return expression;
        }
    }
}
