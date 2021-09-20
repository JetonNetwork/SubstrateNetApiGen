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


namespace SubstrateNetApi.Model.PalletImOnline
{
    
    
    /// <summary>
    /// >> Path: pallet_im_online.pallet.Error
    /// 
    ///			Custom [dispatch errors](https://substrate.dev/docs/en/knowledgebase/runtime/errors)
    ///			of this pallet.
    ///			
    /// </summary>
    public enum PalletImOnlineError
    {
        
        /// <summary>
        /// >> Event: InvalidKey
        /// Non existent public key.
        /// </summary>
        InvalidKey,
        
        /// <summary>
        /// >> Event: DuplicatedHeartbeat
        /// Duplicated heartbeat.
        /// </summary>
        DuplicatedHeartbeat,
    }
}
