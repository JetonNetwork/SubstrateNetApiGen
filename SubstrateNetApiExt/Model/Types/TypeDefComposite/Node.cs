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
    
    
    public sealed class Node : BaseType
    {
        
        private AccountId32 _id;
        
        private BaseOpt<AccountId32> _prev;
        
        private BaseOpt<AccountId32> _next;
        
        private U64 _bagUpper;
        
        public AccountId32 Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        public BaseOpt<AccountId32> Prev
        {
            get
            {
                return this._prev;
            }
            set
            {
                this._prev = value;
            }
        }
        
        public BaseOpt<AccountId32> Next
        {
            get
            {
                return this._next;
            }
            set
            {
                this._next = value;
            }
        }
        
        public U64 BagUpper
        {
            get
            {
                return this._bagUpper;
            }
            set
            {
                this._bagUpper = value;
            }
        }
        
        public override string TypeName()
        {
            return "Node";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Id.Encode());
            result.AddRange(Prev.Encode());
            result.AddRange(Next.Encode());
            result.AddRange(BagUpper.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Id = new AccountId32();
            Id.Decode(byteArray, ref p);
            Prev = new BaseOpt<AccountId32>();
            Prev.Decode(byteArray, ref p);
            Next = new BaseOpt<AccountId32>();
            Next.Decode(byteArray, ref p);
            BagUpper = new U64();
            BagUpper.Decode(byteArray, ref p);
            _typeSize = p - start;
        }
    }
}
