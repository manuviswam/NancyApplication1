using NUnit.Framework;

namespace NancyFunctionalE2ETests.StepDefinition
{
    public class AssertionStepBase
    {
        private StepBase stepBase { get; set; }

        public AssertionStepBase ResponseContent(StepBase step)
        {
            step.ActualResult = step.ResponseOutput.Content;
            stepBase = step;
            return new AssertionStepBase();
        }
        
        public AssertionStepBase Should()
        {
            return this;
        }

        public new StepBase Equals(object expectedResult)
        {
            Assert.AreEqual(stepBase.ActualResult, expectedResult, "Actual value:{0} \nExpected value:{1}", stepBase.ActualResult, expectedResult);
            return stepBase;
        }

        public StepBase NotEquals(object expectedResult)
        {
            Assert.AreNotEqual(stepBase.ActualResult, expectedResult, "Actual value:{0} \nExpected value:{1}", stepBase.ActualResult, expectedResult);
            return stepBase;
        }
    }
}