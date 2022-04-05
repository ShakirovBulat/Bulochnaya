using Bulochnaya;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjAuth
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var authpage = new Login();
            Assert.IsTrue(authpage.Auth("",""));
        }
    }
}
