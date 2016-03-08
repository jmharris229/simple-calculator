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
        public void EnsureCapturingTerm1InExpression()
        {
            Evaluate mathey = new Evaluate();
            Expression math_add = new Expression();

            ParsedExp exp = math_add.collectTerms("1+2");
            //tests to prove that the operator and terms were saved as numbers

            Assert.AreEqual(typeof(int),exp.term1.GetType());
        }
        [TestMethod]
        public void EnsureCapturingTerm2inExpression()
        {
            Evaluate mathey = new Evaluate();
            Expression math_add = new Expression();

            ParsedExp exp = math_add.collectTerms("1+2");
            //tests to prove that the operator and terms were saved as numbers

            Assert.AreEqual(typeof(int), exp.term2.GetType());
        }
        [TestMethod]
        public void EnsureCapturingOperatorinExpression()
        {
            Expression math_add = new Expression();
            ParsedExp exp = math_add.collectTerms("1+2");
            string op = exp.oper.ToString();
            int opPresent = op.IndexOfAny(new char[] { '+', '-', '/', '*', '%' });
            //prove that the operator was saved and ensures that the correct operation was called
            Assert.AreNotEqual(-1, opPresent);
        }
        [TestMethod]
        public void EnsureEvaluatHandleCorrectExpression()
        {
            Evaluate mathey = new Evaluate();
            int result = mathey.calculate("1+2");
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTermException))]
        public void EnsureEvaluateHandleBadTermsExpression()
        {
            Evaluate mathey = new Evaluate();
            mathey.calculate("1+");
            mathey.calculate("%1");
            mathey.calculate("-1");
        }
        [TestMethod]
        [ExpectedException(typeof(NoOperatorException))]
        public void EnsureEvaluateHandleNoOperatorExpression()
        {
            Evaluate mathey = new Evaluate();
            mathey.calculate("1");
        }
        [TestMethod]
        public void EnsureCollectTermsHandleNegativeInFirstTerm()
        {
            Evaluate mathey = new Evaluate();
            int act_result = mathey.calculate("-1+2");
            int exp_result = 1;
            Assert.AreEqual(exp_result, act_result);
        }
        [TestMethod]
        public void EnsureCollectTermsHandleNegativeSecondTerm()
        {
            Evaluate mathey = new Evaluate();
            int act_result = mathey.calculate("1+-2");
            int exp_result = -1;
            Assert.AreEqual(exp_result, act_result);
        }
    }
}
