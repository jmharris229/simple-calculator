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
            char[] opArray = new char[] { '+', '-', '/', '*', '%' };
            char ForP = '+';

            //check to to see if the 0 index is a negative. if so makes substring of input without it.
            if (input[0] == '-')
            {
                ForP = '-';
                
                //input is now a string without the negative at the beginning.
                input = input.Substring(1, input.Length);
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
                if (input[0] == item || input[operatorIndex] + 1 == item || input[input.Length - 1] == item || input[input.Length - 1] == '-')
                {
                    throw new InvalidTermException("Invalid Term Placement.");
                }
            }

            char op = input[operatorIndex];
            string[] terms = input.Split(new char[] { op }, 2);
            /*//saves the index of the operator
            

            //will attempt to split the input into two strings based on new input which starts without the negative at the beginning if there was one. and should split on the first instance of the operator.
            
            
            //checks to see if the length of terms is 2, or if either position is an empty string. This makes sure we have the right amount of terms.
            if(terms.Length != 2 || terms[1].Equals("") || terms[0].Equals(""))
            {
                throw new InvalidTermException("Not right amount of terms.");
            }*/


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
            
            
            /*expression.term1 = int.Parse(input.Substring(0,operatorIndex-1));
            expression.term2 = int.Parse(input.Substring(operatorIndex+1,input.Length-1));*/
            return expression;
        }
    }
}
