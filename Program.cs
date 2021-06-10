using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{ 
			var aboba = new MyList<string>();

			aboba.Add("1");
			aboba.Add("aboba_2");
			aboba.Add("RYWYD");
			aboba.Add("aboba_4");
			aboba.Add("aboba_5");

			aboba.Dispay();

			Console.Write("\n Введите элемент индекс которого ищете");
			string r = Console.ReadLine();
			


			Console.ReadKey();
		}

		class Node<T>
		{
			public Node(T data)
			{
				Data = data;
			}
			public T Data;
			public Node<T> Next;
			public Node<T> Prev;
		}

		class MyList<T>
		{
			Node<T> first;
			Node<T> last;
			int count;

			public void Add(T data)
			{
				var node = new Node<T>(data);
				if (first == null) first = node;
				else
				{
					last.Next = node;
					node.Prev = last;
				}
				last = node;
				count++;
			}

			public void Dispay()
			{
				if (first == null) return;
				int count = 1;
				var node = first;
				while (node != null)
				{
					Console.Write($"{node.Data} ");
					count++;
					node = node.Next;
				}
			}
			public T Poisk(T data)
			{
				MyList<T> poisk = new MyList<T>();
				while(data!=)
			}
		}
	}
}
