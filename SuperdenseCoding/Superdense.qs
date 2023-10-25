namespace Quantum.SuperdenseCoding
{
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Preparation;
    open Microsoft.Quantum.Measurement;

    operation TestDenseCoding(val0 : Bool, val1 : Bool) : Unit 
    {
        use q0 = Qubit();
        use q1 = Qubit();
        // Prepare the maximally entangled state |Φ⁺⟩ between qubits
        PrepareEntangledState([q0], [q1]);
        Encode(val0, val1, q0);
        Decode(q0, q1);
    }


    operation Encode(val0 : Bool, val1 : Bool, qubit : Qubit) : Unit 
    {
        mutable encoded = "";

        // Pauli gate leaves qubit unchanged
        // if we encode 00, use Pauli I to keep |Φ⁺⟩
        if (not val0 and not val1) 
        {
            I(qubit);
            set encoded = "00";
        }

        // Pauli X gates flips vector 180 degrees around x axis (NOT)
        // if we encode 01, use Pauli X to create |Ψ⁺⟩
        if (not val0 and val1) 
        {
            X(qubit);
            set encoded = "01";
        }

        // 180 degree phase shift on 1 (rotation on Z axis), leaves 0 unchanged in phase
        // Leaves the amplitude unchanged
        // |0> to -|1> phase change
        // if we encode 10, use Pauli Z to create |Φ⁻⟩
        // Z = value 0, phase 0
        // X + Z = value 1, phase π
        if (val0 and not val1) 
        {
            Z(qubit);
            set encoded = "10";
        }

        // |0> to -i|1> (bit flip and phase flip)
        // if we encode 11, use Pauli Y to create |Ψ⁻⟩
        // Y = 
        if (val0 and val1) 
        {
            Y(qubit);
            set encoded = "11";
        }
        Message("Encoded: " + encoded);
    }

    operation Decode(q0 : Qubit, q1 : Qubit) : Unit 
    {
        // apply reverse Bell circuit
        CNOT(q0, q1); // Undoes the entanglement that was created
        H(q0);        // Undoes Hadamard to cancel its effect

        // measure both qubits
        let result0 = MResetZ(q0);
        let result1 = MResetZ(q1);
        Message("Decoded: " + (result0 == One ? "1" | "0") + (result1 == One ? "1" | "0"));
    }
}
