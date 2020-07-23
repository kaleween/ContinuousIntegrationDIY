using System;
using System.IO;
using System.Reflection;
using System.Text;
using ContinuousIntegrationDIY;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        [TestCategory("Unit")]
        public void Hello_World_Est_Bien_Forme()
        {
            var consoleOutput = new StringBuilder();
            Console.SetOut(new StringWriter(consoleOutput));

            Program.Main();

            Assert.AreEqual(
                "Version : " + Assembly.GetAssembly(typeof(Program))?.GetName().Version + Environment.NewLine +
                "Hello World!" + Environment.NewLine, 
                consoleOutput.ToString());
            
            consoleOutput.ToString("test pre-push");
        }
    }
}
