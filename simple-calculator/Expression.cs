﻿using System;
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

        virtual public string[] collectTerms()
        {
            string equation = "1+2";
            int operatorIndex = equation.IndexOfAny(new char[] { '+', '-', '/', '*' });
            char op = equation[operatorIndex];
            string[] terms = equation.Split(op);

            string oper = op.ToString();
            string[] Yep = new string[] { "1", "2", "+"};

            return Yep;

        }
    }
}