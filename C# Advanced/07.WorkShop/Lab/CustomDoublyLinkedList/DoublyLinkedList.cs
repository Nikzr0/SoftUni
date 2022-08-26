using System;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        private ListNode<T> head;
        private ListNode<T> tail;

        public int Count { get; set; }

        public void AddFirst(T element)
        {
            if (Count == 0)
            {
                head = tail = new ListNode<T>(element);
            }
            else
            {
                var newHead = new ListNode<T>(element);
                newHead.NextNode = head;
                head.PrevNode = head;
                head.PrevNode = newHead;
                head = newHead;
            }
            Count++;
        }

        public void AddLast(T element)
        {
            if (Count == 0)
            {
                head = tail = new ListNode<T> (element);
            }
            else
            {
                var newTail = new ListNode<T> (element);
                newTail.PrevNode = tail;
                tail.NextNode = newTail;
                tail = newTail;
            }
            Count++;
        }

        public T RemoveFirst()
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

        public T RemoveLast()
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

        public void ForEach(Action<T> action)
        {
            var currNode = head;
            while (currNode != null)
            {
                action(currNode.Value);
                currNode = currNode.NextNode;
            }
        }

        public T[] ToArray()
        {
            T[] array = new T[Count];
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
}