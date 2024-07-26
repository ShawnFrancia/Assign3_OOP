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
		Node head;
		Node tail;
		public Node Head { get => head; set => head = value; }
		public Node Tail { get => tail; set => tail = value; }
		

		public void Append(object data)
        {
			Node newtail = new Node(data);
			if (IsEmpty())
            {
                head = tail = new Node(data);

			}
			else
			{
                tail.Successor = new Node(data);

				newtail = tail;
			}
		}

         public void Print()
        {
            for (Node tempNode = head; tempNode != null; tempNode = tempNode.Successor)
            {
                Console.WriteLine(tempNode.Element);
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
			
		}

        public int IndexOf(object data)
        {
            int counter = 0;
            for (Node tempNode = head; tempNode != null; tempNode = tempNode.Successor)
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
            Node newhead = new Node(data);
            
            if (IsEmpty())
            {
                head = tail = newhead;
            }
		    else
            {
                newhead.Successor = head;
                head = newhead;
            }
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
