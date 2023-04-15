namespace Strategy.Strategies
{
    internal class MultiplyStrategy : ICalculateStrategy
    {
        public double Calculate(double x, double y)
        {
            return x * y;
        }
    }
}