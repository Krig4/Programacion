using System;
using System.Collections.Generic;
using System.Text;

namespace Cajero_Correcion
{
    class Account
    {
        // atributos
        string holder;
        double amount;

        //Constructores
        public Account(string holder)
        {
            this.holder = holder;
            amount = 0;
        }
        public Account(string holder, double amount)
        {
            this.holder = holder;
            this.amount = amount;
        }
         // metodos get y set
        public string GetHolder()
        {
            return holder;
        }
        public void SetHolder(string holder)
        {
            this.holder = holder;
        }
        public double GetAmount()
        {
            return amount;
        }
        public void SetAmount(double amount)
        {
            this.amount = amount;
        }
        public string ToString()
        {
            return "El titular" + GetHolder() + " tiene " + GetAmount() + " euros en la cuenta";
        }
        //metodo ingresar dinero
        public bool Deposit(double amount)
        {
            if(amount >= 0)
            {
                this.amount = this.amount + amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        // metodo retirar dinero
        public bool Withdraw(double amount)
        {
            if (amount >= 0 && (this.amount - amount >= 0))
            {
                this.amount = this.amount - amount;
                return true;
            }
            else
            {
                return false;
            }            
        }
    }
}
