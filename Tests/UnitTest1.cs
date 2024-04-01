namespace Tests;

using Library;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var a = Class1.demo()==14;
        Assert.True(a);
    }
   
}