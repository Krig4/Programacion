using System;

namespace Cajero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuanto dinero quieres retirar?");
            float totalcash = int.Parse(Console.ReadLine());
            Account A1 = new Account("Alberto");
            Account A2 = new Account("Alberto", 25000);

            A1.ToDeposit(10);
            A2.ToDeposit(15000);

            Console.WriteLine(A1.Write());
            Console.WriteLine(A2.Write());
        }
    }
}
