using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
   public class Expression
    {
        virtual public string RecieveEquation()
        {
            string equation = "1 + 2";
            equation = equation.Replace(" ", "");
            return equation;
        }

        virtual public parsedExp collectTerms(string equate)
        {
            string equation = equate;
            equation = equation.Replace(" ", "");
            int operatorIndex = equation.IndexOfAny(new char[] { '+', '-', '/', '*' });
            char op = equation[operatorIndex];
            parsedExp dog = new parsedExp();
            dog.oper = op;
           
            string[] terms = equation.Split(op);
            dog.term1 = int.Parse(terms[0]);
            dog.term2 = int.Parse(terms[1]);
            return dog;
        }
    }
}
