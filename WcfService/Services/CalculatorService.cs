using Contracts;
using System.Threading;

namespace Services
{
    public class CalculatorService : ICalculator
    {
        public double Add(double x, double y)
        {
            Thread.Sleep(20);
            return x + y;
        }

        public double Subtract(double x, double y)
        {
            Thread.Sleep(20);
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            Thread.Sleep(20);
            return x * y;
        }

        public double Divide(double x, double y)
        {
            Thread.Sleep(20);
            return x / y;
        }
    }

    public class PersonService : IPerson
    {
        public string getName(string name)
        {
            Thread.Sleep(20);
            return "####"+name+"####";
        }
    }
}