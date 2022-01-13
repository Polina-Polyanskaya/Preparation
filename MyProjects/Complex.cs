namespace ComplexNumbers
{
    public class Complex
    {
        public double Imaginary { get; private set; }
        public double Real { get; private set; }
        private Complex() {}
        public Complex(double imaginary, double real)
        {
            Imaginary = imaginary;
            Real = real;
        }
        public Complex Plus(Complex other)
        {
            var complex=new Complex();  
            complex.Imaginary=other.Imaginary+Imaginary;
            complex.Real = other.Real + Real;
            return complex;
        }
        public Complex Minus(Complex other)
        {
            var complex = new Complex();
            complex.Imaginary = other.Imaginary - Imaginary;
            complex.Real = other.Real - Real;
            return complex;
        }
    }
}
