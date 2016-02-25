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
            string exp = math_add.collectTerms();

        }

    }
}
