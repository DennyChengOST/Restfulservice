using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestApi.Interfaces.Managers;
using AutoMapper;
using TestApi.ServiceDefinition;

namespace TestApi.Tests.UnitTests.Services
{
    /// <summary>
    /// Summary description for IProductDetailsServiceShould
    /// </summary>
    [TestClass]
    public class ProductDetailsServiceShould
    {
        #region Fields

        private Mock<IProductDetailsManager> _mockProductDetailsManager;

        private Mock<IMapper> _mockMapper;

        private ProductDetailsService _productDetailsService;

        #endregion

        #region Setup

        [TestInitialize]
        public void Initialize()
        {
            _mockProductDetailsManager = new Mock<IProductDetailsManager>();
            _mockMapper = new Mock<IMapper>();
            _productDetailsService = new ProductDetailsService(_mockProductDetailsManager.Object, _mockMapper.Object);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _mockProductDetailsManager = null;
            _mockMapper = null;
            _productDetailsService = null;
        }

        #endregion

        #region Test Methods

        [TestMethod]
        public void Get_GetProductDetailsRequest_ReturnsResponse()
        {
            // Arrange

            //Act

            //Assert

        }

        #endregion

    }
}
