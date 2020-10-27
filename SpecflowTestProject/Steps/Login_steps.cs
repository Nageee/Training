using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowTestProject.Steps
{
    [Binding]
    public sealed class Login_steps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef


        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
