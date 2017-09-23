using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingSite.Models;

namespace BankingUnitTests
{
    [TestClass]
    public class CreditHistoryCheckerTests
    {
        [TestMethod]
        public void ShouldRecognisePeopleWithBadCredit()
        {
            // arrange
            var sut = new CreditHistoryChecker();

            // assign
            var isCreditWorthy = sut.CheckCreditHistory("Sarah", "Smith");

            // assert
            //Assert.That(isCreditWorthy, Is.False);
            //  Assert.isCreditWorthy.

            Assert.AreEqual(false, isCreditWorthy);
        }


        [TestMethod]
        public void ShouldOKPeopleWithGoodCredit()
        {
            var sut = new CreditHistoryChecker();

// red green refactor

            var isCreditWorthy = sut.CheckCreditHistory("Tom", "Smith");

            Assert.AreEqual(true, isCreditWorthy);

        }


    }
}
