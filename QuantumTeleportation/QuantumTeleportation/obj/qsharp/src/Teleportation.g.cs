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

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Teleportation\",\"Name\":\"Teleport\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\Andres\\\\Documents\\\\GitHub\\\\School\\\\QuantumComputing\\\\QuantumTeleportation\\\\QuantumTeleportation\\\\Teleportation.qs\",\"Position\":{\"Item1\":35,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"msg\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":24}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Sends the state of one qubit to a target qubit by using\",\" teleportation.\",\"\",\" Notice that after calling Teleport, the state of `msg` is\",\" collapsed.\",\"\",\" # Input\",\" ## msg\",\" A qubit whose state we wish to send.\",\" ## target\",\" A qubit initially in the |0〉 state that we want to send\",\" the state of msg to.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Teleportation\",\"Name\":\"Teleport\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\Andres\\\\Documents\\\\GitHub\\\\School\\\\QuantumComputing\\\\QuantumTeleportation\\\\QuantumTeleportation\\\\Teleportation.qs\",\"Position\":{\"Item1\":35,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Teleportation\",\"Name\":\"TeleportClassicalMessage\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\Andres\\\\Documents\\\\GitHub\\\\School\\\\QuantumComputing\\\\QuantumTeleportation\\\\QuantumTeleportation\\\\Teleportation.qs\",\"Position\":{\"Item1\":75,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"message\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Bool\"},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Uses teleportation to send a classical message from one qubit\",\" to another.\",\"\",\" # Input\",\" ## message\",\" If `true`, the source qubit (`here`) is prepared in the\",\" |1〉 state, otherwise the source qubit is prepared in |0〉.\",\"\",\" ## Output\",\" The result of a Z-basis measurement on the teleported qubit,\",\" represented as a Bool.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Teleportation\",\"Name\":\"TeleportClassicalMessage\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\Andres\\\\Documents\\\\GitHub\\\\School\\\\QuantumComputing\\\\QuantumTeleportation\\\\QuantumTeleportation\\\\Teleportation.qs\",\"Position\":{\"Item1\":75,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
#line hidden
namespace Teleportation
{
    [SourceLocation("C:\\Users\\Andres\\Documents\\GitHub\\School\\QuantumComputing\\QuantumTeleportation\\QuantumTeleportation\\Teleportation.qs", OperationFunctor.Body, 36, 76)]
    public partial class Teleport : Operation<(Qubit,Qubit), QVoid>, ICallable
    {
        public Teleport(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Teleport";
        String ICallable.FullName => "Teleportation.Teleport";
        protected Allocate Allocate__
        {
            get;
            set;
        }

        protected Release Release__
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> Microsoft__Quantum__Intrinsic__CNOT
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> Microsoft__Quantum__Measurement__MResetZ
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__Z
        {
            get;
            set;
        }

        protected ICallable<Result, Boolean> Microsoft__Quantum__Canon__IsResultOne
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit), QVoid> __Body__ => (__in__) =>
        {
            var (msg,target) = __in__;
#line hidden
            {
#line 37 "C:\\Users\\Andres\\Documents\\GitHub\\School\\QuantumComputing\\QuantumTeleportation\\QuantumTeleportation\\Teleportation.qs"
                var register = Allocate__.Apply();
#line hidden
                bool __arg1__ = true;
                try
                {
#line 39 "C:\\Users\\Andres\\Documents\\GitHub\\School\\QuantumComputing\\QuantumTeleportation\\QuantumTeleportation\\Teleportation.qs"
                    Microsoft__Quantum__Intrinsic__H.Apply(register);
#line 40 "C:\\Users\\Andres\\Documents\\GitHub\\School\\QuantumComputing\\QuantumTeleportation\\QuantumTeleportation\\Teleportation.qs"
                    Microsoft__Quantum__Intrinsic__CNOT.Apply((register, target));
#line 43 "C:\\Users\\Andres\\Documents\\GitHub\\School\\QuantumComputing\\QuantumTeleportation\\QuantumTeleportation\\Teleportation.qs"
                    Microsoft__Quantum__Intrinsic__CNOT.Apply((msg, register));
#line 44 "C:\\Users\\Andres\\Documents\\GitHub\\School\\QuantumComputing\\QuantumTeleportation\\QuantumTeleportation\\Teleportation.qs"
                    Microsoft__Quantum__Intrinsic__H.Apply(msg);
#line 51 "C:\\Users\\Andres\\Documents\\GitHub\\School\\QuantumComputing\\QuantumTeleportation\\QuantumTeleportation\\Teleportation.qs"
                    if ((Microsoft__Quantum__Measurement__MResetZ.Apply(msg) == Result.One))
                    {
#line 51 "C:\\Users\\Andres\\Documents\\GitHub\\School\\QuantumComputing\\QuantumTeleportation\\QuantumTeleportation\\Teleportation.qs"
                        Microsoft__Quantum__Intrinsic__Z.Apply(target);
                    }

#line 56 "C:\\Users\\Andres\\Documents\\GitHub\\School\\QuantumComputing\\QuantumTeleportation\\QuantumTeleportation\\Teleportation.qs"
                    if (Microsoft__Quantum__Canon__IsResultOne.Apply(Microsoft__Quantum__Measurement__MResetZ.Apply(register)))
                    {
#line 56 "C:\\Users\\Andres\\Documents\\GitHub\\School\\QuantumComputing\\QuantumTeleportation\\QuantumTeleportation\\Teleportation.qs"
                        Microsoft__Quantum__Intrinsic__X.Apply(target);
                    }
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release__.Apply(register);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Intrinsic__CNOT = this.__Factory__.Get<IUnitary<(Qubit,Qubit)>>(typeof(global::Microsoft.Quantum.Intrinsic.CNOT));
            this.Microsoft__Quantum__Measurement__MResetZ = this.__Factory__.Get<ICallable<Qubit, Result>>(typeof(global::Microsoft.Quantum.Measurement.MResetZ));
            this.Microsoft__Quantum__Intrinsic__Z = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.Z));
            this.Microsoft__Quantum__Canon__IsResultOne = this.__Factory__.Get<ICallable<Result, Boolean>>(typeof(global::Microsoft.Quantum.Canon.IsResultOne));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __DataIn__((Qubit,Qubit) data) => new In(data);
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit msg, Qubit target)
        {
            return __m__.Run<Teleport, (Qubit,Qubit), QVoid>((msg, target));
        }
    }

