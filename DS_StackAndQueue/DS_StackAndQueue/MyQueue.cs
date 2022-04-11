using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_StackAndQueue
{
    public class MyQueue<Gtype>
    {
        Node<Gtype> front;
        Node<Gtype> rare;

        ///<summary>
        ///Methods to add elements into the Queue
        ///</summary>
        public void Enqueue(Gtype data)
        {
            Node<Gtype> node = new Node<Gtype>(data);
            
            if (rare == null)
            {
                front = node;
                rare = node;
            }
            else
            {
                rare.next = node;
                rare = node;
            }
        }

        ///<summary>
        ///Method to display
        ///</summary>
        public void Show()
        {
            Node<Gtype> temp = front;
            if(temp == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                while(temp.next != null)
                {
                    Console.WriteLine(temp.val + " ");
                    temp = temp.next;
                }
                
            }
            Console.WriteLine(temp.val);
        }

        ///<summary>
        ///Methods to delete element from the Queue
        ///</summary>
        public Gtype Dequeue()
        {
            //variable
            Node<Gtype> temp;

            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return default(Gtype);
            }
            else
            {
                temp = front;

                if (front.next == null)
                {
                    front = null;
                }
                else
                {
                    front = front.next;
                }
                return temp.val;
            }

        }

        ///<summary>
        ///Methods to check wether the Queue is empty
        ///</summary>
        public bool IsEmpty()
        {
            if (front is null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
