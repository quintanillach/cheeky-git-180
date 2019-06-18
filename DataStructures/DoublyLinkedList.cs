namespace Module3
{
	public class DoublyLinkedList
		{
			public class Node
			{
				// Double linked list requires next and previous pointers
				public int data { get; set; }
				public Node next { get; set; }
				public Node prev { get; set; }

				// Overloaded constructor to set default property values when passed the appropriate type
				public Node(int value)
				{
					data = value;
					next = null;
					prev = null;
				}
			}

			public Node first;
			public Node last;

			// Default constructor with first node set to null
			public DoublyLinkedList()   // O(1)
			{
				first = null;
			}

			// Check if list empty
			public bool IsEmpty()   // O(1)
			{
				return first == null;
			}

			public void AddFirst(int value) // O(1)
			{
				Node newNode = new Node(value);

				if (IsEmpty()) // O(1)
				{
					// Set the new Node as the first Node
					first = newNode;
				}
				else // O(1)
				{
					// If list is not empty, set next pointer to current first node
					// to ensure no loss of data
					newNode.next = first;

					// Set the previous pointer for the former first node
					first.prev = newNode;

					// Set the new Node as first
					first = newNode;
				}
			}

			public void AddLast(int value)  // O(1)
			{
				if (IsEmpty())  // O(1)
				{
					// Pass the value to the AddFirst method if empty list            
					AddFirst(value);    // O(1)
				}

				Node newNode = new Node(value);

				// When list contains only one node perform simple assignment
				if (first.next == null)  // O(1)
				{
					// Set prev and next pointers to prevent loss of data
					newNode.prev = first;
					first.next = newNode;

					// Assign new Node as last
					last = newNode;
				}

				// If last has a value, start at the end
				else    // O(1)
				{
					// Set prev and next pointers to prevent loss of data
					newNode.prev = last;
					last.next = newNode;

					// Assigb new node as last
					last = newNode;
				}
			}
			public void PrintReverseList()   // O(n)
			{
				Console.WriteLine("\n");

				if (IsEmpty() || last == null)  // O(1)
				{
					Console.WriteLine("The list is empty...");
				}

				else    // O(n)
				{
					// Start from the end
					Node current = last;

					while (current != null) // O(n)
					{
						// Print to console with space separation
						Console.Write($"{current.data} ");

						// Move to previous node in list
						current = current.prev;
					}
					Console.WriteLine("\n");
				}
			}

			// Determine whether the list is a palindrome (same forward and backward)
			public static bool IsPalindrome(Node first, Node last)  // O(n)
			{
				// Empty list is not a palindrome
				if (first == null)  // O(1)
				{
					return false;
				}

				// List of one node is a palindrome
				else if (first.next == null)    // O(1)
				{
					return true;
				}

				// Declare an indexer to track the nodes pushed to the stack
				Node index_1 = first,
					index_2 = last;

				while (index_1 != index_2)  // O(n)
				{
					if (index_1.data != index_2.data)   // O(1)
					{
						return false;
					}

					// Move inward from both sides
					index_1 = index_1.next;
					index_2 = index_2.prev;
				}

				// All nodes matched and list is a palindrome
				return true;
			}

			// Print the list
			public void PrintList() // O(n)
			{
				Console.WriteLine("\n");

				if (IsEmpty())  //O(1)
				{
					Console.WriteLine("The list is empty...");
				}
				
				else
				{
					// Start from first node
					Node current = first;

					while (current != null) //O(n)
					{
						// Print to console with space separation
						Console.Write($"{current.data} ");

						// Move to next node
						current = current.next;
					}

					Console.WriteLine("\n");
				}
			}
		}
		
	public class MSSA_List
	{
		public static void Main(string[] args)
		{
			DoublyLinkedList problem2 = new DoublyLinkedList();
			problem2.AddFirst(3);
			problem2.AddLast(6);
			problem2.AddLast(9);
			problem2.AddLast(6);
			problem2.AddLast(3);

			problem2.PrintList();

			if (DoublyLinkedList.IsPalindrome(problem2.first, problem2.last))
			{
				Console.WriteLine("Doubly Linked List is a palindrome");
			}
			else
			{
				Console.WriteLine("Doubly Linked List is not a palindrome");
			}

			problem2.PrintReverseList();
		}
	}
}