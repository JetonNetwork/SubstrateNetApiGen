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
using SubstrateNetApi.Model.PalletTips;
using SubstrateNetApi.Model.PrimitiveTypes;
using SubstrateNetApi.Model.SpCore;
using SubstrateNetApi.Model.Types;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNetApi.Model.PalletTips
{
    
    
    public sealed class TipsStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public TipsStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Tips", "Tips"), new System.Tuple<SubstrateNetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                            SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(SubstrateNetApi.Model.PrimitiveTypes.H256), typeof(SubstrateNetApi.Model.PalletTips.OpenTip)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Tips", "Reasons"), new System.Tuple<SubstrateNetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                            SubstrateNetApi.Model.Meta.Storage.Hasher.Identity}, typeof(SubstrateNetApi.Model.PrimitiveTypes.H256), typeof(BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>)));
        }
        
        /// <summary>
        /// >> TipsParams
        ///  TipsMap that are not yet completed. Keyed by the hash of `(reason, who)` from the value.
        ///  This has the insecure enumerable hash function since the key itself is already
        ///  guaranteed to be a secure hash.
        /// </summary>
        public static string TipsParams(SubstrateNetApi.Model.PrimitiveTypes.H256 key)
        {
            return RequestGenerator.GetStorage("Tips", "Tips", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Tips
        ///  TipsMap that are not yet completed. Keyed by the hash of `(reason, who)` from the value.
        ///  This has the insecure enumerable hash function since the key itself is already
        ///  guaranteed to be a secure hash.
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletTips.OpenTip> Tips(SubstrateNetApi.Model.PrimitiveTypes.H256 key, CancellationToken token)
        {
            string parameters = TipsStorage.TipsParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletTips.OpenTip>(parameters, token);
        }
        
        /// <summary>
        /// >> ReasonsParams
        ///  Simple preimage lookup from the reason's hash to the original data. Again, has an
        ///  insecure enumerable hash since the key is guaranteed to be the result of a secure hash.
        /// </summary>
        public static string ReasonsParams(SubstrateNetApi.Model.PrimitiveTypes.H256 key)
        {
            return RequestGenerator.GetStorage("Tips", "Reasons", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Identity}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Reasons
        ///  Simple preimage lookup from the reason's hash to the original data. Again, has an
        ///  insecure enumerable hash since the key is guaranteed to be the result of a secure hash.
        /// </summary>
        public async Task<BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>> Reasons(SubstrateNetApi.Model.PrimitiveTypes.H256 key, CancellationToken token)
        {
            string parameters = TipsStorage.ReasonsParams(key);
            return await _client.GetStorageAsync<BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>>(parameters, token);
        }
    }
    
    public sealed class TipsCalls
    {
        
        /// <summary>
        /// >> report_awesome
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ReportAwesome(BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> reason, SubstrateNetApi.Model.SpCore.AccountId32 who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(reason.Encode());
            byteArray.AddRange(who.Encode());
            return new Method(33, "Tips", 0, "report_awesome", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> retract_tip
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RetractTip(SubstrateNetApi.Model.PrimitiveTypes.H256 hash)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(hash.Encode());
            return new Method(33, "Tips", 1, "retract_tip", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> tip_new
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method TipNew(BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> reason, SubstrateNetApi.Model.SpCore.AccountId32 who, BaseCom<SubstrateNetApi.Model.Types.Primitive.U128> tip_value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(reason.Encode());
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(tip_value.Encode());
            return new Method(33, "Tips", 2, "tip_new", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> tip
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Tip(SubstrateNetApi.Model.PrimitiveTypes.H256 hash, BaseCom<SubstrateNetApi.Model.Types.Primitive.U128> tip_value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(hash.Encode());
            byteArray.AddRange(tip_value.Encode());
            return new Method(33, "Tips", 3, "tip", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> close_tip
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method CloseTip(SubstrateNetApi.Model.PrimitiveTypes.H256 hash)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(hash.Encode());
            return new Method(33, "Tips", 4, "close_tip", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> slash_tip
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SlashTip(SubstrateNetApi.Model.PrimitiveTypes.H256 hash)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(hash.Encode());
            return new Method(33, "Tips", 5, "slash_tip", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> NewTip
    /// A new tip suggestion has been opened. \[tip_hash\]
    /// </summary>
    public sealed class EventNewTip : BaseTuple<SubstrateNetApi.Model.PrimitiveTypes.H256>
    {
    }
    
    /// <summary>
    /// >> TipClosing
    /// A tip suggestion has reached threshold and is closing. \[tip_hash\]
    /// </summary>
    public sealed class EventTipClosing : BaseTuple<SubstrateNetApi.Model.PrimitiveTypes.H256>
    {
    }
    
    /// <summary>
    /// >> TipClosed
    /// A tip suggestion has been closed. \[tip_hash, who, payout\]
    /// </summary>
    public sealed class EventTipClosed : BaseTuple<SubstrateNetApi.Model.PrimitiveTypes.H256, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.U128>
    {
    }
    
    /// <summary>
    /// >> TipRetracted
    /// A tip suggestion has been retracted. \[tip_hash\]
    /// </summary>
    public sealed class EventTipRetracted : BaseTuple<SubstrateNetApi.Model.PrimitiveTypes.H256>
    {
    }
    
    /// <summary>
    /// >> TipSlashed
    /// A tip suggestion has been slashed. \[tip_hash, finder, deposit\]
    /// </summary>
    public sealed class EventTipSlashed : BaseTuple<SubstrateNetApi.Model.PrimitiveTypes.H256, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.U128>
    {
    }
    
    public enum TipsErrors
    {
        
        /// <summary>
        /// >> ReasonTooBig
        /// The reason given is just too big.
        /// </summary>
        ReasonTooBig,
        
        /// <summary>
        /// >> AlreadyKnown
        /// The tip was already found/started.
        /// </summary>
        AlreadyKnown,
        
        /// <summary>
        /// >> UnknownTip
        /// The tip hash is unknown.
        /// </summary>
        UnknownTip,
        
        /// <summary>
        /// >> NotFinder
        /// The account attempting to retract the tip is not the finder of the tip.
        /// </summary>
        NotFinder,
        
        /// <summary>
        /// >> StillOpen
        /// The tip cannot be claimed/closed because there are not enough tippers yet.
        /// </summary>
        StillOpen,
        
        /// <summary>
        /// >> Premature
        /// The tip cannot be claimed/closed because it's still in the countdown period.
        /// </summary>
        Premature,
    }
}
