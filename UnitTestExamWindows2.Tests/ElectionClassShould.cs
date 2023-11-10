using System;
using Xunit;

namespace UnitTestExamWindows2.Tests
{
    public class Class1
    {
        [Theory]
        [InlineData("Hasna", true)]
        public void tester_verifier_date(DateTime date, bool expected)
        {
            Etudiant etud = new Etudiant();
            bool verif = etud.verifier_regex(p_nom);
            Assert.Equal(verif, expected);
        }
    }
}
