using Xunit;
using System;
using ExamWindows2;

namespace ExamWindows2
{
    public class ElectionClassShould
    {
        [Theory]
        [InlineData("12-11-2000", false)]
        [InlineData("12-11-2100", true)]
        [InlineData("10-11-2023", false)]
        [InlineData("12-12-2023", true)]
        public void tester_verifier_date(DateTime DE, bool expected)
        {
            ExamWindows2.Election elect = new Election();
            elect.DateElection = DE;
            Assert.Equal(elect.verifier_date_election(), expected);
        }
    }
}