using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Example_1
{
    class Queue
    {
        public Node front;
        public Node rear;

        public Queue()
        {
            front = null;
            rear = null;
        }
        public void print()
        {
            Node n = front;

            if (front == null && rear == null)
            {
                Console.WriteLine("Queue Is Empty !");
                return;
            }
            while (n != null)
            {
                Console.Write(n.data + " . ");
                n = n.next;
            }
        }

        public void enqueue(int d)
        {
            Node nn = new Node(d);

            if (rear == null)
            {
                rear = nn;
                front = nn;
                return;
            }
            rear.next = nn;
            rear = nn;
        }
        public void dequeue()
        {
            if (front == null)
                return;

            //Node dn = front;
            Console.WriteLine($"{front.data} Is Deleted...");
            front = front.next;

            if (front == null)
                rear = null;
        }


    }
}
