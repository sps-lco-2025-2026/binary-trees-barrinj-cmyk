using BinaryTrees.Lib;
namespace BinaryTrees.Test;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestInsert()
    {
        var tree = new BinaryTrees.BinaryTrees();
        tree.Insert(5);
        tree.Insert(3);
        tree.Insert(7);
        Assert.IsTrue(tree.Contains(5));
        Assert.IsTrue(tree.Contains(3));
        Assert.IsTrue(tree.Contains(7));
        Assert.IsFalse(tree.Contains(4));
    }
}
