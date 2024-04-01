namespace Tests;
using Library;
public class TwoValueCalculatorTest{

    [Fact]
    public void ValidChain(){
        var isValidResult=false;
        var message="";
        try{
            var input="2 +                 5";
            var calculator=new TwoValueCalculator(input);
            var value= calculator.getResult();
            isValidResult=value==7;
            
        }catch(Exception exception){
            message=exception.Message;
        }finally{            
            Assert.True(isValidResult,message);
        }
        
    }

    [Fact]
    public void ValidChainButInvalidOperator(){
        var isValidResult=false;
        var message="";
        try{
            var input="2 r                 5";
            var calculator=new TwoValueCalculator(input);
            var value= calculator.getResult();
            isValidResult=value==0;
            
        }catch(Exception exception){
            message=exception.Message;
        }finally{            
            Assert.True(isValidResult,message);
        }
        
    }

    [Fact]
    public void InvalidChain(){
        var isValidResult=false;
        var message="";
        try{
            var input="22 44";
            var calculator=new TwoValueCalculator(input);
            var value= calculator.getResult();
            isValidResult=value==0;
            
        }catch(Exception exception){
            message=exception.Message;
        }finally{            
            Assert.True(isValidResult,message);
        }
        
    }
}