using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem5;

namespace UnitTestsLab5
{
    [TestClass]
    public class Project5
    {

        [TestMethod]
        public void TestIsRecievingElectricityWhenPlugAndOutletAreSamePass()
        {
            Plug plug = new Plug("B",3,15,120,true);
            Outlet outlet = new Outlet("B", 3, 15, 120, true);
            plug.PlugIn(outlet);

            var result = plug.IsRecievingElectricity;
            var expected = true;
            Assert.AreEqual(expected,result);
        }
        [TestMethod]
        public void TestIsRecievingElectricityWhenUnPlugPass()
        {
            Plug plug = new Plug("B", 3, 15, 120, true);
            Outlet outlet = new Outlet("B", 3, 15, 120, true);
            plug.PlugIn(outlet);

            var result = plug.IsRecievingElectricity;
            var expected = true;
            Assert.AreEqual(expected, result);

            plug.UnPlug();
            result = plug.IsRecievingElectricity;
            expected = false;
            Assert.AreEqual(expected, result);
        }
    }
}
