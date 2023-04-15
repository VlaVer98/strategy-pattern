namespace Strategy.Strategies
{
    internal class SubtractStrategy : ICalculateStrategy
    {
        public double Calculate(double x, double y)
        {
            return x - y;
        }
    }
}