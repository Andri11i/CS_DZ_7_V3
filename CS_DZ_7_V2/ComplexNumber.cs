using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_7_V2
{
    internal class ComplexNumber
    {
        public double Real { get; }
        public double Imaginary { get; }
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }
        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(
                c1.Real * c2.Real - c1.Imaginary * c2.Imaginary,
                c1.Real * c2.Imaginary + c1.Imaginary * c2.Real
            );
        }
        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            double denominator = c2.Real * c2.Real + c2.Imaginary * c2.Imaginary;
            return new ComplexNumber(
                (c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / denominator,
                (c1.Imaginary * c2.Real - c1.Real * c2.Imaginary) / denominator
            );
        }
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }


        public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
        {
            return !c1.Equals(c2);
        }
        public override bool Equals(object obj)
        {
            if (obj is ComplexNumber other)
            {
                return Real == other.Real && Imaginary == other.Imaginary;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Real, Imaginary);
        }
    }
}
