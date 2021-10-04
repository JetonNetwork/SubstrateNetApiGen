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
using SubstrateNetApi.Model.PalletSociety;
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


namespace SubstrateNetApi.Model.PalletSociety
{
    
    
    public sealed class SocietyStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public SocietyStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Society", "Founder"), new System.Tuple<Storage.Hasher[],Type>(null, null));
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Society", "Rules"), new System.Tuple<Storage.Hasher[],Type>(null, null));
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Society", "Candidates"), new System.Tuple<Storage.Hasher[],Type>(null, null));
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Society", "SuspendedCandidates"), new System.Tuple<Storage.Hasher[],Type>(new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                            SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(SubstrateNetApi.Model.SpCore.AccountId32)));
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Society", "Pot"), new System.Tuple<Storage.Hasher[],Type>(null, null));
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Society", "Head"), new System.Tuple<Storage.Hasher[],Type>(null, null));
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Society", "Members"), new System.Tuple<Storage.Hasher[],Type>(null, null));
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Society", "SuspendedMembers"), new System.Tuple<Storage.Hasher[],Type>(new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                            SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(SubstrateNetApi.Model.SpCore.AccountId32)));
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Society", "Bids"), new System.Tuple<Storage.Hasher[],Type>(null, null));
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Society", "Vouching"), new System.Tuple<Storage.Hasher[],Type>(new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                            SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(SubstrateNetApi.Model.SpCore.AccountId32)));
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Society", "Payouts"), new System.Tuple<Storage.Hasher[],Type>(new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                            SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(SubstrateNetApi.Model.SpCore.AccountId32)));
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Society", "Strikes"), new System.Tuple<Storage.Hasher[],Type>(new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                            SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(SubstrateNetApi.Model.SpCore.AccountId32)));
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Society", "Votes"), new System.Tuple<Storage.Hasher[],Type>(new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                            SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.SpCore.AccountId32>)));
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Society", "Defender"), new System.Tuple<Storage.Hasher[],Type>(null, null));
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Society", "DefenderVotes"), new System.Tuple<Storage.Hasher[],Type>(new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                            SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(SubstrateNetApi.Model.SpCore.AccountId32)));
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Society", "MaxMembers"), new System.Tuple<Storage.Hasher[],Type>(null, null));
        }
        
        /// <summary>
        /// >> FounderParams
        ///  The first member.
        /// </summary>
        public static string FounderParams()
        {
            return RequestGenerator.GetStorage("Society", "Founder", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Founder
        ///  The first member.
        /// </summary>
        public async Task<SubstrateNetApi.Model.SpCore.AccountId32> Founder(CancellationToken token)
        {
            string parameters = SocietyStorage.FounderParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.SpCore.AccountId32>(parameters, token);
        }
        
        /// <summary>
        /// >> RulesParams
        ///  A hash of the rules of this society concerning membership. Can only be set once and
        ///  only by the founder.
        /// </summary>
        public static string RulesParams()
        {
            return RequestGenerator.GetStorage("Society", "Rules", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Rules
        ///  A hash of the rules of this society concerning membership. Can only be set once and
        ///  only by the founder.
        /// </summary>
        public async Task<SubstrateNetApi.Model.PrimitiveTypes.H256> Rules(CancellationToken token)
        {
            string parameters = SocietyStorage.RulesParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PrimitiveTypes.H256>(parameters, token);
        }
        
        /// <summary>
        /// >> CandidatesParams
        ///  The current set of candidates; bidders that are attempting to become members.
        /// </summary>
        public static string CandidatesParams()
        {
            return RequestGenerator.GetStorage("Society", "Candidates", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Candidates
        ///  The current set of candidates; bidders that are attempting to become members.
        /// </summary>
        public async Task<BaseVec<SubstrateNetApi.Model.PalletSociety.Bid>> Candidates(CancellationToken token)
        {
            string parameters = SocietyStorage.CandidatesParams();
            return await _client.GetStorageAsync<BaseVec<SubstrateNetApi.Model.PalletSociety.Bid>>(parameters, token);
        }
        
        /// <summary>
        /// >> SuspendedCandidatesParams
        ///  The set of suspended candidates.
        /// </summary>
        public static string SuspendedCandidatesParams(SubstrateNetApi.Model.SpCore.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Society", "SuspendedCandidates", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> SuspendedCandidates
        ///  The set of suspended candidates.
        /// </summary>
        public async Task<BaseTuple<SubstrateNetApi.Model.Types.Primitive.U128,SubstrateNetApi.Model.PalletSociety.EnumBidKind>> SuspendedCandidates(SubstrateNetApi.Model.SpCore.AccountId32 key, CancellationToken token)
        {
            string parameters = SocietyStorage.SuspendedCandidatesParams(key);
            return await _client.GetStorageAsync<BaseTuple<SubstrateNetApi.Model.Types.Primitive.U128,SubstrateNetApi.Model.PalletSociety.EnumBidKind>>(parameters, token);
        }
        
        /// <summary>
        /// >> PotParams
        ///  Amount of our account balance that is specifically for the next round's bid(s).
        /// </summary>
        public static string PotParams()
        {
            return RequestGenerator.GetStorage("Society", "Pot", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Pot
        ///  Amount of our account balance that is specifically for the next round's bid(s).
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U128> Pot(CancellationToken token)
        {
            string parameters = SocietyStorage.PotParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U128>(parameters, token);
        }
        
        /// <summary>
        /// >> HeadParams
        ///  The most primary from the most recently approved members.
        /// </summary>
        public static string HeadParams()
        {
            return RequestGenerator.GetStorage("Society", "Head", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Head
        ///  The most primary from the most recently approved members.
        /// </summary>
        public async Task<SubstrateNetApi.Model.SpCore.AccountId32> Head(CancellationToken token)
        {
            string parameters = SocietyStorage.HeadParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.SpCore.AccountId32>(parameters, token);
        }
        
        /// <summary>
        /// >> MembersParams
        ///  The current set of members, ordered.
        /// </summary>
        public static string MembersParams()
        {
            return RequestGenerator.GetStorage("Society", "Members", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Members
        ///  The current set of members, ordered.
        /// </summary>
        public async Task<BaseVec<SubstrateNetApi.Model.SpCore.AccountId32>> Members(CancellationToken token)
        {
            string parameters = SocietyStorage.MembersParams();
            return await _client.GetStorageAsync<BaseVec<SubstrateNetApi.Model.SpCore.AccountId32>>(parameters, token);
        }
        
        /// <summary>
        /// >> SuspendedMembersParams
        ///  The set of suspended members.
        /// </summary>
        public static string SuspendedMembersParams(SubstrateNetApi.Model.SpCore.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Society", "SuspendedMembers", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> SuspendedMembers
        ///  The set of suspended members.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.Bool> SuspendedMembers(SubstrateNetApi.Model.SpCore.AccountId32 key, CancellationToken token)
        {
            string parameters = SocietyStorage.SuspendedMembersParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.Bool>(parameters, token);
        }
        
        /// <summary>
        /// >> BidsParams
        ///  The current bids, stored ordered by the value of the bid.
        /// </summary>
        public static string BidsParams()
        {
            return RequestGenerator.GetStorage("Society", "Bids", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Bids
        ///  The current bids, stored ordered by the value of the bid.
        /// </summary>
        public async Task<BaseVec<SubstrateNetApi.Model.PalletSociety.Bid>> Bids(CancellationToken token)
        {
            string parameters = SocietyStorage.BidsParams();
            return await _client.GetStorageAsync<BaseVec<SubstrateNetApi.Model.PalletSociety.Bid>>(parameters, token);
        }
        
        /// <summary>
        /// >> VouchingParams
        ///  Members currently vouching or banned from vouching again
        /// </summary>
        public static string VouchingParams(SubstrateNetApi.Model.SpCore.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Society", "Vouching", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Vouching
        ///  Members currently vouching or banned from vouching again
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletSociety.EnumVouchingStatus> Vouching(SubstrateNetApi.Model.SpCore.AccountId32 key, CancellationToken token)
        {
            string parameters = SocietyStorage.VouchingParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletSociety.EnumVouchingStatus>(parameters, token);
        }
        
        /// <summary>
        /// >> PayoutsParams
        ///  Pending payouts; ordered by block number, with the amount that should be paid out.
        /// </summary>
        public static string PayoutsParams(SubstrateNetApi.Model.SpCore.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Society", "Payouts", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Payouts
        ///  Pending payouts; ordered by block number, with the amount that should be paid out.
        /// </summary>
        public async Task<BaseVec<BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U128>>> Payouts(SubstrateNetApi.Model.SpCore.AccountId32 key, CancellationToken token)
        {
            string parameters = SocietyStorage.PayoutsParams(key);
            return await _client.GetStorageAsync<BaseVec<BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U128>>>(parameters, token);
        }
        
        /// <summary>
        /// >> StrikesParams
        ///  The ongoing number of losing votes cast by the member.
        /// </summary>
        public static string StrikesParams(SubstrateNetApi.Model.SpCore.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Society", "Strikes", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Strikes
        ///  The ongoing number of losing votes cast by the member.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U32> Strikes(SubstrateNetApi.Model.SpCore.AccountId32 key, CancellationToken token)
        {
            string parameters = SocietyStorage.StrikesParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> VotesParams
        ///  Double map from Candidate -> Voter -> (Maybe) Vote.
        /// </summary>
        public static string VotesParams(BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.SpCore.AccountId32> key)
        {
            return RequestGenerator.GetStorage("Society", "Votes", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Votes
        ///  Double map from Candidate -> Voter -> (Maybe) Vote.
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletSociety.EnumVote> Votes(BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.SpCore.AccountId32> key, CancellationToken token)
        {
            string parameters = SocietyStorage.VotesParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletSociety.EnumVote>(parameters, token);
        }
        
        /// <summary>
        /// >> DefenderParams
        ///  The defending member currently being challenged.
        /// </summary>
        public static string DefenderParams()
        {
            return RequestGenerator.GetStorage("Society", "Defender", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Defender
        ///  The defending member currently being challenged.
        /// </summary>
        public async Task<SubstrateNetApi.Model.SpCore.AccountId32> Defender(CancellationToken token)
        {
            string parameters = SocietyStorage.DefenderParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.SpCore.AccountId32>(parameters, token);
        }
        
        /// <summary>
        /// >> DefenderVotesParams
        ///  Votes for the defender.
        /// </summary>
        public static string DefenderVotesParams(SubstrateNetApi.Model.SpCore.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Society", "DefenderVotes", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> DefenderVotes
        ///  Votes for the defender.
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletSociety.EnumVote> DefenderVotes(SubstrateNetApi.Model.SpCore.AccountId32 key, CancellationToken token)
        {
            string parameters = SocietyStorage.DefenderVotesParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletSociety.EnumVote>(parameters, token);
        }
        
        /// <summary>
        /// >> MaxMembersParams
        ///  The max number of members for the society at one time.
        /// </summary>
        public static string MaxMembersParams()
        {
            return RequestGenerator.GetStorage("Society", "MaxMembers", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> MaxMembers
        ///  The max number of members for the society at one time.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U32> MaxMembers(CancellationToken token)
        {
            string parameters = SocietyStorage.MaxMembersParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U32>(parameters, token);
        }
    }
    
    public sealed class SocietyCalls
    {
        
        /// <summary>
        /// >> bid
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Bid(SubstrateNetApi.Model.Types.Primitive.U128 value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(value.Encode());
            return new Method(26, "Society", 0, "bid", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> unbid
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Unbid(SubstrateNetApi.Model.Types.Primitive.U32 pos)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(pos.Encode());
            return new Method(26, "Society", 1, "unbid", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> vouch
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Vouch(SubstrateNetApi.Model.SpCore.AccountId32 who, SubstrateNetApi.Model.Types.Primitive.U128 value, SubstrateNetApi.Model.Types.Primitive.U128 tip)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(tip.Encode());
            return new Method(26, "Society", 2, "vouch", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> unvouch
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Unvouch(SubstrateNetApi.Model.Types.Primitive.U32 pos)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(pos.Encode());
            return new Method(26, "Society", 3, "unvouch", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> vote
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Vote(SubstrateNetApi.Model.SpRuntime.EnumMultiAddress candidate, SubstrateNetApi.Model.Types.Primitive.Bool approve)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(candidate.Encode());
            byteArray.AddRange(approve.Encode());
            return new Method(26, "Society", 4, "vote", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> defender_vote
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method DefenderVote(SubstrateNetApi.Model.Types.Primitive.Bool approve)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(approve.Encode());
            return new Method(26, "Society", 5, "defender_vote", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> payout
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Payout()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(26, "Society", 6, "payout", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> found
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Found(SubstrateNetApi.Model.SpCore.AccountId32 founder, SubstrateNetApi.Model.Types.Primitive.U32 max_members, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> rules)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(founder.Encode());
            byteArray.AddRange(max_members.Encode());
            byteArray.AddRange(rules.Encode());
            return new Method(26, "Society", 7, "found", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> unfound
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Unfound()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(26, "Society", 8, "unfound", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> judge_suspended_member
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method JudgeSuspendedMember(SubstrateNetApi.Model.SpCore.AccountId32 who, SubstrateNetApi.Model.Types.Primitive.Bool forgive)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(forgive.Encode());
            return new Method(26, "Society", 9, "judge_suspended_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> judge_suspended_candidate
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method JudgeSuspendedCandidate(SubstrateNetApi.Model.SpCore.AccountId32 who, SubstrateNetApi.Model.PalletSociety.EnumJudgement judgement)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(judgement.Encode());
            return new Method(26, "Society", 10, "judge_suspended_candidate", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_max_members
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetMaxMembers(SubstrateNetApi.Model.Types.Primitive.U32 max)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(max.Encode());
            return new Method(26, "Society", 11, "set_max_members", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> Founded
    /// The society is founded by the given identity. \[founder\]
    /// </summary>
    public sealed class EventFounded : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> Bid
    /// A membership bid just happened. The given account is the candidate's ID and their offer
    /// is the second. \[candidate_id, offer\]
    /// </summary>
    public sealed class EventBid : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.U128>
    {
    }
    
    /// <summary>
    /// >> Vouch
    /// A membership bid just happened by vouching. The given account is the candidate's ID and
    /// their offer is the second. The vouching party is the third. \[candidate_id, offer,
    /// vouching\]
    /// </summary>
    public sealed class EventVouch : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.U128, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> AutoUnbid
    /// A \[candidate\] was dropped (due to an excess of bids in the system).
    /// </summary>
    public sealed class EventAutoUnbid : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> Unbid
    /// A \[candidate\] was dropped (by their request).
    /// </summary>
    public sealed class EventUnbid : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> Unvouch
    /// A \[candidate\] was dropped (by request of who vouched for them).
    /// </summary>
    public sealed class EventUnvouch : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> Inducted
    /// A group of candidates have been inducted. The batch's primary is the first value, the
    /// batch in full is the second. \[primary, candidates\]
    /// </summary>
    public sealed class EventInducted : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32, BaseVec<SubstrateNetApi.Model.SpCore.AccountId32>>
    {
    }
    
    /// <summary>
    /// >> SuspendedMemberJudgement
    /// A suspended member has been judged. \[who, judged\]
    /// </summary>
    public sealed class EventSuspendedMemberJudgement : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.Bool>
    {
    }
    
    /// <summary>
    /// >> CandidateSuspended
    /// A \[candidate\] has been suspended
    /// </summary>
    public sealed class EventCandidateSuspended : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> MemberSuspended
    /// A \[member\] has been suspended
    /// </summary>
    public sealed class EventMemberSuspended : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> Challenged
    /// A \[member\] has been challenged
    /// </summary>
    public sealed class EventChallenged : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> Vote
    /// A vote has been placed \[candidate, voter, vote\]
    /// </summary>
    public sealed class EventVote : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.Bool>
    {
    }
    
    /// <summary>
    /// >> DefenderVote
    /// A vote has been placed for a defending member \[voter, vote\]
    /// </summary>
    public sealed class EventDefenderVote : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.Bool>
    {
    }
    
    /// <summary>
    /// >> NewMaxMembers
    /// A new \[max\] member count has been set
    /// </summary>
    public sealed class EventNewMaxMembers : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    /// <summary>
    /// >> Unfounded
    /// Society is unfounded. \[founder\]
    /// </summary>
    public sealed class EventUnfounded : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> Deposit
    /// Some funds were deposited into the society account. \[value\]
    /// </summary>
    public sealed class EventDeposit : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U128>
    {
    }
    
    public enum SocietyErrors
    {
        
        /// <summary>
        /// >> BadPosition
        /// An incorrect position was provided.
        /// </summary>
        BadPosition,
        
        /// <summary>
        /// >> NotMember
        /// User is not a member.
        /// </summary>
        NotMember,
        
        /// <summary>
        /// >> AlreadyMember
        /// User is already a member.
        /// </summary>
        AlreadyMember,
        
        /// <summary>
        /// >> Suspended
        /// User is suspended.
        /// </summary>
        Suspended,
        
        /// <summary>
        /// >> NotSuspended
        /// User is not suspended.
        /// </summary>
        NotSuspended,
        
        /// <summary>
        /// >> NoPayout
        /// Nothing to payout.
        /// </summary>
        NoPayout,
        
        /// <summary>
        /// >> AlreadyFounded
        /// Society already founded.
        /// </summary>
        AlreadyFounded,
        
        /// <summary>
        /// >> InsufficientPot
        /// Not enough in pot to accept candidate.
        /// </summary>
        InsufficientPot,
        
        /// <summary>
        /// >> AlreadyVouching
        /// Member is already vouching or banned from vouching again.
        /// </summary>
        AlreadyVouching,
        
        /// <summary>
        /// >> NotVouching
        /// Member is not vouching.
        /// </summary>
        NotVouching,
        
        /// <summary>
        /// >> Head
        /// Cannot remove the head of the chain.
        /// </summary>
        Head,
        
        /// <summary>
        /// >> Founder
        /// Cannot remove the founder.
        /// </summary>
        Founder,
        
        /// <summary>
        /// >> AlreadyBid
        /// User has already made a bid.
        /// </summary>
        AlreadyBid,
        
        /// <summary>
        /// >> AlreadyCandidate
        /// User is already a candidate.
        /// </summary>
        AlreadyCandidate,
        
        /// <summary>
        /// >> NotCandidate
        /// User is not a candidate.
        /// </summary>
        NotCandidate,
        
        /// <summary>
        /// >> MaxMembers
        /// Too many members in the society.
        /// </summary>
        MaxMembers,
        
        /// <summary>
        /// >> NotFounder
        /// The caller is not the founder.
        /// </summary>
        NotFounder,
        
        /// <summary>
        /// >> NotHead
        /// The caller is not the head.
        /// </summary>
        NotHead,
    }
}
