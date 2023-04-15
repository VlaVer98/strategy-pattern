namespace Strategy.Strategies
{
    internal class DivideStrategy : ICalculateStrategy
    {
        public double Calculate(double x, double y)
        {
            return x / y;
        }
    }
}