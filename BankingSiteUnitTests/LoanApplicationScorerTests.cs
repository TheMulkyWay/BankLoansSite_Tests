using BankingSite.Models;
using Moq;
using NUnit.Framework;


namespace BankingSiteUnitTests
{
    [TestFixture]
    public class LoanApplicationScorerTests
    {
        [Test]
        public void ShouldRejectApplicationWhenOldEnoughButPoorCredit_classical()
        {
            //create an instances of the system under test using real collaborators
            // sut is as per the name ; the LoanApplicationScorer from the banking site models folder
            var sut = new LoanApplicationScorer(new CreditHistoryChecker());

            var LoanApplication = new LoanApplication
            {
                FirstName = "Sarah",
                LastName = "Smith",
                AnnualIncome = 1000000.01m,
                Age = 22

            };


        }



        [Test]
        public void ShouldRejectApplicationWhenOldEnoughButPoorCredit_mock()
        {

            var fakeTrumpCreditHistoryChecker = new Mock<ICreditHistoryChecker>();




            var sut = new LoanApplicationScorer(new CreditHistoryChecker());

            var LoanApplication = new LoanApplication
            {
                FirstName = "Sarah",
                LastName = "Smith",
                AnnualIncome = 1000000.01m,
                Age = 22

            };


        }



    }
}
