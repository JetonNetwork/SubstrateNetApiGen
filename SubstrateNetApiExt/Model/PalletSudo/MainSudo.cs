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
using SubstrateNetApi.Model.NodeRuntime;
using SubstrateNetApi.Model.SpCore;
using SubstrateNetApi.Model.SpRuntime;
using SubstrateNetApi.Model.Types;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNetApi.Model.PalletSudo
{
    
    
    public sealed class SudoStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public SudoStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Sudo", "Key"), new System.Tuple<SubstrateNetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNetApi.Model.SpCore.AccountId32)));
        }
        
        /// <summary>
        /// >> KeyParams
        ///  The `AccountId` of the sudo key.
        /// </summary>
        public static string KeyParams()
        {
            return RequestGenerator.GetStorage("Sudo", "Key", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Key
        ///  The `AccountId` of the sudo key.
        /// </summary>
        public async Task<SubstrateNetApi.Model.SpCore.AccountId32> Key(CancellationToken token)
        {
            string parameters = SudoStorage.KeyParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.SpCore.AccountId32>(parameters, token);
        }
    }
    
    public sealed class SudoCalls
    {
        
        /// <summary>
        /// >> sudo
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Sudo(SubstrateNetApi.Model.NodeRuntime.EnumNodeCall call)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(call.Encode());
            return new Method(19, "Sudo", 0, "sudo", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> sudo_unchecked_weight
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SudoUncheckedWeight(SubstrateNetApi.Model.NodeRuntime.EnumNodeCall call, SubstrateNetApi.Model.Types.Primitive.U64 weight)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(call.Encode());
            byteArray.AddRange(weight.Encode());
            return new Method(19, "Sudo", 1, "sudo_unchecked_weight", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_key
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetKey(SubstrateNetApi.Model.SpRuntime.EnumMultiAddress @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(19, "Sudo", 2, "set_key", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> sudo_as
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SudoAs(SubstrateNetApi.Model.SpRuntime.EnumMultiAddress who, SubstrateNetApi.Model.NodeRuntime.EnumNodeCall call)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(call.Encode());
            return new Method(19, "Sudo", 3, "sudo_as", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> Sudid
    /// A sudo just took place. \[result\]
    /// </summary>
    public sealed class EventSudid : BaseTuple<BaseTuple<BaseTuple,  SubstrateNetApi.Model.SpRuntime.EnumDispatchError>>
    {
    }
    
    /// <summary>
    /// >> KeyChanged
    /// The \[sudoer\] just switched identity; the old key is supplied.
    /// </summary>
    public sealed class EventKeyChanged : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> SudoAsDone
    /// A sudo just took place. \[result\]
    /// </summary>
    public sealed class EventSudoAsDone : BaseTuple<BaseTuple<BaseTuple,  SubstrateNetApi.Model.SpRuntime.EnumDispatchError>>
    {
    }
    
    public enum SudoErrors
    {
        
        /// <summary>
        /// >> RequireSudo
        /// Sender must be the Sudo account
        /// </summary>
        RequireSudo,
    }
}
