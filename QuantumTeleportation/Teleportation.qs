namespace Teleportation {

    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Measurement;
    open Utils;

    // # Summary
    // Sends the state of one qubit to a target qubit by using teleportation.

    // Notice that after calling Teleport, the state of `msg` is collapsed.
    
    // Input: msg (A qubit whose state we wish to send)
    // Output: target (A qubit initially in the |0〉 state that we want to send the state of msg to.)
    
    operation Teleport (msg : Qubit, target : Qubit) : Unit 
    {
        use register = Qubit();


        // To fully transfer both the relative phase information and the value information of a qubit, 
        // it is essential that the qubit is in a superposition of its basis states |0⟩ and |1⟩. 
        // This superposition is a fundamental requirement for the quantum teleportation protocol to work correctly.
        // If the qubit is not in superposition (for example, if it's in a definite |0⟩ or |1⟩ state), some of the 
        // information may not be properly teleported, and the teleportation may not work as intended. This is because 
        // the superposition states allow for the encoding and transfer of both the phase and value information, which is a 
        // key aspect of quantum teleportation's ability to faithfully transmit quantum states from one location to another.
        
        // Create some entanglement that we can use to send our message.
        H(register);
        CNOT(register, target);

        // Encode the message into the entangled pair.
        CNOT(msg, register);
        H(msg);

        // Measure the qubits to extract the classical data we need to decode the message by applying the corrections on
        // the target qubit accordingly.
        
        // Quantum teleportation aims to transmit the quantum state of one qubit to another qubit. 
        // During this process, various factors like entanglement and measurements can introduce 
        // phase changes that need to be corrected for accurate teleportation. 
        
        // When measured in the Z-basis (the computational basis), 
        // |+⟩ collapses to |0⟩, and |-⟩ collapses to |1⟩.

        // It is needed to detect whether a phase flip occured during the 
        // teleporation process, and to correct it


        // Used to transfer the phase information of the message
        if (MResetZ(msg) == One) // MResetZ = measure a qubit in the Z basis, then returns it to its previous value
        { 
            // negates the phase of the |1⟩ state
            Z(target); 
        }

        // Used to transfer the value of the message
        if (IsResultOne(MResetZ(register))) 
        { 
            // negates the phase of the |0⟩ state
            X(target); 
        }
    }

    // One can use quantum teleportation circuit to send an unobserved
    // (unknown) classical message from source qubit to target qubit
    // by sending specific (known) classical information from source
    // to target.

    /// # Summary
    /// Uses teleportation to send a classical message from one qubit
    /// to another.
    ///
    /// # Input: message
    /// If `true`, the source qubit (`here`) is prepared in the
    /// |1〉 state, otherwise the source qubit is prepared in |0〉.
    ///
    /// Output: 
    /// The result of a Z-basis measurement on the teleported qubit,
    /// represented as a Bool.
    operation TeleportClassicalMessage (message : Bool) : Bool 
    {
        // Ask for some qubits that we can use to teleport.
        use (msg, target) = (Qubit(), Qubit());

        // Encode the message we want to send.
        if (message) 
        {
            X(msg);
        }

        // Use the operation we defined above.
        Teleport(msg, target);

        // Check what message was sent.
        return MResetZ(target) == One;
    }

}

