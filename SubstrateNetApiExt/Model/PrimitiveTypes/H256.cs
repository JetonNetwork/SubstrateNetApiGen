//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Types.Base;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PrimitiveTypes
{
    
    
    /// <summary>
    /// >> Path: primitive_types.H256
    /// </summary>
    public sealed class H256 : BaseType
    {
        
        private SubstrateNetApi.Model.Base.Arr32Special1 _value;
        
        public SubstrateNetApi.Model.Base.Arr32Special1 Value
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
            return "H256";
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
            Value = new SubstrateNetApi.Model.Base.Arr32Special1();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
