using System;

namespace EjerWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            CajaFuerte();
        }
        static void Ejercicio1()
        {
            Console.WriteLine("Dime un número");
            int usnum = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter <= usnum)
            {
                Console.WriteLine(counter);
                counter = counter + 1;
            }
            Console.ReadLine();

        }
        static void Ejercicio2()
        {
            int counter = 0;
            while (counter <= 100)
            {
                Console.WriteLine(counter);
                counter = counter + 5;             
            }
            Console.WriteLine("Múltiplos de 5 de 0 a 100");
            Console.ReadLine();
        }
        static void Ejercicio3()

        {
            int counter = 320;
            while (counter >= 160)
            {
                Console.WriteLine(counter);
                counter = counter - 20;                
            }
            Console.WriteLine("Cuenta regresiva de 320 a 160 en 20 ");
            Console.ReadLine();
        }
        static void Ejercicio4()
        {
            Console.WriteLine("Introduce números que quieras sumar y pon uno negativo para dejar de sumar:");
            int usnum = int.Parse(Console.ReadLine());
            int newnum = usnum;
            
            while (usnum >= 0)
            {
                usnum = int.Parse(Console.ReadLine());
                
                
                if (usnum >= 0)
                {
                    newnum = newnum + usnum;                    
                }
                else
                {
                    Console.WriteLine("La suma total es: " + newnum);
                }
            }            
            Console.ReadLine();

        }
        static void Ejercicio5()
        {
            Console.WriteLine("Introduce números que quieras multiplicar y pon 0 para dejar de multiplicar:");
            int usnum = int.Parse(Console.ReadLine());
            int newnum = usnum;

            while (usnum != 0)
            {
                usnum = int.Parse(Console.ReadLine());


                if (usnum != 0)
                {
                    newnum = newnum * usnum;
                }
                else
                {
                    Console.WriteLine("La multiplicación total es: " + newnum);
                }
            }
            Console.ReadLine();

        }
        static void Ejercicio6()
        {
            Console.WriteLine("Introduce números que quieras sumar (solo se sumarán los pares) y pon uno negativo para dejar de sumar:");
            int usnum = int.Parse(Console.ReadLine());
            int newnum = 0;

            while (usnum >= 0)
            {

                if (usnum % 2 == 0)
                {
                    newnum = newnum + usnum;
                }
                usnum = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("La suma total es: " + newnum);
            Console.ReadLine();

        }
        static void Ejercicio7()
        {
            const int password = 2306;
            int Tryy = 4;
            Console.WriteLine("*Introduce contraseña de 4 dígitos para desbloquear la caja fuerte*");
            int usnum = 1;
            while (usnum != password)
            {
                usnum = int.Parse(Console.ReadLine());

                if (usnum != password)
                {
                    Tryy = Tryy - 1;
                    Console.WriteLine("El código es incorrecto, te quedan " + Tryy + " intentos.");
                   if (Tryy == 0)
                   {
                        Console.WriteLine("¡La caja fuerte se ha bloqueado!");
                    }

                }
            }
            Console.WriteLine("Caja fuerte desbloqueada");
            Console.ReadLine();
        }
        static void CajaFuerte()
        {
            const string CODE = "0000";
            const int MAX_TRY = 4;
            int tryCounter = 0;
            string usrCode;
            bool opened = false;

            while (tryCounter <= MAX_TRY && opened == false)
            {
                Console.WriteLine("Introduce la combinación de la caja fuerte");
                usrCode = Console.ReadLine();

                if (usrCode == CODE)
                {
                    opened = true;
                }
                else
                {
                    Console.WriteLine("La combinación no es correcta");
                    Console.WriteLine("Llevas " + tryCounter + " intentos");
                    Console.WriteLine("Te quedan " + (MAX_TRY - tryCounter) + " intentos");
                }
                tryCounter = tryCounter + 1;
            }
            if (opened == true)
            {
                Console.WriteLine("Caja fuerte abierta");
            }
            else
            {
                Console.WriteLine("Caja fuerte bloqueada");
            }
        }
    }
}
