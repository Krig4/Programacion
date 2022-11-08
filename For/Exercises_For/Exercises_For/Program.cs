using System;

namespace Exercises_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise5();
        }
        static void Exercise1()
        {
        Console.WriteLine("Cuenta del 1 al 10");   
        for(int counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine(counter);
            }

        }

        static void Exercise1_1() //Esta mal
        {
            Console.WriteLine("Dime el número menor para empezar la serie");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dime el número mayor donde termina la serie");
            int end = Convert.ToInt32(Console.ReadLine());
            for (int counter = 1; start < end; start++);
            {
                Console.WriteLine(start);
            }

        }
        static void Exercise2()
        {
            Console.WriteLine("Indica la frase que quieres repetir");
            string text = Console.ReadLine();
            Console.WriteLine("Indica cuantas veces quieres que se repita");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int counter = 1; counter <= number; counter++)
            {
                Console.WriteLine(text);
            }
        }
        static void Exercise3()
        {
            int counterlvl = 1;
            int counterline = 1;
            int valor = 1;
            Console.WriteLine("TRIANGULO DE FLOYD");
            Console.WriteLine("¿Cuantos pisos quiere que tenga el triangulo?");
            int triangle = Convert.ToInt32(Console.ReadLine());
            while(counterlvl <= triangle)
            {
                while(counterline <= counterlvl)
                {
                    Console.Write(valor + " ");
                    valor++;
                    counterline++;
                }
                counterlvl++;
                counterline = 1;
                Console.WriteLine("");
            }
        }
        static void Exercise3_1()
        {
            int counterlvl;
            int counterline;
            int valor = 1;
            Console.WriteLine("TRIANGULO DE FLOYD");
            Console.WriteLine("¿Cuantos pisos quiere que tenga el triangulo?");
            int triangle = Convert.ToInt32(Console.ReadLine());
            for (counterlvl = 1; counterlvl <= triangle; counterlvl++)
            {
                for(counterline = 1; counterline <= counterlvl; counterline++)
                {
                    Console.Write(valor + " ");
                    valor++;
                }
                counterline= 1;
                Console.WriteLine("");
            }

        }
        static void Exercise4()
        {
            Console.Write("Escribe un número: ");
            int numberToConvert = int.Parse(Console.ReadLine());
            Console.Write("Escribe un caracter: ");
            string userchar = (Console.ReadLine());
            for (int dec = 0; dec < 10; dec = dec + 1)
            {
                for (int unit = 0; unit < 10; unit = unit + 1)
                {
                    string valueToPrint;
                    if (dec == numberToConvert)
                    {
                        valueToPrint = userchar;
                    }
                    else
                    {
                        valueToPrint = dec.ToString();
                    }
                    if (unit == numberToConvert)
                        {
                        valueToPrint = valueToPrint + userchar;
                        }
                    else
                    {
                        valueToPrint = valueToPrint + unit;
                    }
                    Console.WriteLine("El resultado final: " + valueToPrint);
                }                
            }
        }
        
        static void Exercise5()
        {
            Console.WriteLine("Dime un número entero mayor que 0");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("El resultado de la serie es: " + Serie(number));

        }

        static float Serie(int number)
        {
            const float DIVIDEND = 1;
            float div;
            float result = 0;
            for (int i = 1; i <= number; i = i + 1)
            {
                div = DIVIDEND / i;
                Console.Write(DIVIDEND + "/" + i + " ");
                result = result + div;
            }
            return result;
        }
        static void Exercise6()
        {
            Console.WriteLine("Dime un valor para ver la cadena");
            int usernum = int.Parse(Console.ReadLine());
            Loop(usernum);
        }
        static void Loop(int usernum)
        {
            string result = "";
            for (int i = 1; i < usernum; i = i + 1) //El número que vamos a repetir
            {
                for ( int m = 1; m <= i; m = m + 1) //El número de veces que repetimos
                {
                    result = result + i;
                }
            }
            Console.WriteLine(result);
        }
    }
}
