// C# program to demonstrate
// insert operation in binary
// search tree
using System;
using System.Diagnostics;
using System.Threading;

class BinarySearchTree
{

	// Class containing left and
	// right child of current node
	// and key value


	public class Node
	{
		public int data;
		public Node left, right;

		public Node(int value)
		{
			data = value;
			left = null;
			right = null;
		}
	}


	Node parent;

	BinarySearchTree() { parent = null; }

	BinarySearchTree(int value) { parent = new Node(value); }

	Node InsertNode(Node root, int value)
	{

		if (root == null)
		{
			root = new Node(value);
			return root;
		}
		if (value < root.data)
        {
			root.right = InsertNode(root.right, value);

		}
		else if (value > root.data)
        {
			root.right = InsertNode(root.right, value);

		}
		return root;

	}
	void InOrder(Node root)
	{
		if (root != null)
		{
			InOrder(root.left);
			Console.WriteLine(root.data);
			InOrder(root.right);
		}
	}
	public static void Main(String[] args)
	{
		BinarySearchTree bst = new BinarySearchTree(0);

		Stopwatch stopWatch = new Stopwatch();

		Node root = null;

		stopWatch.Start();
	
		bst.InsertNode(bst.parent, 2);
		bst.InsertNode(bst.parent, 0);
		bst.InsertNode(bst.parent, 9);
		bst.InsertNode(bst.parent, 1);
		bst.InsertNode(bst.parent, 3);
		bst.InsertNode(bst.parent, 5);
		bst.InsertNode(bst.parent, 1);


		// Print inorder traversal of the BST
		bst.InOrder(bst.parent);
		stopWatch.Stop();
		TimeSpan ts = stopWatch.Elapsed;
		string elapsedTime = 
		   ts.Milliseconds.ToString();
		Console.WriteLine("RunTime " + elapsedTime);
	}
}

