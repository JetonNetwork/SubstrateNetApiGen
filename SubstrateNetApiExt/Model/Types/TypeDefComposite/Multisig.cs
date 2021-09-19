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
    
    
    public sealed class Multisig : BaseType
    {
        
        private Timepoint _when;
        
        private U128 _deposit;
        
        private AccountId32 _depositor;
        
        private BaseVec<AccountId32> _approvals;
        
        public Timepoint When
        {
            get
            {
                return this._when;
            }
            set
            {
                this._when = value;
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
        
        public AccountId32 Depositor
        {
            get
            {
                return this._depositor;
            }
            set
            {
                this._depositor = value;
            }
        }
        
        public BaseVec<AccountId32> Approvals
        {
            get
            {
                return this._approvals;
            }
            set
            {
                this._approvals = value;
            }
        }
        
        public override string TypeName()
        {
            return "Multisig";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(When.Encode());
            result.AddRange(Deposit.Encode());
            result.AddRange(Depositor.Encode());
            result.AddRange(Approvals.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            When = new Timepoint();
            When.Decode(byteArray, ref p);
            Deposit = new U128();
            Deposit.Decode(byteArray, ref p);
            Depositor = new AccountId32();
            Depositor.Decode(byteArray, ref p);
            Approvals = new BaseVec<AccountId32>();
            Approvals.Decode(byteArray, ref p);
            _typeSize = p - start;
        }
    }
}
