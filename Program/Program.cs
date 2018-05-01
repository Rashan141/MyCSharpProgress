using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Willis";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(4,6);
            System.Console.WriteLine(result);
        }
    }
}
