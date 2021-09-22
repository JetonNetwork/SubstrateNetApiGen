//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Meta;
using SubstrateNetApi.Model.PalletAuthorship;
using SubstrateNetApi.Model.SpCore;
using SubstrateNetApi.Model.Types;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNetApi.Model.PalletAuthorship
{
    
    
    public sealed class PalletAuthorshipStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateNetApi.SubstrateClient _client;
        
        public PalletAuthorshipStorage(SubstrateNetApi.SubstrateClient client)
        {
            this._client = client;
        }
        
        /// <summary>
        /// >> Uncles
        /// </summary>
        public async Task<BaseVec<SubstrateNetApi.Model.PalletAuthorship.EnumUncleEntryItem>> Uncles(CancellationToken token)
        {
            var parameters = RequestGenerator.GetStorage("Authorship", "Uncles", Storage.Type.Plain);
            return await _client.GetStorageAsync<BaseVec<SubstrateNetApi.Model.PalletAuthorship.EnumUncleEntryItem>>(parameters, token);
        }
        
        /// <summary>
        /// >> Author
        /// </summary>
        public async Task<SubstrateNetApi.Model.SpCore.AccountId32> Author(CancellationToken token)
        {
            var parameters = RequestGenerator.GetStorage("Authorship", "Author", Storage.Type.Plain);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.SpCore.AccountId32>(parameters, token);
        }
        
        /// <summary>
        /// >> DidSetUncles
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.Bool> DidSetUncles(CancellationToken token)
        {
            var parameters = RequestGenerator.GetStorage("Authorship", "DidSetUncles", Storage.Type.Plain);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.Bool>(parameters, token);
        }
    }
}