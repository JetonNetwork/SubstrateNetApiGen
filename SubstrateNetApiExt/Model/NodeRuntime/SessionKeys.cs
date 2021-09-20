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


namespace SubstrateNetApi.Model.NodeRuntime
{
    
    
    /// <summary>
    /// >> Path: node_runtime.SessionKeys
    /// </summary>
    public sealed class SessionKeys : BaseType
    {
        
        private SubstrateNetApi.Model.SpFinalityGrandpa.Public _grandpa;
        
        private SubstrateNetApi.Model.SpConsensusBabe.Public _babe;
        
        private SubstrateNetApi.Model.PalletImOnline.Public _imOnline;
        
        private SubstrateNetApi.Model.SpAuthorityDiscovery.Public _authorityDiscovery;
        
        public SubstrateNetApi.Model.SpFinalityGrandpa.Public Grandpa
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
        
        public SubstrateNetApi.Model.SpConsensusBabe.Public Babe
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
        
        public SubstrateNetApi.Model.PalletImOnline.Public ImOnline
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
        
        public SubstrateNetApi.Model.SpAuthorityDiscovery.Public AuthorityDiscovery
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
            Grandpa = new SubstrateNetApi.Model.SpFinalityGrandpa.Public();
            Grandpa.Decode(byteArray, ref p);
            Babe = new SubstrateNetApi.Model.SpConsensusBabe.Public();
            Babe.Decode(byteArray, ref p);
            ImOnline = new SubstrateNetApi.Model.PalletImOnline.Public();
            ImOnline.Decode(byteArray, ref p);
            AuthorityDiscovery = new SubstrateNetApi.Model.SpAuthorityDiscovery.Public();
            AuthorityDiscovery.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}