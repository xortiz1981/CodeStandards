namespace Library;

public class TwoValueCalculator{

    private string valueChain;
    private OperationalChainValidator validator;

    

    
    public TwoValueCalculator(string valueChain){
        this.valueChain=valueChain;
        this.validator=new OperationalChainValidator(this.valueChain);

    }

    public int getResult(){
        
        var isValid=this.validator.isValid();
        if(!isValid){
            throw new Exception(this.validator.getErrorCode());
        }

        var parser= new OperationalChainParser(valueChain);
        var operation=parser.getOperation();
        var mathOperation=new MathOperation(operation);

        return mathOperation.executeOperation();
    }

}