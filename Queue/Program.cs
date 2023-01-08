using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {

        class Queuez
        {
            public int[] ele;
            public int front;
            public int rear;
            public int max;

            public Queuez(int size)
            {
                ele = new int[size];
                front = 0;
                rear = -1;
                max = size;
            }


        }

        public class Qu
        {
            Queuez que;
           public Qu(int size)
            {

                que = new Queuez(size);

            }

            // Function to add an item to the queue.
            // It changes rear and size
            public void enqueue(int item)
            {
                if (que.rear == que.max - 1)
                {
                    Console.WriteLine("Queue Overflow");
                    return;
                }
                else
                {
                    que.ele[++que.rear] = item;
                }
            }


            // Function to remove an item from queue.
            // It changes front and size
            public void dequeue()
            {
                if (que.front == que.rear + 1)
                {
                    Console.WriteLine("Queue is Empty");

                }
                else
                {
                    Console.WriteLine(que.ele[que.front] + " dequeued from queue");
                    int p = que.ele[que.front++];
                    Console.WriteLine();
                    Console.WriteLine("Front item is {0}", que.ele[que.front]);
                    Console.WriteLine("Rear item is {0} ", que.ele[que.rear]);
                    que.max++;
                }
            }


            // Function to print queue.
            public void printQueue()
            {
                if (que.front == que.rear + 1)
                {
                    Console.WriteLine("Queue is Empty");
                    return;
                }
                else
                {
                    for (int i = que.front; i <= que.rear; i++)
                    {
                        Console.WriteLine(que.ele[i] + " enqueued to queue");
                    }

                }
            }

           public int search(int x)
           {
                while (que.front<=que.rear)
                {
                    if(que.ele[que.front] == x)
                        return que.front;

                    que.front++;
                }

                return -1;
           }





        }
        

        static void Main(string[] args)
        {

            Qu quzi = new Qu(6);

            quzi.enqueue(6);

            quzi.enqueue(5);
            quzi.enqueue(4);
            quzi.enqueue(3);

            quzi.printQueue();

            Console.ReadLine();
        }
    }
}
