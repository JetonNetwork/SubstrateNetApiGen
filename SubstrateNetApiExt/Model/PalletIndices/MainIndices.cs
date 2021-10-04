//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Extrinsics;
using SubstrateNetApi.Model.Meta;
using SubstrateNetApi.Model.SpCore;
using SubstrateNetApi.Model.Types;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNetApi.Model.PalletIndices
{
    
    
    public sealed class IndicesStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public IndicesStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Indices", "Accounts"), new System.Tuple<Storage.Hasher[],Type>(new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                            SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(SubstrateNetApi.Model.Types.Primitive.U32)));
        }
        
        /// <summary>
        /// >> AccountsParams
        ///  The lookup from index to account.
        /// </summary>
        public static string AccountsParams(SubstrateNetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("Indices", "Accounts", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Accounts
        ///  The lookup from index to account.
        /// </summary>
        public async Task<BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.Types.Primitive.U128,SubstrateNetApi.Model.Types.Primitive.Bool>> Accounts(SubstrateNetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = IndicesStorage.AccountsParams(key);
            return await _client.GetStorageAsync<BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.Types.Primitive.U128,SubstrateNetApi.Model.Types.Primitive.Bool>>(parameters, token);
        }
    }
    
    public sealed class IndicesCalls
    {
        
        /// <summary>
        /// >> claim
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Claim(SubstrateNetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            return new Method(5, "Indices", 0, "claim", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Transfer(SubstrateNetApi.Model.SpCore.AccountId32 @new, SubstrateNetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            byteArray.AddRange(index.Encode());
            return new Method(5, "Indices", 1, "transfer", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> free
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Free(SubstrateNetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            return new Method(5, "Indices", 2, "free", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_transfer
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceTransfer(SubstrateNetApi.Model.SpCore.AccountId32 @new, SubstrateNetApi.Model.Types.Primitive.U32 index, SubstrateNetApi.Model.Types.Primitive.Bool freeze)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            byteArray.AddRange(index.Encode());
            byteArray.AddRange(freeze.Encode());
            return new Method(5, "Indices", 3, "force_transfer", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> freeze
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Freeze(SubstrateNetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            return new Method(5, "Indices", 4, "freeze", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> IndexAssigned
    /// A account index was assigned. \[index, who\]
    /// </summary>
    public sealed class EventIndexAssigned : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    /// <summary>
    /// >> IndexFreed
    /// A account index has been freed up (unassigned). \[index\]
    /// </summary>
    public sealed class EventIndexFreed : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    /// <summary>
    /// >> IndexFrozen
    /// A account index has been frozen to its current account ID. \[index, who\]
    /// </summary>
    public sealed class EventIndexFrozen : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    public enum IndicesErrors
    {
        
        /// <summary>
        /// >> NotAssigned
        /// The index was not already assigned.
        /// </summary>
        NotAssigned,
        
        /// <summary>
        /// >> NotOwner
        /// The index is assigned to another account.
        /// </summary>
        NotOwner,
        
        /// <summary>
        /// >> InUse
        /// The index was not available.
        /// </summary>
        InUse,
        
        /// <summary>
        /// >> NotTransfer
        /// The source and destination accounts are identical.
        /// </summary>
        NotTransfer,
        
        /// <summary>
        /// >> Permanent
        /// The index is permanent and may not be freed/changed.
        /// </summary>
        Permanent,
    }
}
