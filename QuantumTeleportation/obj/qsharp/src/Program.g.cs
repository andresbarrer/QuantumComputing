//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 436
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Intrinsic.Interfaces;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QuantumTeleportation\",\"Name\":\"RunProgram\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Core\",\"Name\":\"EntryPoint\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]},\"Argument\":{\"Item1\":{\"Case\":\"UnitValue\"},\"Item2\":[],\"Item3\":{\"Case\":\"UnitType\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":12},\"Item2\":{\"Line\":1,\"Column\":14}}]}},\"Offset\":{\"Item1\":10,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/andres/Documents/GitHub/School/QuantumComputing/QuantumTeleportation/Program.qs\",\"Position\":{\"Item1\":11,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QuantumTeleportation\",\"Name\":\"RunProgram\"},\"Attributes\":[],\"SourceFile\":\"/home/andres/Documents/GitHub/School/QuantumComputing/QuantumTeleportation/Program.qs\",\"Position\":{\"Item1\":11,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
#line hidden
namespace QuantumTeleportation
{
    [SourceLocation("/home/andres/Documents/GitHub/School/QuantumComputing/QuantumTeleportation/Program.qs", OperationFunctor.Body, 12, -1)]
    public partial class RunProgram : Operation<QVoid, QVoid>, ICallable
    {
        public RunProgram(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "RunProgram";
        String ICallable.FullName => "QuantumTeleportation.RunProgram";
        public static EntryPointInfo<QVoid, QVoid> Info => new EntryPointInfo<QVoid, QVoid>(typeof(RunProgram));
        protected ICallable<Double, Boolean> Microsoft__Quantum__Random__DrawRandomBool
        {
            get;
            set;
        }

        protected ICallable<Boolean, Boolean> Teleportation__TeleportClassicalMessage
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message__
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> __Body__ => (__in__) =>
        {
#line 14 "/home/andres/Documents/GitHub/School/QuantumComputing/QuantumTeleportation/Program.qs"
            foreach (var i in new QRange(1L, 8L))
#line hidden
            {
#line 16 "/home/andres/Documents/GitHub/School/QuantumComputing/QuantumTeleportation/Program.qs"
                var sent = Microsoft__Quantum__Random__DrawRandomBool.Apply(0.5D);
#line 17 "/home/andres/Documents/GitHub/School/QuantumComputing/QuantumTeleportation/Program.qs"
                var received = Teleportation__TeleportClassicalMessage.Apply(sent);
#line 18 "/home/andres/Documents/GitHub/School/QuantumComputing/QuantumTeleportation/Program.qs"
                Message__.Apply(String.Format("Round {0}: Sent {1}, got {2}.", i, sent, received));
#line 19 "/home/andres/Documents/GitHub/School/QuantumComputing/QuantumTeleportation/Program.qs"
                Message__.Apply(((sent == received) ? "Success.\n" : "Failed."));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Random__DrawRandomBool = this.__Factory__.Get<ICallable<Double, Boolean>>(typeof(global::Microsoft.Quantum.Random.DrawRandomBool));
            this.Teleportation__TeleportClassicalMessage = this.__Factory__.Get<ICallable<Boolean, Boolean>>(typeof(global::Teleportation.TeleportClassicalMessage));
            this.Message__ = this.__Factory__.Get<ICallable<String, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.Message));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<RunProgram, QVoid, QVoid>(QVoid.Instance);
        }
    }
}