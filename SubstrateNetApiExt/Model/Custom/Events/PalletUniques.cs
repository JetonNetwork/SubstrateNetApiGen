//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using SubstrateNetApi.Model.Types.TypeDefArray;
using SubstrateNetApi.Model.Types.TypeDefComposite;
using SubstrateNetApi.Model.Types.TypeDefVariant;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.Custom.Events
{
    
    
    /// <summary>
    /// >> Path: pallet_uniques.pallet.Event
    /// 
    ///			The [event](https://substrate.dev/docs/en/knowledgebase/runtime/events) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class PalletUniques
    {
        
        /// <summary>
        /// >> Event: Created
        /// An asset class was created. \[ class, creator, owner \]
        /// </summary>
        public sealed class Created : BaseTuple<U32, AccountId32, AccountId32>
        {
        }
        
        /// <summary>
        /// >> Event: ForceCreated
        /// An asset class was force-created. \[ class, owner \]
        /// </summary>
        public sealed class ForceCreated : BaseTuple<U32, AccountId32>
        {
        }
        
        /// <summary>
        /// >> Event: Destroyed
        /// An asset `class` was destroyed. \[ class \]
        /// </summary>
        public sealed class Destroyed : BaseTuple<U32>
        {
        }
        
        /// <summary>
        /// >> Event: Issued
        /// An asset `instance` was issued. \[ class, instance, owner \]
        /// </summary>
        public sealed class Issued : BaseTuple<U32, U32, AccountId32>
        {
        }
        
        /// <summary>
        /// >> Event: Transferred
        /// An asset `instance` was transferred. \[ class, instance, from, to \]
        /// </summary>
        public sealed class Transferred : BaseTuple<U32, U32, AccountId32, AccountId32>
        {
        }
        
        /// <summary>
        /// >> Event: Burned
        /// An asset `instance` was destroyed. \[ class, instance, owner \]
        /// </summary>
        public sealed class Burned : BaseTuple<U32, U32, AccountId32>
        {
        }
        
        /// <summary>
        /// >> Event: Frozen
        /// Some asset `instance` was frozen. \[ class, instance \]
        /// </summary>
        public sealed class Frozen : BaseTuple<U32, U32>
        {
        }
        
        /// <summary>
        /// >> Event: Thawed
        /// Some asset `instance` was thawed. \[ class, instance \]
        /// </summary>
        public sealed class Thawed : BaseTuple<U32, U32>
        {
        }
        
        /// <summary>
        /// >> Event: ClassFrozen
        /// Some asset `class` was frozen. \[ class \]
        /// </summary>
        public sealed class ClassFrozen : BaseTuple<U32>
        {
        }
        
        /// <summary>
        /// >> Event: ClassThawed
        /// Some asset `class` was thawed. \[ class \]
        /// </summary>
        public sealed class ClassThawed : BaseTuple<U32>
        {
        }
        
        /// <summary>
        /// >> Event: OwnerChanged
        /// The owner changed \[ class, new_owner \]
        /// </summary>
        public sealed class OwnerChanged : BaseTuple<U32, AccountId32>
        {
        }
        
        /// <summary>
        /// >> Event: TeamChanged
        /// The management team changed \[ class, issuer, admin, freezer \]
        /// </summary>
        public sealed class TeamChanged : BaseTuple<U32, AccountId32, AccountId32, AccountId32>
        {
        }
        
        /// <summary>
        /// >> Event: ApprovedTransfer
        /// An `instance` of an asset `class` has been approved by the `owner` for transfer by a
        /// `delegate`.
        /// \[ class, instance, owner, delegate \]
        /// </summary>
        public sealed class ApprovedTransfer : BaseTuple<U32, U32, AccountId32, AccountId32>
        {
        }
        
        /// <summary>
        /// >> Event: ApprovalCancelled
        /// An approval for a `delegate` account to transfer the `instance` of an asset `class` was
        /// cancelled by its `owner`.
        /// \[ class, instance, owner, delegate \]
        /// </summary>
        public sealed class ApprovalCancelled : BaseTuple<U32, U32, AccountId32, AccountId32>
        {
        }
        
        /// <summary>
        /// >> Event: AssetStatusChanged
        /// An asset `class` has had its attributes changed by the `Force` origin.
        /// \[ class \]
        /// </summary>
        public sealed class AssetStatusChanged : BaseTuple<U32>
        {
        }
        
        /// <summary>
        /// >> Event: ClassMetadataSet
        /// New metadata has been set for an asset class. \[ class, data, is_frozen \]
        /// </summary>
        public sealed class ClassMetadataSet : BaseTuple<U32, BoundedVec, Bool>
        {
        }
        
        /// <summary>
        /// >> Event: ClassMetadataCleared
        /// Metadata has been cleared for an asset class. \[ class \]
        /// </summary>
        public sealed class ClassMetadataCleared : BaseTuple<U32>
        {
        }
        
        /// <summary>
        /// >> Event: MetadataSet
        /// New metadata has been set for an asset instance.
        /// \[ class, instance, data, is_frozen \]
        /// </summary>
        public sealed class MetadataSet : BaseTuple<U32, U32, BoundedVec, Bool>
        {
        }
        
        /// <summary>
        /// >> Event: MetadataCleared
        /// Metadata has been cleared for an asset instance. \[ class, instance \]
        /// </summary>
        public sealed class MetadataCleared : BaseTuple<U32, U32>
        {
        }
        
        /// <summary>
        /// >> Event: Redeposited
        /// Metadata has been cleared for an asset instance. \[ class, successful_instances \]
        /// </summary>
        public sealed class Redeposited : BaseTuple<U32, BaseVec<U32>>
        {
        }
        
        /// <summary>
        /// >> Event: AttributeSet
        /// New attribute metadata has been set for an asset class or instance.
        /// \[ class, maybe_instance, key, value \]
        /// </summary>
        public sealed class AttributeSet : BaseTuple<U32, BaseOpt<U32>, BoundedVec, BoundedVec>
        {
        }
        
        /// <summary>
        /// >> Event: AttributeCleared
        /// Attribute metadata has been cleared for an asset class or instance.
        /// \[ class, maybe_instance, key, maybe_value \]
        /// </summary>
        public sealed class AttributeCleared : BaseTuple<U32, BaseOpt<U32>, BoundedVec>
        {
        }
    }
}