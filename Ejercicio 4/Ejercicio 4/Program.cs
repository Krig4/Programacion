﻿using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Cuantos kilometros ha recorrido?:");
        int km = Convert.ToInt32(Console.ReadLine());
        float factura;
        if (km <= 299)
        {
            Console.WriteLine("La factura es de 100 euros");
        }

        else if (300 < km && 1000 > km)
        {
            factura = (km - 300) * 10 + 100;
            Console.WriteLine("La factura es de " + factura);
        }
        else
        {
            factura = (km - 1000) * 5 + 7100;
            Console.WriteLine("La factura es de " + factura);

        }
        Console.ReadLine();
    }

}
