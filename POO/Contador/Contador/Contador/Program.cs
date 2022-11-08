using System;

namespace Contador
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter();
            Counter c2 = new Counter(1, 2);
            Counter cC = new Counter(c2);

            Console.WriteLine(c1.toString());
            Console.WriteLine(c2.toString());
            Console.WriteLine(cC.toString());

            c1.Increase();
            Console.WriteLine(c1.toString());
            c2.Increase();
            Console.WriteLine(c2.toString());
            c1.Increase(20);
            Console.WriteLine(c1.toString());
            c2.Decrease();
            Console.WriteLine(c2.toString());
            c2.Decrease(2);
            Console.WriteLine(c2.toString());
        }
    }
}
