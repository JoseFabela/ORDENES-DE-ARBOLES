using System;

class TreeNode
{
    public int Data;
    public TreeNode Left;
    public TreeNode Right;

    public TreeNode(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

class BinaryTree
{
    public TreeNode Root;

    public void Preorder(TreeNode node)
    {
        if (node != null)
        {
            Console.Write(node.Data + " ");
            Preorder(node.Left);
            Preorder(node.Right);
        }
    }

    public void Inorder(TreeNode node)
    {
        if (node != null)
        {
            Inorder(node.Left);
            Console.Write(node.Data + " ");
            Inorder(node.Right);
        }
    }

    public void Postorder(TreeNode node)
    {
        if (node != null)
        {
            Postorder(node.Left);
            Postorder(node.Right);
            Console.Write(node.Data + " ");
        }
    }

    public void PrintTreeStructure(TreeNode node, string indent = "", bool last = true)
    {
        if (node != null)
        {
            Console.Write(indent);
            if (last)
            {
                Console.Write("└─");
                indent += "  ";
            }
            else
            {
                Console.Write("├─");
                indent += "|";
            }

            Console.WriteLine(node.Data);

            PrintTreeStructure(node.Left, indent, false);
            PrintTreeStructure(node.Right, indent, true);
        }
    }
}

class Program
{
    static void Main()
    {
        // Crear un árbol de ejemplo
        BinaryTree tree = new BinaryTree();
        tree.Root = new TreeNode(1);
        tree.Root.Left = new TreeNode(2);
        tree.Root.Right = new TreeNode(3);
        tree.Root.Left.Left = new TreeNode(4);
        tree.Root.Left.Right = new TreeNode(5);
        tree.Root.Right.Left = new TreeNode(6);
        tree.Root.Right.Right = new TreeNode(7);

        Console.WriteLine("Recorrido Preorden:");
        tree.Preorder(tree.Root);
        Console.WriteLine("\nÁrbol Preorden:");
        tree.PrintTreeStructure(tree.Root);

        Console.WriteLine("Recorrido Inorden:");
        tree.Inorder(tree.Root);
        Console.WriteLine("\nÁrbol Inorden:");
        tree.PrintTreeStructure(tree.Root);

        Console.WriteLine("Recorrido Postorden:");
        tree.Postorder(tree.Root);
        Console.WriteLine("\nÁrbol Postorden:");
        tree.PrintTreeStructure(tree.Root);
        Console.ReadLine();
    }
}

