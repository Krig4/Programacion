using System;
using System.Collections.Generic;
using System.Text;

namespace Contador
{
    class Counter
    {             
        int number;
        int add;
        //constructor defecto
        public Counter()
        {
            number = 0;
            add = 1;
        }
        // con parámetros
        public Counter(int number, int add)
        {
            this.number = number;
            this.add = add;
        }
        // constructor copia
        public Counter(Counter c)
        {
            number = c.number;
            add = c.add;
        }
        //métodos incrementar y decrementar
        public int Increase()
        {
            number = number + add;
            return number;
        }
        public int Increase(int ammount)
        {
            number = number + ammount;
            return number;
        }
        public int Decrease()
        {
            number = number - add;
            return number;
        }
        public int Decrease(int ammount)
        {
            number = number - ammount;
            return number;
        }
        //getter setter
        public int GetNumber()
        {
            return number;
        }
        public int GetAdd()
        {
            return add;
        }
        public void  SetNumber(int number)
        {
            this.number = number;
        }
        public void SetAdd(int add)
        {
            this.add = add;
        }
        //Metodo toString
        public string toString()
        {
            return "Contador: " + number + " + " + add + "/";
        }
    }
}
