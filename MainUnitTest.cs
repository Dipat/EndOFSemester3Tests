using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EndOfSemester3.Controllers;

namespace EndOfSemester3.Tests
{
    [TestClass]
    public class UnitTest1
    {
        UsersController usersController = new UsersController();
        SalesController salesController = new SalesController();
        ProductsController productsController = new ProductsController();
        [TestMethod]
        public void CreateAccountTest()
        {
            // Arrange
            string userName = "test1";
            string password = "testpassword";
            string name = "testname";
            string email = "testemail";
            string address = "testaddress";

            // Act
            int returnValue = usersController.Create(userName, password, name, email, address);

            // Assert
            Assert.AreEqual(0, returnValue, 0.001, "Account created correctly");
        }

        [TestMethod]
        public void CreateSaleTest()
        {
            // Arrange
            string usersId = "test1";
            string description = "A generic football";
            int currentPrice = 100;
            DateTime endTime = DateTime.Now.AddDays(2);

            string name = "football";
            int startingPrice = 50;
            string location = "testlocation";
            int productTypes_id = 9;

            int productsId = productsController.Create(name, startingPrice, location, productTypes_id);

            // Act
            bool returnValue = salesController.Create(usersId, productsId, description, currentPrice, endTime);
            // Assert
            Assert.AreEqual(true, returnValue, "Sale created correctly");

        }

        [TestMethod]
        public void CreateAccount2Test()
        {
            // Arrange
            string userName = "testt";
            string password = "testpassword2";
            string name = "testname2";
            string email = "testemail2";
            string address = "testaddress2";

            // Act
            int returnvalue = usersController.Create(userName, password, name, email, address);

            // Assert
            Assert.AreEqual(0, returnvalue, 0.001, "Account created correctly");
        }

        [TestMethod]
        public void ModifyAccount2Test()
        {
            // Arrange
            string userName = "testt";
            string password = "testpassword2";
            string name = "testname2";
            string email = "testemail2@gmail.com";
            string address = "testaddress2";

            // Act
            bool returnValue = usersController.Update(userName, password, name, email, address);

            // Assert
            Assert.AreEqual(true, returnValue, "Account modified correctly");
        }

        [TestMethod]
        public void BidOnSaleTest()
        {
            // Arrange
            int salesId = 3;
            string usersId = "testt";
            int bidValue = 10;

            // Act
            bool returnValue = salesController.Bid(salesId, usersId, bidValue);

            // Assert
            Assert.AreEqual(true, returnValue, "Bid successfull");
        }

        [TestMethod]
        public void DeleteSaleTest()
        {

            // Arrange
            int saleID = 14;

            // Act
            salesController.Delete(saleID);

            // Assert
        }
    }
}
