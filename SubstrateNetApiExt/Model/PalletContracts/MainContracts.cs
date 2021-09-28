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
using SubstrateNetApi.Model.PalletContracts;
using SubstrateNetApi.Model.PrimitiveTypes;
using SubstrateNetApi.Model.SpCore;
using SubstrateNetApi.Model.SpRuntime;
using SubstrateNetApi.Model.Types;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNetApi.Model.PalletContracts
{
    
    
    public sealed class ContractsStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateNetApi.SubstrateClient _client;
        
        public ContractsStorage(SubstrateNetApi.SubstrateClient client)
        {
            this._client = client;
        }
        
        public static string PristineCodeParams(SubstrateNetApi.Model.PrimitiveTypes.H256 key)
        {
            return RequestGenerator.GetStorage("Contracts", "PristineCode", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Identity}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> PristineCode
        ///  A mapping from an original code hash to the original code, untouched by instrumentation.
        /// </summary>
        public async Task<BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>> PristineCode(SubstrateNetApi.Model.PrimitiveTypes.H256 key, CancellationToken token)
        {
            string parameters = ContractsStorage.PristineCodeParams(key);
            return await _client.GetStorageAsync<BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>>(parameters, token);
        }
        
        public static string CodeStorageParams(SubstrateNetApi.Model.PrimitiveTypes.H256 key)
        {
            return RequestGenerator.GetStorage("Contracts", "CodeStorage", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Identity}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> CodeStorage
        ///  A mapping between an original code hash and instrumented wasm code, ready for execution.
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletContracts.PrefabWasmModule> CodeStorage(SubstrateNetApi.Model.PrimitiveTypes.H256 key, CancellationToken token)
        {
            string parameters = ContractsStorage.CodeStorageParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletContracts.PrefabWasmModule>(parameters, token);
        }
        
        public static string AccountCounterParams()
        {
            return RequestGenerator.GetStorage("Contracts", "AccountCounter", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> AccountCounter
        ///  The subtrie counter.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U64> AccountCounter(CancellationToken token)
        {
            string parameters = ContractsStorage.AccountCounterParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U64>(parameters, token);
        }
        
        public static string ContractInfoOfParams(SubstrateNetApi.Model.SpCore.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Contracts", "ContractInfoOf", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ContractInfoOf
        ///  The code associated with a given account.
        /// 
        ///  TWOX-NOTE: SAFE since `AccountId` is a secure hash.
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletContracts.RawContractInfo> ContractInfoOf(SubstrateNetApi.Model.SpCore.AccountId32 key, CancellationToken token)
        {
            string parameters = ContractsStorage.ContractInfoOfParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletContracts.RawContractInfo>(parameters, token);
        }
        
        public static string DeletionQueueParams()
        {
            return RequestGenerator.GetStorage("Contracts", "DeletionQueue", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> DeletionQueue
        ///  Evicted contracts that await child trie deletion.
        /// 
        ///  Child trie deletion is a heavy operation depending on the amount of storage items
        ///  stored in said trie. Therefore this operation is performed lazily in `on_initialize`.
        /// </summary>
        public async Task<BaseVec<SubstrateNetApi.Model.PalletContracts.DeletedContract>> DeletionQueue(CancellationToken token)
        {
            string parameters = ContractsStorage.DeletionQueueParams();
            return await _client.GetStorageAsync<BaseVec<SubstrateNetApi.Model.PalletContracts.DeletedContract>>(parameters, token);
        }
    }
    
    public sealed class ContractsCalls
    {
        
        /// <summary>
        /// >> call
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Call(SubstrateNetApi.Model.SpRuntime.EnumMultiAddress dest, BaseCom<SubstrateNetApi.Model.Types.Primitive.U128> value, BaseCom<SubstrateNetApi.Model.Types.Primitive.U64> gas_limit, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> data)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(data.Encode());
            return new Method(18, "Contracts", 0, "call", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> instantiate_with_code
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method InstantiateWithCode(BaseCom<SubstrateNetApi.Model.Types.Primitive.U128> endowment, BaseCom<SubstrateNetApi.Model.Types.Primitive.U64> gas_limit, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> code, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> data, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> salt)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(endowment.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(code.Encode());
            byteArray.AddRange(data.Encode());
            byteArray.AddRange(salt.Encode());
            return new Method(18, "Contracts", 1, "instantiate_with_code", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> instantiate
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Instantiate(BaseCom<SubstrateNetApi.Model.Types.Primitive.U128> endowment, BaseCom<SubstrateNetApi.Model.Types.Primitive.U64> gas_limit, SubstrateNetApi.Model.PrimitiveTypes.H256 code_hash, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> data, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> salt)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(endowment.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(code_hash.Encode());
            byteArray.AddRange(data.Encode());
            byteArray.AddRange(salt.Encode());
            return new Method(18, "Contracts", 2, "instantiate", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> Instantiated
    /// Contract deployed by address at the specified address. \[deployer, contract\]
    /// </summary>
    public sealed class EventInstantiated : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> Terminated
    /// Contract has been removed.
    /// \[contract, beneficiary\]
    /// 
    /// # Params
    /// 
    /// - `contract`: The contract that was terminated.
    /// - `beneficiary`: The account that received the contracts remaining balance.
    /// 
    /// # Note
    /// 
    /// The only way for a contract to be removed and emitting this event is by calling
    /// `seal_terminate`.
    /// </summary>
    public sealed class EventTerminated : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> CodeStored
    /// Code with the specified hash has been stored. \[code_hash\]
    /// </summary>
    public sealed class EventCodeStored : BaseTuple<SubstrateNetApi.Model.PrimitiveTypes.H256>
    {
    }
    
    /// <summary>
    /// >> ScheduleUpdated
    /// Triggered when the current schedule is updated.
    /// \[version\]
    /// 
    /// # Params
    /// 
    /// - `version`: The version of the newly set schedule.
    /// </summary>
    public sealed class EventScheduleUpdated : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    /// <summary>
    /// >> ContractEmitted
    /// A custom event emitted by the contract.
    /// \[contract, data\]
    /// 
    /// # Params
    /// 
    /// - `contract`: The contract that emitted the event.
    /// - `data`: Data supplied by the contract. Metadata generated during contract compilation
    ///   is needed to decode it.
    /// </summary>
    public sealed class EventContractEmitted : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>>
    {
    }
    
    /// <summary>
    /// >> CodeRemoved
    /// A code with the specified hash was removed.
    /// \[code_hash\]
    /// 
    /// This happens when the last contract that uses this code hash was removed.
    /// </summary>
    public sealed class EventCodeRemoved : BaseTuple<SubstrateNetApi.Model.PrimitiveTypes.H256>
    {
    }
    
    public enum ContractsErrors
    {
        
        /// <summary>
        /// >> InvalidScheduleVersion
        /// A new schedule must have a greater version than the current one.
        /// </summary>
        InvalidScheduleVersion,
        
        /// <summary>
        /// >> OutOfGas
        /// The executed contract exhausted its gas limit.
        /// </summary>
        OutOfGas,
        
        /// <summary>
        /// >> OutputBufferTooSmall
        /// The output buffer supplied to a contract API call was too small.
        /// </summary>
        OutputBufferTooSmall,
        
        /// <summary>
        /// >> BelowSubsistenceThreshold
        /// Performing the requested transfer would have brought the contract below
        /// the subsistence threshold. No transfer is allowed to do this. Use `seal_terminate`
        /// to recover a deposit.
        /// </summary>
        BelowSubsistenceThreshold,
        
        /// <summary>
        /// >> NewContractNotFunded
        /// The newly created contract is below the subsistence threshold after executing
        /// its contructor. No contracts are allowed to exist below that threshold.
        /// </summary>
        NewContractNotFunded,
        
        /// <summary>
        /// >> TransferFailed
        /// Performing the requested transfer failed for a reason originating in the
        /// chosen currency implementation of the runtime. Most probably the balance is
        /// too low or locks are placed on it.
        /// </summary>
        TransferFailed,
        
        /// <summary>
        /// >> MaxCallDepthReached
        /// Performing a call was denied because the calling depth reached the limit
        /// of what is specified in the schedule.
        /// </summary>
        MaxCallDepthReached,
        
        /// <summary>
        /// >> ContractNotFound
        /// No contract was found at the specified address.
        /// </summary>
        ContractNotFound,
        
        /// <summary>
        /// >> CodeTooLarge
        /// The code supplied to `instantiate_with_code` exceeds the limit specified in the
        /// current schedule.
        /// </summary>
        CodeTooLarge,
        
        /// <summary>
        /// >> CodeNotFound
        /// No code could be found at the supplied code hash.
        /// </summary>
        CodeNotFound,
        
        /// <summary>
        /// >> OutOfBounds
        /// A buffer outside of sandbox memory was passed to a contract API function.
        /// </summary>
        OutOfBounds,
        
        /// <summary>
        /// >> DecodingFailed
        /// Input passed to a contract API function failed to decode as expected type.
        /// </summary>
        DecodingFailed,
        
        /// <summary>
        /// >> ContractTrapped
        /// Contract trapped during execution.
        /// </summary>
        ContractTrapped,
        
        /// <summary>
        /// >> ValueTooLarge
        /// The size defined in `T::MaxValueSize` was exceeded.
        /// </summary>
        ValueTooLarge,
        
        /// <summary>
        /// >> TerminatedWhileReentrant
        /// Termination of a contract is not allowed while the contract is already
        /// on the call stack. Can be triggered by `seal_terminate`.
        /// </summary>
        TerminatedWhileReentrant,
        
        /// <summary>
        /// >> InputForwarded
        /// `seal_call` forwarded this contracts input. It therefore is no longer available.
        /// </summary>
        InputForwarded,
        
        /// <summary>
        /// >> RandomSubjectTooLong
        /// The subject passed to `seal_random` exceeds the limit.
        /// </summary>
        RandomSubjectTooLong,
        
        /// <summary>
        /// >> TooManyTopics
        /// The amount of topics passed to `seal_deposit_events` exceeds the limit.
        /// </summary>
        TooManyTopics,
        
        /// <summary>
        /// >> DuplicateTopics
        /// The topics passed to `seal_deposit_events` contains at least one duplicate.
        /// </summary>
        DuplicateTopics,
        
        /// <summary>
        /// >> NoChainExtension
        /// The chain does not provide a chain extension. Calling the chain extension results
        /// in this error. Note that this usually  shouldn't happen as deploying such contracts
        /// is rejected.
        /// </summary>
        NoChainExtension,
        
        /// <summary>
        /// >> DeletionQueueFull
        /// Removal of a contract failed because the deletion queue is full.
        /// 
        /// This can happen when calling `seal_terminate`.
        /// The queue is filled by deleting contracts and emptied by a fixed amount each block.
        /// Trying again during another block is the only way to resolve this issue.
        /// </summary>
        DeletionQueueFull,
        
        /// <summary>
        /// >> StorageExhausted
        /// A storage modification exhausted the 32bit type that holds the storage size.
        /// 
        /// This can either happen when the accumulated storage in bytes is too large or
        /// when number of storage items is too large.
        /// </summary>
        StorageExhausted,
        
        /// <summary>
        /// >> DuplicateContract
        /// A contract with the same AccountId already exists.
        /// </summary>
        DuplicateContract,
        
        /// <summary>
        /// >> TerminatedInConstructor
        /// A contract self destructed in its constructor.
        /// 
        /// This can be triggered by a call to `seal_terminate`.
        /// </summary>
        TerminatedInConstructor,
        
        /// <summary>
        /// >> DebugMessageInvalidUTF8
        /// The debug message specified to `seal_debug_message` does contain invalid UTF-8.
        /// </summary>
        DebugMessageInvalidUTF8,
        
        /// <summary>
        /// >> ReentranceDenied
        /// A call tried to invoke a contract that is flagged as non-reentrant.
        /// </summary>
        ReentranceDenied,
    }
}
