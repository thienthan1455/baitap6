using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 2, 8 };

            Queue s = new Queue();
            for (int i = 0; i < array.Length; i++)
                s.Enqueue(array[i]);
            for (int i = 0; i < array.Length; i++)
                array[i] = s.Dequeue();
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + "  ");
        }

    }
}
