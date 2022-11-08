using System;

namespace Bucle
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise5();
        }
        
        static void Exercise5()
        {
            Console.WriteLine("Dime el numero que quieres saber si es primo o compuesto:");
            int primenum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Para saber si el número es primo escribe true");
            Console.WriteLine("Para saber si el número no es primo escribe false");
            bool prime;
            prime = Convert.ToBoolean(Console.ReadLine());
            bool answer = IsPrimeNumber(primenum); prime));
            if (prime == true && answer == true)
            {
                Console.WriteLine("El número " + primenum + " es primo");
            }
            else
            { 
                if (prime == true)
                {
                    Console.WriteLine("El número " + primenum + " no es primo");
                }
                else
                {
                    if (answer == false)
                    {
                        Console.WriteLine("El número " + primenum + " no es compuesto");
                    }
                    else
                    {
                        Console.WriteLine("El número " + primenum + " es compuesto");
                    }
                }
            }

        }


    }
}
