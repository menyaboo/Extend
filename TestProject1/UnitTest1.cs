using Extend;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Lib lib = new Lib();

            // Act
            string str = "String";
            string libMessage = lib.PrintStr(str);

            // Assert
            Assert.AreEqual(str, libMessage);
        }
    }
}