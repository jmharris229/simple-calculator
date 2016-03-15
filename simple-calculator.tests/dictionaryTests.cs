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
            Dictionary<char, int> actual = new Dictionary<char, int>();

            //expected parts
            expected.Add('x', 1);

            //actual test
            dict.setDictionary("X=1", actual);

            bool expectThere = expected.ContainsKey('x');
            bool actualThere = actual.ContainsKey('x');
            Assert.AreEqual(expectThere, actualThere);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DictionaryTestHandlesConstantsDefinedOnce()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            Dictionary<char, int> constants = new Dictionary<char, int>();

            dict.setDictionary("x=1", constants);
            dict.setDictionary("x=2", constants);
        }
        [TestMethod]
        public void DictionaryTestProvesUseConstantsInExpression()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            Dictionary<char, int> constants = new Dictionary<char, int>();
            dict.setDictionary("x=1", constants);
            double actual = mathey.calculate("x+2", dict, constants);

            double expected = 3;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DictionaryTestHandlesIfConstantNotSaved()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            Dictionary<char, int> constants = new Dictionary<char, int>();
            constants.Add('x', 1);

            dict.constantsDictionary("y", constants);
        }
       
    }
}
