using CS_DZ_7_V2;


// арифметические операторы

var c1 = new ComplexNumber(3, 4);
var c2 = new ComplexNumber(1, 2);

var sum = c1 + c2;
var difference = c1 - c2;
var product = c1 * c2;
var quotient = c1 / c2;

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");

// операторы сравнения

c1 = new ComplexNumber(3, 4);
c2 = new ComplexNumber(3, 4);
var c3 = new ComplexNumber(1, 2);

Console.WriteLine($"c1 == c2: {c1 == c2}");
Console.WriteLine($"c1 != c3: {c1 != c3}");