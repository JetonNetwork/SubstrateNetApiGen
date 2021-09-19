//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Calls;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using SubstrateNetApi.Model.Types.TypeDefArray;
using SubstrateNetApi.Model.Types.TypeDefComposite;
using SubstrateNetApi.Model.Types.TypeDefVariant;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.Custom.Calls
{
    
    
    /// <summary>
    /// >> Path: pallet_grandpa.pallet.Call
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class PalletGrandpa
    {
        
        /// <summary>
        /// >> Extrinsic: report_equivocation
        /// Report voter equivocation/misbehavior. This method will verify the
        /// equivocation proof and validate the given key ownership proof
        /// against the extracted offender. If both are valid, the offence
        /// will be reported.
        /// </summary>
        public GenericExtrinsicCall ReportEquivocation(EquivocationProof equivocation_proof, MembershipProof key_owner_proof)
        {
            return new GenericExtrinsicCall("Grandpa", "report_equivocation", equivocation_proof, key_owner_proof);
        }
        
        /// <summary>
        /// >> Extrinsic: report_equivocation_unsigned
        /// Report voter equivocation/misbehavior. This method will verify the
        /// equivocation proof and validate the given key ownership proof
        /// against the extracted offender. If both are valid, the offence
        /// will be reported.
        /// 
        /// This extrinsic must be called unsigned and it is expected that only
        /// block authors will call it (validated in `ValidateUnsigned`), as such
        /// if the block author is defined it will be defined as the equivocation
        /// reporter.
        /// </summary>
        public GenericExtrinsicCall ReportEquivocationUnsigned(EquivocationProof equivocation_proof, MembershipProof key_owner_proof)
        {
            return new GenericExtrinsicCall("Grandpa", "report_equivocation_unsigned", equivocation_proof, key_owner_proof);
        }
        
        /// <summary>
        /// >> Extrinsic: note_stalled
        /// Note that the current authority set of the GRANDPA finality gadget has
        /// stalled. This will trigger a forced authority set change at the beginning
        /// of the next session, to be enacted `delay` blocks after that. The delay
        /// should be high enough to safely assume that the block signalling the
        /// forced change will not be re-orged (e.g. 1000 blocks). The GRANDPA voters
        /// will start the new authority set using the given finalized block as base.
        /// Only callable by root.
        /// </summary>
        public GenericExtrinsicCall NoteStalled(U32 delay, U32 best_finalized_block_number)
        {
            return new GenericExtrinsicCall("Grandpa", "note_stalled", delay, best_finalized_block_number);
        }
    }
}