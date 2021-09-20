//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Types.Base;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletSudo
{
    
    
    /// <summary>
    /// >> Path: pallet_sudo.pallet.Event
    /// 
    ///			The [event](https://substrate.dev/docs/en/knowledgebase/runtime/events) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class PalletSudoEvent
    {
        
        /// <summary>
        /// >> Event: Sudid
        /// A sudo just took place. \[result\]
        /// </summary>
        public sealed class Sudid : BaseTuple<BaseTuple<BaseTuple,  SubstrateNetApi.Model.SpRuntime.EnumDispatchError>>
        {
        }
        
        /// <summary>
        /// >> Event: KeyChanged
        /// The \[sudoer\] just switched identity; the old key is supplied.
        /// </summary>
        public sealed class KeyChanged : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32>
        {
        }
        
        /// <summary>
        /// >> Event: SudoAsDone
        /// A sudo just took place. \[result\]
        /// </summary>
        public sealed class SudoAsDone : BaseTuple<BaseTuple<BaseTuple,  SubstrateNetApi.Model.SpRuntime.EnumDispatchError>>
        {
        }
    }
}
