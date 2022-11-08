using System;

namespace Cajero_Correcion
{
    class Program
    {
        static void Main(string[] args)
        {
            // objetos creados
            Account account1 = new Account("Pepe");
            Account account2 = new Account("Maria", 100);

            //get
            Console.WriteLine(account1.GetHolder() + " - " + account1.GetAmount());
            Console.WriteLine(account2.GetHolder() + " - " + account2.GetAmount());

            //set
            account2.SetHolder("Lucia");
            account2.SetAmount(200);
            Console.WriteLine(account2.ToString());

            //ingresar dinero
            account1.Deposit(300);
            account2.Deposit(400);
            account2.Deposit(200);

            //retirar dinero
            account1.Withdraw(200);
            account2.Withdraw(800);

            //mostrar datos
            Console.WriteLine(account1.ToString());
            Console.WriteLine(account2.ToString());            
        }
    }
}
