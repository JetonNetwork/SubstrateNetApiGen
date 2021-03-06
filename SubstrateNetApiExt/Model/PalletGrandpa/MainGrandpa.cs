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
using SubstrateNetApi.Model.PalletGrandpa;
using SubstrateNetApi.Model.SpFinalityGrandpa;
using SubstrateNetApi.Model.SpSession;
using SubstrateNetApi.Model.Types;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNetApi.Model.PalletGrandpa
{
    
    
    public sealed class GrandpaStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public GrandpaStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Grandpa", "State"), new System.Tuple<SubstrateNetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNetApi.Model.PalletGrandpa.EnumStoredState)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Grandpa", "PendingChange"), new System.Tuple<SubstrateNetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNetApi.Model.PalletGrandpa.StoredPendingChange)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Grandpa", "NextForced"), new System.Tuple<SubstrateNetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Grandpa", "Stalled"), new System.Tuple<SubstrateNetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U32>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Grandpa", "CurrentSetId"), new System.Tuple<SubstrateNetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNetApi.Model.Types.Primitive.U64)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Grandpa", "SetIdSession"), new System.Tuple<SubstrateNetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                            SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(SubstrateNetApi.Model.Types.Primitive.U64), typeof(SubstrateNetApi.Model.Types.Primitive.U32)));
        }
        
        /// <summary>
        /// >> StateParams
        ///  State of the current authority set.
        /// </summary>
        public static string StateParams()
        {
            return RequestGenerator.GetStorage("Grandpa", "State", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> State
        ///  State of the current authority set.
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletGrandpa.EnumStoredState> State(CancellationToken token)
        {
            string parameters = GrandpaStorage.StateParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletGrandpa.EnumStoredState>(parameters, token);
        }
        
        /// <summary>
        /// >> PendingChangeParams
        ///  Pending change: (signaled at, scheduled change).
        /// </summary>
        public static string PendingChangeParams()
        {
            return RequestGenerator.GetStorage("Grandpa", "PendingChange", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> PendingChange
        ///  Pending change: (signaled at, scheduled change).
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletGrandpa.StoredPendingChange> PendingChange(CancellationToken token)
        {
            string parameters = GrandpaStorage.PendingChangeParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletGrandpa.StoredPendingChange>(parameters, token);
        }
        
        /// <summary>
        /// >> NextForcedParams
        ///  next block number where we can force a change.
        /// </summary>
        public static string NextForcedParams()
        {
            return RequestGenerator.GetStorage("Grandpa", "NextForced", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> NextForced
        ///  next block number where we can force a change.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U32> NextForced(CancellationToken token)
        {
            string parameters = GrandpaStorage.NextForcedParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> StalledParams
        ///  `true` if we are currently stalled.
        /// </summary>
        public static string StalledParams()
        {
            return RequestGenerator.GetStorage("Grandpa", "Stalled", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Stalled
        ///  `true` if we are currently stalled.
        /// </summary>
        public async Task<BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U32>> Stalled(CancellationToken token)
        {
            string parameters = GrandpaStorage.StalledParams();
            return await _client.GetStorageAsync<BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U32>>(parameters, token);
        }
        
        /// <summary>
        /// >> CurrentSetIdParams
        ///  The number of changes (both in terms of keys and underlying economic responsibilities)
        ///  in the "set" of Grandpa validators from genesis.
        /// </summary>
        public static string CurrentSetIdParams()
        {
            return RequestGenerator.GetStorage("Grandpa", "CurrentSetId", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CurrentSetId
        ///  The number of changes (both in terms of keys and underlying economic responsibilities)
        ///  in the "set" of Grandpa validators from genesis.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U64> CurrentSetId(CancellationToken token)
        {
            string parameters = GrandpaStorage.CurrentSetIdParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U64>(parameters, token);
        }
        
        /// <summary>
        /// >> SetIdSessionParams
        ///  A mapping from grandpa set ID to the index of the *most recent* session for which its
        ///  members were responsible.
        /// 
        ///  TWOX-NOTE: `SetId` is not under user control.
        /// </summary>
        public static string SetIdSessionParams(SubstrateNetApi.Model.Types.Primitive.U64 key)
        {
            return RequestGenerator.GetStorage("Grandpa", "SetIdSession", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> SetIdSession
        ///  A mapping from grandpa set ID to the index of the *most recent* session for which its
        ///  members were responsible.
        /// 
        ///  TWOX-NOTE: `SetId` is not under user control.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U32> SetIdSession(SubstrateNetApi.Model.Types.Primitive.U64 key, CancellationToken token)
        {
            string parameters = GrandpaStorage.SetIdSessionParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U32>(parameters, token);
        }
    }
    
    public sealed class GrandpaCalls
    {
        
        /// <summary>
        /// >> report_equivocation
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ReportEquivocation(SubstrateNetApi.Model.SpFinalityGrandpa.EquivocationProof equivocation_proof, SubstrateNetApi.Model.SpSession.MembershipProof key_owner_proof)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(equivocation_proof.Encode());
            byteArray.AddRange(key_owner_proof.Encode());
            return new Method(16, "Grandpa", 0, "report_equivocation", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> report_equivocation_unsigned
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ReportEquivocationUnsigned(SubstrateNetApi.Model.SpFinalityGrandpa.EquivocationProof equivocation_proof, SubstrateNetApi.Model.SpSession.MembershipProof key_owner_proof)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(equivocation_proof.Encode());
            byteArray.AddRange(key_owner_proof.Encode());
            return new Method(16, "Grandpa", 1, "report_equivocation_unsigned", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> note_stalled
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method NoteStalled(SubstrateNetApi.Model.Types.Primitive.U32 delay, SubstrateNetApi.Model.Types.Primitive.U32 best_finalized_block_number)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(delay.Encode());
            byteArray.AddRange(best_finalized_block_number.Encode());
            return new Method(16, "Grandpa", 2, "note_stalled", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> NewAuthorities
    /// New authority set has been applied. \[authority_set\]
    /// </summary>
    public sealed class EventNewAuthorities : BaseTuple<BaseVec<BaseTuple<SubstrateNetApi.Model.SpFinalityGrandpa.Public,SubstrateNetApi.Model.Types.Primitive.U64>>>
    {
    }
    
    /// <summary>
    /// >> Paused
    /// Current authority set has been paused.
    /// </summary>
    public sealed class EventPaused : BaseTuple
    {
    }
    
    /// <summary>
    /// >> Resumed
    /// Current authority set has been resumed.
    /// </summary>
    public sealed class EventResumed : BaseTuple
    {
    }
    
    public enum GrandpaErrors
    {
        
        /// <summary>
        /// >> PauseFailed
        /// Attempt to signal GRANDPA pause when the authority set isn't live
        /// (either paused or already pending pause).
        /// </summary>
        PauseFailed,
        
        /// <summary>
        /// >> ResumeFailed
        /// Attempt to signal GRANDPA resume when the authority set isn't paused
        /// (either live or already pending resume).
        /// </summary>
        ResumeFailed,
        
        /// <summary>
        /// >> ChangePending
        /// Attempt to signal GRANDPA change with one already pending.
        /// </summary>
        ChangePending,
        
        /// <summary>
        /// >> TooSoon
        /// Cannot signal forced change so soon after last.
        /// </summary>
        TooSoon,
        
        /// <summary>
        /// >> InvalidKeyOwnershipProof
        /// A key ownership proof provided as part of an equivocation report is invalid.
        /// </summary>
        InvalidKeyOwnershipProof,
        
        /// <summary>
        /// >> InvalidEquivocationProof
        /// An equivocation proof provided as part of an equivocation report is invalid.
        /// </summary>
        InvalidEquivocationProof,
        
        /// <summary>
        /// >> DuplicateOffenceReport
        /// A given equivocation report is valid but already previously reported.
        /// </summary>
        DuplicateOffenceReport,
    }
}
