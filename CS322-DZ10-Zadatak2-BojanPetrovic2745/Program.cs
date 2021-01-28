using System;
using System.Collections;

namespace CS322_DZ10_Zadatak2_BojanPetrovic2745
{
    class Program
    {

        static void Main(string[] args)
        {
            MyStack stack = new MyStack(5);

            Console.WriteLine("Stack");

            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            stack.Peek();
            Console.WriteLine("Treba da brise 4, ali nisam uspeo da namestim da formatira kako treba");
            Console.WriteLine("............");

            stack.Pop();
            stack.Peek();

            Console.WriteLine("--------------------------");

            Console.WriteLine("Queue");

            MyQueue queue = new MyQueue();
            Console.WriteLine("Treba da brise 2, ali nisam uspeo da namestim da formatira kako treba");
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            queue.Print();

            Console.WriteLine("--------------------------");

            queue.Dequeue();
            queue.Print();





            



        }



    }
}
