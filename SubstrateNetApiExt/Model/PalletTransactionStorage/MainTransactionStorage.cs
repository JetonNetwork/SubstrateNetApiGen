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
using SubstrateNetApi.Model.PalletTransactionStorage;
using SubstrateNetApi.Model.SpTransactionStorageProof;
using SubstrateNetApi.Model.Types;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNetApi.Model.PalletTransactionStorage
{
    
    
    public sealed class TransactionStorageStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateNetApi.SubstrateClient _client;
        
        public TransactionStorageStorage(SubstrateNetApi.SubstrateClient client)
        {
            this._client = client;
        }
        
        /// <summary>
        /// >> TransactionsParams
        ///  Collection of transaction metadata by block number.
        /// </summary>
        public static string TransactionsParams(SubstrateNetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("TransactionStorage", "Transactions", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Transactions
        ///  Collection of transaction metadata by block number.
        /// </summary>
        public async Task<BaseVec<SubstrateNetApi.Model.PalletTransactionStorage.TransactionInfo>> Transactions(SubstrateNetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = TransactionStorageStorage.TransactionsParams(key);
            return await _client.GetStorageAsync<BaseVec<SubstrateNetApi.Model.PalletTransactionStorage.TransactionInfo>>(parameters, token);
        }
        
        /// <summary>
        /// >> ChunkCountParams
        ///  Count indexed chunks for each block.
        /// </summary>
        public static string ChunkCountParams(SubstrateNetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("TransactionStorage", "ChunkCount", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ChunkCount
        ///  Count indexed chunks for each block.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U32> ChunkCount(SubstrateNetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = TransactionStorageStorage.ChunkCountParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> ByteFeeParams
        ///  Storage fee per byte.
        /// </summary>
        public static string ByteFeeParams()
        {
            return RequestGenerator.GetStorage("TransactionStorage", "ByteFee", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ByteFee
        ///  Storage fee per byte.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U128> ByteFee(CancellationToken token)
        {
            string parameters = TransactionStorageStorage.ByteFeeParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U128>(parameters, token);
        }
        
        /// <summary>
        /// >> EntryFeeParams
        ///  Storage fee per transaction.
        /// </summary>
        public static string EntryFeeParams()
        {
            return RequestGenerator.GetStorage("TransactionStorage", "EntryFee", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> EntryFee
        ///  Storage fee per transaction.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U128> EntryFee(CancellationToken token)
        {
            string parameters = TransactionStorageStorage.EntryFeeParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U128>(parameters, token);
        }
        
        /// <summary>
        /// >> MaxTransactionSizeParams
        ///  Maximum data set in a single transaction in bytes.
        /// </summary>
        public static string MaxTransactionSizeParams()
        {
            return RequestGenerator.GetStorage("TransactionStorage", "MaxTransactionSize", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> MaxTransactionSize
        ///  Maximum data set in a single transaction in bytes.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U32> MaxTransactionSize(CancellationToken token)
        {
            string parameters = TransactionStorageStorage.MaxTransactionSizeParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> MaxBlockTransactionsParams
        ///  Maximum number of indexed transactions in the block.
        /// </summary>
        public static string MaxBlockTransactionsParams()
        {
            return RequestGenerator.GetStorage("TransactionStorage", "MaxBlockTransactions", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> MaxBlockTransactions
        ///  Maximum number of indexed transactions in the block.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U32> MaxBlockTransactions(CancellationToken token)
        {
            string parameters = TransactionStorageStorage.MaxBlockTransactionsParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> StoragePeriodParams
        ///  Storage period for data in blocks. Should match `sp_storage_proof::DEFAULT_STORAGE_PERIOD`
        ///  for block authoring.
        /// </summary>
        public static string StoragePeriodParams()
        {
            return RequestGenerator.GetStorage("TransactionStorage", "StoragePeriod", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> StoragePeriod
        ///  Storage period for data in blocks. Should match `sp_storage_proof::DEFAULT_STORAGE_PERIOD`
        ///  for block authoring.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U32> StoragePeriod(CancellationToken token)
        {
            string parameters = TransactionStorageStorage.StoragePeriodParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> BlockTransactionsParams
        /// </summary>
        public static string BlockTransactionsParams()
        {
            return RequestGenerator.GetStorage("TransactionStorage", "BlockTransactions", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> BlockTransactions
        /// </summary>
        public async Task<BaseVec<SubstrateNetApi.Model.PalletTransactionStorage.TransactionInfo>> BlockTransactions(CancellationToken token)
        {
            string parameters = TransactionStorageStorage.BlockTransactionsParams();
            return await _client.GetStorageAsync<BaseVec<SubstrateNetApi.Model.PalletTransactionStorage.TransactionInfo>>(parameters, token);
        }
        
        /// <summary>
        /// >> ProofCheckedParams
        ///  Was the proof checked in this block?
        /// </summary>
        public static string ProofCheckedParams()
        {
            return RequestGenerator.GetStorage("TransactionStorage", "ProofChecked", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ProofChecked
        ///  Was the proof checked in this block?
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.Bool> ProofChecked(CancellationToken token)
        {
            string parameters = TransactionStorageStorage.ProofCheckedParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.Bool>(parameters, token);
        }
    }
    
    public sealed class TransactionStorageCalls
    {
        
        /// <summary>
        /// >> store
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Store(BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> data)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(data.Encode());
            return new Method(39, "TransactionStorage", 0, "store", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> renew
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Renew(SubstrateNetApi.Model.Types.Primitive.U32 block, SubstrateNetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(block.Encode());
            byteArray.AddRange(index.Encode());
            return new Method(39, "TransactionStorage", 1, "renew", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> check_proof
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method CheckProof(SubstrateNetApi.Model.SpTransactionStorageProof.TransactionStorageProof proof)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proof.Encode());
            return new Method(39, "TransactionStorage", 2, "check_proof", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> Stored
    /// Stored data under specified index.
    /// </summary>
    public sealed class EventStored : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    /// <summary>
    /// >> Renewed
    /// Renewed data under specified index.
    /// </summary>
    public sealed class EventRenewed : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    /// <summary>
    /// >> ProofChecked
    /// Storage proof was successfully checked.
    /// </summary>
    public sealed class EventProofChecked : BaseTuple
    {
    }
    
    public enum TransactionStorageErrors
    {
        
        /// <summary>
        /// >> InsufficientFunds
        /// Insufficient account balance.
        /// </summary>
        InsufficientFunds,
        
        /// <summary>
        /// >> NotConfigured
        /// Invalid configuration.
        /// </summary>
        NotConfigured,
        
        /// <summary>
        /// >> RenewedNotFound
        /// Renewed extrinsic is not found.
        /// </summary>
        RenewedNotFound,
        
        /// <summary>
        /// >> EmptyTransaction
        /// Attempting to store empty transaction
        /// </summary>
        EmptyTransaction,
        
        /// <summary>
        /// >> UnexpectedProof
        /// Proof was not expected in this block.
        /// </summary>
        UnexpectedProof,
        
        /// <summary>
        /// >> InvalidProof
        /// Proof failed verification.
        /// </summary>
        InvalidProof,
        
        /// <summary>
        /// >> MissingProof
        /// Missing storage proof.
        /// </summary>
        MissingProof,
        
        /// <summary>
        /// >> MissingStateData
        /// Unable to verify proof becasue state data is missing.
        /// </summary>
        MissingStateData,
        
        /// <summary>
        /// >> DoubleCheck
        /// Double proof check in the block.
        /// </summary>
        DoubleCheck,
        
        /// <summary>
        /// >> ProofNotChecked
        /// Storage proof was not checked in the block.
        /// </summary>
        ProofNotChecked,
        
        /// <summary>
        /// >> TransactionTooLarge
        /// Transaction is too large.
        /// </summary>
        TransactionTooLarge,
        
        /// <summary>
        /// >> TooManyTransactions
        /// Too many transactions in the block.
        /// </summary>
        TooManyTransactions,
        
        /// <summary>
        /// >> BadContext
        /// Attempted to call `store` outside of block execution.
        /// </summary>
        BadContext,
    }
}
