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
            // y' = y
            var euler = new ForwardEuler(1, TimeSpan.FromSeconds(1));

            // act
            for (var i = 0; i < 4; i++)
            {
                var valueFromModel = i;
                euler.Integrate(valueFromModel);
            }

            // assert
            Assert.AreEqual(16, euler.IntegratedValue);
        }

        [TestMethod]
        public void Test_LowpassFilter_Output()
        {

        }
    }
}
