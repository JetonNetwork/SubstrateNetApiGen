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


namespace SubstrateNetApi.Model.PalletSociety
{
    
    
    /// <summary>
    /// >> Path: pallet_society.Bid
    /// </summary>
    public sealed class Bid : BaseType
    {
        
        private SubstrateNetApi.Model.SpCore.AccountId32 _who;
        
        private SubstrateNetApi.Model.PalletSociety.EnumBidKind _kind;
        
        private SubstrateNetApi.Model.Types.Primitive.U128 _value;
        
        public SubstrateNetApi.Model.SpCore.AccountId32 Who
        {
            get
            {
                return this._who;
            }
            set
            {
                this._who = value;
            }
        }
        
        public SubstrateNetApi.Model.PalletSociety.EnumBidKind Kind
        {
            get
            {
                return this._kind;
            }
            set
            {
                this._kind = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U128 Value
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
            return "Bid";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Who.Encode());
            result.AddRange(Kind.Encode());
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Who = new SubstrateNetApi.Model.SpCore.AccountId32();
            Who.Decode(byteArray, ref p);
            Kind = new SubstrateNetApi.Model.PalletSociety.EnumBidKind();
            Kind.Decode(byteArray, ref p);
            Value = new SubstrateNetApi.Model.Types.Primitive.U128();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}