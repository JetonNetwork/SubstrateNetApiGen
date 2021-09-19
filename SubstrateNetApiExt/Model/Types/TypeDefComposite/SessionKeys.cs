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
    
    
    public sealed class SessionKeys : BaseType
    {
        
        private Public _grandpa;
        
        private Public _babe;
        
        private Public _imOnline;
        
        private Public _authorityDiscovery;
        
        public Public Grandpa
        {
            get
            {
                return this._grandpa;
            }
            set
            {
                this._grandpa = value;
            }
        }
        
        public Public Babe
        {
            get
            {
                return this._babe;
            }
            set
            {
                this._babe = value;
            }
        }
        
        public Public ImOnline
        {
            get
            {
                return this._imOnline;
            }
            set
            {
                this._imOnline = value;
            }
        }
        
        public Public AuthorityDiscovery
        {
            get
            {
                return this._authorityDiscovery;
            }
            set
            {
                this._authorityDiscovery = value;
            }
        }
        
        public override string TypeName()
        {
            return "SessionKeys";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Grandpa.Encode());
            result.AddRange(Babe.Encode());
            result.AddRange(ImOnline.Encode());
            result.AddRange(AuthorityDiscovery.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Grandpa = new Public();
            Grandpa.Decode(byteArray, ref p);
            Babe = new Public();
            Babe.Decode(byteArray, ref p);
            ImOnline = new Public();
            ImOnline.Decode(byteArray, ref p);
            AuthorityDiscovery = new Public();
            AuthorityDiscovery.Decode(byteArray, ref p);
            _typeSize = p - start;
        }
    }
}