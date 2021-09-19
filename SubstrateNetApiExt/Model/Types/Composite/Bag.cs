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
    /// >> Path: pallet_bags_list.list.Bag
    /// </summary>
    public sealed class Bag : BaseType
    {
        
        private BaseOpt<AccountId32> _head;
        
        private BaseOpt<AccountId32> _tail;
        
        public BaseOpt<AccountId32> Head
        {
            get
            {
                return this._head;
            }
            set
            {
                this._head = value;
            }
        }
        
        public BaseOpt<AccountId32> Tail
        {
            get
            {
                return this._tail;
            }
            set
            {
                this._tail = value;
            }
        }
        
        public override string TypeName()
        {
            return "Bag";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Head.Encode());
            result.AddRange(Tail.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Head = new BaseOpt<AccountId32>();
            Head.Decode(byteArray, ref p);
            Tail = new BaseOpt<AccountId32>();
            Tail.Decode(byteArray, ref p);
            _typeSize = p - start;
        }
    }
}
