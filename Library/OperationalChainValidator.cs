namespace Library;

using System.Text.RegularExpressions;

public class OperationalChainValidator{

    private string inputString;
    private string validPattern;

    private string errorCode="";
    public OperationalChainValidator(string inputString){
        this.inputString=inputString.Trim();
        this.validPattern=@"^[0-9]{1,7}[ ]+\D[ ]+[0-9]{1,7}$";
    }

    public bool isValid(){
        var isValidChain=Regex.IsMatch(this.inputString,this.validPattern);
        this.errorCode=isValidChain?"":"E12345";
        return isValidChain; 
    }

    public string getErrorCode(){
        return this.errorCode;
    }

}