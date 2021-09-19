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
    /// >> Path: pallet_membership.pallet.Event
    /// 
    ///			The [event](https://substrate.dev/docs/en/knowledgebase/runtime/events) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class PalletMembership
    {
        
        /// <summary>
        /// >> Event: MemberAdded
        /// The given member was added; see the transaction for who.
        /// </summary>
        public sealed class MemberAdded : BaseTuple
        {
        }
        
        /// <summary>
        /// >> Event: MemberRemoved
        /// The given member was removed; see the transaction for who.
        /// </summary>
        public sealed class MemberRemoved : BaseTuple
        {
        }
        
        /// <summary>
        /// >> Event: MembersSwapped
        /// Two members were swapped; see the transaction for who.
        /// </summary>
        public sealed class MembersSwapped : BaseTuple
        {
        }
        
        /// <summary>
        /// >> Event: MembersReset
        /// The membership was reset; see the transaction for who the new set is.
        /// </summary>
        public sealed class MembersReset : BaseTuple
        {
        }
        
        /// <summary>
        /// >> Event: KeyChanged
        /// One of the members' keys changed.
        /// </summary>
        public sealed class KeyChanged : BaseTuple
        {
        }
        
        /// <summary>
        /// >> Event: Dummy
        /// Phantom member, never used.
        /// </summary>
        public sealed class Dummy : BaseTuple
        {
        }
    }
}