    [SourceLocation("C:\\Users\\Andres\\Documents\\GitHub\\School\\QuantumComputing\\QuantumTeleportation\\QuantumTeleportation\\Teleportation.qs", OperationFunctor.Body, 76, -1)]
    public partial class TeleportClassicalMessage : Operation<Boolean, Boolean>, ICallable
    {
        public TeleportClassicalMessage(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TeleportClassicalMessage";
        String ICallable.FullName => "Teleportation.TeleportClassicalMessage";
        protected Allocate Allocate__
        {
            get;
            set;
        }

        protected Release Release__
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Qubit), QVoid> Teleport__
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> Microsoft__Quantum__Measurement__MResetZ
        {
            get;
            set;
        }

        public override Func<Boolean, Boolean> __Body__ => (__in__) =>
        {
            var message = __in__;
#line hidden
            {
#line 78 "C:\\Users\\Andres\\Documents\\GitHub\\School\\QuantumComputing\\QuantumTeleportation\\QuantumTeleportation\\Teleportation.qs"
                var (msg,target) = (Allocate__.Apply(), Allocate__.Apply());
#line hidden
                bool __arg1__ = true;
                try
                {
#line 81 "C:\\Users\\Andres\\Documents\\GitHub\\School\\QuantumComputing\\QuantumTeleportation\\QuantumTeleportation\\Teleportation.qs"
                    if (message)
                    {
#line 82 "C:\\Users\\Andres\\Documents\\GitHub\\School\\QuantumComputing\\QuantumTeleportation\\QuantumTeleportation\\Teleportation.qs"
                        Microsoft__Quantum__Intrinsic__X.Apply(msg);
                    }

#line 86 "C:\\Users\\Andres\\Documents\\GitHub\\School\\QuantumComputing\\QuantumTeleportation\\QuantumTeleportation\\Teleportation.qs"
                    Teleport__.Apply((msg, target));
#line 89 "C:\\Users\\Andres\\Documents\\GitHub\\School\\QuantumComputing\\QuantumTeleportation\\QuantumTeleportation\\Teleportation.qs"
                    return (Microsoft__Quantum__Measurement__MResetZ.Apply(target) == Result.One);
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release__.Apply(msg);
#line hidden
                        Release__.Apply(target);
                    }
                }
            }
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
            this.Teleport__ = this.__Factory__.Get<ICallable<(Qubit,Qubit), QVoid>>(typeof(Teleport));
            this.Microsoft__Quantum__Measurement__MResetZ = this.__Factory__.Get<ICallable<Qubit, Result>>(typeof(global::Microsoft.Quantum.Measurement.MResetZ));
        }

        public override IApplyData __DataIn__(Boolean data) => new QTuple<Boolean>(data);
        public override IApplyData __DataOut__(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Boolean message)
        {
            return __m__.Run<TeleportClassicalMessage, Boolean, Boolean>(message);
        }
    }
}