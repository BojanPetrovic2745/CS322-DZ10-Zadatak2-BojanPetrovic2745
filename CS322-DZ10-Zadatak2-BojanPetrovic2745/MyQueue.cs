using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CS322_DZ10_Zadatak2_BojanPetrovic2745
{
    class MyQueue
    {
        private ArrayList queue;

        public MyQueue()
        {
            queue = new ArrayList();
        }

        public void Enqueue(int data)
        {
            queue.Add(data);
        }

        public void Dequeue()
        {
            queue.RemoveAt(0);
        }

        public void Print()
        {
            for (int i = 0; i < queue.Count; i++)
            {
                Console.WriteLine("Item[" + (i + 1) + "]: "+ queue[i]);
            }
        }
    }
}
