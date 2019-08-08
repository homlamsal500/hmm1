using System;

namespace hm1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");





            {
                int firstno;
                int secondno;
                int sumVal;
                int subVal;
                int multVal;
                double divVal;
                

                Console.WriteLine("Enter first no :");
                firstno = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second no: ");
                secondno = Convert.ToInt32(Console.ReadLine());
                sumVal = firstno + secondno;
                Console.WriteLine("Addition of two no is: " + sumVal);
                subVal = firstno - secondno;
                Console.WriteLine("Substraction of two no is: " + subVal);
                multVal = firstno * secondno;
                Console.WriteLine("Multiplication  of two no is: " + multVal);
                divVal = (double)firstno / secondno;
                Console.WriteLine("Division  of two no is: " + divVal);
                

            }
        }
    }
}
