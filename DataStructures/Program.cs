using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welome to Linked List");
            LinkedList list = new LinkedList();
            list.Add(56);
           // list.Add(30);
            list.Add(70);
            list.Insert();
            list.InsertAtParticularPosition(2, 30);
            list.Display();
        }
    }
}
