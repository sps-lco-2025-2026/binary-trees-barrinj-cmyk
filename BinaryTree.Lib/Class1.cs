using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;

namespace BinaryTreeLib;

public class BinaryTrees
{
    private Node _root;
    public BinaryTrees()
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
        return Contains(_root, n);
    }

    public override string ToString()
    {
        return ToString(_root);
    }

    public int sumTotal()
    {
        return sumTotal(_root);
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
}
