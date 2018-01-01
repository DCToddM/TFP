using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TFP.Domain.Abstract;
using TFP.Domain.Entities;
using TFP.WebUI.Controllers;

namespace TFP.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Paginate()
        {
            // Arrange
            Mock<IAccountsRepository> mock = new Mock<IAccountsRepository>();
            mock.Setup(m => m.Accounts).Returns(new Account[]
            {
                new Account { AccountName = "Test Account 1", AccountBalance = 100, AccountNumber = "666555222111", AccountType = "Savings" },
                new Account { AccountName = "Test Account 2", AccountBalance = 200, AccountNumber = "111555222111", AccountType = "Checking" },
                new Account { AccountName = "Test Account 3", AccountBalance = 300, AccountNumber = "222555222111", AccountType = "Credit Card" },
                new Account { AccountName = "Test Account 4", AccountBalance = 100, AccountNumber = "333555222111", AccountType = "Savings" },
                new Account { AccountName = "Test Account 5", AccountBalance = 200, AccountNumber = "444555222111", AccountType = "Checking" },
                new Account { AccountName = "Test Account 6", AccountBalance = 300, AccountNumber = "555555222111", AccountType = "Credit Card" },
            });

            AccountController controller = new AccountController(mock.Object);
            controller.PageSize = 3;

            // Act
            IEnumerable<Account> result = (IEnumerable < Account >) controller.List(2).Model;

            // Assert
            Account[] acctArray = result.ToArray();
            Assert.IsTrue(acctArray.Length == 2);
            Assert.AreEqual(acctArray[0].AccountName, "Test Account 4");
            Assert.AreEqual(acctArray[1].AccountName, "Test Account 5");
        }
    }
}
