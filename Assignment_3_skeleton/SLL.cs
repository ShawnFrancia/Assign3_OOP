using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_3_skeleton
{
    public class SLL : LinkedListADT
    {
        public void Append(object data)
        {
            if (IsEmpty())
            {
                tail.Successor = new Node(data);
                tail = tail.Successor;
            }
            else
            {
                head = tail = new Node(data);
            }
        }

        public void Clear()
        {
            head = null; tail = null;
        }

        public bool Contains(object data)
        {
            throw new NotImplementedException();
        }

        public void Delete(int index)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object data)
        {
            int counter = 0;
        for (Node tempNode = head; tempNode != null; tempNode.Successor)
            {
                if (data.Equals(tempNode.Element))
                {
                    return counter;
                }
                counter++;
            }
            return -1;
        }

        public void Insert(object data, int index)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            return (head == null);
        }

        public void Prepend(object data)
        {
            head = new Node(o, head);
            if (tail == null)
            {
                tail = head;
            }
            else
            { }
        }

        public void Replace(object data, int index)
        {
            throw new NotImplementedException();
        }

        public object Retrieve(int index)
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            throw new NotImplementedException();
        }
    }
}
