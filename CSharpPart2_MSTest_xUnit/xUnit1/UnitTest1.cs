using CSharpPart2.ExampleUnitTest;

namespace xUnit1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange.  
            Employee alex = new Employee();
            //Act 
            decimal result = alex.CalculateTotalPay(100000, 20000);
            //Assert.
            Assert.Equal(120000, result);
        }

        //---------------------------------------------------------
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(-4,-6,-10)]
        [InlineData(-2, 2, 0)]
        public void Test2(decimal salary, decimal bonus, decimal expected)
        {
            //Arrange.  
            Employee alex = new Employee();
            //Act 
            decimal result = alex.CalculateTotalPay(salary, bonus);
            //Assert.
            Assert.Equal(expected, result);
        }
    }
}