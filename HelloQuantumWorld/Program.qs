namespace HelloQuantumWorld
{

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;

    @EntryPoint()
    operation sayHelloQ() : Unit {
        Message("Hello Quantum World!");
    }
}

