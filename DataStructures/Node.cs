using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Node
    {
        /// <summary>
        /// constructor to intialize data and next variable
        /// data create the next node
        /// </summary>
        public int data;
        public Node next;
        public Node(int data)
        {
         this.data = data;
        }
    }
}

