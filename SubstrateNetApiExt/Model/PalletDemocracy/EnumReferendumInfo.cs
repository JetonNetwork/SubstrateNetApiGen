//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.PalletDemocracy;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletDemocracy
{
    
    
    public enum ReferendumInfo
    {
        
        Ongoing,
        
        Finished,
    }
    
    /// <summary>
    /// >> 372 - Variant[pallet_democracy.types.ReferendumInfo]
    /// </summary>
    public sealed class EnumReferendumInfo : BaseEnumExt<ReferendumInfo, SubstrateNetApi.Model.PalletDemocracy.ReferendumStatus, BaseTuple<SubstrateNetApi.Model.Types.Primitive.Bool, SubstrateNetApi.Model.Types.Primitive.U32>>
    {
    }
}
