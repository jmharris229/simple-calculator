using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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
            Stack dict = new Stack();
            ParsedExp exp = math_add.collectTerms("1+2", dict);
            //tests to prove that the operator and terms were saved as numbers

            Assert.AreEqual(typeof(int),exp.term1.GetType());
        }
        [TestMethod]
        public void EnsureCapturingTerm2inExpression()
        {
            Evaluate mathey = new Evaluate();
            Expression math_add = new Expression();
            Stack dict = new Stack();
            ParsedExp exp = math_add.collectTerms("1+2", dict);
            //tests to prove that the operator and terms were saved as numbers

            Assert.AreEqual(typeof(int), exp.term2.GetType());
        }
        [TestMethod]
        public void EnsureCapturingOperatorinExpression()
        {
            Expression math_add = new Expression();
            Stack dict = new Stack();
            ParsedExp exp = math_add.collectTerms("1+2", dict);
            int opPresent = '+';
            //prove that the operator was saved and ensures that the correct operation was called
            Assert.AreEqual(opPresent, exp.oper);
        }
        [TestMethod]
        public void EnsureEvaluatHandleCorrectExpression()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            double result = mathey.calculate("1+2", dict);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTermException))]
        public void EnsureEvaluateHandleBadTermsExpressionEndOp()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            mathey.calculate("1+", dict);
        }
        [TestMethod]
        [ExpectedException(typeof(NoOperatorException))]
        public void EnsureEvaluateHandleBadTermsExpressionBegOp()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            mathey.calculate("%1", dict);
            
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTermException))]
        public void EnsureEvaluateHandleBadTermsExpressionExtraOp()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            mathey.calculate("1+%2", dict);
        }
        [TestMethod]
        [ExpectedException(typeof(NoOperatorException))]
        public void EnsureEvaluateHandleNoOperatorExpression()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            mathey.calculate("1", dict);
        }
        [TestMethod]
        public void EnsureCollectTermsHandleNegativeInFirstTerm()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            double act_result = mathey.calculate("-1+2", dict);
            int exp_result = 1;
            Assert.AreEqual(exp_result, act_result);
        }
        [TestMethod]
        public void EnsureCollectTermsHandleNegativeSecondTerm()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            double act_result = mathey.calculate("1+-2", dict);
            int exp_result = -1;
            Assert.AreEqual(exp_result, act_result);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidConstantDeclarationException))]
        public void EnsureCollectTermsHandlesInvalid2ConstantDec()
        {
            Evaluate mathey = new Evaluate();
            Stack dict = new Stack();
            mathey.calculate("x=y",dict);
            
        }
    }
}
