//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Composite;
using SubstrateNetApi.Model.Types.Enum;
using SubstrateNetApi.Model.Types.Primitive;
using SubstrateNetApi.Model.Types.Sequence;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.Types.Composite
{
    
    
    /// <summary>
    /// >> Path: pallet_recovery.RecoveryConfig
    /// </summary>
    public sealed class RecoveryConfig : BaseType
    {
        
        private U32 _delayPeriod;
        
        private U128 _deposit;
        
        private BaseVec<AccountId32> _friends;
        
        private U16 _threshold;
        
        public U32 DelayPeriod
        {
            get
            {
                return this._delayPeriod;
            }
            set
            {
                this._delayPeriod = value;
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
        
        public BaseVec<AccountId32> Friends
        {
            get
            {
                return this._friends;
            }
            set
            {
                this._friends = value;
            }
        }
        
        public U16 Threshold
        {
            get
            {
                return this._threshold;
            }
            set
            {
                this._threshold = value;
            }
        }
        
        public override string TypeName()
        {
            return "RecoveryConfig";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(DelayPeriod.Encode());
            result.AddRange(Deposit.Encode());
            result.AddRange(Friends.Encode());
            result.AddRange(Threshold.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            DelayPeriod = new U32();
            DelayPeriod.Decode(byteArray, ref p);
            Deposit = new U128();
            Deposit.Decode(byteArray, ref p);
            Friends = new BaseVec<AccountId32>();
            Friends.Decode(byteArray, ref p);
            Threshold = new U16();
            Threshold.Decode(byteArray, ref p);
            _typeSize = p - start;
        }
    }
}
