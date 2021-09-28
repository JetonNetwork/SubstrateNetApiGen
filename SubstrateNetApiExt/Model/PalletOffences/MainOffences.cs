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
using SubstrateNetApi.Model.Meta;
using SubstrateNetApi.Model.PrimitiveTypes;
using SubstrateNetApi.Model.SpStaking;
using SubstrateNetApi.Model.Types;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNetApi.Model.PalletOffences
{
    
    
    public sealed class OffencesStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateNetApi.SubstrateClient _client;
        
        public OffencesStorage(SubstrateNetApi.SubstrateClient client)
        {
            this._client = client;
        }
        
        /// <summary>
        /// >> ReportsParams
        ///  The primary structure that holds all offence records keyed by report identifiers.
        /// </summary>
        public static string ReportsParams(SubstrateNetApi.Model.PrimitiveTypes.H256 key)
        {
            return RequestGenerator.GetStorage("Offences", "Reports", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Reports
        ///  The primary structure that holds all offence records keyed by report identifiers.
        /// </summary>
        public async Task<SubstrateNetApi.Model.SpStaking.OffenceDetails> Reports(SubstrateNetApi.Model.PrimitiveTypes.H256 key, CancellationToken token)
        {
            string parameters = OffencesStorage.ReportsParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.SpStaking.OffenceDetails>(parameters, token);
        }
        
        /// <summary>
        /// >> ConcurrentReportsIndexParams
        ///  A vector of reports of the same kind that happened at the same time slot.
        /// </summary>
        public static string ConcurrentReportsIndexParams(BaseTuple<SubstrateNetApi.Model.Base.Arr16U8,BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>> key)
        {
            return RequestGenerator.GetStorage("Offences", "ConcurrentReportsIndex", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ConcurrentReportsIndex
        ///  A vector of reports of the same kind that happened at the same time slot.
        /// </summary>
        public async Task<BaseVec<SubstrateNetApi.Model.PrimitiveTypes.H256>> ConcurrentReportsIndex(BaseTuple<SubstrateNetApi.Model.Base.Arr16U8,BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>> key, CancellationToken token)
        {
            string parameters = OffencesStorage.ConcurrentReportsIndexParams(key);
            return await _client.GetStorageAsync<BaseVec<SubstrateNetApi.Model.PrimitiveTypes.H256>>(parameters, token);
        }
        
        /// <summary>
        /// >> ReportsByKindIndexParams
        ///  Enumerates all reports of a kind along with the time they happened.
        /// 
        ///  All reports are sorted by the time of offence.
        /// 
        ///  Note that the actual type of this mapping is `Vec<u8>`, this is because values of
        ///  different types are not supported at the moment so we are doing the manual serialization.
        /// </summary>
        public static string ReportsByKindIndexParams(SubstrateNetApi.Model.Base.Arr16U8 key)
        {
            return RequestGenerator.GetStorage("Offences", "ReportsByKindIndex", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ReportsByKindIndex
        ///  Enumerates all reports of a kind along with the time they happened.
        /// 
        ///  All reports are sorted by the time of offence.
        /// 
        ///  Note that the actual type of this mapping is `Vec<u8>`, this is because values of
        ///  different types are not supported at the moment so we are doing the manual serialization.
        /// </summary>
        public async Task<BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>> ReportsByKindIndex(SubstrateNetApi.Model.Base.Arr16U8 key, CancellationToken token)
        {
            string parameters = OffencesStorage.ReportsByKindIndexParams(key);
            return await _client.GetStorageAsync<BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>>(parameters, token);
        }
    }
    
    public sealed class OffencesCalls
    {
    }
    
    /// <summary>
    /// >> Offence
    /// There is an offence reported of the given `kind` happened at the `session_index` and
    /// (kind-specific) time slot. This event is not deposited for duplicate slashes.
    /// \[kind, timeslot\].
    /// </summary>
    public sealed class EventOffence : BaseTuple<SubstrateNetApi.Model.Base.Arr16U8, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>>
    {
    }
}