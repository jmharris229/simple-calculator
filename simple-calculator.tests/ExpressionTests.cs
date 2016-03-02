using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simple_calculator.tests
{
    [TestClass]
    public class ExpressionTests
    {
        [TestMethod]
        public void EnsureICanCallNewExpressionClass()
        {
            Expression math_add = new Expression();
            Assert.IsNotNull(math_add);
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
            ParsedExp exp = math_add.collectTerms();

            //tests to prove that the operator and terms were saved as numbers
            Assert.AreEqual(typeof(int),exp.term1.GetType());
            Assert.AreEqual(typeof(int),exp.term2.GetType());

           string op =  exp.oper.ToString();
           int opPresent =  op.IndexOfAny(new char[] { '+', '-', '/', '*', '%' });
            //prove that the operator was saved and ensures that the correct operation was called
           Assert.AreEqual(0, opPresent);
        }
        [TestMethod]
        public void EnsureCanHandleABadExpression()
        {
            Expression math_add = new Expression();
            string equation = "1+2";
            //ParsedExp actual = math_add.collectTerms(equation);
            //Assert.AreEqual(3, actual.Length);
        }
    }
}
