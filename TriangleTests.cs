using Triangles;

namespace TriangleTests;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void IsRight()
    {
        TriangleClassifier classifier = new TriangleClassifier();
        Assert.AreEqual(true, classifier.IsRight(new List<int>() { 90, 90, 90 }));
    }
    public void IsObtuse() 
    {
        TriangleClassifier classifier = new TriangleClassifier();
        Assert.AreEqual(false, classifier.IsObtuse(new List<int>() { 90, 90, 90 }));
    }
    public void IsAcute()
    {
        TriangleClassifier classifier = new TriangleClassifier();
        Assert.AreEqual(false, classifier.IsAcute(new List<int>() { 90, 90, 90 }));
    }
}
