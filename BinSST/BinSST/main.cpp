

struct node
{
	int data;
	node* left;
	node* right;



	node() = default;

	node(int d, node* l, node* r)
	{
		data = d;
		left = l;
		right = r;



	}
};



int main()
{



}


node* insert(int data, node* n)
{

	if (n == nullptr)
	{
		n = new node(data , null , null);

		
	}


}
