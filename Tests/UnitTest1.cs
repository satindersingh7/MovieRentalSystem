using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRentalSystem;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckConnection()
        {
            Assert.AreEqual(true, new Database().CheckConnection());
        }

        [TestMethod]
        public void GetValues()
        {
            Database database = new Database();
            DataTable table = database.GetCustomers();
            Assert.IsNotNull(table);
        }
    }
}
