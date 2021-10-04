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
using SubstrateNetApi.Model.PalletUniques;
using SubstrateNetApi.Model.SpCore;
using SubstrateNetApi.Model.SpRuntime;
using SubstrateNetApi.Model.Types;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNetApi.Model.PalletUniques
{
    
    
    public sealed class UniquesStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public UniquesStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Uniques", "Class"), new System.Tuple<SubstrateNetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                            SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(SubstrateNetApi.Model.Types.Primitive.U32), typeof(SubstrateNetApi.Model.PalletUniques.ClassDetails)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Uniques", "Account"), new System.Tuple<SubstrateNetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                            SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                            SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                            SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U32>), typeof(BaseTuple)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Uniques", "Asset"), new System.Tuple<SubstrateNetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                            SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                            SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U32>), typeof(SubstrateNetApi.Model.PalletUniques.InstanceDetails)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Uniques", "ClassMetadataOf"), new System.Tuple<SubstrateNetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                            SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(SubstrateNetApi.Model.Types.Primitive.U32), typeof(SubstrateNetApi.Model.PalletUniques.ClassMetadata)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Uniques", "InstanceMetadataOf"), new System.Tuple<SubstrateNetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                            SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                            SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U32>), typeof(SubstrateNetApi.Model.PalletUniques.InstanceMetadata)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Uniques", "Attribute"), new System.Tuple<SubstrateNetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                            SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                            SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                            SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,BaseOpt<SubstrateNetApi.Model.Types.Primitive.U32>,SubstrateNetApi.Model.FrameSupport.BoundedVec>), typeof(BaseTuple<SubstrateNetApi.Model.FrameSupport.BoundedVec,SubstrateNetApi.Model.Types.Primitive.U128>)));
        }
        
        /// <summary>
        /// >> ClassParams
        ///  Details of an asset class.
        /// </summary>
        public static string ClassParams(SubstrateNetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("Uniques", "Class", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Class
        ///  Details of an asset class.
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletUniques.ClassDetails> Class(SubstrateNetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = UniquesStorage.ClassParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletUniques.ClassDetails>(parameters, token);
        }
        
        /// <summary>
        /// >> AccountParams
        ///  The assets held by any given account; set out this way so that assets owned by a single
        ///  account can be enumerated.
        /// </summary>
        public static string AccountParams(BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U32> key)
        {
            return RequestGenerator.GetStorage("Uniques", "Account", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Account
        ///  The assets held by any given account; set out this way so that assets owned by a single
        ///  account can be enumerated.
        /// </summary>
        public async Task<BaseTuple> Account(BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U32> key, CancellationToken token)
        {
            string parameters = UniquesStorage.AccountParams(key);
            return await _client.GetStorageAsync<BaseTuple>(parameters, token);
        }
        
        /// <summary>
        /// >> AssetParams
        ///  The assets in existence and their ownership details.
        /// </summary>
        public static string AssetParams(BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U32> key)
        {
            return RequestGenerator.GetStorage("Uniques", "Asset", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Asset
        ///  The assets in existence and their ownership details.
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletUniques.InstanceDetails> Asset(BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U32> key, CancellationToken token)
        {
            string parameters = UniquesStorage.AssetParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletUniques.InstanceDetails>(parameters, token);
        }
        
        /// <summary>
        /// >> ClassMetadataOfParams
        ///  Metadata of an asset class.
        /// </summary>
        public static string ClassMetadataOfParams(SubstrateNetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("Uniques", "ClassMetadataOf", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ClassMetadataOf
        ///  Metadata of an asset class.
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletUniques.ClassMetadata> ClassMetadataOf(SubstrateNetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = UniquesStorage.ClassMetadataOfParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletUniques.ClassMetadata>(parameters, token);
        }
        
        /// <summary>
        /// >> InstanceMetadataOfParams
        ///  Metadata of an asset instance.
        /// </summary>
        public static string InstanceMetadataOfParams(BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U32> key)
        {
            return RequestGenerator.GetStorage("Uniques", "InstanceMetadataOf", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> InstanceMetadataOf
        ///  Metadata of an asset instance.
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletUniques.InstanceMetadata> InstanceMetadataOf(BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.Types.Primitive.U32> key, CancellationToken token)
        {
            string parameters = UniquesStorage.InstanceMetadataOfParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletUniques.InstanceMetadata>(parameters, token);
        }
        
        /// <summary>
        /// >> AttributeParams
        ///  Metadata of an asset class.
        /// </summary>
        public static string AttributeParams(BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,BaseOpt<SubstrateNetApi.Model.Types.Primitive.U32>,SubstrateNetApi.Model.FrameSupport.BoundedVec> key)
        {
            return RequestGenerator.GetStorage("Uniques", "Attribute", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Attribute
        ///  Metadata of an asset class.
        /// </summary>
        public async Task<BaseTuple<SubstrateNetApi.Model.FrameSupport.BoundedVec,SubstrateNetApi.Model.Types.Primitive.U128>> Attribute(BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,BaseOpt<SubstrateNetApi.Model.Types.Primitive.U32>,SubstrateNetApi.Model.FrameSupport.BoundedVec> key, CancellationToken token)
        {
            string parameters = UniquesStorage.AttributeParams(key);
            return await _client.GetStorageAsync<BaseTuple<SubstrateNetApi.Model.FrameSupport.BoundedVec,SubstrateNetApi.Model.Types.Primitive.U128>>(parameters, token);
        }
    }
    
    public sealed class UniquesCalls
    {
        
        /// <summary>
        /// >> create
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Create(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress admin)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(admin.Encode());
            return new Method(38, "Uniques", 0, "create", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_create
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceCreate(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress owner, SubstrateNetApi.Model.Types.Primitive.Bool free_holding)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(owner.Encode());
            byteArray.AddRange(free_holding.Encode());
            return new Method(38, "Uniques", 1, "force_create", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> destroy
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Destroy(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class, SubstrateNetApi.Model.PalletUniques.DestroyWitness witness)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(witness.Encode());
            return new Method(38, "Uniques", 2, "destroy", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> mint
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Mint(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class, BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> instance, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress owner)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(instance.Encode());
            byteArray.AddRange(owner.Encode());
            return new Method(38, "Uniques", 3, "mint", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> burn
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Burn(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class, BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> instance, BaseOpt<SubstrateNetApi.Model.SpRuntime.EnumMultiAddress> check_owner)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(instance.Encode());
            byteArray.AddRange(check_owner.Encode());
            return new Method(38, "Uniques", 4, "burn", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Transfer(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class, BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> instance, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress dest)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(instance.Encode());
            byteArray.AddRange(dest.Encode());
            return new Method(38, "Uniques", 5, "transfer", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> redeposit
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Redeposit(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class, BaseVec<SubstrateNetApi.Model.Types.Primitive.U32> instances)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(instances.Encode());
            return new Method(38, "Uniques", 6, "redeposit", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> freeze
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Freeze(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class, BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> instance)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(instance.Encode());
            return new Method(38, "Uniques", 7, "freeze", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> thaw
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Thaw(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class, BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> instance)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(instance.Encode());
            return new Method(38, "Uniques", 8, "thaw", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> freeze_class
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method FreezeClass(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            return new Method(38, "Uniques", 9, "freeze_class", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> thaw_class
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ThawClass(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            return new Method(38, "Uniques", 10, "thaw_class", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer_ownership
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method TransferOwnership(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress owner)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(owner.Encode());
            return new Method(38, "Uniques", 11, "transfer_ownership", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_team
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetTeam(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress issuer, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress admin, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress freezer)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(issuer.Encode());
            byteArray.AddRange(admin.Encode());
            byteArray.AddRange(freezer.Encode());
            return new Method(38, "Uniques", 12, "set_team", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> approve_transfer
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ApproveTransfer(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class, BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> instance, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress @delegate)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(instance.Encode());
            byteArray.AddRange(@delegate.Encode());
            return new Method(38, "Uniques", 13, "approve_transfer", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> cancel_approval
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method CancelApproval(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class, BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> instance, BaseOpt<SubstrateNetApi.Model.SpRuntime.EnumMultiAddress> maybe_check_delegate)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(instance.Encode());
            byteArray.AddRange(maybe_check_delegate.Encode());
            return new Method(38, "Uniques", 14, "cancel_approval", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_asset_status
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceAssetStatus(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress owner, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress issuer, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress admin, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress freezer, SubstrateNetApi.Model.Types.Primitive.Bool free_holding, SubstrateNetApi.Model.Types.Primitive.Bool is_frozen)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(owner.Encode());
            byteArray.AddRange(issuer.Encode());
            byteArray.AddRange(admin.Encode());
            byteArray.AddRange(freezer.Encode());
            byteArray.AddRange(free_holding.Encode());
            byteArray.AddRange(is_frozen.Encode());
            return new Method(38, "Uniques", 15, "force_asset_status", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_attribute
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetAttribute(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class, BaseOpt<SubstrateNetApi.Model.Types.Primitive.U32> maybe_instance, SubstrateNetApi.Model.FrameSupport.BoundedVec key, SubstrateNetApi.Model.FrameSupport.BoundedVec value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(maybe_instance.Encode());
            byteArray.AddRange(key.Encode());
            byteArray.AddRange(value.Encode());
            return new Method(38, "Uniques", 16, "set_attribute", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> clear_attribute
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ClearAttribute(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class, BaseOpt<SubstrateNetApi.Model.Types.Primitive.U32> maybe_instance, SubstrateNetApi.Model.FrameSupport.BoundedVec key)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(maybe_instance.Encode());
            byteArray.AddRange(key.Encode());
            return new Method(38, "Uniques", 17, "clear_attribute", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_metadata
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetMetadata(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class, BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> instance, SubstrateNetApi.Model.FrameSupport.BoundedVec data, SubstrateNetApi.Model.Types.Primitive.Bool is_frozen)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(instance.Encode());
            byteArray.AddRange(data.Encode());
            byteArray.AddRange(is_frozen.Encode());
            return new Method(38, "Uniques", 18, "set_metadata", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> clear_metadata
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ClearMetadata(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class, BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> instance)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(instance.Encode());
            return new Method(38, "Uniques", 19, "clear_metadata", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_class_metadata
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetClassMetadata(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class, SubstrateNetApi.Model.FrameSupport.BoundedVec data, SubstrateNetApi.Model.Types.Primitive.Bool is_frozen)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(data.Encode());
            byteArray.AddRange(is_frozen.Encode());
            return new Method(38, "Uniques", 20, "set_class_metadata", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> clear_class_metadata
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ClearClassMetadata(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @class)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            return new Method(38, "Uniques", 21, "clear_class_metadata", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> Created
    /// An asset class was created. \[ class, creator, owner \]
    /// </summary>
    public sealed class EventCreated : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> ForceCreated
    /// An asset class was force-created. \[ class, owner \]
    /// </summary>
    public sealed class EventForceCreated : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> Destroyed
    /// An asset `class` was destroyed. \[ class \]
    /// </summary>
    public sealed class EventDestroyed : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    /// <summary>
    /// >> Issued
    /// An asset `instance` was issued. \[ class, instance, owner \]
    /// </summary>
    public sealed class EventIssued : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> Transferred
    /// An asset `instance` was transferred. \[ class, instance, from, to \]
    /// </summary>
    public sealed class EventTransferred : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> Burned
    /// An asset `instance` was destroyed. \[ class, instance, owner \]
    /// </summary>
    public sealed class EventBurned : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> Frozen
    /// Some asset `instance` was frozen. \[ class, instance \]
    /// </summary>
    public sealed class EventFrozen : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    /// <summary>
    /// >> Thawed
    /// Some asset `instance` was thawed. \[ class, instance \]
    /// </summary>
    public sealed class EventThawed : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    /// <summary>
    /// >> ClassFrozen
    /// Some asset `class` was frozen. \[ class \]
    /// </summary>
    public sealed class EventClassFrozen : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    /// <summary>
    /// >> ClassThawed
    /// Some asset `class` was thawed. \[ class \]
    /// </summary>
    public sealed class EventClassThawed : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    /// <summary>
    /// >> OwnerChanged
    /// The owner changed \[ class, new_owner \]
    /// </summary>
    public sealed class EventOwnerChanged : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> TeamChanged
    /// The management team changed \[ class, issuer, admin, freezer \]
    /// </summary>
    public sealed class EventTeamChanged : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> ApprovedTransfer
    /// An `instance` of an asset `class` has been approved by the `owner` for transfer by a
    /// `delegate`.
    /// \[ class, instance, owner, delegate \]
    /// </summary>
    public sealed class EventApprovedTransfer : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> ApprovalCancelled
    /// An approval for a `delegate` account to transfer the `instance` of an asset `class` was
    /// cancelled by its `owner`.
    /// \[ class, instance, owner, delegate \]
    /// </summary>
    public sealed class EventApprovalCancelled : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> AssetStatusChanged
    /// An asset `class` has had its attributes changed by the `Force` origin.
    /// \[ class \]
    /// </summary>
    public sealed class EventAssetStatusChanged : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    /// <summary>
    /// >> ClassMetadataSet
    /// New metadata has been set for an asset class. \[ class, data, is_frozen \]
    /// </summary>
    public sealed class EventClassMetadataSet : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.FrameSupport.BoundedVec, SubstrateNetApi.Model.Types.Primitive.Bool>
    {
    }
    
    /// <summary>
    /// >> ClassMetadataCleared
    /// Metadata has been cleared for an asset class. \[ class \]
    /// </summary>
    public sealed class EventClassMetadataCleared : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    /// <summary>
    /// >> MetadataSet
    /// New metadata has been set for an asset instance.
    /// \[ class, instance, data, is_frozen \]
    /// </summary>
    public sealed class EventMetadataSet : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.FrameSupport.BoundedVec, SubstrateNetApi.Model.Types.Primitive.Bool>
    {
    }
    
    /// <summary>
    /// >> MetadataCleared
    /// Metadata has been cleared for an asset instance. \[ class, instance \]
    /// </summary>
    public sealed class EventMetadataCleared : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    /// <summary>
    /// >> Redeposited
    /// Metadata has been cleared for an asset instance. \[ class, successful_instances \]
    /// </summary>
    public sealed class EventRedeposited : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, BaseVec<SubstrateNetApi.Model.Types.Primitive.U32>>
    {
    }
    
    /// <summary>
    /// >> AttributeSet
    /// New attribute metadata has been set for an asset class or instance.
    /// \[ class, maybe_instance, key, value \]
    /// </summary>
    public sealed class EventAttributeSet : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, BaseOpt<SubstrateNetApi.Model.Types.Primitive.U32>, SubstrateNetApi.Model.FrameSupport.BoundedVec, SubstrateNetApi.Model.FrameSupport.BoundedVec>
    {
    }
    
    /// <summary>
    /// >> AttributeCleared
    /// Attribute metadata has been cleared for an asset class or instance.
    /// \[ class, maybe_instance, key, maybe_value \]
    /// </summary>
    public sealed class EventAttributeCleared : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, BaseOpt<SubstrateNetApi.Model.Types.Primitive.U32>, SubstrateNetApi.Model.FrameSupport.BoundedVec>
    {
    }
    
    public enum UniquesErrors
    {
        
        /// <summary>
        /// >> NoPermission
        /// The signing account has no permission to do the operation.
        /// </summary>
        NoPermission,
        
        /// <summary>
        /// >> Unknown
        /// The given asset ID is unknown.
        /// </summary>
        Unknown,
        
        /// <summary>
        /// >> AlreadyExists
        /// The asset instance ID has already been used for an asset.
        /// </summary>
        AlreadyExists,
        
        /// <summary>
        /// >> WrongOwner
        /// The owner turned out to be different to what was expected.
        /// </summary>
        WrongOwner,
        
        /// <summary>
        /// >> BadWitness
        /// Invalid witness data given.
        /// </summary>
        BadWitness,
        
        /// <summary>
        /// >> InUse
        /// The asset ID is already taken.
        /// </summary>
        InUse,
        
        /// <summary>
        /// >> Frozen
        /// The asset instance or class is frozen.
        /// </summary>
        Frozen,
        
        /// <summary>
        /// >> WrongDelegate
        /// The delegate turned out to be different to what was expected.
        /// </summary>
        WrongDelegate,
        
        /// <summary>
        /// >> NoDelegate
        /// There is no delegate approved.
        /// </summary>
        NoDelegate,
        
        /// <summary>
        /// >> Unapproved
        /// No approval exists that would allow the transfer.
        /// </summary>
        Unapproved,
    }
}
