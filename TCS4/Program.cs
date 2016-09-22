using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CS4  Rational Numbers - Jim Harris
/*
The Rational class contains two integers.
The following operators are overloaded:
 + - * / < > == !=

*/

namespace CS4
{

    public class Rational
    {
        //The code provided in this project may need to be alter to match your class variable names.

        //declare class variables
        private int n;  // numerator
        private int d;  // denominator


        //default constructor - sets numerator to 0, denominator to 1
        public Rational()
        {
            n = 0;
            d = 1;
        }

        //Overloaded constructor - assign arguments to property names
        public Rational(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }




        //Properties: Numerator (provided), Denominator, Fraction
        public int Numerator
        {
            get
            {
                return n;
            }
            set
            {
                n = value;
            }
        }


        public int Denominator
        {
            get { return d; }
            set { d = value; }
        }



        public string Fraction
        {
            get { return n.ToString() + "/" + d.ToString(); }

        }
        
        


        //overloaded arithmetic operators declared as public static (+ provided)  (jjh - binary operator)
        public static Rational operator +(Rational left, Rational right)
        {
            int numer = left.Numerator * right.Denominator + left.Denominator * right.Numerator;
            int denom = left.Denominator * right.Denominator;
            Rational local = new Rational(numer, denom);
            return local;
        }

        public static Rational operator -(Rational left, Rational right)
        {
            int numer = left.Numerator * right.Denominator - left.Denominator * right.Numerator;
            int denom = left.Denominator * right.Denominator;
            Rational local = new Rational(numer, denom);
            return local;
        }

        public static Rational operator *(Rational left, Rational right)
        {
            int numer = left.Numerator * right.Numerator;
            int denom = left.Denominator * right.Denominator;
            Rational local = new Rational(numer, denom);
            return local;
        }

        public static Rational operator /(Rational left, Rational right)
        {
            int numer = left.Numerator * right.Denominator;
            int denom = right.Numerator * left.Denominator;
            Rational local = new Rational(numer, denom);
            return local;
        }



        //overload comparison operators declared as public static (< provided)
        public static bool operator <(Rational left, Rational right)
        {
            return left.Numerator * right.Denominator < right.Numerator * left.Denominator;
        }

        public static bool operator >(Rational left, Rational right)
        {
            return left.Numerator * right.Denominator > right.Numerator * left.Denominator;
        }


        //override Equals and GetHashCode (provided)
        public override bool Equals(Object obj)
        {
            Rational right = (Rational)obj;  // cast the obj to Rational
            return this.Numerator * right.Denominator == right.Numerator * this.Denominator;
        }

        public override int GetHashCode()
        {
            string hashString = this.Numerator.ToString() + "/" + this.Denominator.ToString();
            return hashString.GetHashCode();
        }

        public static bool operator == (Rational left, Rational right)
        {
            if (Object.Equals(left, null))
                if (Object.Equals(right, null))
                    return true;
                else
                    return false;
            else
                return left.Equals(right);
        }

        public static bool operator !=(Rational left, Rational right)
        {
            return !(left == right);
        }



    }//end of Rational

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("CS4 Jim Harris \n");

            Rational x = new Rational();         //calls default constructor 
            x.Numerator = 2;    //use properties to set values
            x.Denominator = 3;
            Console.WriteLine("Rational x;           //calls default constructor");
            Console.WriteLine("  x = " + x.Fraction + " \n");

            Rational y = new Rational(3, 5);   //calls overloaded ructor
            Console.WriteLine("Rational y(3,5);      //calls overloaded constructor ");
            Console.WriteLine("  y = " + y.Fraction + "\n");

            Rational result = new Rational();
            Console.WriteLine("Testing arithmetic operator overloading:");

            result = y + x;
            Console.WriteLine("  " + y.Fraction + " + " + x.Fraction + " = " + result.Fraction);

            result = y * x;
            Console.WriteLine("  " + y.Fraction + " * " + x.Fraction + " = " + result.Fraction);

            result = y - x;
            Console.WriteLine("  " + y.Fraction + " - " + x.Fraction + " = " + result.Fraction);

            result = y / x;
            Console.WriteLine("  " + y.Fraction + " / " + x.Fraction + " = " + result.Fraction);


            Console.WriteLine("\nTesting relational operator overloading (9/15 < 10/15) ");

            Console.WriteLine("  " + y.Fraction + " == " + x.Fraction + " = " + (y == x));
            Console.WriteLine("  " + y.Fraction + " != " + x.Fraction + " = " + (y != x));

            Console.WriteLine("  " + y.Fraction + " <  " + x.Fraction + " = " + (y < x));
            Console.WriteLine("  " + x.Fraction + " <  " + y.Fraction + " = " + (x < y));

            Console.WriteLine("  " + y.Fraction + " >  " + x.Fraction + " = " + (y > x));
            Console.WriteLine("  " + x.Fraction + " >  " + y.Fraction + " = " + (x > y));
            Console.WriteLine(" ");

            return;
        }
    }
}
