using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        private ListNode head;
        private ListNode tail;

        public int Count { get; set; }
        private class ListNode
        {
            public int Value { get; set; }
            public ListNode NextNode { get; set; }
            public ListNode PrevNode { get; set; }
            public ListNode(int value)
            {
                Value = value;
            }
        }

        public void AddFirst(int element)
        {
            if (Count == 0)
            {
                head = tail = new ListNode(element);
            }
            else
            {
                var newHead = new ListNode(element);
                newHead.NextNode = head;
                head.PrevNode = head;
                head.PrevNode = newHead;
                head = newHead;
            }
            Count++;
        }

        public void AddLast(int element)
        {
            if (Count == 0)
            {
                head = tail = new ListNode(element);
            }
            else
            {
                var newTail = new ListNode(element);
                newTail.PrevNode = tail;
                tail.NextNode = newTail;
                tail = newTail;
            }
            Count++;
        }

        public int RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            var firstElement = head.Value;
            head = head.NextNode;

            if (head != null)
            {
                head.PrevNode = null;
            }
            else
            {
                tail = null;
            }

            Count--;
            return firstElement;
        }

        public int RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            var lastElement = tail.Value;
            tail = tail.PrevNode;

            if (tail != null)
            {
                tail.NextNode = null;
            }
            else
            {
                head = null;
            }

            Count--;
            return lastElement;
        }

        public void Foreach(Action<int> action)
        {
            var currNode = head;
            while (currNode != null)
            {
                action(currNode.Value);
                currNode = currNode.NextNode;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[Count];
            int counter = 0;
            var currMode = head;

            while (currMode != null)
            {
                array[counter] = currMode.Value;
                currMode = currMode.NextNode;
                counter++;
            }

            return array;
        }

    }
    class Program
    {
        static void Main()
        {            
            var list = new DoublyLinkedList();
            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);
            list.AddLast(4);
            list.AddFirst(0);
            list.AddLast(100);
            list.RemoveFirst();
            list.RemoveLast();

            Console.WriteLine(list.Count);
            Console.WriteLine(String.Join("-",list.ToArray()));
        }
    }
}