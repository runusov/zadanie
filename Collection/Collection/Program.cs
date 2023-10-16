using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arr arr = new Arr();
            arr.z1();
            arr.z2();
            arr.z3();
            arr.z4();

            Lis lis = new Lis();
            lis.z1();
            lis.z2();
            lis.z3();
            lis.z4();

            Queue q = new Queue();
            q.z1();
            q.z2();
            q.z3();
            q.z4();

            Stack s = new Stack();
            s.z1();
            s.z2();
            s.z3();
            s.z4();
        }

        class General 
        {
            public ArrayList a = new ArrayList();
            public List<int> b = new List<int>();
            public Queue<string> c = new Queue<string>();
            public Stack<double> d = new Stack<double>();
        }

        class Arr : General
        {
            public void z1()
            {
                a.Add(1);
                a.Add("kek");
                a.Add(35);
                a.Add("popa");
            }

            public void z2()
            {
                a.Remove(1);
            }

            public void z3()
            {
                Console.WriteLine(a[0]);
            }

            public void z4() 
            {
                Console.WriteLine(a.Count);
            }
        }

        class Lis : General
        {
            public void z1()
            {
                b.Add(1);
                b.Add(13);
                b.Add(35);
                b.Add(5);
            }

            public void z2()
            {
                b.Remove(1);
            }

            public void z3()
            {
                Console.WriteLine(b[0]);
            }

            public void z4()
            {
                Console.WriteLine(b.Count);
            }
        }


        class Queue : General
        {
            public void z1()
            {
                c.Enqueue("kek");
                c.Enqueue("lol");
                c.Enqueue("chebureck");
                c.Enqueue("lmao");
            }

            public void z2()
            {
                c.Dequeue();
            }

            public void z3()
            {
                Console.WriteLine(c.Peek());
            }

            public void z4()
            {
                Console.WriteLine(c.Count);
            }
        }



        class Stack : General
        {
            public void z1()
            {
                d.Push(5);
                d.Push(10);
                d.Push(15);
                d.Push(20);
                
            }

            public void z2()
            {
                d.Pop();
            }

            public void z3()
            {
                Console.WriteLine(d.Peek());
            }

            public void z4()
            {
                Console.WriteLine(d.Count);
            }
        }
    }
}
