using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CHR.ServiceStack.Plugins.Models.HealthCheckFeature;
using ServiceStack;

namespace TestApi.Tests.AcceptanceTests
{
    [TestClass]
    public class AcceptanceTest
    {
        private IJsonServiceClient _jsonClient;

        [TestInitialize]
        public void InitializeTestData()
        {
            Console.WriteLine("--AppSettings--");
            foreach (var key in ConfigurationManager.AppSettings.AllKeys)
            {
                Console.WriteLine($"{key}: '{ConfigurationManager.AppSettings[key]}'");
            }
            Console.WriteLine("--End AppSettings--");
            _jsonClient = new JsonServiceClient(ConfigurationManager.AppSettings["ServiceUrl"]);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _jsonClient.Dispose();
        }

        [TestMethod, TestCategory("AutomatedAcceptance")]
        public void CheckServiceHealth_ShouldBeHealthy()
        {
            HealthCheckRequest request = new HealthCheckRequest();

            Console.WriteLine($"Calling Health Check...");
            try
            {
                _jsonClient.Get(request);
            }
            catch (WebServiceException ex)
            {
                var unresolvedDependencies = ex.ResponseStatus?.Errors?.Select(responseError => responseError.Message);

                if (unresolvedDependencies != null && unresolvedDependencies.Any())
                {
                    Console.WriteLine($"Found {unresolvedDependencies.Count()} unresolved dependencies");

                    foreach (var unresolvedDependency in unresolvedDependencies)
                    {
                        Console.WriteLine($"Dependency that was unresolved: {unresolvedDependency}");
                    }
                    Assert.IsTrue(false);
                }
                else
                {
                    Console.WriteLine($"Health check failed but no unresolved dependencies were found");
                    Assert.IsTrue(false);
                }

                return;
            }

            Console.WriteLine("Healthy Health Check Returned.");
            Assert.IsTrue(true);
        }
    }
}

