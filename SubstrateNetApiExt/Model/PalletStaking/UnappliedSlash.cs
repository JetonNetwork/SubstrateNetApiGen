//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.SpCore;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletStaking
{
    
    
    /// <summary>
    /// >> 356 - Composite[pallet_staking.UnappliedSlash]
    /// </summary>
    public sealed class UnappliedSlash : BaseType
    {
        
        /// <summary>
        /// >> validator
        /// </summary>
        private SubstrateNetApi.Model.SpCore.AccountId32 _validator;
        
        /// <summary>
        /// >> own
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U128 _own;
        
        /// <summary>
        /// >> others
        /// </summary>
        private BaseVec<BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.Types.Primitive.U128>> _others;
        
        /// <summary>
        /// >> reporters
        /// </summary>
        private BaseVec<SubstrateNetApi.Model.SpCore.AccountId32> _reporters;
        
        /// <summary>
        /// >> payout
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U128 _payout;
        
        public SubstrateNetApi.Model.SpCore.AccountId32 Validator
        {
            get
            {
                return this._validator;
            }
            set
            {
                this._validator = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U128 Own
        {
            get
            {
                return this._own;
            }
            set
            {
                this._own = value;
            }
        }
        
        public BaseVec<BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.Types.Primitive.U128>> Others
        {
            get
            {
                return this._others;
            }
            set
            {
                this._others = value;
            }
        }
        
        public BaseVec<SubstrateNetApi.Model.SpCore.AccountId32> Reporters
        {
            get
            {
                return this._reporters;
            }
            set
            {
                this._reporters = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U128 Payout
        {
            get
            {
                return this._payout;
            }
            set
            {
                this._payout = value;
            }
        }
        
        public override string TypeName()
        {
            return "UnappliedSlash";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Validator.Encode());
            result.AddRange(Own.Encode());
            result.AddRange(Others.Encode());
            result.AddRange(Reporters.Encode());
            result.AddRange(Payout.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Validator = new SubstrateNetApi.Model.SpCore.AccountId32();
            Validator.Decode(byteArray, ref p);
            Own = new SubstrateNetApi.Model.Types.Primitive.U128();
            Own.Decode(byteArray, ref p);
            Others = new BaseVec<BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.Types.Primitive.U128>>();
            Others.Decode(byteArray, ref p);
            Reporters = new BaseVec<SubstrateNetApi.Model.SpCore.AccountId32>();
            Reporters.Decode(byteArray, ref p);
            Payout = new SubstrateNetApi.Model.Types.Primitive.U128();
            Payout.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
