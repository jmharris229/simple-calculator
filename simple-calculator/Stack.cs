﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class Stack
    {
        public string lastq { get; set; }
        public int last { get; set; }

        public Stack()
        {
            the_dictionary = new Dictionary<char, int>();
        }

        public Dictionary<char, int> the_dictionary { get; set; }
        //Dictionary<char, int> constants = new Dictionary<char, int>();

        public void setDictionary( char constant, int constantValue)
        {

            if (the_dictionary.ContainsKey(constant))
            {
                throw new AlreadyDefinedConstantException("Oops! That constant is already defined!");
            }
            else
            {
                the_dictionary.Add(char.ToLower(constant), constantValue);
                Console.WriteLine("= Saved {0} as {1}", constant, constantValue);
            }
        }

        public int constantsDictionary(string exp)
        {
            //create an if statement that checks to see if the value is there, if it is return the value, else throw exception that constant not defined
            if (the_dictionary.ContainsKey(exp[0]))
            {
                return the_dictionary[exp[0]];
            }
            else
            {
                throw new NoConstantException("That Constant is not defined!");
            }       
        }
    }
}
