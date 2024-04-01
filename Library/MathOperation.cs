namespace Library;

public class MathOperation{

    private Operation operation;
    private int result;
    public MathOperation(Operation operation){
        this.operation=operation;
    }

    private void makeAddition(){
        var valueA= this.operation.valueA;

        var valueB= this.operation.valueB;

        this.result = valueA + valueB;
    }
    private void makeSubtraction(){
        var valueA= this.operation.valueA;

        var valueB= this.operation.valueB;

        this.result = valueA - valueB;
    }
    private void makeMultiplication(){
        var multiplier= this.operation.valueA;

        var multiplicand= this.operation.valueB;

        this.result = multiplier * multiplicand;
    }
    private void makeDivision(){
        var dividend = this.operation.valueA;

        var divisor = this.operation.valueB==0?1:this.operation.valueB;

        this.result = dividend / divisor;
    }

    public int executeOperation(){
        var mathOperator = this.operation.mathOperation;

        switch(mathOperator){
            case '+':
                this.makeAddition();
                break;
            case '-':
                this.makeSubtraction();
                break;
            case '*':
                this.makeMultiplication();
                break;
            case '/':
                this.makeDivision();
                break;
            default:
                this.result=0;
                break;
        }

        return this.result;
    }
}