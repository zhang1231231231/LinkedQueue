using System;

namespace LinkedQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedQueue<int> queue = new LinkedQueue<int>();
            queue.EnQueue(2);
            queue.EnQueue(4);
            queue.EnQueue(6);
            Console.WriteLine("queue size = {0}", queue.Size);
            Console.WriteLine("queue.DeQueue() = {0}", queue.DeQueue());
            Console.WriteLine("queue size = {0}", queue.Size);
            Console.ReadLine();
        }
    }

    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Item { get; set; }

        public Node(T item)
        {
            this.Item = item;
        }
        public Node()
        {

        }
    }

    public class LinkedQueue<T>
    {
        private Node<T> first;
        private Node<T> tail;
        private int index;
        public LinkedQueue()
        {
            index = 0;
            tail = null;
            first = null;
        }
        /// <summary>
        /// 入队列
        /// </summary>
        /// <param name="item">添加元素</param>
        public void EnQueue(T item)
        {
            Node<T> oldLastQueue = tail;
            tail = new Node<T>();
            tail.Item = item;
            if (IsEmpty())
            {
                first = tail;
            }
            else
            {
                oldLastQueue.Next = tail;
            }
            index++;
        }
        /// <summary>
        /// 出队列
        /// </summary>
        /// <returns>出队元素</returns>
        public T DeQueue()
        {
            T item = first.Item;
            first = first.Next;
            index--;
            if (IsEmpty())
            {
                tail = null;
            }
            return item;
        }
        /// <summary>
        /// 判断是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return this.index == 0;
        }
        /// <summary>
        /// 该队列的元素长度
        /// </summary>
        public int Size
        {
            get
            {
                return this.index;
            }
            
        }

    }

}
