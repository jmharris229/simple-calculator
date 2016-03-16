using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace simple_calculator.tests
{
    [TestClass]
    public class dictionaryTests
    {
        [TestMethod]
        public void DictionaryTestHandlesLowercase()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            Dictionary<char, int> expected = new Dictionary<char, int>();

            //expected parts
            expected.Add('x', 1);

            //actual test
            dict.setDictionary('X', 1);

            bool expectThere = expected.ContainsKey('x');
            bool actualThere = dict.the_dictionary.ContainsKey('x');
            Assert.AreEqual(expectThere, actualThere);
        }
        [TestMethod]
        [ExpectedException(typeof(AlreadyDefinedConstantException))]
        public void DictionaryTestHandlesConstantsDefinedOnce()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();

            dict.setDictionary('x', 1);
            dict.setDictionary('x', 2);
        }
        [TestMethod]
        public void DictionaryTestProvesUseConstantsInExpression()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            dict.setDictionary('x', 1);
            double actual = mathey.calculate("x+2", dict);

            double expected = 3;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DictionaryTestProveUseConstantInSecondTerm()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            dict.setDictionary('x', 1);
            double actual = mathey.calculate("2+x", dict);

            double expected = 3;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DictionaryTestProveSetConstantThroughCalculate()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            double actual = mathey.calculate("x=1", dict);

            Assert.IsTrue(dict.the_dictionary.ContainsKey('x'));
        }
        [TestMethod]
        public void DictionaryTestProveSetConstantThroughCalculateSecondTerm()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            double actual = mathey.calculate("1=x", dict);

            Assert.IsTrue(dict.the_dictionary.ContainsKey('x'));
        }
        [TestMethod]
        public void DictionaryTestProveCanAddMultipleConstants()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            mathey.calculate("x=1", dict);
            mathey.calculate("y=2", dict);

            Assert.IsTrue(dict.the_dictionary.Count == 2);
        }
        [TestMethod]
        [ExpectedException(typeof(NoConstantException))]
        public void DictionaryTestHandlesIfConstantNotSaved()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            
            dict.the_dictionary.Add('x', 1);

            dict.constantsDictionary("y");
        }
       
    }
}
