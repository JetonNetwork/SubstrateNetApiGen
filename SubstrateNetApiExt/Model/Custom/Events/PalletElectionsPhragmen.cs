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
    /// >> Path: pallet_elections_phragmen.pallet.Event
    /// 
    ///			The [event](https://substrate.dev/docs/en/knowledgebase/runtime/events) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class PalletElectionsPhragmen
    {
        
        /// <summary>
        /// >> Event: NewTerm
        /// A new term with \[new_members\]. This indicates that enough candidates existed to run
        /// the election, not that enough have has been elected. The inner value must be examined
        /// for this purpose. A `NewTerm(\[\])` indicates that some candidates got their bond
        /// slashed and none were elected, whilst `EmptyTerm` means that no candidates existed to
        /// begin with.
        /// </summary>
        public sealed class NewTerm : BaseTuple<BaseVec<BaseTuple<AccountId32,U128>>>
        {
        }
        
        /// <summary>
        /// >> Event: EmptyTerm
        /// No (or not enough) candidates existed for this round. This is different from
        /// `NewTerm(\[\])`. See the description of `NewTerm`.
        /// </summary>
        public sealed class EmptyTerm : BaseTuple
        {
        }
        
        /// <summary>
        /// >> Event: ElectionError
        /// Internal error happened while trying to perform election.
        /// </summary>
        public sealed class ElectionError : BaseTuple
        {
        }
        
        /// <summary>
        /// >> Event: MemberKicked
        /// A \[member\] has been removed. This should always be followed by either `NewTerm` or
        /// `EmptyTerm`.
        /// </summary>
        public sealed class MemberKicked : BaseTuple<AccountId32>
        {
        }
        
        /// <summary>
        /// >> Event: Renounced
        /// Someone has renounced their candidacy.
        /// </summary>
        public sealed class Renounced : BaseTuple<AccountId32>
        {
        }
        
        /// <summary>
        /// >> Event: CandidateSlashed
        /// A \[candidate\] was slashed by \[amount\] due to failing to obtain a seat as member or
        /// runner-up.
        /// 
        /// Note that old members and runners-up are also candidates.
        /// </summary>
        public sealed class CandidateSlashed : BaseTuple<AccountId32, U128>
        {
        }
        
        /// <summary>
        /// >> Event: SeatHolderSlashed
        /// A \[seat holder\] was slashed by \[amount\] by being forcefully removed from the set.
        /// </summary>
        public sealed class SeatHolderSlashed : BaseTuple<AccountId32, U128>
        {
        }
    }
}
