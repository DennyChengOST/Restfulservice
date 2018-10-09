using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestApi.Tests.UnitTests
{
    /// <summary>
    /// Summary description for FoodAccessShould
    /// </summary>
    [TestClass]
    public class FoodAccessShould
    {
        private Repositories.FoodAccess _foodAccess;

        [TestInitialize]
        public void Initialize()
        {
            _foodAccess = new Repositories.FoodAccess();
        }

        [TestMethod]
        public void FoodGetShould()
        {
            //Arrange
            //_foodAccess.Testfunction();
            //_foodAccess.StoreFood("meow");
            //var food = _foodAccess.SearchFood("Grape");
            //_foodAccess.Updatefood("grape","grapesz");
            //var mewo = "meow";
            _foodAccess.DeleteFood("meow");



            //Act

            //Assert

        }

    }
}
