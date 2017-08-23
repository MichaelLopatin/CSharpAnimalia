using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class MyList<T> : IEnumerable, IEnumerator
    {
        private Node head;
        private Node current;
        public class Node
        {
            public T data;
            public T Data
            {
                get
                {
                    return data;
                }
                set
                {
                    data = value;
                }
            }
            public Node next;
            public Node Next
            {
                get
                {
                    return next;
                }
                set
                {
                    next = value;
                }
            }
            public Node(T data)
            {
                this.data = data;
                this.Next = this;
            }
        }

        public void AddNode(T node)
        {
            Node item = new Node(node);
            if (!ExistHead())
            {
                item.Next = null;
            }
            else
            {
                item.Next = head;
            }
            current = head = item;
        }

        public void RemoveHead()
        {
            current = head;
            if (!ExistHead())
            {
                return;
            }
            else
            {
                current = head = current.next;
            }
        }
        public T GetCurentData()
        {
            return current.Data;
        }

        public T GetHeadData()
        {
            return head.Data;
        }
        public bool ExistHead()
        {
            return (head != null);
        }
        public Node GetCurentNext()
        {
            return current.Next;
        }

        public object Current
        {
            get
            {
                return this.current.Data;
            }
        }

        public IEnumerator GetEnumerator()
        {
            Reset();
            return this;
        }

        private int count = -1;// счетчик
        public bool MoveNext()
        {
            Console.WriteLine("MoveNext");
            if (count==-1)
            {
                current = head;
            }
            else
            {
                current = current?.next;
            }
            count++;
            return (current != null);
        }
        public void Reset()
        {
            Console.WriteLine("Reset");
            count = -1;
        }
    }
}
