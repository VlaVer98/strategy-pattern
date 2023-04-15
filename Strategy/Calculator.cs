using Strategy.Strategies;

namespace Strategy
{
    internal class Calculator
    {
        private ICalculateStrategy _calculateStrategy;

        public Calculator(ICalculateStrategy calculateStrategy)
        {
            _calculateStrategy = calculateStrategy;
        }

        public double Calculate(double x, double y)
        {
            return _calculateStrategy.Calculate(x, y);
        }

        public void SetStrategy(ICalculateStrategy calculateStrategy)
        {
            _calculateStrategy = calculateStrategy;
        }
    }
}