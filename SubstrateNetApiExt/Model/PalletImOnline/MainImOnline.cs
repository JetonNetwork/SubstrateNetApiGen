//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Extrinsics;
using SubstrateNetApi.Model.FrameSupport;
using SubstrateNetApi.Model.Meta;
using SubstrateNetApi.Model.PalletImOnline;
using SubstrateNetApi.Model.PalletStaking;
using SubstrateNetApi.Model.SpCore;
using SubstrateNetApi.Model.Types;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNetApi.Model.PalletImOnline
{
    
    
    public sealed class ImOnlineStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateNetApi.SubstrateClient _client;
        
        public ImOnlineStorage(SubstrateNetApi.SubstrateClient client)
        {
            this._client = client;
        }
        
        /// <summary>
        /// >> HeartbeatAfterParams
        ///  The block number after which it's ok to send heartbeats in the current
        ///  session.
        /// 
        ///  At the beginning of each session we set this to a value that should fall
        ///  roughly in the middle of the session duration. The idea is to first wait for
        ///  the validators to produce a block in the current session, so that the
        ///  heartbeat later on will not be necessary.
        /// 
        ///  This value will only be used as a fallback if we fail to get a proper session
        ///  progress estimate from `NextSessionRotation`, as those estimates should be
        ///  more accurate then the value we calculate for `HeartbeatAfter`.
        /// </summary>
        public static string HeartbeatAfterParams()
        {
            return RequestGenerator.GetStorage("ImOnline", "HeartbeatAfter", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> HeartbeatAfter
        ///  The block number after which it's ok to send heartbeats in the current
        ///  session.
        /// 
        ///  At the beginning of each session we set this to a value that should fall
        ///  roughly in the middle of the session duration. The idea is to first wait for
        ///  the validators to produce a block in the current session, so that the
        ///  heartbeat later on will not be necessary.
        /// 
        ///  This value will only be used as a fallback if we fail to get a proper session
        ///  progress estimate from `NextSessionRotation`, as those estimates should be
        ///  more accurate then the value we calculate for `HeartbeatAfter`.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U32> HeartbeatAfter(CancellationToken token)
        {
            string parameters = ImOnlineStorage.HeartbeatAfterParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> KeysParams
        ///  The current set of keys that may issue a heartbeat.
        /// </summary>
        public static string KeysParams()
        {
            return RequestGenerator.GetStorage("ImOnline", "Keys", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Keys
        ///  The current set of keys that may issue a heartbeat.
        /// </summary>
        public async Task<SubstrateNetApi.Model.FrameSupport.WeakBoundedVec> Keys(CancellationToken token)
        {
            string parameters = ImOnlineStorage.KeysParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.FrameSupport.WeakBoundedVec>(parameters, token);
        }
        
        /// <summary>
        /// >> ReceivedHeartbeatsParams
        ///  For each session index, we keep a mapping of 'SessionIndex` and `AuthIndex` to
        ///  `WrapperOpaque<BoundedOpaqueNetworkState>`.
        /// </summary>
        public static string ReceivedHeartbeatsParams(BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U32> key)
        {
            return RequestGenerator.GetStorage("ImOnline", "ReceivedHeartbeats", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ReceivedHeartbeats
        ///  For each session index, we keep a mapping of 'SessionIndex` and `AuthIndex` to
        ///  `WrapperOpaque<BoundedOpaqueNetworkState>`.
        /// </summary>
        public async Task<SubstrateNetApi.Model.FrameSupport.WrapperOpaque> ReceivedHeartbeats(BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U32> key, CancellationToken token)
        {
            string parameters = ImOnlineStorage.ReceivedHeartbeatsParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.FrameSupport.WrapperOpaque>(parameters, token);
        }
        
        /// <summary>
        /// >> AuthoredBlocksParams
        ///  For each session index, we keep a mapping of `ValidatorId<T>` to the
        ///  number of blocks authored by the given authority.
        /// </summary>
        public static string AuthoredBlocksParams(BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.SpCore.AccountId32> key)
        {
            return RequestGenerator.GetStorage("ImOnline", "AuthoredBlocks", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> AuthoredBlocks
        ///  For each session index, we keep a mapping of `ValidatorId<T>` to the
        ///  number of blocks authored by the given authority.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U32> AuthoredBlocks(BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.SpCore.AccountId32> key, CancellationToken token)
        {
            string parameters = ImOnlineStorage.AuthoredBlocksParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U32>(parameters, token);
        }
    }
    
    public sealed class ImOnlineCalls
    {
        
        /// <summary>
        /// >> heartbeat
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Heartbeat(SubstrateNetApi.Model.PalletImOnline.Heartbeat heartbeat, SubstrateNetApi.Model.PalletImOnline.Signature signature)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(heartbeat.Encode());
            byteArray.AddRange(signature.Encode());
            return new Method(20, "ImOnline", 0, "heartbeat", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> HeartbeatReceived
    /// A new heartbeat was received from `AuthorityId` \[authority_id\]
    /// </summary>
    public sealed class EventHeartbeatReceived : BaseTuple<SubstrateNetApi.Model.PalletImOnline.Public>
    {
    }
    
    /// <summary>
    /// >> AllGood
    /// At the end of the session, no offence was committed.
    /// </summary>
    public sealed class EventAllGood : BaseTuple
    {
    }
    
    /// <summary>
    /// >> SomeOffline
    /// At the end of the session, at least one validator was found to be \[offline\].
    /// </summary>
    public sealed class EventSomeOffline : BaseTuple<BaseVec<BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.PalletStaking.Exposure>>>
    {
    }
    
    public enum ImOnlineErrors
    {
        
        /// <summary>
        /// >> InvalidKey
        /// Non existent public key.
        /// </summary>
        InvalidKey,
        
        /// <summary>
        /// >> DuplicatedHeartbeat
        /// Duplicated heartbeat.
        /// </summary>
        DuplicatedHeartbeat,
    }
}