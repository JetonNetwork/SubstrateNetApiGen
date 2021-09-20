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


namespace SubstrateNetApi.Model.PalletElectionsPhragmen
{
    
    
    /// <summary>
    /// >> Path: pallet_elections_phragmen.SeatHolder
    /// </summary>
    public sealed class SeatHolder : BaseType
    {
        
        private SubstrateNetApi.Model.SpCore.AccountId32 _who;
        
        private SubstrateNetApi.Model.Types.Primitive.U128 _stake;
        
        private SubstrateNetApi.Model.Types.Primitive.U128 _deposit;
        
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
        
        public SubstrateNetApi.Model.Types.Primitive.U128 Stake
        {
            get
            {
                return this._stake;
            }
            set
            {
                this._stake = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U128 Deposit
        {
            get
            {
                return this._deposit;
            }
            set
            {
                this._deposit = value;
            }
        }
        
        public override string TypeName()
        {
            return "SeatHolder";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Who.Encode());
            result.AddRange(Stake.Encode());
            result.AddRange(Deposit.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Who = new SubstrateNetApi.Model.SpCore.AccountId32();
            Who.Decode(byteArray, ref p);
            Stake = new SubstrateNetApi.Model.Types.Primitive.U128();
            Stake.Decode(byteArray, ref p);
            Deposit = new SubstrateNetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
