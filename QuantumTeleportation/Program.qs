// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace QuantumTeleportation
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Random;
    open Teleportation;

    @EntryPoint()
    operation RunProgram () : Unit {
        for idxRun in 1 .. 8 {
            let sent = DrawRandomBool(0.5);
            let received = TeleportClassicalMessage(sent);
            Message($"Round {idxRun}: Sent {sent}, got {received}.");
            Message(sent == received ? "Teleportation successful!" | "");
        }
    }
}