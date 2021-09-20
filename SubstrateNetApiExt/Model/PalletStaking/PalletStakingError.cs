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


namespace SubstrateNetApi.Model.PalletStaking
{
    
    
    /// <summary>
    /// >> Path: pallet_staking.pallet.pallet.Error
    /// 
    ///			Custom [dispatch errors](https://substrate.dev/docs/en/knowledgebase/runtime/errors)
    ///			of this pallet.
    ///			
    /// </summary>
    public enum PalletStakingError
    {
        
        /// <summary>
        /// >> Event: NotController
        /// Not a controller account.
        /// </summary>
        NotController,
        
        /// <summary>
        /// >> Event: NotStash
        /// Not a stash account.
        /// </summary>
        NotStash,
        
        /// <summary>
        /// >> Event: AlreadyBonded
        /// Stash is already bonded.
        /// </summary>
        AlreadyBonded,
        
        /// <summary>
        /// >> Event: AlreadyPaired
        /// Controller is already paired.
        /// </summary>
        AlreadyPaired,
        
        /// <summary>
        /// >> Event: EmptyTargets
        /// Targets cannot be empty.
        /// </summary>
        EmptyTargets,
        
        /// <summary>
        /// >> Event: DuplicateIndex
        /// Duplicate index.
        /// </summary>
        DuplicateIndex,
        
        /// <summary>
        /// >> Event: InvalidSlashIndex
        /// Slash record index out of bounds.
        /// </summary>
        InvalidSlashIndex,
        
        /// <summary>
        /// >> Event: InsufficientBond
        /// Can not bond with value less than minimum required.
        /// </summary>
        InsufficientBond,
        
        /// <summary>
        /// >> Event: NoMoreChunks
        /// Can not schedule more unlock chunks.
        /// </summary>
        NoMoreChunks,
        
        /// <summary>
        /// >> Event: NoUnlockChunk
        /// Can not rebond without unlocking chunks.
        /// </summary>
        NoUnlockChunk,
        
        /// <summary>
        /// >> Event: FundedTarget
        /// Attempting to target a stash that still has funds.
        /// </summary>
        FundedTarget,
        
        /// <summary>
        /// >> Event: InvalidEraToReward
        /// Invalid era to reward.
        /// </summary>
        InvalidEraToReward,
        
        /// <summary>
        /// >> Event: InvalidNumberOfNominations
        /// Invalid number of nominations.
        /// </summary>
        InvalidNumberOfNominations,
        
        /// <summary>
        /// >> Event: NotSortedAndUnique
        /// Items are not sorted and unique.
        /// </summary>
        NotSortedAndUnique,
        
        /// <summary>
        /// >> Event: AlreadyClaimed
        /// Rewards for this era have already been claimed for this validator.
        /// </summary>
        AlreadyClaimed,
        
        /// <summary>
        /// >> Event: IncorrectHistoryDepth
        /// Incorrect previous history depth input provided.
        /// </summary>
        IncorrectHistoryDepth,
        
        /// <summary>
        /// >> Event: IncorrectSlashingSpans
        /// Incorrect number of slashing spans provided.
        /// </summary>
        IncorrectSlashingSpans,
        
        /// <summary>
        /// >> Event: BadState
        /// Internal state has become somehow corrupted and the operation cannot continue.
        /// </summary>
        BadState,
        
        /// <summary>
        /// >> Event: TooManyTargets
        /// Too many nomination targets supplied.
        /// </summary>
        TooManyTargets,
        
        /// <summary>
        /// >> Event: BadTarget
        /// A nomination target was supplied that was blocked or otherwise not a validator.
        /// </summary>
        BadTarget,
        
        /// <summary>
        /// >> Event: CannotChillOther
        /// The user has enough bond and thus cannot be chilled forcefully by an external person.
        /// </summary>
        CannotChillOther,
        
        /// <summary>
        /// >> Event: TooManyNominators
        /// There are too many nominators in the system. Governance needs to adjust the staking
        /// settings to keep things safe for the runtime.
        /// </summary>
        TooManyNominators,
        
        /// <summary>
        /// >> Event: TooManyValidators
        /// There are too many validators in the system. Governance needs to adjust the staking
        /// settings to keep things safe for the runtime.
        /// </summary>
        TooManyValidators,
    }
}
