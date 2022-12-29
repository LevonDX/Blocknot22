using Blocknot22;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class TestRecord
    {
        [TestMethod]
        public void TestParse()
        {
            // Arrange
            Record record = new Record("John", "123456789");

            string correctStr = record.ToString();
            string incorrectStr = "john smith";
            string emptyStr = "";

            // Act
            Record parsedRecord = Record.Parse(correctStr);

            // Assert
            Assert.IsTrue(parsedRecord.Name == record.Name && parsedRecord.Phone == record.Phone);
            Assert.ThrowsException<ArgumentException>(() => Record.Parse(incorrectStr));
            Assert.ThrowsException<ArgumentException>(() => Record.Parse(emptyStr));
        }

        [TestMethod]
        public void TestGetRecord()
        {
            // Arrange
            Blocknot blocknot = new Blocknot();
            Record record1 = new Record("Ivan", "123456789");
            Record record2 = new Record("Petr", "987654321");
            Record record3 = new Record("Ivan", "123456789");

            blocknot.Add(record1);
            blocknot.Add(record2);
            blocknot.Add(record3);

            // Act
            Record foundRecord = blocknot.GetRecord("Ivan");

            // Assert
            Assert.AreEqual(record1.Name, foundRecord.Name);
        }
    }
}