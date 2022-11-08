using System;

namespace Asignature
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject s11 = new Subject(1);
            Subject s12 = new Subject(2);
            Subject s13 = new Subject(3);
            Subject s21 = new Subject(1);
            Subject s22 = new Subject(2);
            Subject s23 = new Subject(3);
            Subject s31 = new Subject(1);
            Subject s32 = new Subject(2);
            Subject s33 = new Subject(3);

            Student st1 = new Student(s11, s12, s13, "Paco", 100);
            Student st2 = new Student(s21, s22, s23, "Lola", 200);
            Student st3 = new Student(s31, s32, s33, "Reme", 300);

            Teacher teach1 = new Teacher("11111111A", "Lucas", "Informatica");

            teach1.PutMark(st1);
            teach1.PutMark(st2);
            teach1.PutMark(st3);

            double av1 = teach1.AverageScore(st1);
            double av2 = teach1.AverageScore(st2);
            double av3 = teach1.AverageScore(st3);

            double maxAv = Max(av1, av2, av3);
            string maxAvName;
            if (av1 == maxAv)
            {
                maxAvName = st1.GetName();
            }
            else
            {
                if (av2 == maxAv)
                {
                    maxAvName = st2.GetName();
                }
                else
                {
                    maxAvName = st3.GetName();
                }
            }

            Console.WriteLine("Media de " + st1.GetName() + ": " + teach1.AverageScore(st1));
            Console.WriteLine("Media de " + st2.GetName() + ": " + teach1.AverageScore(st2));
            Console.WriteLine("Media de " + st3.GetName() + ": " + teach1.AverageScore(st3));

            Console.WriteLine("La media mas alta es la de " + maxAvName);

        }
        static double Max(double d1, double d2, double d3)
        {
            if (d1 > d2)
            {
                if (d1 > d3)
                {
                    return d1;
                }
                else
                {
                    return d3;
                }
            }
            else
            {
                if (d2 > d3)
                {
                    return d2;
                }
                else
                {
                    return d3;
                }
            }
        }
    }
}
