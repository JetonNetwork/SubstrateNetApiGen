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
using SubstrateNetApi.Model.PalletGilt;
using SubstrateNetApi.Model.SpArithmetic;
using SubstrateNetApi.Model.SpCore;
using SubstrateNetApi.Model.Types;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNetApi.Model.PalletGilt
{
    
    
    public sealed class GiltStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateNetApi.SubstrateClient _client;
        
        public GiltStorage(SubstrateNetApi.SubstrateClient client)
        {
            this._client = client;
        }
        
        /// <summary>
        /// >> QueueTotalsParams
        ///  The totals of items and balances within each queue. Saves a lot of storage reads in the
        ///  case of sparsely packed queues.
        /// 
        ///  The vector is indexed by duration in `Period`s, offset by one, so information on the queue
        ///  whose duration is one `Period` would be storage `0`.
        /// </summary>
        public static string QueueTotalsParams()
        {
            return RequestGenerator.GetStorage("Gilt", "QueueTotals", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> QueueTotals
        ///  The totals of items and balances within each queue. Saves a lot of storage reads in the
        ///  case of sparsely packed queues.
        /// 
        ///  The vector is indexed by duration in `Period`s, offset by one, so information on the queue
        ///  whose duration is one `Period` would be storage `0`.
        /// </summary>
        public async Task<BaseVec<BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U128>>> QueueTotals(CancellationToken token)
        {
            string parameters = GiltStorage.QueueTotalsParams();
            return await _client.GetStorageAsync<BaseVec<BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U128>>>(parameters, token);
        }
        
        /// <summary>
        /// >> QueuesParams
        ///  The queues of bids ready to become gilts. Indexed by duration (in `Period`s).
        /// </summary>
        public static string QueuesParams(SubstrateNetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("Gilt", "Queues", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Queues
        ///  The queues of bids ready to become gilts. Indexed by duration (in `Period`s).
        /// </summary>
        public async Task<BaseVec<SubstrateNetApi.Model.PalletGilt.GiltBid>> Queues(SubstrateNetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = GiltStorage.QueuesParams(key);
            return await _client.GetStorageAsync<BaseVec<SubstrateNetApi.Model.PalletGilt.GiltBid>>(parameters, token);
        }
        
        /// <summary>
        /// >> ActiveTotalParams
        ///  Information relating to the gilts currently active.
        /// </summary>
        public static string ActiveTotalParams()
        {
            return RequestGenerator.GetStorage("Gilt", "ActiveTotal", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ActiveTotal
        ///  Information relating to the gilts currently active.
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletGilt.ActiveGiltsTotal> ActiveTotal(CancellationToken token)
        {
            string parameters = GiltStorage.ActiveTotalParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletGilt.ActiveGiltsTotal>(parameters, token);
        }
        
        /// <summary>
        /// >> ActiveParams
        ///  The currently active gilts, indexed according to the order of creation.
        /// </summary>
        public static string ActiveParams(SubstrateNetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("Gilt", "Active", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Active
        ///  The currently active gilts, indexed according to the order of creation.
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletGilt.ActiveGilt> Active(SubstrateNetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = GiltStorage.ActiveParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletGilt.ActiveGilt>(parameters, token);
        }
    }
    
    public sealed class GiltCalls
    {
        
        /// <summary>
        /// >> place_bid
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method PlaceBid(BaseCom<SubstrateNetApi.Model.Types.Primitive.U128> amount, SubstrateNetApi.Model.Types.Primitive.U32 duration)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(amount.Encode());
            byteArray.AddRange(duration.Encode());
            return new Method(37, "Gilt", 0, "place_bid", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> retract_bid
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RetractBid(BaseCom<SubstrateNetApi.Model.Types.Primitive.U128> amount, SubstrateNetApi.Model.Types.Primitive.U32 duration)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(amount.Encode());
            byteArray.AddRange(duration.Encode());
            return new Method(37, "Gilt", 1, "retract_bid", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_target
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetTarget(BaseCom<SubstrateNetApi.Model.SpArithmetic.Perquintill> target)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(target.Encode());
            return new Method(37, "Gilt", 2, "set_target", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> thaw
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Thaw(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            return new Method(37, "Gilt", 3, "thaw", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> BidPlaced
    /// A bid was successfully placed.
    /// \[ who, amount, duration \]
    /// </summary>
    public sealed class EventBidPlaced : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.U128, SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    /// <summary>
    /// >> BidRetracted
    /// A bid was successfully removed (before being accepted as a gilt).
    /// \[ who, amount, duration \]
    /// </summary>
    public sealed class EventBidRetracted : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.U128, SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    /// <summary>
    /// >> GiltIssued
    /// A bid was accepted as a gilt. The balance may not be released until expiry.
    /// \[ index, expiry, who, amount \]
    /// </summary>
    public sealed class EventGiltIssued : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.U128>
    {
    }
    
    /// <summary>
    /// >> GiltThawed
    /// An expired gilt has been thawed.
    /// \[ index, who, original_amount, additional_amount \]
    /// </summary>
    public sealed class EventGiltThawed : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.U128, SubstrateNetApi.Model.Types.Primitive.U128>
    {
    }
    
    public enum GiltErrors
    {
        
        /// <summary>
        /// >> DurationTooSmall
        /// The duration of the bid is less than one.
        /// </summary>
        DurationTooSmall,
        
        /// <summary>
        /// >> DurationTooBig
        /// The duration is the bid is greater than the number of queues.
        /// </summary>
        DurationTooBig,
        
        /// <summary>
        /// >> AmountTooSmall
        /// The amount of the bid is less than the minimum allowed.
        /// </summary>
        AmountTooSmall,
        
        /// <summary>
        /// >> BidTooLow
        /// The queue for the bid's duration is full and the amount bid is too low to get in
        /// through replacing an existing bid.
        /// </summary>
        BidTooLow,
        
        /// <summary>
        /// >> Unknown
        /// Gilt index is unknown.
        /// </summary>
        Unknown,
        
        /// <summary>
        /// >> NotOwner
        /// Not the owner of the gilt.
        /// </summary>
        NotOwner,
        
        /// <summary>
        /// >> NotExpired
        /// Gilt not yet at expiry date.
        /// </summary>
        NotExpired,
        
        /// <summary>
        /// >> NotFound
        /// The given bid for retraction is not found.
        /// </summary>
        NotFound,
    }
}