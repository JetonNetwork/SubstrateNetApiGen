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


namespace SubstrateNetApi.Model.Types.TypeDefVariant
{
    
    
    public enum Phase
    {
        
        Off,
        
        Signed,
        
        Unsigned,
        
        Emergency,
    }
    
    public sealed class EnumPhase : BaseEnumExt<Phase, NullType, NullType, BaseTuple<Bool,U32>, NullType>
    {
    }
}
