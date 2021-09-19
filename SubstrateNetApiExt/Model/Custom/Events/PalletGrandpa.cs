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
    /// >> Path: pallet_grandpa.pallet.Event
    /// 
    ///			The [event](https://substrate.dev/docs/en/knowledgebase/runtime/events) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class PalletGrandpa
    {
        
        /// <summary>
        /// >> Event: NewAuthorities
        /// New authority set has been applied. \[authority_set\]
        /// </summary>
        public sealed class NewAuthorities : BaseTuple<BaseVec<BaseTuple<Public,U64>>>
        {
        }
        
        /// <summary>
        /// >> Event: Paused
        /// Current authority set has been paused.
        /// </summary>
        public sealed class Paused : BaseTuple
        {
        }
        
        /// <summary>
        /// >> Event: Resumed
        /// Current authority set has been resumed.
        /// </summary>
        public sealed class Resumed : BaseTuple
        {
        }
    }
}
