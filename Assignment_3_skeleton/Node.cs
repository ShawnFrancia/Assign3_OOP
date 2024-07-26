using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
	public class Node
	{
		object element;
		Node successor;

		public Node(object o)
		{
			Element = o;
		}

		public Node(Object o, Node n)
		{
			this.Element = o;
			this.Successor = n;
		}

		public object Element { get => element; set => element = value; }
		public Node Successor { get => successor; set => successor = value; }
	}
}
