//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Calls;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Composite;
using SubstrateNetApi.Model.Types.Enum;
using SubstrateNetApi.Model.Types.Primitive;
using SubstrateNetApi.Model.Types.Sequence;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.Custom.Calls
{
    
    
    /// <summary>
    /// >> Path: pallet_assets.pallet.Call
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class PalletAssets
    {
        
        /// <summary>
        /// >> Extrinsic: create
        /// Issue a new class of fungible assets from a public origin.
        /// 
        /// This new asset class has no assets initially and its owner is the origin.
        /// 
        /// The origin must be Signed and the sender must have sufficient funds free.
        /// 
        /// Funds of sender are reserved by `AssetDeposit`.
        /// 
        /// Parameters:
        /// - `id`: The identifier of the new asset. This must not be currently in use to identify
        /// an existing asset.
        /// - `admin`: The admin of this class of assets. The admin is the initial address of each
        /// member of the asset class's admin team.
        /// - `min_balance`: The minimum balance of this new asset that any single account must
        /// have. If an account's balance is reduced below this, then it collapses to zero.
        /// 
        /// Emits `Created` event when successful.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        public GenericExtrinsicCall Create(BaseCom<U32> id, EnumMultiAddress admin, U64 min_balance)
        {
            return new GenericExtrinsicCall("Assets", "create", id, admin, min_balance);
        }
        
        /// <summary>
        /// >> Extrinsic: force_create
        /// Issue a new class of fungible assets from a privileged origin.
        /// 
        /// This new asset class has no assets initially.
        /// 
        /// The origin must conform to `ForceOrigin`.
        /// 
        /// Unlike `create`, no funds are reserved.
        /// 
        /// - `id`: The identifier of the new asset. This must not be currently in use to identify
        /// an existing asset.
        /// - `owner`: The owner of this class of assets. The owner has full superuser permissions
        /// over this asset, but may later change and configure the permissions using
        /// `transfer_ownership` and `set_team`.
        /// - `min_balance`: The minimum balance of this new asset that any single account must
        /// have. If an account's balance is reduced below this, then it collapses to zero.
        /// 
        /// Emits `ForceCreated` event when successful.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        public GenericExtrinsicCall ForceCreate(BaseCom<U32> id, EnumMultiAddress owner, Bool is_sufficient, BaseCom<U64> min_balance)
        {
            return new GenericExtrinsicCall("Assets", "force_create", id, owner, is_sufficient, min_balance);
        }
        
        /// <summary>
        /// >> Extrinsic: destroy
        /// Destroy a class of fungible assets.
        /// 
        /// The origin must conform to `ForceOrigin` or must be Signed and the sender must be the
        /// owner of the asset `id`.
        /// 
        /// - `id`: The identifier of the asset to be destroyed. This must identify an existing
        /// asset.
        /// 
        /// Emits `Destroyed` event when successful.
        /// 
        /// NOTE: It can be helpful to first freeze an asset before destroying it so that you
        /// can provide accurate witness information and prevent users from manipulating state
        /// in a way that can make it harder to destroy.
        /// 
        /// Weight: `O(c + p + a)` where:
        /// - `c = (witness.accounts - witness.sufficients)`
        /// - `s = witness.sufficients`
        /// - `a = witness.approvals`
        /// </summary>
        public GenericExtrinsicCall Destroy(BaseCom<U32> id, DestroyWitness witness)
        {
            return new GenericExtrinsicCall("Assets", "destroy", id, witness);
        }
        
        /// <summary>
        /// >> Extrinsic: mint
        /// Mint assets of a particular class.
        /// 
        /// The origin must be Signed and the sender must be the Issuer of the asset `id`.
        /// 
        /// - `id`: The identifier of the asset to have some amount minted.
        /// - `beneficiary`: The account to be credited with the minted assets.
        /// - `amount`: The amount of the asset to be minted.
        /// 
        /// Emits `Issued` event when successful.
        /// 
        /// Weight: `O(1)`
        /// Modes: Pre-existing balance of `beneficiary`; Account pre-existence of `beneficiary`.
        /// </summary>
        public GenericExtrinsicCall Mint(BaseCom<U32> id, EnumMultiAddress beneficiary, BaseCom<U64> amount)
        {
            return new GenericExtrinsicCall("Assets", "mint", id, beneficiary, amount);
        }
        
        /// <summary>
        /// >> Extrinsic: burn
        /// Reduce the balance of `who` by as much as possible up to `amount` assets of `id`.
        /// 
        /// Origin must be Signed and the sender should be the Manager of the asset `id`.
        /// 
        /// Bails with `BalanceZero` if the `who` is already dead.
        /// 
        /// - `id`: The identifier of the asset to have some amount burned.
        /// - `who`: The account to be debited from.
        /// - `amount`: The maximum amount by which `who`'s balance should be reduced.
        /// 
        /// Emits `Burned` with the actual amount burned. If this takes the balance to below the
        /// minimum for the asset, then the amount burned is increased to take it to zero.
        /// 
        /// Weight: `O(1)`
        /// Modes: Post-existence of `who`; Pre & post Zombie-status of `who`.
        /// </summary>
        public GenericExtrinsicCall Burn(BaseCom<U32> id, EnumMultiAddress who, BaseCom<U64> amount)
        {
            return new GenericExtrinsicCall("Assets", "burn", id, who, amount);
        }
        
        /// <summary>
        /// >> Extrinsic: transfer
        /// Move some assets from the sender account to another.
        /// 
        /// Origin must be Signed.
        /// 
        /// - `id`: The identifier of the asset to have some amount transferred.
        /// - `target`: The account to be credited.
        /// - `amount`: The amount by which the sender's balance of assets should be reduced and
        /// `target`'s balance increased. The amount actually transferred may be slightly greater in
        /// the case that the transfer would otherwise take the sender balance above zero but below
        /// the minimum balance. Must be greater than zero.
        /// 
        /// Emits `Transferred` with the actual amount transferred. If this takes the source balance
        /// to below the minimum for the asset, then the amount transferred is increased to take it
        /// to zero.
        /// 
        /// Weight: `O(1)`
        /// Modes: Pre-existence of `target`; Post-existence of sender; Account pre-existence of
        /// `target`.
        /// </summary>
        public GenericExtrinsicCall Transfer(BaseCom<U32> id, EnumMultiAddress target, BaseCom<U64> amount)
        {
            return new GenericExtrinsicCall("Assets", "transfer", id, target, amount);
        }
        
        /// <summary>
        /// >> Extrinsic: transfer_keep_alive
        /// Move some assets from the sender account to another, keeping the sender account alive.
        /// 
        /// Origin must be Signed.
        /// 
        /// - `id`: The identifier of the asset to have some amount transferred.
        /// - `target`: The account to be credited.
        /// - `amount`: The amount by which the sender's balance of assets should be reduced and
        /// `target`'s balance increased. The amount actually transferred may be slightly greater in
        /// the case that the transfer would otherwise take the sender balance above zero but below
        /// the minimum balance. Must be greater than zero.
        /// 
        /// Emits `Transferred` with the actual amount transferred. If this takes the source balance
        /// to below the minimum for the asset, then the amount transferred is increased to take it
        /// to zero.
        /// 
        /// Weight: `O(1)`
        /// Modes: Pre-existence of `target`; Post-existence of sender; Account pre-existence of
        /// `target`.
        /// </summary>
        public GenericExtrinsicCall TransferKeepAlive(BaseCom<U32> id, EnumMultiAddress target, BaseCom<U64> amount)
        {
            return new GenericExtrinsicCall("Assets", "transfer_keep_alive", id, target, amount);
        }
        
        /// <summary>
        /// >> Extrinsic: force_transfer
        /// Move some assets from one account to another.
        /// 
        /// Origin must be Signed and the sender should be the Admin of the asset `id`.
        /// 
        /// - `id`: The identifier of the asset to have some amount transferred.
        /// - `source`: The account to be debited.
        /// - `dest`: The account to be credited.
        /// - `amount`: The amount by which the `source`'s balance of assets should be reduced and
        /// `dest`'s balance increased. The amount actually transferred may be slightly greater in
        /// the case that the transfer would otherwise take the `source` balance above zero but
        /// below the minimum balance. Must be greater than zero.
        /// 
        /// Emits `Transferred` with the actual amount transferred. If this takes the source balance
        /// to below the minimum for the asset, then the amount transferred is increased to take it
        /// to zero.
        /// 
        /// Weight: `O(1)`
        /// Modes: Pre-existence of `dest`; Post-existence of `source`; Account pre-existence of
        /// `dest`.
        /// </summary>
        public GenericExtrinsicCall ForceTransfer(BaseCom<U32> id, EnumMultiAddress source, EnumMultiAddress dest, BaseCom<U64> amount)
        {
            return new GenericExtrinsicCall("Assets", "force_transfer", id, source, dest, amount);
        }
        
        /// <summary>
        /// >> Extrinsic: freeze
        /// Disallow further unprivileged transfers from an account.
        /// 
        /// Origin must be Signed and the sender should be the Freezer of the asset `id`.
        /// 
        /// - `id`: The identifier of the asset to be frozen.
        /// - `who`: The account to be frozen.
        /// 
        /// Emits `Frozen`.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        public GenericExtrinsicCall Freeze(BaseCom<U32> id, EnumMultiAddress who)
        {
            return new GenericExtrinsicCall("Assets", "freeze", id, who);
        }
        
        /// <summary>
        /// >> Extrinsic: thaw
        /// Allow unprivileged transfers from an account again.
        /// 
        /// Origin must be Signed and the sender should be the Admin of the asset `id`.
        /// 
        /// - `id`: The identifier of the asset to be frozen.
        /// - `who`: The account to be unfrozen.
        /// 
        /// Emits `Thawed`.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        public GenericExtrinsicCall Thaw(BaseCom<U32> id, EnumMultiAddress who)
        {
            return new GenericExtrinsicCall("Assets", "thaw", id, who);
        }
        
        /// <summary>
        /// >> Extrinsic: freeze_asset
        /// Disallow further unprivileged transfers for the asset class.
        /// 
        /// Origin must be Signed and the sender should be the Freezer of the asset `id`.
        /// 
        /// - `id`: The identifier of the asset to be frozen.
        /// 
        /// Emits `Frozen`.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        public GenericExtrinsicCall FreezeAsset(BaseCom<U32> id)
        {
            return new GenericExtrinsicCall("Assets", "freeze_asset", id);
        }
        
        /// <summary>
        /// >> Extrinsic: thaw_asset
        /// Allow unprivileged transfers for the asset again.
        /// 
        /// Origin must be Signed and the sender should be the Admin of the asset `id`.
        /// 
        /// - `id`: The identifier of the asset to be thawed.
        /// 
        /// Emits `Thawed`.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        public GenericExtrinsicCall ThawAsset(BaseCom<U32> id)
        {
            return new GenericExtrinsicCall("Assets", "thaw_asset", id);
        }
        
        /// <summary>
        /// >> Extrinsic: transfer_ownership
        /// Change the Owner of an asset.
        /// 
        /// Origin must be Signed and the sender should be the Owner of the asset `id`.
        /// 
        /// - `id`: The identifier of the asset.
        /// - `owner`: The new Owner of this asset.
        /// 
        /// Emits `OwnerChanged`.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        public GenericExtrinsicCall TransferOwnership(BaseCom<U32> id, EnumMultiAddress owner)
        {
            return new GenericExtrinsicCall("Assets", "transfer_ownership", id, owner);
        }
        
        /// <summary>
        /// >> Extrinsic: set_team
        /// Change the Issuer, Admin and Freezer of an asset.
        /// 
        /// Origin must be Signed and the sender should be the Owner of the asset `id`.
        /// 
        /// - `id`: The identifier of the asset to be frozen.
        /// - `issuer`: The new Issuer of this asset.
        /// - `admin`: The new Admin of this asset.
        /// - `freezer`: The new Freezer of this asset.
        /// 
        /// Emits `TeamChanged`.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        public GenericExtrinsicCall SetTeam(BaseCom<U32> id, EnumMultiAddress issuer, EnumMultiAddress admin, EnumMultiAddress freezer)
        {
            return new GenericExtrinsicCall("Assets", "set_team", id, issuer, admin, freezer);
        }
        
        /// <summary>
        /// >> Extrinsic: set_metadata
        /// Set the metadata for an asset.
        /// 
        /// Origin must be Signed and the sender should be the Owner of the asset `id`.
        /// 
        /// Funds of sender are reserved according to the formula:
        /// `MetadataDepositBase + MetadataDepositPerByte * (name.len + symbol.len)` taking into
        /// account any already reserved funds.
        /// 
        /// - `id`: The identifier of the asset to update.
        /// - `name`: The user friendly name of this asset. Limited in length by `StringLimit`.
        /// - `symbol`: The exchange symbol for this asset. Limited in length by `StringLimit`.
        /// - `decimals`: The number of decimals this asset uses to represent one unit.
        /// 
        /// Emits `MetadataSet`.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        public GenericExtrinsicCall SetMetadata(BaseCom<U32> id, BaseVec<U8> name, BaseVec<U8> symbol, U8 decimals)
        {
            return new GenericExtrinsicCall("Assets", "set_metadata", id, name, symbol, decimals);
        }
        
        /// <summary>
        /// >> Extrinsic: clear_metadata
        /// Clear the metadata for an asset.
        /// 
        /// Origin must be Signed and the sender should be the Owner of the asset `id`.
        /// 
        /// Any deposit is freed for the asset owner.
        /// 
        /// - `id`: The identifier of the asset to clear.
        /// 
        /// Emits `MetadataCleared`.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        public GenericExtrinsicCall ClearMetadata(BaseCom<U32> id)
        {
            return new GenericExtrinsicCall("Assets", "clear_metadata", id);
        }
        
        /// <summary>
        /// >> Extrinsic: force_set_metadata
        /// Force the metadata for an asset to some value.
        /// 
        /// Origin must be ForceOrigin.
        /// 
        /// Any deposit is left alone.
        /// 
        /// - `id`: The identifier of the asset to update.
        /// - `name`: The user friendly name of this asset. Limited in length by `StringLimit`.
        /// - `symbol`: The exchange symbol for this asset. Limited in length by `StringLimit`.
        /// - `decimals`: The number of decimals this asset uses to represent one unit.
        /// 
        /// Emits `MetadataSet`.
        /// 
        /// Weight: `O(N + S)` where N and S are the length of the name and symbol respectively.
        /// </summary>
        public GenericExtrinsicCall ForceSetMetadata(BaseCom<U32> id, BaseVec<U8> name, BaseVec<U8> symbol, U8 decimals, Bool is_frozen)
        {
            return new GenericExtrinsicCall("Assets", "force_set_metadata", id, name, symbol, decimals, is_frozen);
        }
        
        /// <summary>
        /// >> Extrinsic: force_clear_metadata
        /// Clear the metadata for an asset.
        /// 
        /// Origin must be ForceOrigin.
        /// 
        /// Any deposit is returned.
        /// 
        /// - `id`: The identifier of the asset to clear.
        /// 
        /// Emits `MetadataCleared`.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        public GenericExtrinsicCall ForceClearMetadata(BaseCom<U32> id)
        {
            return new GenericExtrinsicCall("Assets", "force_clear_metadata", id);
        }
        
        /// <summary>
        /// >> Extrinsic: force_asset_status
        /// Alter the attributes of a given asset.
        /// 
        /// Origin must be `ForceOrigin`.
        /// 
        /// - `id`: The identifier of the asset.
        /// - `owner`: The new Owner of this asset.
        /// - `issuer`: The new Issuer of this asset.
        /// - `admin`: The new Admin of this asset.
        /// - `freezer`: The new Freezer of this asset.
        /// - `min_balance`: The minimum balance of this new asset that any single account must
        /// have. If an account's balance is reduced below this, then it collapses to zero.
        /// - `is_sufficient`: Whether a non-zero balance of this asset is deposit of sufficient
        /// value to account for the state bloat associated with its balance storage. If set to
        /// `true`, then non-zero balances may be stored without a `consumer` reference (and thus
        /// an ED in the Balances pallet or whatever else is used to control user-account state
        /// growth).
        /// - `is_frozen`: Whether this asset class is frozen except for permissioned/admin
        /// instructions.
        /// 
        /// Emits `AssetStatusChanged` with the identity of the asset.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        public GenericExtrinsicCall ForceAssetStatus(BaseCom<U32> id, EnumMultiAddress owner, EnumMultiAddress issuer, EnumMultiAddress admin, EnumMultiAddress freezer, BaseCom<U64> min_balance, Bool is_sufficient, Bool is_frozen)
        {
            return new GenericExtrinsicCall("Assets", "force_asset_status", id, owner, issuer, admin, freezer, min_balance, is_sufficient, is_frozen);
        }
        
        /// <summary>
        /// >> Extrinsic: approve_transfer
        /// Approve an amount of asset for transfer by a delegated third-party account.
        /// 
        /// Origin must be Signed.
        /// 
        /// Ensures that `ApprovalDeposit` worth of `Currency` is reserved from signing account
        /// for the purpose of holding the approval. If some non-zero amount of assets is already
        /// approved from signing account to `delegate`, then it is topped up or unreserved to
        /// meet the right value.
        /// 
        /// NOTE: The signing account does not need to own `amount` of assets at the point of
        /// making this call.
        /// 
        /// - `id`: The identifier of the asset.
        /// - `delegate`: The account to delegate permission to transfer asset.
        /// - `amount`: The amount of asset that may be transferred by `delegate`. If there is
        /// already an approval in place, then this acts additively.
        /// 
        /// Emits `ApprovedTransfer` on success.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        public GenericExtrinsicCall ApproveTransfer(BaseCom<U32> id, EnumMultiAddress @delegate, BaseCom<U64> amount)
        {
            return new GenericExtrinsicCall("Assets", "approve_transfer", id, @delegate, amount);
        }
        
        /// <summary>
        /// >> Extrinsic: cancel_approval
        /// Cancel all of some asset approved for delegated transfer by a third-party account.
        /// 
        /// Origin must be Signed and there must be an approval in place between signer and
        /// `delegate`.
        /// 
        /// Unreserves any deposit previously reserved by `approve_transfer` for the approval.
        /// 
        /// - `id`: The identifier of the asset.
        /// - `delegate`: The account delegated permission to transfer asset.
        /// 
        /// Emits `ApprovalCancelled` on success.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        public GenericExtrinsicCall CancelApproval(BaseCom<U32> id, EnumMultiAddress @delegate)
        {
            return new GenericExtrinsicCall("Assets", "cancel_approval", id, @delegate);
        }
        
        /// <summary>
        /// >> Extrinsic: force_cancel_approval
        /// Cancel all of some asset approved for delegated transfer by a third-party account.
        /// 
        /// Origin must be either ForceOrigin or Signed origin with the signer being the Admin
        /// account of the asset `id`.
        /// 
        /// Unreserves any deposit previously reserved by `approve_transfer` for the approval.
        /// 
        /// - `id`: The identifier of the asset.
        /// - `delegate`: The account delegated permission to transfer asset.
        /// 
        /// Emits `ApprovalCancelled` on success.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        public GenericExtrinsicCall ForceCancelApproval(BaseCom<U32> id, EnumMultiAddress owner, EnumMultiAddress @delegate)
        {
            return new GenericExtrinsicCall("Assets", "force_cancel_approval", id, owner, @delegate);
        }
        
        /// <summary>
        /// >> Extrinsic: transfer_approved
        /// Transfer some asset balance from a previously delegated account to some third-party
        /// account.
        /// 
        /// Origin must be Signed and there must be an approval in place by the `owner` to the
        /// signer.
        /// 
        /// If the entire amount approved for transfer is transferred, then any deposit previously
        /// reserved by `approve_transfer` is unreserved.
        /// 
        /// - `id`: The identifier of the asset.
        /// - `owner`: The account which previously approved for a transfer of at least `amount` and
        /// from which the asset balance will be withdrawn.
        /// - `destination`: The account to which the asset balance of `amount` will be transferred.
        /// - `amount`: The amount of assets to transfer.
        /// 
        /// Emits `TransferredApproved` on success.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        public GenericExtrinsicCall TransferApproved(BaseCom<U32> id, EnumMultiAddress owner, EnumMultiAddress destination, BaseCom<U64> amount)
        {
            return new GenericExtrinsicCall("Assets", "transfer_approved", id, owner, destination, amount);
        }
    }
}
