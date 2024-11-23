using CSharpPart2.ExampleUnitTest;
namespace MSTest1
{
    [TestClass]
    public sealed class Test1
    {
        //------------------------1---------------------------------
        [TestMethod]
        public void TestMethod1()
        {
            //AAA
            //Arrange
            Employee alex = new Employee(1);
            //Act
            decimal result = alex.CalculateTotalPay(100,20);
            //Assert
            Assert.AreEqual(120, result);
        }

        //-----------------------2----------------------------------
        [DataTestMethod]
        [DataRow("100.1", "20.2", "120.3")]
        [DataRow("0", "20", "20")]
        [DataRow("100", "0", "100")]
        public void TestMethod2(string salary, string bonus, string expected)
        {
            //AAA
            //Arrange
            Employee alex = new Employee(1);
            //Act
            decimal result = alex.CalculateTotalPay(Convert.ToDecimal(salary), Convert.ToDecimal(bonus));
            //Assert
            Assert.AreEqual(Convert.ToDecimal(expected), result);
        }


        //----------------------------3-----------------------------
        //You can take double int and convert to decimal too
        [DataTestMethod]
        [DataRow(100, 20, 120)]

        public void TestMethod3(int salary, int bonus, int expected)
        {
            //AAA
            //Arrange
            Employee alex = new Employee(1);
            //Act
            decimal result = alex.CalculateTotalPay(Convert.ToDecimal(salary), Convert.ToDecimal(bonus));
            //Assert
            Assert.AreEqual(Convert.ToDecimal(expected), result);
        }

        //----------------------------3-----------------------------
        //You can take double values and convert to decimal too
        [DataTestMethod]
        [DataRow(100.1, 20.2, 120.3)]
        public void TestMethod3(double salary, double bonus, double expected)
        {
            //AAA
            //Arrange
            Employee alex = new Employee(1);
            //Act
            decimal result = alex.CalculateTotalPay(Convert.ToDecimal(salary), Convert.ToDecimal(bonus));
            //Assert
            Assert.AreEqual(Convert.ToDecimal(expected), result);
        }

        //----------------------------4-----------------------------
        [TestMethod]
        public void TestMethod4()
        {
            //AAA
            //Arrange
            Employee alex = new Employee(100);
            //Act
            decimal result = alex.CalculateTotalPay();
            //Assert
            Assert.AreEqual(120,result);
        }

        //MSTest----------------------------5-----------------------------
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),"Salary <=0!")]
        public void TestMethod5()
        {
            //AAA
            //Arrange
            Employee alex = new Employee(0);
        }

        //MSTest----------------------------6-----------------------------
        [TestMethod]
        public void TestMethod6()
        {
            //AAA
            //Arrange
            try { Employee alex = new Employee(1); Assert.Fail(); }
            catch (ArgumentException) { }
            catch (Exception) { Assert.Fail(); }
        }
    }
}

