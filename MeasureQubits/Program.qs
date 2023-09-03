namespace MeasureQubits {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    
    @EntryPoint()
    operation MeasureOneQubit() : Result {

        //Allocate a qubit, default state is 0
        use q = Qubit();

        // Using a Hadamard operation, we put the qubit into
        // 50% chance of the qubit measuring 0 or 1
        H(q);

        // Measuring the qubit in Z-basis
        let result = M(q);

        // Reset the q bit before releasing it
        if result == One { X(q); }

        // We return the result of the measurement
        return result;
    }
}