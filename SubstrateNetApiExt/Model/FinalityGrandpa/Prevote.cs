//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.PrimitiveTypes;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.FinalityGrandpa
{
    
    
    /// <summary>
    /// >> 222 - Composite[finality_grandpa.Prevote]
    /// </summary>
    public sealed class Prevote : BaseType
    {
        
        /// <summary>
        /// >> target_hash
        /// </summary>
        private SubstrateNetApi.Model.PrimitiveTypes.H256 _targetHash;
        
        /// <summary>
        /// >> target_number
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U32 _targetNumber;
        
        public SubstrateNetApi.Model.PrimitiveTypes.H256 TargetHash
        {
            get
            {
                return this._targetHash;
            }
            set
            {
                this._targetHash = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U32 TargetNumber
        {
            get
            {
                return this._targetNumber;
            }
            set
            {
                this._targetNumber = value;
            }
        }
        
        public override string TypeName()
        {
            return "Prevote";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(TargetHash.Encode());
            result.AddRange(TargetNumber.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            TargetHash = new SubstrateNetApi.Model.PrimitiveTypes.H256();
            TargetHash.Decode(byteArray, ref p);
            TargetNumber = new SubstrateNetApi.Model.Types.Primitive.U32();
            TargetNumber.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
