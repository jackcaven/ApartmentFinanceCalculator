using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApartmentFinanceCalculatorClassLibrary.Classes;

namespace ApartmentFinanceCalculatorTests
{
    [TestClass]
    public class AccountUnitTest
    {
        [TestMethod]
        public void DefaultAmountPaidEqualToZero()
        {
            Account account = new("DummyAccount");

            Assert.AreEqual(account.AmmountPaid, 0);
        }

        [TestMethod]
        public void NameIsAssignedInConstructor()
        {
            string nameForDummyAccount = "Dummy";

            Account account = new(nameForDummyAccount);

            Assert.AreEqual(account.AccountHolder, nameForDummyAccount);
        }
        
    }
};