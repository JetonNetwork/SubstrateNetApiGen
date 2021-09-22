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


namespace SubstrateNetApi.Model.PalletMultisig
{
    
    
    /// <summary>
    /// >> 472 - Variant[pallet_multisig.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://substrate.dev/docs/en/knowledgebase/runtime/errors)
    ///			of this pallet.
    ///			
    /// </summary>
    public enum PalletMultisigError
    {
        
        /// <summary>
        /// >> MinimumThreshold
        /// </summary>
        MinimumThreshold,
        
        /// <summary>
        /// >> AlreadyApproved
        /// </summary>
        AlreadyApproved,
        
        /// <summary>
        /// >> NoApprovalsNeeded
        /// </summary>
        NoApprovalsNeeded,
        
        /// <summary>
        /// >> TooFewSignatories
        /// </summary>
        TooFewSignatories,
        
        /// <summary>
        /// >> TooManySignatories
        /// </summary>
        TooManySignatories,
        
        /// <summary>
        /// >> SignatoriesOutOfOrder
        /// </summary>
        SignatoriesOutOfOrder,
        
        /// <summary>
        /// >> SenderInSignatories
        /// </summary>
        SenderInSignatories,
        
        /// <summary>
        /// >> NotFound
        /// </summary>
        NotFound,
        
        /// <summary>
        /// >> NotOwner
        /// </summary>
        NotOwner,
        
        /// <summary>
        /// >> NoTimepoint
        /// </summary>
        NoTimepoint,
        
        /// <summary>
        /// >> WrongTimepoint
        /// </summary>
        WrongTimepoint,
        
        /// <summary>
        /// >> UnexpectedTimepoint
        /// </summary>
        UnexpectedTimepoint,
        
        /// <summary>
        /// >> MaxWeightTooLow
        /// </summary>
        MaxWeightTooLow,
        
        /// <summary>
        /// >> AlreadyStored
        /// </summary>
        AlreadyStored,
    }
}
