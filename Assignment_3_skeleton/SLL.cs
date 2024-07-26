using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
	
	public class SLL : LinkedListADT
    {
		Node head;
		Node tail;
        	int size = 0;
		public Node Head { get => head; set => head = value; }
		public Node Tail { get => tail; set => tail = value; }
		public int Size1 { get => size; set => size = value; }

		public void Append(object data)
        {
			// Create a new node with the given data
			Node newtail = new Node(data);
			// If the list is empty, both head and tail point to the new node
			if (!IsEmpty())
            {
				//set the current tail's Successor to the new node
				tail.Successor = new Node(data);

				// Update the tail to the new node
				tail = tail.Successor;
			}
			else
			{
				head = tail = new Node(data);
			}
            size++;
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
            size = 0;
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
            size++;
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
            return size;
        }
    }
}
