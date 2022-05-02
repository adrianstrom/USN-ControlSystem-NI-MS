using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using USN_ControlSystem_NI_MS.Controllers;

namespace USN_ControlSystem_NI_MS.Test
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Test_EulerMethod_Output()
        {
            // arrange
            var euler = new ForwardEuler(20, TimeSpan.FromSeconds(1));

            // act
            for (var i = 0; i > 5; i++)
            {
                euler.Integrate(0);
            }

            // assert
            Assert.AreEqual(10, euler.IntegratedValue);
        }

        [TestMethod]
        public void Test_LowpassFilter_Output()
        {

        }
    }
}
