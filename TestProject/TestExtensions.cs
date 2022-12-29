using Blocknot22;

namespace TestProject
{
    [TestClass]
    public class TestExtensions
    {
        [TestMethod]
        public void TestAddSpaceBetween()
        {
            // Arrange
            string s1 = "HelloWorld";
            string s2 = "";
            string s3 = "helloworld";

            // Act
            string r1 = s1.AddSpaceBetween();
            string r2 = s2.AddSpaceBetween();
            string r3 = s3.AddSpaceBetween();


            // Assert
            Assert.AreEqual("Hello World", r1);
            Assert.AreEqual("", r2);
            Assert.AreEqual("helloworld", r3);
        }
    }
}