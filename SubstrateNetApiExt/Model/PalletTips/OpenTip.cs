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


namespace SubstrateNetApi.Model.PalletTips
{
    
    
    /// <summary>
    /// >> Path: pallet_tips.OpenTip
    /// </summary>
    public sealed class OpenTip : BaseType
    {
        
        private SubstrateNetApi.Model.PrimitiveTypes.H256 _reason;
        
        private SubstrateNetApi.Model.SpCore.AccountId32 _who;
        
        private SubstrateNetApi.Model.SpCore.AccountId32 _finder;
        
        private SubstrateNetApi.Model.Types.Primitive.U128 _deposit;
        
        private BaseOpt<SubstrateNetApi.Model.Types.Primitive.U32> _closes;
        
        private BaseVec<BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.Types.Primitive.U128>> _tips;
        
        private SubstrateNetApi.Model.Types.Primitive.Bool _findersFee;
        
        public SubstrateNetApi.Model.PrimitiveTypes.H256 Reason
        {
            get
            {
                return this._reason;
            }
            set
            {
                this._reason = value;
            }
        }
        
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
        
        public SubstrateNetApi.Model.SpCore.AccountId32 Finder
        {
            get
            {
                return this._finder;
            }
            set
            {
                this._finder = value;
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
        
        public BaseOpt<SubstrateNetApi.Model.Types.Primitive.U32> Closes
        {
            get
            {
                return this._closes;
            }
            set
            {
                this._closes = value;
            }
        }
        
        public BaseVec<BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.Types.Primitive.U128>> Tips
        {
            get
            {
                return this._tips;
            }
            set
            {
                this._tips = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.Bool FindersFee
        {
            get
            {
                return this._findersFee;
            }
            set
            {
                this._findersFee = value;
            }
        }
        
        public override string TypeName()
        {
            return "OpenTip";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Reason.Encode());
            result.AddRange(Who.Encode());
            result.AddRange(Finder.Encode());
            result.AddRange(Deposit.Encode());
            result.AddRange(Closes.Encode());
            result.AddRange(Tips.Encode());
            result.AddRange(FindersFee.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Reason = new SubstrateNetApi.Model.PrimitiveTypes.H256();
            Reason.Decode(byteArray, ref p);
            Who = new SubstrateNetApi.Model.SpCore.AccountId32();
            Who.Decode(byteArray, ref p);
            Finder = new SubstrateNetApi.Model.SpCore.AccountId32();
            Finder.Decode(byteArray, ref p);
            Deposit = new SubstrateNetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            Closes = new BaseOpt<SubstrateNetApi.Model.Types.Primitive.U32>();
            Closes.Decode(byteArray, ref p);
            Tips = new BaseVec<BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.Types.Primitive.U128>>();
            Tips.Decode(byteArray, ref p);
            FindersFee = new SubstrateNetApi.Model.Types.Primitive.Bool();
            FindersFee.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}