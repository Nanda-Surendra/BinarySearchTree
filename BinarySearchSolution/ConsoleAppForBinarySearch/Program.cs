// See https://aka.ms/new-console-template for more information
using ConsoleAppForBinarySearch;

//Recursive version with help from ChatGPT

Node root = new Node(20);
BinarySearchTreeUsingRecursion_ChatGPT.InsertNode(root, 4);
BinarySearchTreeUsingRecursion_ChatGPT.InsertNode(root, 16);

BinarySearchTreeUsingRecursion_ChatGPT.InsertNode(root, 76);
BinarySearchTreeUsingRecursion_ChatGPT.InsertNode(root, 13);

BinarySearchTreeUsingRecursion_ChatGPT.InsertNode(root, 4);
BinarySearchTreeUsingRecursion_ChatGPT.InsertNode(root, 11);


Console.WriteLine("Created BST using Recursion");
List<Node> allNodes = new List<Node>();


Console.WriteLine("Loop: Sort ascending");

BinarySearchTreeUsingRecursion_ChatGPT.SortTreeAscending(root, allNodes);

foreach(Node node in allNodes)
{
    Console.WriteLine(node.Data);
}

Console.WriteLine("Loop: Sort descending");


allNodes.Clear();
BinarySearchTreeUsingRecursion_ChatGPT.SortTreeDescending(root, allNodes);

foreach (Node node in allNodes)
{
    Console.WriteLine(node.Data);
}



//Loop version
BinarySearchTreeUsingLoop bst = new BinarySearchTreeUsingLoop();
bst.InsertNode(20);
bst.InsertNode(30);
bst.InsertNode(10);
bst.InsertNode(15);
bst.InsertNode(25);
bst.InsertNode(35);

Console.WriteLine("Created BST using loop");
allNodes = new List<Node>();

Console.WriteLine("Loop: Sort ascending");

BinarySearchTreeUsingRecursion_ChatGPT.SortTreeAscending(bst.root, allNodes);
foreach (Node node in allNodes)
{
    Console.WriteLine(node.Data);
}

Console.WriteLine("Loop: Sort descending");

allNodes.Clear();
BinarySearchTreeUsingRecursion_ChatGPT.SortTreeDescending(bst.root, allNodes);
foreach (Node node in allNodes)
{
    Console.WriteLine(node.Data);
}
