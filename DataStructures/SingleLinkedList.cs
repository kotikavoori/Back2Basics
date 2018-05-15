using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class SingleLinkedList
    {
        public Node head;
        public Node tail;
        public int count;

        public SingleLinkedList()
        {
            head = new Node();
            tail = head;
        }


        void InsertAtLast(object data)
        {




        }
        void InsertAtBegin(object data)
        {
                Node newNode = new Node() { nodevalue = 1 };
                newNode.next = head.next;
                head.next = newNode;
                count++;
            

        }
        void RemoveFromStart()
        {

        }

        void Remove()
        {

        }

        void Travel()
        {

        }


    }



    //Each Node stores data and link to next node
    //Address of head node gives access to list ,
    //if addrss of node is null or zero , then its last node
    public class Node
    {
        public Node next;
        public object nodevalue;
    }
}
