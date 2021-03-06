//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletContracts
{
    
    
    /// <summary>
    /// >> 403 - Composite[pallet_contracts.wasm.PrefabWasmModule]
    /// </summary>
    public sealed class PrefabWasmModule : BaseType
    {
        
        /// <summary>
        /// >> instruction_weights_version
        /// </summary>
        private BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> _instructionWeightsVersion;
        
        /// <summary>
        /// >> initial
        /// </summary>
        private BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> _initial;
        
        /// <summary>
        /// >> maximum
        /// </summary>
        private BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> _maximum;
        
        /// <summary>
        /// >> refcount
        /// </summary>
        private BaseCom<SubstrateNetApi.Model.Types.Primitive.U64> _refcount;
        
        /// <summary>
        /// >> _reserved
        /// </summary>
        private BaseOpt<BaseTuple> _reserved;
        
        /// <summary>
        /// >> code
        /// </summary>
        private BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> _code;
        
        /// <summary>
        /// >> original_code_len
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U32 _originalCodeLen;
        
        public BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> InstructionWeightsVersion
        {
            get
            {
                return this._instructionWeightsVersion;
            }
            set
            {
                this._instructionWeightsVersion = value;
            }
        }
        
        public BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> Initial
        {
            get
            {
                return this._initial;
            }
            set
            {
                this._initial = value;
            }
        }
        
        public BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> Maximum
        {
            get
            {
                return this._maximum;
            }
            set
            {
                this._maximum = value;
            }
        }
        
        public BaseCom<SubstrateNetApi.Model.Types.Primitive.U64> Refcount
        {
            get
            {
                return this._refcount;
            }
            set
            {
                this._refcount = value;
            }
        }
        
        public BaseOpt<BaseTuple> Reserved
        {
            get
            {
                return this._reserved;
            }
            set
            {
                this._reserved = value;
            }
        }
        
        public BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U32 OriginalCodeLen
        {
            get
            {
                return this._originalCodeLen;
            }
            set
            {
                this._originalCodeLen = value;
            }
        }
        
        public override string TypeName()
        {
            return "PrefabWasmModule";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(InstructionWeightsVersion.Encode());
            result.AddRange(Initial.Encode());
            result.AddRange(Maximum.Encode());
            result.AddRange(Refcount.Encode());
            result.AddRange(Reserved.Encode());
            result.AddRange(Code.Encode());
            result.AddRange(OriginalCodeLen.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            InstructionWeightsVersion = new BaseCom<SubstrateNetApi.Model.Types.Primitive.U32>();
            InstructionWeightsVersion.Decode(byteArray, ref p);
            Initial = new BaseCom<SubstrateNetApi.Model.Types.Primitive.U32>();
            Initial.Decode(byteArray, ref p);
            Maximum = new BaseCom<SubstrateNetApi.Model.Types.Primitive.U32>();
            Maximum.Decode(byteArray, ref p);
            Refcount = new BaseCom<SubstrateNetApi.Model.Types.Primitive.U64>();
            Refcount.Decode(byteArray, ref p);
            Reserved = new BaseOpt<BaseTuple>();
            Reserved.Decode(byteArray, ref p);
            Code = new BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>();
            Code.Decode(byteArray, ref p);
            OriginalCodeLen = new SubstrateNetApi.Model.Types.Primitive.U32();
            OriginalCodeLen.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
