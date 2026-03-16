using BinaryTree.Lib;
namespace BinaryTrees.Test;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestInsert()
    {
        var tree = new BinaryTree.Lib.BinaryTree();
        tree.Insert(5);
        tree.Insert(3);
        tree.Insert(7);
        Assert.IsTrue(tree.Contains(5));
        Assert.IsTrue(tree.Contains(3));
        Assert.IsTrue(tree.Contains(7));
        Assert.IsFalse(tree.Contains(4));
    }

    [TestMethod]

    public void TestContains()
    {
        var tree = new BinaryTree.Lib.BinaryTree();
        tree.Insert(10);
        tree.Insert(5);
        tree.Insert(15);
        Assert.IsTrue(tree.Contains(10));
        Assert.IsTrue(tree.Contains(5));
        Assert.IsTrue(tree.Contains(15));
        Assert.IsFalse(tree.Contains(20));
    }

    [TestMethod]
    public void TestSum()
    {
        var tree = new BinaryTree.Lib.BinaryTree();
        tree.Insert(1);
        tree.Insert(2);
        tree.Insert(3);
        Assert.AreEqual(6, tree.Sum());
    }

    [TestMethod]
    public void TestOrderedString()
    {
        var tree = new BinaryTree.Lib.BinaryTree();
        tree.Insert(5);
        tree.Insert(3);
        tree.Insert(7);
        Assert.AreEqual("357", tree.orderedString());
    }
}

