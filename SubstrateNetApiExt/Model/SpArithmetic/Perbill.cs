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


namespace SubstrateNetApi.Model.SpArithmetic
{
    
    
    /// <summary>
    /// >> 101 - Composite[sp_arithmetic.per_things.Perbill]
    /// </summary>
    public sealed class Perbill : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U32 _value;
        
        public SubstrateNetApi.Model.Types.Primitive.U32 Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public override string TypeName()
        {
            return "Perbill";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new SubstrateNetApi.Model.Types.Primitive.U32();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
