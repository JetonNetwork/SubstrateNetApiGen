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
using SubstrateNetApi.Model.PalletAssets;
using SubstrateNetApi.Model.SpCore;
using SubstrateNetApi.Model.SpRuntime;
using SubstrateNetApi.Model.Types;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNetApi.Model.PalletAssets
{
    
    
    public sealed class AssetsStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateNetApi.SubstrateClient _client;
        
        public AssetsStorage(SubstrateNetApi.SubstrateClient client)
        {
            this._client = client;
        }
        
        /// <summary>
        /// >> AssetParams
        ///  Details of an asset.
        /// </summary>
        public static string AssetParams(SubstrateNetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("Assets", "Asset", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Asset
        ///  Details of an asset.
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletAssets.AssetDetails> Asset(SubstrateNetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = AssetsStorage.AssetParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletAssets.AssetDetails>(parameters, token);
        }
        
        /// <summary>
        /// >> AccountParams
        ///  The number of units of assets held by any given account.
        /// </summary>
        public static string AccountParams(BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.SpCore.AccountId32> key)
        {
            return RequestGenerator.GetStorage("Assets", "Account", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Account
        ///  The number of units of assets held by any given account.
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletAssets.AssetBalance> Account(BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.SpCore.AccountId32> key, CancellationToken token)
        {
            string parameters = AssetsStorage.AccountParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletAssets.AssetBalance>(parameters, token);
        }
        
        /// <summary>
        /// >> ApprovalsParams
        ///  Approved balance transfers. First balance is the amount approved for transfer. Second
        ///  is the amount of `T::Currency` reserved for storing this.
        ///  First key is the asset ID, second key is the owner and third key is the delegate.
        /// </summary>
        public static string ApprovalsParams(BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.SpCore.AccountId32> key)
        {
            return RequestGenerator.GetStorage("Assets", "Approvals", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Approvals
        ///  Approved balance transfers. First balance is the amount approved for transfer. Second
        ///  is the amount of `T::Currency` reserved for storing this.
        ///  First key is the asset ID, second key is the owner and third key is the delegate.
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletAssets.Approval> Approvals(BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32,SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.SpCore.AccountId32> key, CancellationToken token)
        {
            string parameters = AssetsStorage.ApprovalsParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletAssets.Approval>(parameters, token);
        }
        
        /// <summary>
        /// >> MetadataParams
        ///  Metadata of an asset.
        /// </summary>
        public static string MetadataParams(SubstrateNetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("Assets", "Metadata", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Metadata
        ///  Metadata of an asset.
        /// </summary>
        public async Task<SubstrateNetApi.Model.PalletAssets.AssetMetadata> Metadata(SubstrateNetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = AssetsStorage.MetadataParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PalletAssets.AssetMetadata>(parameters, token);
        }
    }
    
    public sealed class AssetsCalls
    {
        
        /// <summary>
        /// >> create
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Create(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress admin, SubstrateNetApi.Model.Types.Primitive.U64 min_balance)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            byteArray.AddRange(admin.Encode());
            byteArray.AddRange(min_balance.Encode());
            return new Method(34, "Assets", 0, "create", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_create
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceCreate(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress owner, SubstrateNetApi.Model.Types.Primitive.Bool is_sufficient, BaseCom<SubstrateNetApi.Model.Types.Primitive.U64> min_balance)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            byteArray.AddRange(owner.Encode());
            byteArray.AddRange(is_sufficient.Encode());
            byteArray.AddRange(min_balance.Encode());
            return new Method(34, "Assets", 1, "force_create", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> destroy
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Destroy(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id, SubstrateNetApi.Model.PalletAssets.DestroyWitness witness)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            byteArray.AddRange(witness.Encode());
            return new Method(34, "Assets", 2, "destroy", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> mint
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Mint(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress beneficiary, BaseCom<SubstrateNetApi.Model.Types.Primitive.U64> amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            byteArray.AddRange(beneficiary.Encode());
            byteArray.AddRange(amount.Encode());
            return new Method(34, "Assets", 3, "mint", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> burn
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Burn(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress who, BaseCom<SubstrateNetApi.Model.Types.Primitive.U64> amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(amount.Encode());
            return new Method(34, "Assets", 4, "burn", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Transfer(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress target, BaseCom<SubstrateNetApi.Model.Types.Primitive.U64> amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            byteArray.AddRange(target.Encode());
            byteArray.AddRange(amount.Encode());
            return new Method(34, "Assets", 5, "transfer", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer_keep_alive
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method TransferKeepAlive(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress target, BaseCom<SubstrateNetApi.Model.Types.Primitive.U64> amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            byteArray.AddRange(target.Encode());
            byteArray.AddRange(amount.Encode());
            return new Method(34, "Assets", 6, "transfer_keep_alive", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_transfer
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceTransfer(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress source, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress dest, BaseCom<SubstrateNetApi.Model.Types.Primitive.U64> amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            byteArray.AddRange(source.Encode());
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(amount.Encode());
            return new Method(34, "Assets", 7, "force_transfer", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> freeze
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Freeze(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            byteArray.AddRange(who.Encode());
            return new Method(34, "Assets", 8, "freeze", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> thaw
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Thaw(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            byteArray.AddRange(who.Encode());
            return new Method(34, "Assets", 9, "thaw", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> freeze_asset
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method FreezeAsset(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            return new Method(34, "Assets", 10, "freeze_asset", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> thaw_asset
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ThawAsset(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            return new Method(34, "Assets", 11, "thaw_asset", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer_ownership
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method TransferOwnership(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress owner)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            byteArray.AddRange(owner.Encode());
            return new Method(34, "Assets", 12, "transfer_ownership", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_team
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetTeam(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress issuer, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress admin, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress freezer)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            byteArray.AddRange(issuer.Encode());
            byteArray.AddRange(admin.Encode());
            byteArray.AddRange(freezer.Encode());
            return new Method(34, "Assets", 13, "set_team", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_metadata
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetMetadata(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> name, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> symbol, SubstrateNetApi.Model.Types.Primitive.U8 decimals)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            byteArray.AddRange(name.Encode());
            byteArray.AddRange(symbol.Encode());
            byteArray.AddRange(decimals.Encode());
            return new Method(34, "Assets", 14, "set_metadata", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> clear_metadata
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ClearMetadata(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            return new Method(34, "Assets", 15, "clear_metadata", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_set_metadata
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceSetMetadata(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> name, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> symbol, SubstrateNetApi.Model.Types.Primitive.U8 decimals, SubstrateNetApi.Model.Types.Primitive.Bool is_frozen)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            byteArray.AddRange(name.Encode());
            byteArray.AddRange(symbol.Encode());
            byteArray.AddRange(decimals.Encode());
            byteArray.AddRange(is_frozen.Encode());
            return new Method(34, "Assets", 16, "force_set_metadata", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_clear_metadata
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceClearMetadata(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            return new Method(34, "Assets", 17, "force_clear_metadata", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_asset_status
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceAssetStatus(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress owner, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress issuer, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress admin, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress freezer, BaseCom<SubstrateNetApi.Model.Types.Primitive.U64> min_balance, SubstrateNetApi.Model.Types.Primitive.Bool is_sufficient, SubstrateNetApi.Model.Types.Primitive.Bool is_frozen)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            byteArray.AddRange(owner.Encode());
            byteArray.AddRange(issuer.Encode());
            byteArray.AddRange(admin.Encode());
            byteArray.AddRange(freezer.Encode());
            byteArray.AddRange(min_balance.Encode());
            byteArray.AddRange(is_sufficient.Encode());
            byteArray.AddRange(is_frozen.Encode());
            return new Method(34, "Assets", 18, "force_asset_status", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> approve_transfer
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ApproveTransfer(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress @delegate, BaseCom<SubstrateNetApi.Model.Types.Primitive.U64> amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            byteArray.AddRange(@delegate.Encode());
            byteArray.AddRange(amount.Encode());
            return new Method(34, "Assets", 19, "approve_transfer", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> cancel_approval
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method CancelApproval(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress @delegate)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            byteArray.AddRange(@delegate.Encode());
            return new Method(34, "Assets", 20, "cancel_approval", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_cancel_approval
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceCancelApproval(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress owner, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress @delegate)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            byteArray.AddRange(owner.Encode());
            byteArray.AddRange(@delegate.Encode());
            return new Method(34, "Assets", 21, "force_cancel_approval", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer_approved
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method TransferApproved(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> id, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress owner, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress destination, BaseCom<SubstrateNetApi.Model.Types.Primitive.U64> amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            byteArray.AddRange(owner.Encode());
            byteArray.AddRange(destination.Encode());
            byteArray.AddRange(amount.Encode());
            return new Method(34, "Assets", 22, "transfer_approved", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> Created
    /// Some asset class was created. \[asset_id, creator, owner\]
    /// </summary>
    public sealed class EventCreated : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> Issued
    /// Some assets were issued. \[asset_id, owner, total_supply\]
    /// </summary>
    public sealed class EventIssued : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.U64>
    {
    }
    
    /// <summary>
    /// >> Transferred
    /// Some assets were transferred. \[asset_id, from, to, amount\]
    /// </summary>
    public sealed class EventTransferred : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.U64>
    {
    }
    
    /// <summary>
    /// >> Burned
    /// Some assets were destroyed. \[asset_id, owner, balance\]
    /// </summary>
    public sealed class EventBurned : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.U64>
    {
    }
    
    /// <summary>
    /// >> TeamChanged
    /// The management team changed \[asset_id, issuer, admin, freezer\]
    /// </summary>
    public sealed class EventTeamChanged : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> OwnerChanged
    /// The owner changed \[asset_id, owner\]
    /// </summary>
    public sealed class EventOwnerChanged : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> Frozen
    /// Some account `who` was frozen. \[asset_id, who\]
    /// </summary>
    public sealed class EventFrozen : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> Thawed
    /// Some account `who` was thawed. \[asset_id, who\]
    /// </summary>
    public sealed class EventThawed : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> AssetFrozen
    /// Some asset `asset_id` was frozen. \[asset_id\]
    /// </summary>
    public sealed class EventAssetFrozen : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    /// <summary>
    /// >> AssetThawed
    /// Some asset `asset_id` was thawed. \[asset_id\]
    /// </summary>
    public sealed class EventAssetThawed : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    /// <summary>
    /// >> Destroyed
    /// An asset class was destroyed.
    /// </summary>
    public sealed class EventDestroyed : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    /// <summary>
    /// >> ForceCreated
    /// Some asset class was force-created. \[asset_id, owner\]
    /// </summary>
    public sealed class EventForceCreated : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> MetadataSet
    /// New metadata has been set for an asset. \[asset_id, name, symbol, decimals, is_frozen\]
    /// </summary>
    public sealed class EventMetadataSet : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>, SubstrateNetApi.Model.Types.Primitive.U8, SubstrateNetApi.Model.Types.Primitive.Bool>
    {
    }
    
    /// <summary>
    /// >> MetadataCleared
    /// Metadata has been cleared for an asset. \[asset_id\]
    /// </summary>
    public sealed class EventMetadataCleared : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    /// <summary>
    /// >> ApprovedTransfer
    /// (Additional) funds have been approved for transfer to a destination account.
    /// \[asset_id, source, delegate, amount\]
    /// </summary>
    public sealed class EventApprovedTransfer : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.U64>
    {
    }
    
    /// <summary>
    /// >> ApprovalCancelled
    /// An approval for account `delegate` was cancelled by `owner`.
    /// \[id, owner, delegate\]
    /// </summary>
    public sealed class EventApprovalCancelled : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> TransferredApproved
    /// An `amount` was transferred in its entirety from `owner` to `destination` by
    /// the approved `delegate`.
    /// \[id, owner, delegate, destination\]
    /// </summary>
    public sealed class EventTransferredApproved : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.U64>
    {
    }
    
    /// <summary>
    /// >> AssetStatusChanged
    /// An asset has had its attributes changed by the `Force` origin.
    /// \[id\]
    /// </summary>
    public sealed class EventAssetStatusChanged : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    public enum AssetsErrors
    {
        
        /// <summary>
        /// >> BalanceLow
        /// Account balance must be greater than or equal to the transfer amount.
        /// </summary>
        BalanceLow,
        
        /// <summary>
        /// >> BalanceZero
        /// Balance should be non-zero.
        /// </summary>
        BalanceZero,
        
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
        /// >> Frozen
        /// The origin account is frozen.
        /// </summary>
        Frozen,
        
        /// <summary>
        /// >> InUse
        /// The asset ID is already taken.
        /// </summary>
        InUse,
        
        /// <summary>
        /// >> BadWitness
        /// Invalid witness data given.
        /// </summary>
        BadWitness,
        
        /// <summary>
        /// >> MinBalanceZero
        /// Minimum balance should be non-zero.
        /// </summary>
        MinBalanceZero,
        
        /// <summary>
        /// >> NoProvider
        /// No provider reference exists to allow a non-zero balance of a non-self-sufficient
        /// asset.
        /// </summary>
        NoProvider,
        
        /// <summary>
        /// >> BadMetadata
        /// Invalid metadata given.
        /// </summary>
        BadMetadata,
        
        /// <summary>
        /// >> Unapproved
        /// No approval exists that would allow the transfer.
        /// </summary>
        Unapproved,
        
        /// <summary>
        /// >> WouldDie
        /// The source account would not survive the transfer and it needs to stay alive.
        /// </summary>
        WouldDie,
    }
}
