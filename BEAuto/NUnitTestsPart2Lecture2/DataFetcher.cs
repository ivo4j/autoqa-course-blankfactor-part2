using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestsPart2Lecture2
{
    [TestFixture]
    internal class DataFetcher
    {
        [Test]
        public void testMETHOD()
        {
            // Arrange
            var mockService = new Mock<IExternalService>();
            mockService.Setup(s => s.FetchData()).Returns("test data");
            //mockService.Setup(s => s.FetchData()).Throws(new Exception("Service unavailable"));
            DataProcessor processor = new DataProcessor(mockService.Object);
            // Act
            string result = processor.ProcessData();
            // Assert
            Assert.That(result, Is.EqualTo("TEST DATA"));
        }
    }
}
