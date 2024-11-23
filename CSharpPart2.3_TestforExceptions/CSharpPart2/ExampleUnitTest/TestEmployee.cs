using System.Diagnostics.CodeAnalysis;

namespace CSharpPart2.ExampleUnitTest
{
    [ExcludeFromCodeCoverage]
    public class TestEmployee
    {
        static void Main()
        {
            Employee alex = new Employee(100);
            Console.WriteLine(alex.CalculateTotalPay(100, 200));
        }
    }
}

