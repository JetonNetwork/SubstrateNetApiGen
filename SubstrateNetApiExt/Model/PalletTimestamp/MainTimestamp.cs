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
using SubstrateNetApi.Model.Types;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNetApi.Model.PalletTimestamp
{
    
    
    public sealed class TimestampStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public TimestampStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Timestamp", "Now"), new System.Tuple<SubstrateNetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNetApi.Model.Types.Primitive.U64)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Timestamp", "DidUpdate"), new System.Tuple<SubstrateNetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNetApi.Model.Types.Primitive.Bool)));
        }
        
        /// <summary>
        /// >> NowParams
        ///  Current time for the current block.
        /// </summary>
        public static string NowParams()
        {
            return RequestGenerator.GetStorage("Timestamp", "Now", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Now
        ///  Current time for the current block.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U64> Now(CancellationToken token)
        {
            string parameters = TimestampStorage.NowParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U64>(parameters, token);
        }
        
        /// <summary>
        /// >> DidUpdateParams
        ///  Did the timestamp get updated in this block?
        /// </summary>
        public static string DidUpdateParams()
        {
            return RequestGenerator.GetStorage("Timestamp", "DidUpdate", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> DidUpdate
        ///  Did the timestamp get updated in this block?
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.Bool> DidUpdate(CancellationToken token)
        {
            string parameters = TimestampStorage.DidUpdateParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.Bool>(parameters, token);
        }
    }
    
    public sealed class TimestampCalls
    {
        
        /// <summary>
        /// >> set
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Set(BaseCom<SubstrateNetApi.Model.Types.Primitive.U64> now)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(now.Encode());
            return new Method(3, "Timestamp", 0, "set", byteArray.ToArray());
        }
    }
}
