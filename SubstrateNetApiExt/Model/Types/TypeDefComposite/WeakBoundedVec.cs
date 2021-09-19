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
using SubstrateNetApi.Model.Types.TypeDefArray;
using SubstrateNetApi.Model.Types.TypeDefComposite;
using SubstrateNetApi.Model.Types.TypeDefVariant;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.Types.TypeDefComposite
{
    
    
    public sealed class WeakBoundedVec : BaseType
    {
        
        private BaseVec<BalanceLock> _value;
        
        public BaseVec<BalanceLock> Value
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
            return "WeakBoundedVec";
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
            Value = new BaseVec<BalanceLock>();
            Value.Decode(byteArray, ref p);
            _typeSize = p - start;
        }
    }
}
