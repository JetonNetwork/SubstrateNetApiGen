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


namespace SubstrateNetApi.Model.SpFinalityGrandpa
{
    
    
    /// <summary>
    /// >> Path: sp_finality_grandpa.app.Signature
    /// </summary>
    public sealed class Signature : BaseType
    {
        
        private SubstrateNetApi.Model.SpCore.Signature _value;
        
        public SubstrateNetApi.Model.SpCore.Signature Value
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
            return "Signature";
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
            Value = new SubstrateNetApi.Model.SpCore.Signature();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}