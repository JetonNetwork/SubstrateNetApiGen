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
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletElectionsPhragmen
{
    
    
    public enum Renouncing
    {
        
        Member,
        
        RunnerUp,
        
        Candidate,
    }
    
    /// <summary>
    /// >> 216 - Variant[pallet_elections_phragmen.Renouncing]
    /// </summary>
    public sealed class EnumRenouncing : BaseEnumExt<Renouncing, BaseVoid, BaseVoid, BaseCom<SubstrateNetApi.Model.Types.Primitive.U32>>
    {
    }
}
