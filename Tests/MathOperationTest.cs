namespace Tests;

using System.Reflection;
using Library;
public class MathOperationTest
{
    [Fact]
    public void TestAddition()
    {
        var operation = new Operation();
        operation.valueA=7;
        operation.valueB=10;
        operation.mathOperation='+';

        var mathOperation= new MathOperation(operation);
        var result = mathOperation.executeOperation();

        var is17=result==17;
        Assert.True(is17);        
    }

     [Fact]
    public void TestSubtraction()
    {
        var operation = new Operation();
        operation.valueA=13;
        operation.valueB=10;
        operation.mathOperation='-';

        var mathOperation= new MathOperation(operation);
        var result = mathOperation.executeOperation();

        var is3=result==3;
        Assert.True(is3);        
    }

    [Fact]
    public void TestSubtractionWithNegativeResult()
    {
        var operation = new Operation();
        operation.valueA=7;
        operation.valueB=10;
        operation.mathOperation='-';

        var mathOperation= new MathOperation(operation);
        var result = mathOperation.executeOperation();

        var isNegative=result<0;
        Assert.True(isNegative);        
    }

    [Fact]
    public void TestMultiplication()
    {
        var operation = new Operation();
        operation.valueA=7;
        operation.valueB=10;
        operation.mathOperation='*';

        var mathOperation= new MathOperation(operation);
        var result = mathOperation.executeOperation();

        var is70=result==70;
        Assert.True(is70);        
    }
   
   [Fact]
    public void TestDivision()
    {
        var operation = new Operation();
        operation.valueA=63;
        operation.valueB=7;
        operation.mathOperation='/';

        var mathOperation= new MathOperation(operation);
        var result = mathOperation.executeOperation();

        var is9=result==9;
        Assert.True(is9);        
    }

    [Fact]
    public void TestDivisionWithZeroDivisor()
    {
        var operation = new Operation();
        operation.valueA=63;
        operation.valueB=0;
        operation.mathOperation='/';

        var mathOperation= new MathOperation(operation);
        var result = mathOperation.executeOperation();

        var isEqualsValueA=result==operation.valueA;
        Assert.True(isEqualsValueA);        
    }

    [Fact]
    public void TestDefault()
    {
        var operation = new Operation();
        operation.valueA=63;
        operation.valueB=0;
        operation.mathOperation='#';

        var mathOperation= new MathOperation(operation);
        var result = mathOperation.executeOperation();

        var isEqualsZero=result==0;
        Assert.True(isEqualsZero);        
    }
}