using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;

namespace BinaryTree.Lib;

public class BinaryTree
{
    private Node _root;
    public BinaryTree()
    {
        _root = null;
    }

    public void Insert(int n)
    {
        if (_root == null)
        {
            _root = new Node(n);
        }
        else
        {
            _root.Insert(n);
        }
    }

    public bool Contains(int n)
    {
        return _root != null && _root.Contains(n);
    }


    private string ToString(Node root)
    {
        if (root == null)
        {
            return "";
        }
        return ToString(root.Left) + root.Value.ToString() + ToString(root.Right);
    }

    public string orderedString()
    {
        return ToString(_root);
    }
    public int Sum()
    {
        return _root != null ? _root.sum() : 0;
    }

}


internal class Node
{
    public int Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
    
    public void Insert(int n)
    {
        if (n < Value)
        {
            if (Left == null)
            {
                Left = new Node(n);
            }
            else
            {
                Left.Insert(n);
            }
        }
        else
        {
            if (Right == null)
            {
                Right = new Node(n);
            }
            else
            {
                Right.Insert(n);
            }
        }
    }

    public bool Contains(int n)
    {
        if (n == Value)
        {
            return true;
        }
        else if (n < Value)
        {
            return Left != null && Left.Contains(n);
        }
        else
        {
            return Right != null && Right.Contains(n);
        }
    }

    public override string ToString()
    {
        return Value.ToString();
    }

    public int sum()
    {
        int sum = Value;
        if (Left != null)
        {
            sum += Left.sum();
        }
        if (Right != null)
        {
            sum += Right.sum();
        }
        return sum;
    }

    public string orderedString()
    {
        string result = "";
        if (Left != null)
        {
            result += Left.orderedString();
        }
        result += Value.ToString();
        if (Right != null)
        {
            result += Right.orderedString();
        }
        return result.Trim();
    }
}
