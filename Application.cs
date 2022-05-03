using System;

namespace HW3_Fractions
{
    class Application
    {
        public static void Main(string[] args)
        {
            string choice = "";
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction();

            while (choice.ToUpper() != "X")
            {

                System.Console.WriteLine("*******************************************");
                System.Console.WriteLine("Please make your selection");
                System.Console.WriteLine();
                System.Console.WriteLine("Enter first fraction (1)");
                System.Console.WriteLine("Enter second fraction (2)");
                System.Console.WriteLine();
                System.Console.WriteLine("(A)ddtion");
                System.Console.WriteLine("(S)ubtraction");
                System.Console.WriteLine("(M)ultiplication");
                System.Console.WriteLine("(D)ivision");
                System.Console.WriteLine("(G)reater than");
                System.Console.WriteLine("(L)ess than");
                System.Console.WriteLine("(E)qual to");
                System.Console.WriteLine();
                System.Console.WriteLine("e(X)it");
                System.Console.WriteLine("*******************************************");
                System.Console.WriteLine();
                choice = System.Console.ReadLine();

                if (choice == "1" || choice == "2")
                {
                    System.Console.Write("Enter the numerator: ");
                    int numerator = Int32.Parse(System.Console.ReadLine());
                    System.Console.Write("Enter the denominator: ");
                    int denominator = Int32.Parse(System.Console.ReadLine());
                    if (choice == "1")
                        f1 = new Fraction(numerator, denominator);
                    else
                        f2 = new Fraction(numerator, denominator);
                
                }
                else if (choice.ToUpper() == "A")
                {
                    System.Console.WriteLine(f1 + " + " + f2 + " = " + (f1 + f2));
                }
                else if (choice.ToUpper() == "S")
                {
                    System.Console.WriteLine(f1 + " - " + f2 + " = " + (f1 - f2));
                }
                else if (choice.ToUpper() == "M")
                {
                    System.Console.WriteLine(f1 + " × " + f2 + " = " + (f1 * f2));
                }
                else if (choice.ToUpper() == "D")
                {
                    try
                    {
                        System.Console.WriteLine(f1 + " ÷ " + f2 + " = " + (f1 / f2));
                    }
                    catch (DivideByZeroException dbze)
                    {
                        System.Console.WriteLine("ERROR: " + dbze.Message + "\n  Operands: " + f1 + ", " + f2);
                    }
                }
                else if (choice.ToUpper() == "G")
                {
                    System.Console.WriteLine(f1 + ">" + f2 + ": " + (f1 > f2));
                }
                else if (choice.ToUpper() == "L")
                {
                    System.Console.WriteLine(f1 + "<" + f2 + ": " + (f1 < f2));
                }
                else if (choice.ToUpper() == "E")
                {
                    System.Console.WriteLine(f1 + "=" + f2 + ": " + (f1.Equals(f2)));
                }
                System.Console.WriteLine();
                
            }
        }
    }
}