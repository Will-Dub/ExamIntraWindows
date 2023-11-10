using Xunit;
using System;
using ExamWindows2;

namespace ExamWindows2
{
    public class ElectionClassShould
    {
        [Theory]
        [InlineData("12-11-2000", true)]
        [InlineData("01-11-1980", true)]
        [InlineData("12-11-1980", true)]
        public void tester_calculer_age(DateTime DN, bool expected)
        {
            
        }
    }
}