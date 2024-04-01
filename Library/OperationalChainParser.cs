using System.Numerics;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace Library;

public class OperationalChainParser{

    private Operation operation;
    private string operationalChain="";

    public OperationalChainParser(string operationalChain){
        this.operation= new Operation();
        this.operationalChain=operationalChain.Trim();
        this.stringSplitter();
    }

     

    private void stringSplitter(){
        var buffer=Regex.Replace(this.operationalChain,@"\s+"," ");
        var temporal=buffer.Split(" ");
        
        this.operation.valueA=Int32.Parse(temporal[0]);
        this.operation.mathOperation=Char.Parse(temporal[1]);
        this.operation.valueB=Int32.Parse(temporal[2]);       
        
    }

    public Operation getOperation(){        
        return this.operation;
    }

    



}