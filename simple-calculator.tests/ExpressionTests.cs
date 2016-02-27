using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simple_calculator.tests
{
    [TestClass]
    public class ExpressionTests
    {
        [TestMethod]
        public void EnsureICanCallNewClass()
        {
            Expression math_add = new Expression();
            Assert.IsNotNull(math_add);
        }
        [TestMethod]
        public void EnsureEnteredExpressionisString()
        {
            Expression math_add = new Expression();
            string exp = math_add.RecieveEquation();
            Assert.AreEqual(typeof(string), exp.GetType());
        }
        [TestMethod]
        public void EnsureNoSpacesPresentInExpression()
        {
            Expression math_add = new Expression();
            string exp = math_add.RecieveEquation();
            string expected = "1+2";
            Assert.AreEqual(expected, exp);
        }
        [TestMethod]
        public void EnsureCapturingTermsInExpression()
        {
            Expression math_add = new Expression();
            string[] exp = math_add.collectTerms();

            //tests to prove that the terms are all saved
            CollectionAssert.AreEqual(new string[] { "1", "2", "+" }, exp);

            //tests to prove that the operator was saved
            Assert.AreEqual("+", exp[2]);
        }
        [TestMethod]
        public void EnsureThatThereIsNotABadExpression()
        {
            Expression math_add = new Expression();
            string[] actual = math_add.collectTerms();
            Assert.AreEqual(3, actual.Length);
        }

    }
}
