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
    /// >> Path: pallet_vesting.pallet.Event
    /// 
    ///			The [event](https://substrate.dev/docs/en/knowledgebase/runtime/events) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class PalletVesting
    {
        
        /// <summary>
        /// >> Event: VestingUpdated
        /// The amount vested has been updated. This could indicate a change in funds available.
        /// The balance given is the amount which is left unvested (and thus locked).
        /// \[account, unvested\]
        /// </summary>
        public sealed class VestingUpdated : BaseTuple<AccountId32, U128>
        {
        }
        
        /// <summary>
        /// >> Event: VestingCompleted
        /// An \[account\] has become fully vested.
        /// </summary>
        public sealed class VestingCompleted : BaseTuple<AccountId32>
        {
        }
    }
}
