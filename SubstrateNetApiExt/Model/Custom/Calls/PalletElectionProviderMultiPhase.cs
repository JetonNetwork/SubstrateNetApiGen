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
using SubstrateNetApi.Model.Types.Composite;
using SubstrateNetApi.Model.Types.Enum;
using SubstrateNetApi.Model.Types.Primitive;
using SubstrateNetApi.Model.Types.Sequence;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.Custom.Calls
{
    
    
    /// <summary>
    /// >> Path: pallet_election_provider_multi_phase.pallet.Call
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class PalletElectionProviderMultiPhase
    {
        
        /// <summary>
        /// >> Extrinsic: submit_unsigned
        /// Submit a solution for the unsigned phase.
        /// 
        /// The dispatch origin fo this call must be __none__.
        /// 
        /// This submission is checked on the fly. Moreover, this unsigned solution is only
        /// validated when submitted to the pool from the **local** node. Effectively, this means
        /// that only active validators can submit this transaction when authoring a block (similar
        /// to an inherent).
        /// 
        /// To prevent any incorrect solution (and thus wasted time/weight), this transaction will
        /// panic if the solution submitted by the validator is invalid in any way, effectively
        /// putting their authoring reward at risk.
        /// 
        /// No deposit or reward is associated with this submission.
        /// </summary>
        public GenericExtrinsicCall SubmitUnsigned(RawSolution raw_solution, SolutionOrSnapshotSize witness)
        {
            return new GenericExtrinsicCall("ElectionProviderMultiPhase", "submit_unsigned", raw_solution, witness);
        }
        
        /// <summary>
        /// >> Extrinsic: set_minimum_untrusted_score
        /// Set a new value for `MinimumUntrustedScore`.
        /// 
        /// Dispatch origin must be aligned with `T::ForceOrigin`.
        /// 
        /// This check can be turned off by setting the value to `None`.
        /// </summary>
        public GenericExtrinsicCall SetMinimumUntrustedScore(BaseOpt<Arr3U128> maybe_next_score)
        {
            return new GenericExtrinsicCall("ElectionProviderMultiPhase", "set_minimum_untrusted_score", maybe_next_score);
        }
        
        /// <summary>
        /// >> Extrinsic: set_emergency_election_result
        /// Set a solution in the queue, to be handed out to the client of this pallet in the next
        /// call to `ElectionProvider::elect`.
        /// 
        /// This can only be set by `T::ForceOrigin`, and only when the phase is `Emergency`.
        /// 
        /// The solution is not checked for any feasibility and is assumed to be trustworthy, as any
        /// feasibility check itself can in principle cause the election process to fail (due to
        /// memory/weight constrains).
        /// </summary>
        public GenericExtrinsicCall SetEmergencyElectionResult(BaseVec<BaseTuple<AccountId32,Support>> supports)
        {
            return new GenericExtrinsicCall("ElectionProviderMultiPhase", "set_emergency_election_result", supports);
        }
        
        /// <summary>
        /// >> Extrinsic: submit
        /// Submit a solution for the signed phase.
        /// 
        /// The dispatch origin fo this call must be __signed__.
        /// 
        /// The solution is potentially queued, based on the claimed score and processed at the end
        /// of the signed phase.
        /// 
        /// A deposit is reserved and recorded for the solution. Based on the outcome, the solution
        /// might be rewarded, slashed, or get all or a part of the deposit back.
        /// 
        /// # <weight>
        /// Queue size must be provided as witness data.
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall Submit(RawSolution raw_solution, U32 num_signed_submissions)
        {
            return new GenericExtrinsicCall("ElectionProviderMultiPhase", "submit", raw_solution, num_signed_submissions);
        }
    }
}
