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
    
    
    public sealed class LastRuntimeUpgradeInfo : BaseType
    {
        
        private BaseCom<U32> _specVersion;
        
        private Str _specName;
        
        public BaseCom<U32> SpecVersion
        {
            get
            {
                return this._specVersion;
            }
            set
            {
                this._specVersion = value;
            }
        }
        
        public Str SpecName
        {
            get
            {
                return this._specName;
            }
            set
            {
                this._specName = value;
            }
        }
        
        public override string TypeName()
        {
            return "LastRuntimeUpgradeInfo";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(SpecVersion.Encode());
            result.AddRange(SpecName.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            SpecVersion = new BaseCom<U32>();
            SpecVersion.Decode(byteArray, ref p);
            SpecName = new Str();
            SpecName.Decode(byteArray, ref p);
            _typeSize = p - start;
        }
    }
}
