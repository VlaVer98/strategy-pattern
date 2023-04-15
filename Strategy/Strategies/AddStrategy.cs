namespace Strategy.Strategies
{
    internal class AddStrategy : ICalculateStrategy
    {
        public double Calculate(double x, double y)
        {
            return x + y;
        }
    }
}