using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedList
    {
        internal  Node head;
        /// <summary>
        /// Adding the data
        /// </summary>
        /// <param name="data"></param>

        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        internal void Insert()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("linked list is empty");
                return;
            }
            while(temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }
        /// <summary>
        /// inserting the data at particular position
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        internal Node InsertAtParticularPosition(int Position, int data)
        {
            Node temp = this.head;
            Node node = new Node(data);
            for (int i = 0; i < Position - 1; i++)
            {
                temp = temp.next;
            }
            temp.next = node;
            return head;
        }
        /// <summary>
        /// displaying the list
        /// </summary>
        internal void Display()
        {
            Node node = head;
            while(node.next != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
            Console.WriteLine(node.data);
        }
           
    }
}
