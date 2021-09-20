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
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletBabe
{
    
    
    /// <summary>
    /// >> Path: pallet_babe.pallet.Call
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class PalletBabeCall
    {
        
        /// <summary>
        /// >> Extrinsic: report_equivocation
        /// Report authority equivocation/misbehavior. This method will verify
        /// the equivocation proof and validate the given key ownership proof
        /// against the extracted offender. If both are valid, the offence will
        /// be reported.
        /// </summary>
        public GenericExtrinsicCall ReportEquivocation(SubstrateNetApi.Model.SpConsensusSlots.EquivocationProof equivocation_proof, SubstrateNetApi.Model.SpSession.MembershipProof key_owner_proof)
        {
            return new GenericExtrinsicCall("Babe", "report_equivocation", equivocation_proof, key_owner_proof);
        }
        
        /// <summary>
        /// >> Extrinsic: report_equivocation_unsigned
        /// Report authority equivocation/misbehavior. This method will verify
        /// the equivocation proof and validate the given key ownership proof
        /// against the extracted offender. If both are valid, the offence will
        /// be reported.
        /// This extrinsic must be called unsigned and it is expected that only
        /// block authors will call it (validated in `ValidateUnsigned`), as such
        /// if the block author is defined it will be defined as the equivocation
        /// reporter.
        /// </summary>
        public GenericExtrinsicCall ReportEquivocationUnsigned(SubstrateNetApi.Model.SpConsensusSlots.EquivocationProof equivocation_proof, SubstrateNetApi.Model.SpSession.MembershipProof key_owner_proof)
        {
            return new GenericExtrinsicCall("Babe", "report_equivocation_unsigned", equivocation_proof, key_owner_proof);
        }
        
        /// <summary>
        /// >> Extrinsic: plan_config_change
        /// Plan an epoch config change. The epoch config change is recorded and will be enacted on
        /// the next call to `enact_epoch_change`. The config will be activated one epoch after.
        /// Multiple calls to this method will replace any existing planned config change that had
        /// not been enacted yet.
        /// </summary>
        public GenericExtrinsicCall PlanConfigChange(SubstrateNetApi.Model.SpConsensusBabe.EnumNextConfigDescriptor config)
        {
            return new GenericExtrinsicCall("Babe", "plan_config_change", config);
        }
    }
}
