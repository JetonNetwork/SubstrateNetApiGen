//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.FrameSystem;
using SubstrateNetApi.Model.PalletCollective;
using SubstrateNetApi.Model.Types.Base;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.NodeRuntime
{
    
    
    public enum OriginCaller
    {
        
        system,
        
        Council,
        
        TechnicalCommittee,
        
        Void,
    }
    
    /// <summary>
    /// >> 453 - Variant[node_runtime.OriginCaller]
    /// </summary>
    public sealed class EnumOriginCaller : BaseEnumExt<OriginCaller, SubstrateNetApi.Model.FrameSystem.EnumRawOrigin, SubstrateNetApi.Model.PalletCollective.EnumRawOrigin, SubstrateNetApi.Model.PalletCollective.EnumRawOrigin, SubstrateNetApi.Model.Types.Base.BaseVoid>
    {
    }
}
