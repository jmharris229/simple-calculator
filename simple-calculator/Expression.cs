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
            Stack Prevterms = new Stack();
            Console.WriteLine("Write expression");
            string input = exp;          
            input = input.Replace(" ", "");
            int operatorIndex = input.IndexOfAny(new char[] { '+', '-', '/', '*' },1);

            if(operatorIndex == -1)
            {
                throw new NoOperatorException("Need an operator!");
            }

            char op = input[operatorIndex];

            //check to to see if the 0 index is a negative. if so makes substring of 

            string[] terms = input.Split(new char[] { op }, 2);
           
            if(terms.Length != 2 || terms[1].Equals("") || terms[0].Equals(""))
            {
                throw new InvalidTermException("Not right terms.");
            }

            ParsedExp expression = new ParsedExp();
            expression.oper = op;
            expression.term1 = int.Parse(input.Substring(0,operatorIndex-1));
            expression.term2 = int.Parse(input.Substring(operatorIndex+1,input.Length-1));
            return expression;
        }
    }
}
