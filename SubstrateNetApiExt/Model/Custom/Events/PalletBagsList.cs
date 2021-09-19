//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Composite;
using SubstrateNetApi.Model.Types.Enum;
using SubstrateNetApi.Model.Types.Primitive;
using SubstrateNetApi.Model.Types.Sequence;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.Custom.Events
{
    
    
    /// <summary>
    /// >> Path: pallet_bags_list.pallet.Event
    /// 
    ///			The [event](https://substrate.dev/docs/en/knowledgebase/runtime/events) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class PalletBagsList
    {
        
        /// <summary>
        /// >> Event: Rebagged
        /// Moved an account from one bag to another. \[who, from, to\].
        /// </summary>
        public sealed class Rebagged : BaseTuple<AccountId32, U64, U64>
        {
        }
    }
}
