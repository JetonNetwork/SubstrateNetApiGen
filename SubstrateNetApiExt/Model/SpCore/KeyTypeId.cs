//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Base;
using SubstrateNetApi.Model.Types.Base;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.SpCore
{
    
    
    /// <summary>
    /// >> 365 - Composite[sp_core.crypto.KeyTypeId]
    /// </summary>
    public sealed class KeyTypeId : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private SubstrateNetApi.Model.Base.Arr4U8 _value;
        
        public SubstrateNetApi.Model.Base.Arr4U8 Value
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
            return "KeyTypeId";
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
            Value = new SubstrateNetApi.Model.Base.Arr4U8();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
