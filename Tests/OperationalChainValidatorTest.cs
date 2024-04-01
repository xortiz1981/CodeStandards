using Library;

namespace Tests;


public class OperationalChainValidatorTest{
    [Fact]
    public void TestValidInput(){
        var validChain="3   +       5";
        var operationalChainValidator=new OperationalChainValidator(validChain);
        var pass=operationalChainValidator.isValid();
        Assert.True(pass);
    }

    [Fact]
    public void TestInvalidInputMax8DigitsPerValue(){
        var validChain="3   dd       12345678";
        var operationalChainValidator=new OperationalChainValidator(validChain);
        var fail=operationalChainValidator.isValid();
        Assert.False(fail);
    }


}