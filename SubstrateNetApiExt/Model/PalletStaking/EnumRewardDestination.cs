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
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletStaking
{
    
    
    public enum RewardDestination
    {
        
        Staked,
        
        Stash,
        
        Controller,
        
        Account,
        
        None,
    }
    
    /// <summary>
    /// >> 200 - Variant[pallet_staking.RewardDestination]
    /// </summary>
    public sealed class EnumRewardDestination : BaseEnumExt<RewardDestination, BaseVoid, BaseVoid, BaseVoid, SubstrateNetApi.Model.SpCore.AccountId32, BaseVoid>
    {
    }
}
