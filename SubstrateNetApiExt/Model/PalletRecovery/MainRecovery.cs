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
using SubstrateNetApi.Model.NodeRuntime;
using SubstrateNetApi.Model.PalletRecovery;
using SubstrateNetApi.Model.SpCore;
using SubstrateNetApi.Model.Types;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNetApi.Model.PalletRecovery
{
    
    
    public sealed class RecoveryStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateNetApi.SubstrateClient _client;
        
        public RecoveryStorage(SubstrateNetApi.SubstrateClient client)
        {
            this._client = client;
        }
        
        public static string RecoverableParams(SubstrateNetApi.Model.SpCore.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Recovery", "Recoverable", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Recoverable
        ///  The set of recoverable accounts and their recovery configuration.
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletRecovery.RecoveryConfig> Recoverable(SubstrateNetApi.Model.SpCore.AccountId32 key, CancellationToken token)
        {
            string parameters = RecoveryStorage.RecoverableParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletRecovery.RecoveryConfig>(parameters, token);
        }
        
        public static string ActiveRecoveriesParams(BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.SpCore.AccountId32> key)
        {
            return RequestGenerator.GetStorage("Recovery", "ActiveRecoveries", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ActiveRecoveries
        ///  Active recovery attempts.
        /// 
        ///  First account is the account to be recovered, and the second account
        ///  is the user trying to recover the account.
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletRecovery.ActiveRecovery> ActiveRecoveries(BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.SpCore.AccountId32> key, CancellationToken token)
        {
            string parameters = RecoveryStorage.ActiveRecoveriesParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletRecovery.ActiveRecovery>(parameters, token);
        }
        
        public static string ProxyParams(SubstrateNetApi.Model.SpCore.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Recovery", "Proxy", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Proxy
        ///  The list of allowed proxy accounts.
        /// 
        ///  Map from the user who can access it to the recovered account.
        /// </summary>
        public async Task<SubstrateNetApi.Model.SpCore.AccountId32> Proxy(SubstrateNetApi.Model.SpCore.AccountId32 key, CancellationToken token)
        {
            string parameters = RecoveryStorage.ProxyParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.SpCore.AccountId32>(parameters, token);
        }
    }
    
    public sealed class RecoveryCalls
    {
        
        /// <summary>
        /// >> as_recovered
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method AsRecovered(SubstrateNetApi.Model.SpCore.AccountId32 account, SubstrateNetApi.Model.NodeRuntime.EnumNodeCall call)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(account.Encode());
            byteArray.AddRange(call.Encode());
            return new Method(27, "Recovery", 0, "as_recovered", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_recovered
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetRecovered(SubstrateNetApi.Model.SpCore.AccountId32 lost, SubstrateNetApi.Model.SpCore.AccountId32 rescuer)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(lost.Encode());
            byteArray.AddRange(rescuer.Encode());
            return new Method(27, "Recovery", 1, "set_recovered", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> create_recovery
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method CreateRecovery(BaseVec<SubstrateNetApi.Model.SpCore.AccountId32> friends, SubstrateNetApi.Model.Types.Primitive.U16 threshold, SubstrateNetApi.Model.Types.Primitive.U32 delay_period)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(friends.Encode());
            byteArray.AddRange(threshold.Encode());
            byteArray.AddRange(delay_period.Encode());
            return new Method(27, "Recovery", 2, "create_recovery", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> initiate_recovery
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method InitiateRecovery(SubstrateNetApi.Model.SpCore.AccountId32 account)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(account.Encode());
            return new Method(27, "Recovery", 3, "initiate_recovery", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> vouch_recovery
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method VouchRecovery(SubstrateNetApi.Model.SpCore.AccountId32 lost, SubstrateNetApi.Model.SpCore.AccountId32 rescuer)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(lost.Encode());
            byteArray.AddRange(rescuer.Encode());
            return new Method(27, "Recovery", 4, "vouch_recovery", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> claim_recovery
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ClaimRecovery(SubstrateNetApi.Model.SpCore.AccountId32 account)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(account.Encode());
            return new Method(27, "Recovery", 5, "claim_recovery", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> close_recovery
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method CloseRecovery(SubstrateNetApi.Model.SpCore.AccountId32 rescuer)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(rescuer.Encode());
            return new Method(27, "Recovery", 6, "close_recovery", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_recovery
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveRecovery()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(27, "Recovery", 7, "remove_recovery", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> cancel_recovered
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method CancelRecovered(SubstrateNetApi.Model.SpCore.AccountId32 account)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(account.Encode());
            return new Method(27, "Recovery", 8, "cancel_recovered", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> RecoveryCreated
    /// A recovery process has been set up for an \[account\].
    /// </summary>
    public sealed class EventRecoveryCreated : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> RecoveryInitiated
    /// A recovery process has been initiated for lost account by rescuer account.
    /// \[lost, rescuer\]
    /// </summary>
    public sealed class EventRecoveryInitiated : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> RecoveryVouched
    /// A recovery process for lost account by rescuer account has been vouched for by sender.
    /// \[lost, rescuer, sender\]
    /// </summary>
    public sealed class EventRecoveryVouched : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> RecoveryClosed
    /// A recovery process for lost account by rescuer account has been closed.
    /// \[lost, rescuer\]
    /// </summary>
    public sealed class EventRecoveryClosed : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> AccountRecovered
    /// Lost account has been successfully recovered by rescuer account.
    /// \[lost, rescuer\]
    /// </summary>
    public sealed class EventAccountRecovered : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> RecoveryRemoved
    /// A recovery process has been removed for an \[account\].
    /// </summary>
    public sealed class EventRecoveryRemoved : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    public enum RecoveryErrors
    {
        
        /// <summary>
        /// >> NotAllowed
        /// User is not allowed to make a call on behalf of this account
        /// </summary>
        NotAllowed,
        
        /// <summary>
        /// >> ZeroThreshold
        /// Threshold must be greater than zero
        /// </summary>
        ZeroThreshold,
        
        /// <summary>
        /// >> NotEnoughFriends
        /// Friends list must be greater than zero and threshold
        /// </summary>
        NotEnoughFriends,
        
        /// <summary>
        /// >> MaxFriends
        /// Friends list must be less than max friends
        /// </summary>
        MaxFriends,
        
        /// <summary>
        /// >> NotSorted
        /// Friends list must be sorted and free of duplicates
        /// </summary>
        NotSorted,
        
        /// <summary>
        /// >> NotRecoverable
        /// This account is not set up for recovery
        /// </summary>
        NotRecoverable,
        
        /// <summary>
        /// >> AlreadyRecoverable
        /// This account is already set up for recovery
        /// </summary>
        AlreadyRecoverable,
        
        /// <summary>
        /// >> AlreadyStarted
        /// A recovery process has already started for this account
        /// </summary>
        AlreadyStarted,
        
        /// <summary>
        /// >> NotStarted
        /// A recovery process has not started for this rescuer
        /// </summary>
        NotStarted,
        
        /// <summary>
        /// >> NotFriend
        /// This account is not a friend who can vouch
        /// </summary>
        NotFriend,
        
        /// <summary>
        /// >> DelayPeriod
        /// The friend must wait until the delay period to vouch for this recovery
        /// </summary>
        DelayPeriod,
        
        /// <summary>
        /// >> AlreadyVouched
        /// This user has already vouched for this recovery
        /// </summary>
        AlreadyVouched,
        
        /// <summary>
        /// >> Threshold
        /// The threshold for recovering this account has not been met
        /// </summary>
        Threshold,
        
        /// <summary>
        /// >> StillActive
        /// There are still active recovery attempts that need to be closed
        /// </summary>
        StillActive,
        
        /// <summary>
        /// >> AlreadyProxy
        /// This account is already set up for recovery
        /// </summary>
        AlreadyProxy,
        
        /// <summary>
        /// >> BadState
        /// Some internal state is broken.
        /// </summary>
        BadState,
    }
}
