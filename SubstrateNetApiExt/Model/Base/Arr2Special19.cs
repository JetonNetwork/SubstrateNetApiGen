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


namespace SubstrateNetApi.Model.Base
{
    
    
    /// <summary>
    /// >> Array
    /// </summary>
    public sealed class Arr2Special19 : BaseType
    {
        
        private SubstrateNetApi.Model.Types.Primitive.U8[] _value;
        
        public override int TypeSize
        {
            get
            {
                return 2;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U8[] Value
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
            return string.Format("[{0}; {1}]", new SubstrateNetApi.Model.Types.Primitive.U8().TypeName(), this.TypeSize);
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            foreach (var v in Value){result.AddRange(v.Encode());};
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            var array = new SubstrateNetApi.Model.Types.Primitive.U8[TypeSize];
            for (var i = 0; i < array.Length; i++) {var t = new SubstrateNetApi.Model.Types.Primitive.U8();t.Decode(byteArray, ref p);array[i] = t;};
            var bytesLength = p - start;
            Bytes = new byte[bytesLength];
            Array.Copy(byteArray, start, Bytes, 0, bytesLength);
            Value = array;
        }
        
        public void Create(SubstrateNetApi.Model.Types.Primitive.U8[] array)
        {
            Value = array;
            Bytes = Encode();
        }
    }
}