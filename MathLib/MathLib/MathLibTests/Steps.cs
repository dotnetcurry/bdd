using MathLib;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MathLibTests
{
    [Binding]
    public sealed class Steps
    {
        [Given(@"a first number (.*)")]
        public void GivenAFirstNumber(int firstNumber)
        {
            ScenarioContext.Current.Add("FirstNumber", firstNumber);
        }

        [Given(@"a second number (.*)")]
        public void GivenASecondNumber(int secondNumber)
        {
            ScenarioContext.Current.Add("SecondNumber", secondNumber);
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            var firstNumber = (int)ScenarioContext.Current["FirstNumber"];
            var secondNumber = (int)ScenarioContext.Current["SecondNumber"];

            var mathLibOps = new MathLibOps();
            var addResult = mathLibOps.Add(firstNumber, secondNumber);

            ScenarioContext.Current.Add("AddResult", addResult);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            var addResult = (int)ScenarioContext.Current["AddResult"];
            Assert.AreEqual(expectedResult, addResult);
        }

    }
}
