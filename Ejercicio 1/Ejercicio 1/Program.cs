using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Dime un numero:");
        int age = Convert.ToInt32(Console.ReadLine());
        age = age % 2;
        if (age == 0)
        {
            Console.WriteLine("El numero es par");
        }
        else
        {
            Console.WriteLine("El numero es impar");

        }
    }
}