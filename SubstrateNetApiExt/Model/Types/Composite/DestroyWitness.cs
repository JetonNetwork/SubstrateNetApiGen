//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Composite;
using SubstrateNetApi.Model.Types.Enum;
using SubstrateNetApi.Model.Types.Primitive;
using SubstrateNetApi.Model.Types.Sequence;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.Types.Composite
{
    
    
    /// <summary>
    /// >> Path: pallet_uniques.types.DestroyWitness
    /// </summary>
    public sealed class DestroyWitness : BaseType
    {
        
        private BaseCom<U32> _instances;
        
        private BaseCom<U32> _instanceMetadatas;
        
        private BaseCom<U32> _attributes;
        
        public BaseCom<U32> Instances
        {
            get
            {
                return this._instances;
            }
            set
            {
                this._instances = value;
            }
        }
        
        public BaseCom<U32> InstanceMetadatas
        {
            get
            {
                return this._instanceMetadatas;
            }
            set
            {
                this._instanceMetadatas = value;
            }
        }
        
        public BaseCom<U32> Attributes
        {
            get
            {
                return this._attributes;
            }
            set
            {
                this._attributes = value;
            }
        }
        
        public override string TypeName()
        {
            return "DestroyWitness";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Instances.Encode());
            result.AddRange(InstanceMetadatas.Encode());
            result.AddRange(Attributes.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Instances = new BaseCom<U32>();
            Instances.Decode(byteArray, ref p);
            InstanceMetadatas = new BaseCom<U32>();
            InstanceMetadatas.Decode(byteArray, ref p);
            Attributes = new BaseCom<U32>();
            Attributes.Decode(byteArray, ref p);
            _typeSize = p - start;
        }
    }
}
