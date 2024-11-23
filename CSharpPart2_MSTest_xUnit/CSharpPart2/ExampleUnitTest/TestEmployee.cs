namespace CSharpPart2.ExampleUnitTest
{
    public class TestEmployee
    {
        static void Main()
        {
            Employee alex = new Employee();
            Console.WriteLine(alex.CalculateTotalPay(100, 200));
        }
    }
}

