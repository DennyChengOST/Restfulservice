using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Interfaces.Managers;
using TestApi.Managers;
using TestApi.ServiceDefinition;

namespace TestApi.Tests.AcceptanceTests
{
    [TestClass]
   public class RestfulTest
    {
        private ProductDetailsManager _productDetailsManager;

        private IMapper _mapper;

        private ProductDetailsService _productDetailsService;

        [TestInitialize]
        public void Initialize()
        {
            //_productDetailsManager = new IProductDetailsManager();
            //_mapper = new IMapper();
            //_productDetailsService = new ProductDetailsService();
        }

        [TestMethod]
        public void GeneralTest()
        {

        }
    }
}
