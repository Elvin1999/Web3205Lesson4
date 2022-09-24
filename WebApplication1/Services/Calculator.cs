namespace WebApplication1.Services
{
    public class Calculator : ICalculator
    {
        public Calculator()
        {
            //int data = 10;
        }
        public decimal Calculate(decimal amount)
        {
            return amount+100;
        }
    }
}
