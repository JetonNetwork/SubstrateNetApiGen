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


namespace SubstrateNetApi.Model.SpConsensusBabe
{
    
    
    /// <summary>
    /// >> Path: sp_consensus_babe.BabeEpochConfiguration
    /// </summary>
    public sealed class BabeEpochConfiguration : BaseType
    {
        
        private BaseTuple<SubstrateNetApi.Model.Types.Primitive.U64,SubstrateNetApi.Model.Types.Primitive.U64> _c;
        
        private SubstrateNetApi.Model.SpConsensusBabe.EnumAllowedSlots _allowedSlots;
        
        public BaseTuple<SubstrateNetApi.Model.Types.Primitive.U64,SubstrateNetApi.Model.Types.Primitive.U64> C
        {
            get
            {
                return this._c;
            }
            set
            {
                this._c = value;
            }
        }
        
        public SubstrateNetApi.Model.SpConsensusBabe.EnumAllowedSlots AllowedSlots
        {
            get
            {
                return this._allowedSlots;
            }
            set
            {
                this._allowedSlots = value;
            }
        }
        
        public override string TypeName()
        {
            return "BabeEpochConfiguration";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(C.Encode());
            result.AddRange(AllowedSlots.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            C = new BaseTuple<SubstrateNetApi.Model.Types.Primitive.U64,SubstrateNetApi.Model.Types.Primitive.U64>();
            C.Decode(byteArray, ref p);
            AllowedSlots = new SubstrateNetApi.Model.SpConsensusBabe.EnumAllowedSlots();
            AllowedSlots.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
