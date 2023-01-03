using Blocknot22;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class TestBlocknot
    {
        // Testing Add method of Blocknot class - in github from command line
        // Package Manager Console
        [TestMethod]
        public void TestAdd()
        {
            // Arrange
            Blocknot blocknot = new Blocknot();
            Record record1 = new Record("Ivan", "123456789");
            Record record2 = new Record("Petr", "987654321");
            Record record3 = new Record("Ivan", "123456789");

            // Act
            blocknot.Add(record1);
            blocknot.Add(record2);
            blocknot.Add(record3);

            // Assert
            Assert.AreEqual(3, blocknot.Count());
        }

        // Testing Remove method
        [TestMethod]
        public void TestRemove()
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
            blocknot.Remove(record1);
            blocknot.Remove(record2);

            // Assert
            Assert.AreEqual(1, blocknot.Count());
        }

        [TestMethod]
        public void TestFind()
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
            IEnumerable<Record> records = blocknot.Find("Ivan");

            // Assert
            Assert.AreEqual(2, records.Count());
        }
    }
}
