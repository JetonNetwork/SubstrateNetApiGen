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
    
    
    public enum Phase
    {
        
        Off,
        
        Signed,
        
        Unsigned,
        
        Emergency,
    }
    
    /// <summary>
    /// >> Enum
    /// </summary>
    public sealed class EnumPhase : BaseEnumExt<Phase, BaseVoid, BaseVoid, BaseTuple<SubstrateNetApi.Model.Types.Primitive.Bool,SubstrateNetApi.Model.Types.Primitive.U32>, BaseVoid>
    {
    }
}
