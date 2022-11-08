using System;

namespace Contraseña
{
    class Program
    {
        static void Main(string[] args)
        {
            Password p1 = new Password();
            Password p2 = new Password(4);

            Console.WriteLine("La contraseña " + p1.GetPassword() + " es de longitud " + p1.GetLength() + " es fuerte " + p1.IsStrong());
            Console.WriteLine("La contraseña " + p2.GetPassword() + " es de longitud " + p2.GetLength() + " es fuerte " + p2.IsStrong());
        }
    }
}
