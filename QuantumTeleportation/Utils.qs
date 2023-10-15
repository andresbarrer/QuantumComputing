// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

// This file includes some utility functions to set and 
// verify |+⟩ and |-⟩ quantum states.
namespace TeleporationUtils 
{
    open Microsoft.Quantum.Random;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Math;

    // # Summary
    // Sets the qubit's state to |+⟩.
    operation SetToPlus(q: Qubit) : Unit 
    {
        Reset(q);   // Resets the qbit the 0 state
        H(q);       // Superposition to |0⟩ and |1⟩, sets the qubit to the |+⟩ state
    }

    // # Summary
    // Sets the qubit's state to |−⟩.
    operation SetToMinus(q: Qubit) : Unit 
    {
        Reset(q);   // Resets the qbit the 0 state
        X(q);       // Flips the qbit to the 1 state
        H(q);       // Superposition to |0⟩ and |1⟩, sets the qubit to the |-⟩ state
    }

    // # Summary
    // Returns true if qubit is |+⟩ 
    // (assumes qubit is either |+⟩ or |−⟩)
    operation MeasureIsPlus(q: Qubit) : Bool 
    {
        return (Measure([PauliX], [q]) == Zero);
    }

    /// # Summary
    /// Returns true if qubit is |−⟩ (assumes qubit is either |+> or |−⟩)
    operation MeasureIsMinus(q: Qubit) : Bool 
    {
        return (Measure([PauliX], [q]) == One);
    }

    /// # Summary
    /// Randomly prepares the qubit into |+⟩ or |−⟩
    operation PrepareRandomMessage(q: Qubit) : Unit {        
        let choice = DrawRandomBool(0.5);

        if (choice) {
            Message("Sending |−⟩");
            SetToMinus(q);
        } else {
            Message("Sending |+⟩");
            SetToPlus(q);
        }
    }
}