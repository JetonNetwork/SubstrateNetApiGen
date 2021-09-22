//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Base;
using SubstrateNetApi.Model.FrameSupport;
using SubstrateNetApi.Model.Meta;
using SubstrateNetApi.Model.PalletElectionProviderMultiPhase;
using SubstrateNetApi.Model.Types;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNetApi.Model.PalletElectionProviderMultiPhase
{
    
    
    public sealed class PalletElectionProviderMultiPhaseStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateNetApi.SubstrateClient _client;
        
        public PalletElectionProviderMultiPhaseStorage(SubstrateNetApi.SubstrateClient client)
        {
            this._client = client;
        }
        
        /// <summary>
        /// >> Round
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U32> Round(CancellationToken token)
        {
            var parameters = RequestGenerator.GetStorage("ElectionProviderMultiPhase", "Round", Storage.Type.Plain);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> CurrentPhase
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletElectionProviderMultiPhase.EnumPhase> CurrentPhase(CancellationToken token)
        {
            var parameters = RequestGenerator.GetStorage("ElectionProviderMultiPhase", "CurrentPhase", Storage.Type.Plain);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletElectionProviderMultiPhase.EnumPhase>(parameters, token);
        }
        
        /// <summary>
        /// >> QueuedSolution
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletElectionProviderMultiPhase.ReadySolution> QueuedSolution(CancellationToken token)
        {
            var parameters = RequestGenerator.GetStorage("ElectionProviderMultiPhase", "QueuedSolution", Storage.Type.Plain);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletElectionProviderMultiPhase.ReadySolution>(parameters, token);
        }
        
        /// <summary>
        /// >> Snapshot
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletElectionProviderMultiPhase.RoundSnapshot> Snapshot(CancellationToken token)
        {
            var parameters = RequestGenerator.GetStorage("ElectionProviderMultiPhase", "Snapshot", Storage.Type.Plain);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletElectionProviderMultiPhase.RoundSnapshot>(parameters, token);
        }
        
        /// <summary>
        /// >> DesiredTargets
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U32> DesiredTargets(CancellationToken token)
        {
            var parameters = RequestGenerator.GetStorage("ElectionProviderMultiPhase", "DesiredTargets", Storage.Type.Plain);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> SnapshotMetadata
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletElectionProviderMultiPhase.SolutionOrSnapshotSize> SnapshotMetadata(CancellationToken token)
        {
            var parameters = RequestGenerator.GetStorage("ElectionProviderMultiPhase", "SnapshotMetadata", Storage.Type.Plain);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletElectionProviderMultiPhase.SolutionOrSnapshotSize>(parameters, token);
        }
        
        /// <summary>
        /// >> SignedSubmissionNextIndex
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U32> SignedSubmissionNextIndex(CancellationToken token)
        {
            var parameters = RequestGenerator.GetStorage("ElectionProviderMultiPhase", "SignedSubmissionNextIndex", Storage.Type.Plain);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> SignedSubmissionIndices
        /// </summary>
        public async Task<SubstrateNetApi.Model.FrameSupport.BoundedBTreeMap> SignedSubmissionIndices(CancellationToken token)
        {
            var parameters = RequestGenerator.GetStorage("ElectionProviderMultiPhase", "SignedSubmissionIndices", Storage.Type.Plain);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.FrameSupport.BoundedBTreeMap>(parameters, token);
        }
        
        /// <summary>
        /// >> SignedSubmissionsMap
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletElectionProviderMultiPhase.SignedSubmission> SignedSubmissionsMap(SubstrateNetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            var keyParams = new IType[] { key };
            var parameters = RequestGenerator.GetStorage("ElectionProviderMultiPhase", "SignedSubmissionsMap", Storage.Type.Map, new[] {Storage.Hasher.Twox64Concat}, keyParams);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletElectionProviderMultiPhase.SignedSubmission>(parameters, token);
        }
        
        /// <summary>
        /// >> MinimumUntrustedScore
        /// </summary>
        public async Task<SubstrateNetApi.Model.Base.Arr3U128> MinimumUntrustedScore(CancellationToken token)
        {
            var parameters = RequestGenerator.GetStorage("ElectionProviderMultiPhase", "MinimumUntrustedScore", Storage.Type.Plain);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Base.Arr3U128>(parameters, token);
        }
    }
}
