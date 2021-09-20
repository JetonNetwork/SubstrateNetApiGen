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


namespace SubstrateNetApi.Model.SpTransactionStorageProof
{
    
    
    /// <summary>
    /// >> Path: sp_transaction_storage_proof.TransactionStorageProof
    /// </summary>
    public sealed class TransactionStorageProof : BaseType
    {
        
        private BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> _chunk;
        
        private BaseVec<BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>> _proof;
        
        public BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> Chunk
        {
            get
            {
                return this._chunk;
            }
            set
            {
                this._chunk = value;
            }
        }
        
        public BaseVec<BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>> Proof
        {
            get
            {
                return this._proof;
            }
            set
            {
                this._proof = value;
            }
        }
        
        public override string TypeName()
        {
            return "TransactionStorageProof";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Chunk.Encode());
            result.AddRange(Proof.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Chunk = new BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>();
            Chunk.Decode(byteArray, ref p);
            Proof = new BaseVec<BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>>();
            Proof.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}