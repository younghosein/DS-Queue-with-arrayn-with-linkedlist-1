using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue s = new Queue();

            s.enqueue(26);
            s.enqueue(72);
            s.enqueue(98);
            s.enqueue(51);
            s.enqueue(83);
            s.enqueue(13);
            s.enqueue(56);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Queue Is : ");
            s.print();
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            s.dequeue();
            s.dequeue();
            Console.WriteLine("Now Queue Is : ");
            s.print();
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
