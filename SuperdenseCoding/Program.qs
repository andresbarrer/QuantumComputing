namespace SuperdenseCoding 
{

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Measurement;
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Preparation;
    open Quantum.SuperdenseCoding;
    

    @EntryPoint()
    operation Start() : Unit 
    {
    
        // encode 00
        TestDenseCoding(false, false); 
        Message("***************");
        
        // encode 01
        TestDenseCoding(false, true); 
        Message("***************");
        
        
        // encode 10
        TestDenseCoding(true, false);  
        Message("***************");
        
        // encode 11
        TestDenseCoding(true, true);  
        Message("***************");
    }
}