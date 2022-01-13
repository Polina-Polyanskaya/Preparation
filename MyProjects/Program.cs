using ComplexNumbers;

Complex c1 = new Complex(1, 1);
Complex c2 = new Complex(1, 2);
Complex result = c1.Minus(c2);
Console.WriteLine($"{result.Imaginary} {result.Real}");