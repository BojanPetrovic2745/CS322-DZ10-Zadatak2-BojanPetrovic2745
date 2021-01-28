using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CS322_DZ10_Zadatak2_BojanPetrovic2745
{
    class MyStack
    {

        private ArrayList stack;


       public MyStack(int size)
       {
           stack = new ArrayList(size);
          
       }

       public void Push(int value)
       {
           stack.Add(value);
       }

       public void Reverse()
       {
           stack.Reverse();
       }

       public void Pop()
       {
           
           stack.Remove(stack.Count +1);
       }


       public void Peek()
       {
           for (int i = 0; i <= stack.Count -1; i++)
           {
               Console.WriteLine("Item[" + (i + 1) + "]: " + stack[i]);
           }
           
        }


    }
}
