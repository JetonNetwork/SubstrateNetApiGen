//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Base;
using SubstrateNetApi.Model.Extrinsics;
using SubstrateNetApi.Model.FrameSupport;
using SubstrateNetApi.Model.Meta;
using SubstrateNetApi.Model.SpConsensusBabe;
using SubstrateNetApi.Model.SpConsensusSlots;
using SubstrateNetApi.Model.SpSession;
using SubstrateNetApi.Model.Types;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNetApi.Model.PalletBabe
{
    
    
    public sealed class BabeStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateNetApi.SubstrateClient _client;
        
        public BabeStorage(SubstrateNetApi.SubstrateClient client)
        {
            this._client = client;
        }
        
        public static string EpochIndexParams()
        {
            return RequestGenerator.GetStorage("Babe", "EpochIndex", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> EpochIndex
        ///  Current epoch index.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U64> EpochIndex(CancellationToken token)
        {
            string parameters = BabeStorage.EpochIndexParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U64>(parameters, token);
        }
        
        public static string AuthoritiesParams()
        {
            return RequestGenerator.GetStorage("Babe", "Authorities", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Authorities
        ///  Current epoch authorities.
        /// </summary>
        public async Task<SubstrateNetApi.Model.FrameSupport.WeakBoundedVec> Authorities(CancellationToken token)
        {
            string parameters = BabeStorage.AuthoritiesParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.FrameSupport.WeakBoundedVec>(parameters, token);
        }
        
        public static string GenesisSlotParams()
        {
            return RequestGenerator.GetStorage("Babe", "GenesisSlot", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> GenesisSlot
        ///  The slot at which the first epoch actually started. This is 0
        ///  until the first block of the chain.
        /// </summary>
        public async Task<SubstrateNetApi.Model.SpConsensusSlots.Slot> GenesisSlot(CancellationToken token)
        {
            string parameters = BabeStorage.GenesisSlotParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.SpConsensusSlots.Slot>(parameters, token);
        }
        
        public static string CurrentSlotParams()
        {
            return RequestGenerator.GetStorage("Babe", "CurrentSlot", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CurrentSlot
        ///  Current slot number.
        /// </summary>
        public async Task<SubstrateNetApi.Model.SpConsensusSlots.Slot> CurrentSlot(CancellationToken token)
        {
            string parameters = BabeStorage.CurrentSlotParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.SpConsensusSlots.Slot>(parameters, token);
        }
        
        public static string RandomnessParams()
        {
            return RequestGenerator.GetStorage("Babe", "Randomness", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Randomness
        ///  The epoch randomness for the *current* epoch.
        /// 
        ///  # Security
        /// 
        ///  This MUST NOT be used for gambling, as it can be influenced by a
        ///  malicious validator in the short term. It MAY be used in many
        ///  cryptographic protocols, however, so long as one remembers that this
        ///  (like everything else on-chain) it is public. For example, it can be
        ///  used where a number is needed that cannot have been chosen by an
        ///  adversary, for purposes such as public-coin zero-knowledge proofs.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Base.Arr32U8> Randomness(CancellationToken token)
        {
            string parameters = BabeStorage.RandomnessParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Base.Arr32U8>(parameters, token);
        }
        
        public static string PendingEpochConfigChangeParams()
        {
            return RequestGenerator.GetStorage("Babe", "PendingEpochConfigChange", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> PendingEpochConfigChange
        ///  Pending epoch configuration change that will be applied when the next epoch is enacted.
        /// </summary>
        public async Task<SubstrateNetApi.Model.SpConsensusBabe.EnumNextConfigDescriptor> PendingEpochConfigChange(CancellationToken token)
        {
            string parameters = BabeStorage.PendingEpochConfigChangeParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.SpConsensusBabe.EnumNextConfigDescriptor>(parameters, token);
        }
        
        public static string NextRandomnessParams()
        {
            return RequestGenerator.GetStorage("Babe", "NextRandomness", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> NextRandomness
        ///  Next epoch randomness.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Base.Arr32U8> NextRandomness(CancellationToken token)
        {
            string parameters = BabeStorage.NextRandomnessParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Base.Arr32U8>(parameters, token);
        }
        
        public static string NextAuthoritiesParams()
        {
            return RequestGenerator.GetStorage("Babe", "NextAuthorities", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> NextAuthorities
        ///  Next epoch authorities.
        /// </summary>
        public async Task<SubstrateNetApi.Model.FrameSupport.WeakBoundedVec> NextAuthorities(CancellationToken token)
        {
            string parameters = BabeStorage.NextAuthoritiesParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.FrameSupport.WeakBoundedVec>(parameters, token);
        }
        
        public static string SegmentIndexParams()
        {
            return RequestGenerator.GetStorage("Babe", "SegmentIndex", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> SegmentIndex
        ///  Randomness under construction.
        /// 
        ///  We make a tradeoff between storage accesses and list length.
        ///  We store the under-construction randomness in segments of up to
        ///  `UNDER_CONSTRUCTION_SEGMENT_LENGTH`.
        /// 
        ///  Once a segment reaches this length, we begin the next one.
        ///  We reset all segments and return to `0` at the beginning of every
        ///  epoch.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U32> SegmentIndex(CancellationToken token)
        {
            string parameters = BabeStorage.SegmentIndexParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        public static string UnderConstructionParams(SubstrateNetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("Babe", "UnderConstruction", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> UnderConstruction
        ///  TWOX-NOTE: `SegmentIndex` is an increasing integer, so this is okay.
        /// </summary>
        public async Task<SubstrateNetApi.Model.FrameSupport.BoundedVec> UnderConstruction(SubstrateNetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = BabeStorage.UnderConstructionParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.FrameSupport.BoundedVec>(parameters, token);
        }
        
        public static string InitializedParams()
        {
            return RequestGenerator.GetStorage("Babe", "Initialized", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Initialized
        ///  Temporary value (cleared at block finalization) which is `Some`
        ///  if per-block initialization has already been called for current block.
        /// </summary>
        public async Task<BaseOpt<SubstrateNetApi.Model.Base.Arr32U8>> Initialized(CancellationToken token)
        {
            string parameters = BabeStorage.InitializedParams();
            return await _client.GetStorageAsync<BaseOpt<SubstrateNetApi.Model.Base.Arr32U8>>(parameters, token);
        }
        
        public static string AuthorVrfRandomnessParams()
        {
            return RequestGenerator.GetStorage("Babe", "AuthorVrfRandomness", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> AuthorVrfRandomness
        ///  This field should always be populated during block processing unless
        ///  secondary plain slots are enabled (which don't contain a VRF output).
        /// 
        ///  It is set in `on_initialize`, before it will contain the value from the last block.
        /// </summary>
        public async Task<BaseOpt<SubstrateNetApi.Model.Base.Arr32U8>> AuthorVrfRandomness(CancellationToken token)
        {
            string parameters = BabeStorage.AuthorVrfRandomnessParams();
            return await _client.GetStorageAsync<BaseOpt<SubstrateNetApi.Model.Base.Arr32U8>>(parameters, token);
        }
        
        public static string EpochStartParams()
        {
            return RequestGenerator.GetStorage("Babe", "EpochStart", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> EpochStart
        ///  The block numbers when the last and current epoch have started, respectively `N-1` and
        ///  `N`.
        ///  NOTE: We track this is in order to annotate the block number when a given pool of
        ///  entropy was fixed (i.e. it was known to chain observers). Since epochs are defined in
        ///  slots, which may be skipped, the block numbers may not line up with the slot numbers.
        /// </summary>
        public async Task<BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U32>> EpochStart(CancellationToken token)
        {
            string parameters = BabeStorage.EpochStartParams();
            return await _client.GetStorageAsync<BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U32>>(parameters, token);
        }
        
        public static string LatenessParams()
        {
            return RequestGenerator.GetStorage("Babe", "Lateness", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Lateness
        ///  How late the current block is compared to its parent.
        /// 
        ///  This entry is populated as part of block execution and is cleaned up
        ///  on block finalization. Querying this storage entry outside of block
        ///  execution context should always yield zero.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U32> Lateness(CancellationToken token)
        {
            string parameters = BabeStorage.LatenessParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        public static string EpochConfigParams()
        {
            return RequestGenerator.GetStorage("Babe", "EpochConfig", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> EpochConfig
        ///  The configuration for the current epoch. Should never be `None` as it is initialized in
        ///  genesis.
        /// </summary>
        public async Task<SubstrateNetApi.Model.SpConsensusBabe.BabeEpochConfiguration> EpochConfig(CancellationToken token)
        {
            string parameters = BabeStorage.EpochConfigParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.SpConsensusBabe.BabeEpochConfiguration>(parameters, token);
        }
        
        public static string NextEpochConfigParams()
        {
            return RequestGenerator.GetStorage("Babe", "NextEpochConfig", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> NextEpochConfig
        ///  The configuration for the next epoch, `None` if the config will not change
        ///  (you can fallback to `EpochConfig` instead in that case).
        /// </summary>
        public async Task<SubstrateNetApi.Model.SpConsensusBabe.BabeEpochConfiguration> NextEpochConfig(CancellationToken token)
        {
            string parameters = BabeStorage.NextEpochConfigParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.SpConsensusBabe.BabeEpochConfiguration>(parameters, token);
        }
    }
    
    public sealed class BabeCalls
    {
        
        /// <summary>
        /// >> report_equivocation
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ReportEquivocation(SubstrateNetApi.Model.SpConsensusSlots.EquivocationProof equivocation_proof, SubstrateNetApi.Model.SpSession.MembershipProof key_owner_proof)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(equivocation_proof.Encode());
            byteArray.AddRange(key_owner_proof.Encode());
            return new Method(2, "Babe", 0, "report_equivocation", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> report_equivocation_unsigned
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ReportEquivocationUnsigned(SubstrateNetApi.Model.SpConsensusSlots.EquivocationProof equivocation_proof, SubstrateNetApi.Model.SpSession.MembershipProof key_owner_proof)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(equivocation_proof.Encode());
            byteArray.AddRange(key_owner_proof.Encode());
            return new Method(2, "Babe", 1, "report_equivocation_unsigned", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> plan_config_change
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method PlanConfigChange(SubstrateNetApi.Model.SpConsensusBabe.EnumNextConfigDescriptor config)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(config.Encode());
            return new Method(2, "Babe", 2, "plan_config_change", byteArray.ToArray());
        }
    }
    
    public enum BabeErrors
    {
        
        /// <summary>
        /// >> InvalidEquivocationProof
        /// An equivocation proof provided as part of an equivocation report is invalid.
        /// </summary>
        InvalidEquivocationProof,
        
        /// <summary>
        /// >> InvalidKeyOwnershipProof
        /// A key ownership proof provided as part of an equivocation report is invalid.
        /// </summary>
        InvalidKeyOwnershipProof,
        
        /// <summary>
        /// >> DuplicateOffenceReport
        /// A given equivocation report is valid but already previously reported.
        /// </summary>
        DuplicateOffenceReport,
    }
}
