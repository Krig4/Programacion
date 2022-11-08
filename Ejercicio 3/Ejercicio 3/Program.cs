using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Dime la hora en formato 24 horas:");
        int hora = Convert.ToInt32(Console.ReadLine());
        if (hora <= 12)
        {
            Console.WriteLine("La hora es " + hora + " am");
        }

        else
        {
            hora = hora - 12;
            Console.WriteLine("La hora es " + hora + " pm");

        }
    }
}