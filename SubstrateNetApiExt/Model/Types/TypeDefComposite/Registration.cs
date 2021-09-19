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
    
    
    public sealed class Registration : BaseType
    {
        
        private BoundedVec _judgements;
        
        private U128 _deposit;
        
        private IdentityInfo _info;
        
        public BoundedVec Judgements
        {
            get
            {
                return this._judgements;
            }
            set
            {
                this._judgements = value;
            }
        }
        
        public U128 Deposit
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
        
        public IdentityInfo Info
        {
            get
            {
                return this._info;
            }
            set
            {
                this._info = value;
            }
        }
        
        public override string TypeName()
        {
            return "Registration";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Judgements.Encode());
            result.AddRange(Deposit.Encode());
            result.AddRange(Info.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Judgements = new BoundedVec();
            Judgements.Decode(byteArray, ref p);
            Deposit = new U128();
            Deposit.Decode(byteArray, ref p);
            Info = new IdentityInfo();
            Info.Decode(byteArray, ref p);
            _typeSize = p - start;
        }
    }
}