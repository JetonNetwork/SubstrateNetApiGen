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
    
    
    public sealed class RuntimeVersion : BaseType
    {
        
        private Str _specName;
        
        private Str _implName;
        
        private U32 _authoringVersion;
        
        private U32 _specVersion;
        
        private U32 _implVersion;
        
        private Cow _apis;
        
        private U32 _transactionVersion;
        
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
        
        public Str ImplName
        {
            get
            {
                return this._implName;
            }
            set
            {
                this._implName = value;
            }
        }
        
        public U32 AuthoringVersion
        {
            get
            {
                return this._authoringVersion;
            }
            set
            {
                this._authoringVersion = value;
            }
        }
        
        public U32 SpecVersion
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
        
        public U32 ImplVersion
        {
            get
            {
                return this._implVersion;
            }
            set
            {
                this._implVersion = value;
            }
        }
        
        public Cow Apis
        {
            get
            {
                return this._apis;
            }
            set
            {
                this._apis = value;
            }
        }
        
        public U32 TransactionVersion
        {
            get
            {
                return this._transactionVersion;
            }
            set
            {
                this._transactionVersion = value;
            }
        }
        
        public override string TypeName()
        {
            return "RuntimeVersion";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(SpecName.Encode());
            result.AddRange(ImplName.Encode());
            result.AddRange(AuthoringVersion.Encode());
            result.AddRange(SpecVersion.Encode());
            result.AddRange(ImplVersion.Encode());
            result.AddRange(Apis.Encode());
            result.AddRange(TransactionVersion.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            SpecName = new Str();
            SpecName.Decode(byteArray, ref p);
            ImplName = new Str();
            ImplName.Decode(byteArray, ref p);
            AuthoringVersion = new U32();
            AuthoringVersion.Decode(byteArray, ref p);
            SpecVersion = new U32();
            SpecVersion.Decode(byteArray, ref p);
            ImplVersion = new U32();
            ImplVersion.Decode(byteArray, ref p);
            Apis = new Cow();
            Apis.Decode(byteArray, ref p);
            TransactionVersion = new U32();
            TransactionVersion.Decode(byteArray, ref p);
            _typeSize = p - start;
        }
    }
}
