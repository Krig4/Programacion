using System;

namespace Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            Person paco = new Person();
            Person lucia = new Person("Lucia", 21, 'M');
            Person lucas = new Person("Lucas", 35, 'H', 1.85f, 70);

            Console.WriteLine(paco.toString());
            Console.WriteLine(lucia.toString());
            Console.WriteLine(lucas.toString());

            Console.WriteLine("El IMC de " + paco.GetName() + " es " + paco.CalculateIMC() + " es mayo de edad " + paco.IsAdult() + " es hombre " + paco.IsGender('H') + " es mujer " + paco.IsGender('M'));
        }
    }
}
