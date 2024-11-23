using CSharpPart2.ExampleUnitTest;

namespace MSTest1
{
    [TestClass]

    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange.  
            Employee alex = new Employee();
            //Act 
            decimal result = alex.CalculateTotalPay(100000, 20000);
            //Assert.
            Assert.AreEqual(120000, result);

        }


        //---------------------------------------------------------
        [DataTestMethod]
        [DataRow("100","20","120")]
        [DataRow("100", "0", "100")]
        [DataRow("0", "20", "21")]
        public void TestMethod2(string salary, string bonus, string expected)
        {
            //Arrange.  
            Employee alex = new Employee();
            //Act 
            decimal result = alex.CalculateTotalPay(Convert.ToDecimal(salary), Convert.ToDecimal(bonus));
            //Assert.
            Assert.AreEqual(Convert.ToDecimal(expected), result);
        }


        /*-------------------Won't work in MSTest--------------------------------------
        [DataTestMethod]
        [DataRow(100, 20, 120)]

        public void TestMethod3(decimal salary, decimal bonus, decimal expected)
        {
            //Arrange.  
            Employee alex = new Employee();
            //Act 
            decimal result = alex.CalculateTotalPay(salary, bonus);
            //Assert.
            Assert.AreEqual(Convert.ToDecimal(expected), result);

        }
        */
    }
}
