using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Cajero
{ 
            //Crea una clase llamada cuenta con atributos titular y cantidad, el titular es un dato obligatorio y la cantidad es opcional.
            //Dos constructores. Metodos Get Set String. Metodo ingresar y retirar, reciben una cantidad(Si es negativa no retira dinero de la cuenta)
            //(No puedo retirar si me quedo descubierto)
    class Account
    {
        string person;
        float amount;

        public Account (string person)
        {
            this.person = person;
            amount = 0;
        }
        public Account (string person, float amount)
        {
            this.person = person;
            this.amount = amount;
        }
        public string GetPerson ()
        {
            return person;
        }
        public float GetAmount()
        {
            return amount;
        }
        public void SetPerson(string person)
        {
            this.person = person;
        }
        public void SetAmount(float amount)
        {
            this.amount = amount;
        }
        public string Write()
        {
            return person + " tienes " + amount + " dinero disponible ";
        }
        public bool ToDeposit (float cash)
        {
            if (cash <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool WithDraw (float cash)
        {
            if (cash <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            if (cash > amount)
            {
                return false;
            }
        }

    }
}
