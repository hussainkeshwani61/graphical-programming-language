using System.Security.Cryptography.X509Certificates;
using graphical_programming_language;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void checkNumber_test()
        {
            //inital boolean for isNumber is false
            var bl = new CommonFunction();
            int i = 0;
            var isnumber = bl.checkNumber("2", ref i);

            Assert.AreEqual(true, isnumber);

            isnumber = bl.checkNumber("c", ref i);

            Assert.AreEqual(false, isnumber);
        }

        [TestMethod]
        public void CheckArrayLength_Test()
        {
            var bl = new CommonFunction();
            string[] str = new string[3] { "1", "2", "3" };
            var flage = bl.CheckArrayLength(str);

            Assert.IsTrue(flage);
        }

    }
}