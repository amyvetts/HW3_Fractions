using System;

namespace HW3_Fractions

{
    public class Fraction
    {
        int Numerator { get; set; }
        int Denominator { get; set; }

        //set fraction
        public Fraction()
        {
            Numerator = 0;
            Denominator = 1;
        }

        //set numerator and denominator as 1 to create a whole number
        public Fraction(int wholeNumber)
        {
            Numerator = wholeNumber;
            Denominator = 1;
        }

        //create fraction with given numerator and denominator
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            Reduce();
        }

        //calls back fraction in reduced form (2/4 -> 1/2)
        private void Reduce()
        {
            int commonDenom = GCD(this.Numerator, this.Denominator);
            this.Numerator /= commonDenom;
            this.Denominator /= commonDenom;
        }

        /* The following helper functions are provided for you. */
        private static int GCD(int n, int m)
        {
            while (n != 0 && m != 0)
            {
                if (n > m)
                    n = n % m;
                else
                    m = m % n;
            }
            return Math.Max(n, m);
        }

        private static int LCM(int n, int m)
        {
            return n * m / GCD(n, m);
        }


        //overloaded logical operators

        public override bool Equals(object obj)
        {

            if (obj == null)
            {
                return false;
            }
            else if ((this.Numerator != ((Fraction)obj).Numerator) || (this.Denominator != ((Fraction)obj).Denominator))
            {
                return false;
            }
            else
            {
                return true;
            }

        }




        //equality
        public static bool operator ==(Fraction f1, Fraction f2)
        {
            if (f1.Equals(f2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            if (!(f1.Equals(f2)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //operations
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int commonDenom = LCM(f1.Denominator, f2.Denominator);
            Fraction result = new Fraction();
            if (f1.Denominator == f2.Denominator)
            {
                result.Numerator = f1.Numerator + f2.Numerator;
                result.Denominator = f1.Denominator;

            }
            else
            {
                result.Numerator = f1.Numerator * (commonDenom / f1.Denominator) + f2.Numerator * (commonDenom / f2.Denominator);
                result.Denominator = commonDenom;
            }
            return result;
            
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            int commonDenom = LCM(f1.Denominator, f2.Denominator);
            Fraction result = new Fraction();
            if (f1.Denominator == f2.Denominator)
            {
                result.Numerator = f1.Numerator - f2.Numerator;
                result.Denominator = f1.Denominator;

            }
            else
            {
                result.Numerator = f1.Numerator * (commonDenom / f1.Denominator) - f2.Numerator * (commonDenom / f2.Denominator);
                result.Denominator = commonDenom;
            }
            return result;

        }


        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();
            result.Numerator = f1.Numerator * f2.Numerator;
            result.Denominator = f1.Denominator * f2.Denominator;

            return result;
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();
            result.Numerator = f1.Numerator * f2.Denominator;
            result.Denominator = f1.Denominator * f2.Numerator;

            return result;
        }
        public static bool operator <(Fraction f1, Fraction f2)
        {
            int commonDenom = LCM(f1.Denominator, f2.Denominator);
            if ((f1.Numerator * (commonDenom / f1.Denominator)) < (f2.Numerator * (commonDenom / f2.Denominator)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator >(Fraction f1, Fraction f2)
        {
            int commonDenom = LCM(f1.Denominator, f2.Denominator);
            if ((f1.Numerator * (commonDenom / f1.Denominator)) > (f2.Numerator * (commonDenom / f2.Denominator)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public override string ToString()
        {
            return "( " + this.Numerator + " / " + this.Denominator + " )";
        }

    }
}