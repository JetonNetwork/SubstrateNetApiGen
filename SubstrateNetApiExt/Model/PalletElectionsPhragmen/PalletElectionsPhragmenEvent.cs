//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.SpCore;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletElectionsPhragmen
{
    
    
    /// <summary>
    /// >> 45 - Variant[pallet_elections_phragmen.pallet.Event]
    /// 
    ///			The [event](https://substrate.dev/docs/en/knowledgebase/runtime/events) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class PalletElectionsPhragmenEvent
    {
        
        /// <summary>
        /// >> NewTerm
        /// </summary>
        public sealed class NewTerm : BaseTuple<BaseVec<BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.Types.Primitive.U128>>>
        {
        }
        
        /// <summary>
        /// >> EmptyTerm
        /// </summary>
        public sealed class EmptyTerm : BaseTuple
        {
        }
        
        /// <summary>
        /// >> ElectionError
        /// </summary>
        public sealed class ElectionError : BaseTuple
        {
        }
        
        /// <summary>
        /// >> MemberKicked
        /// </summary>
        public sealed class MemberKicked : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32>
        {
        }
        
        /// <summary>
        /// >> Renounced
        /// </summary>
        public sealed class Renounced : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32>
        {
        }
        
        /// <summary>
        /// >> CandidateSlashed
        /// </summary>
        public sealed class CandidateSlashed : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.U128>
        {
        }
        
        /// <summary>
        /// >> SeatHolderSlashed
        /// </summary>
        public sealed class SeatHolderSlashed : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.U128>
        {
        }
    }
}
