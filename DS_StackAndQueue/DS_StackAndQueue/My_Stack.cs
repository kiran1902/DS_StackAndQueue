﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_StackAndQueue
{
    public class My_Stack<Gtype>
    {
        Node<Gtype>? top;

        public My_Stack()
        {
            this.top = null;
        }

        ///<summary>
        ///Methods to push elements in the stack
        ///</summary>
        public void Push(Gtype data)
        {
            //create a node 
            Node<Gtype> node = new Node<Gtype>(data);
            if (top is null)
            {
                top = node;
            }
            else
            {
                node.next = top;
                top = node;
            }
        }

        ///<summary>
        ///Methods to show elements in the stack
        ///</summary>
        public void Show()
        {
            //traverse and print the elements in data while loop traverse till condition is satisfied
            Node<Gtype> temp_top = top;

            while (temp_top.next != null)
            {
                Console.WriteLine(temp_top.val + " ");
                temp_top = temp_top.next;
            }
            Console.WriteLine(temp_top.val);
        }
    }
}
