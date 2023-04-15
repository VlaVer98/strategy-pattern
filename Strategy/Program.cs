using Strategy;
using Strategy.Strategies;

var addStrategy = new AddStrategy();
var substractStrategy = new SubtractStrategy();
var divideStrategy = new DivideStrategy();
var multiplyStrategy = new MultiplyStrategy();

var calculator = new Calculator(multiplyStrategy);
Console.WriteLine(calculator.Calculate(2, 4));

calculator.SetStrategy(substractStrategy);
Console.WriteLine(calculator.Calculate(2, 1));

calculator.SetStrategy(divideStrategy);
Console.WriteLine(calculator.Calculate(10, 2));

calculator.SetStrategy(multiplyStrategy);
Console.WriteLine(calculator.Calculate(10, 2));

calculator.SetStrategy(addStrategy);
Console.WriteLine(calculator.Calculate(10, 6));