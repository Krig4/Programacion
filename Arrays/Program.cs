using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Organize(8,1,10);
        }
        static void Example()
        {
            Random r = new Random();
            int[] nums2 = new int[101];
            for (int index = 0; index < nums2.Length; index = index + 1) // Se puede poner ++index
            {
                nums2[index] = r.Next(0, 101);
                Console.WriteLine(nums2[index]);
            }
        }
        static void ten_numbers()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; ++i)
            {
                Console.WriteLine("Escribe un número");
                int num = Convert.ToInt32(Console.ReadLine());
                array[i] = num;

            }
            Console.WriteLine("Mostrar datos");
            for (int i = array.Length - 1; i >= 0; --i)
            {
                Console.WriteLine(array[i]);

            }
        }
        static void min_max()
        {
            Random r = new Random();
            int[] array = new int[15];
            for (int index = 0; index < array.Length; ++index)
            {
                array[index] = r.Next(0, 200);
                Console.WriteLine(array[index]);
            }
            int max = array[0];
            int min = array[0];
            for (int index = 1; index < array.Length; ++index)
            {
                if (array[index] > max)
                {
                    max = array[index];
                }
                if (array[index] < min)
                {
                    min = array[index];
                }
            }
            Console.WriteLine("El valor mínimo es: " + min);
            Console.WriteLine("El valor máximo es: " + max);
        }
        static void OneToRigth()
        {
            Random array = new Random();
            int[] nums = new int[20];
            for (int index = 0; index < nums.Length; index = index + 1)
            {
                nums[index] = array.Next(0, 50);
                Console.Write(nums[index] + " ");
            }
            int last = nums[nums.Length - 1];
            for (int index = nums.Length - 2; index >= 0; --index)
            {
                nums[index + 1] = nums[index];
            }
            nums[0] = last;
            Console.WriteLine();
            for (int index = 0; index < nums.Length; ++index)
            {
                Console.Write(nums[index] + " ");
            }
        }
        static void Square_Cube()
        {
            double[] array1 = new double[20];
            double[] array2 = new double[20];
            double[] array3 = new double[20];
            Random r = new Random();
            //rellenando el primero
            for (int i = 0; i < array1.Length; ++i)
            {
                array1[i] = r.Next(0, 101);
                Console.WriteLine(array1[i]);
            }
            Console.WriteLine();
            //elevando al cuadrado el segundo
            for (int i = 0; i < array2.Length; ++i)
            {
                array2[i] = Math.Pow(array1[i], 2);
                Console.WriteLine("el array2 es " + array2[i]);

            }
            Console.WriteLine();
            //elevando al cubo el tercero
            for (int i = 0; i < array3.Length; ++i)
            {
                /*array3[i] = array1[i] * array1[i] * array1[i]*/                
                array3[i] = Math.Pow(array1[i], 3);
                Console.WriteLine("el array3 es " + array3[i]);
            }
        }
        static void Organize(int narray, int minarray, int maxarray)
        {
            //Funcion con 3 parametros de entrada, el primero es el tamaño de la Array, el segundo es el mínimo array y el tercero el máximo del array. Ordenarlo de menos a mayor.
            Random random = new Random();
            int[] array = new int[narray];
            for (int index = 0; index < array.Length; ++index)
            {
                array[index] = random.Next(minarray, maxarray);
                Console.Write(array[index] + " ");
            }
            Console.WriteLine();
            Array.Sort(array);
            for (int index = 0; index < array.Length; ++index)
            {
                 Console.Write(array[index] + " ");
            }
        }
    }
}
