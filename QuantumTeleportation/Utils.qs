
// This file includes some utility functions to set and 
// verify |+⟩ and |-⟩ quantum states.
namespace Utils 
{
    open Microsoft.Quantum.Random;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Math;

    // # Summary
    // Sets the qubit's state to |+⟩.
    operation SetToPlus(q: Qubit) : Unit 
    {
        Reset(q);   // Resets the qbit to the 0 state
        H(q);       // Superposition to |0⟩ and |1⟩, sets the qubit to the |+⟩ state (phase 0)
    }

    // # Summary
    // Sets the qubit's state to |−⟩.
    operation SetToMinus(q: Qubit) : Unit 
    {
        Reset(q);   // Resets the qbit to the 0 state
        X(q);       // Flips the qbit to the 1 state
        H(q);       // Superposition to |0⟩ and |1⟩, sets the qubit to the |-⟩ state (phase π) 
    }


    // Eigenvalues represent the possible measurement outcomes, and how
    // an operator scales the vectors (quantum states) it acts upon

    // Eigenvalue 1 tells us that the gate preserves the length (magnitude in the complex vector space) 
    // of the quantum states
    
    // # Summary
    // Returns true if qubit is |+⟩ 
    // (assumes qubit is either |+⟩ or |−⟩)
    operation MeasureIsPlus(q: Qubit) : Bool 
    {
        // Measure returns Zero if +1 eigenvalue is observed
        return (Measure([PauliX], [q]) == Zero);
    }

    /// # Summary
    /// Returns true if qubit is |−⟩ (assumes qubit is either |+> or |−⟩)
    operation MeasureIsMinus(q: Qubit) : Bool 
    {
        // Measure returns One if -1 eigenvalue is observed
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