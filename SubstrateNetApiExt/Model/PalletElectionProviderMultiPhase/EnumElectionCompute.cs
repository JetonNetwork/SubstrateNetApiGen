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


namespace SubstrateNetApi.Model.PalletElectionProviderMultiPhase
{
    
    
    public enum ElectionCompute
    {
        
        OnChain,
        
        Signed,
        
        Unsigned,
        
        Fallback,
        
        Emergency,
    }
    
    /// <summary>
    /// >> 33 - Variant[pallet_election_provider_multi_phase.ElectionCompute]
    /// </summary>
    public sealed class EnumElectionCompute : BaseEnum<ElectionCompute>
    {
    }
}
