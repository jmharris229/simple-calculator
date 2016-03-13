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
            Stack dictionary = new Stack();
            string input = exp;          
            input = input.Replace(" ", "");

            char[] opArray = new char[] { '+', '-', '/', '*', '%' };
            char ForP = '+';

            //check to to see if the 0 index is a negative. if so makes substring of input without it.
            if (input[0] == '-')
            {
                ForP = '-';
                
                //input is now a string without the negative at the beginning.
                input = input.Substring(1, input.Length-1);
            }

            //find the index of the operator
            int operatorIndex = input.IndexOfAny(opArray, 1);

            //throw an exception if no operator found
            if (operatorIndex == -1)
            {
                throw new NoOperatorException("Need an operator!");
            }

            char[] NoMinusOpArray = new char[] { '+', '/', '*', '%' };
            foreach (var item in NoMinusOpArray)
            {
                try
                {
                    if (input[0] == item || (operatorIndex + 1 < input.Length && input[operatorIndex + 1] == item) || input[input.Length - 1] == item || input[input.Length - 1] == '-')
                    {
                        throw new InvalidTermException("Invalid Term Placement.");
                    }
                }catch(IndexOutOfRangeException ex)
                {
                    throw new InvalidTermException("Invalid Term Placement.");
                }
 
            }

            //saves the value of the operator index
            char op = input[operatorIndex];

            //will attempt to split the input into two strings based on new input which starts without the negative at the beginning if there was one. and should split on the first instance of the operator.
            string[] terms = input.Split(new char[] { op }, 2);

            ParsedExp expression = new ParsedExp();
            if (ForP == '-')
            {
                expression.oper = op;
                expression.term1 = int.Parse(ForP + terms[0]);
                expression.term2 = int.Parse(terms[1]);
            }
            else
            {
                expression.oper = op;
                expression.term1 = int.Parse(terms[0]);
                expression.term2 = int.Parse(terms[1]);
            }
            return expression;
        }
    }
}
