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
    /// >> Path: pallet_contracts.storage.RawContractInfo
    /// </summary>
    public sealed class RawContractInfo : BaseType
    {
        
        private BaseVec<U8> _trieId;
        
        private H256 _codeHash;
        
        private BaseOpt<BaseTuple> _reserved;
        
        public BaseVec<U8> TrieId
        {
            get
            {
                return this._trieId;
            }
            set
            {
                this._trieId = value;
            }
        }
        
        public H256 CodeHash
        {
            get
            {
                return this._codeHash;
            }
            set
            {
                this._codeHash = value;
            }
        }
        
        public BaseOpt<BaseTuple> Reserved
        {
            get
            {
                return this._reserved;
            }
            set
            {
                this._reserved = value;
            }
        }
        
        public override string TypeName()
        {
            return "RawContractInfo";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(TrieId.Encode());
            result.AddRange(CodeHash.Encode());
            result.AddRange(Reserved.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            TrieId = new BaseVec<U8>();
            TrieId.Decode(byteArray, ref p);
            CodeHash = new H256();
            CodeHash.Decode(byteArray, ref p);
            Reserved = new BaseOpt<BaseTuple>();
            Reserved.Decode(byteArray, ref p);
            _typeSize = p - start;
        }
    }
}