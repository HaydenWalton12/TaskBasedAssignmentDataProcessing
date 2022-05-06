#include <chrono>
#include <iostream>
using namespace std;

struct BST
{

	int data;
	BST* left = nullptr;
	BST* right = nullptr;


	BST()
	{
		data = 0;
		left = nullptr;
		right = nullptr;
	}

	BST(int value)
	{
		data = value;
		left = nullptr;
		right = nullptr;
	}

	BST* Insert(BST* root, int value)
	{
		//Creates Initial Root Node If not Already Created
		if (root == nullptr)
		{
			return new BST(value);
		}
		// Insert data if onto the 
		if (value > root->data)
		{
			root->right = Insert(root->right, value);
		}
		else
		{
			//process Left node
			root->left = Insert(root->left, value);
		}
		//returns root after insertion
		return root;
	}

	void DisplayInOrder(BST* root)
	{
		if (root == nullptr)
		{
			return;
		}
		DisplayInOrder(root->left);
		cout << root->data << endl;
		DisplayInOrder(root->right);
	}
};


int main()
{
	BST system, * root = nullptr;

	std::chrono::high_resolution_clock::time_point start(
		std::chrono::high_resolution_clock::now());
	
	std::chrono::high_resolution_clock::now() - start;

	cout << start;
	root = system.Insert(root, 50);
	
	system.Insert(root, 30);
	system.Insert(root, 20);
	system.Insert(root, 40);
	system.Insert(root, 70);
	system.Insert(root, 60);
	system.Insert(root, 80);

	system.DisplayInOrder(root);
	return 0;
}
