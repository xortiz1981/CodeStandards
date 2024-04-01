using Library;

namespace Tests;


public class OperationalChainParserTest{
    [Fact]
    public void TestSingleBlankSpaceAroundOperator(){
        var additionChain="4 + 6";
        var operationalChainParser = new OperationalChainParser(additionChain);
        var operation = operationalChainParser.getOperation();
        var testValueA=operation.valueA==4;
        var operatorSymbol=operation.mathOperation=='+';
        var testValueB=operation.valueB==6;
        var test =  testValueA &&  operatorSymbol && testValueB;
        Assert.True(test,"Addition test "+additionChain+" gets a wrong parse");
    }

    [Fact]
    public void TestMultipleBlankSpaceAroundOperator(){
        var additionChain="4      +   6";
        var operationalChainParser = new OperationalChainParser(additionChain);
        var operation = operationalChainParser.getOperation();
        var testValueA=operation.valueA==4;
        var operatorSymbol=operation.mathOperation=='+';
        var testValueB=operation.valueB==6;
        var test =  testValueA &&  operatorSymbol && testValueB;
        Assert.True(test,"Addition test "+additionChain+" gets a wrong parse");
    }
}