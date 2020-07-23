using System.Linq;
using System.Threading.Tasks;
using ContinuousIntegrationDIY;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class IntegrationTests
    {
        [TestMethod]
        [TestCategory("Integration")]
        public async Task One_Hundred_Thousand_Runs_Doesnt_Fail()
        {
            var tasks = Enumerable.Range(0, 100000).Select(async _ =>
            {
                await Task.Delay(1000);
                await Task.Run(Program.Main);
            });

            await Task.WhenAll(tasks);

            
        }
    }
}
