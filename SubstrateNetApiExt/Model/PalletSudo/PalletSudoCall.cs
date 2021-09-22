//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Calls;
using SubstrateNetApi.Model.NodeRuntime;
using SubstrateNetApi.Model.SpRuntime;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletSudo
{
    
    
    /// <summary>
    /// >> 233 - Variant[pallet_sudo.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class PalletSudoCall
    {
        
        /// <summary>
        /// >> sudo
        /// </summary>
        public GenericExtrinsicCall Sudo(SubstrateNetApi.Model.NodeRuntime.EnumNodeCall call)
        {
            return new GenericExtrinsicCall("Sudo", "sudo", call);
        }
        
        /// <summary>
        /// >> sudo_unchecked_weight
        /// </summary>
        public GenericExtrinsicCall SudoUncheckedWeight(SubstrateNetApi.Model.NodeRuntime.EnumNodeCall call, SubstrateNetApi.Model.Types.Primitive.U64 weight)
        {
            return new GenericExtrinsicCall("Sudo", "sudo_unchecked_weight", call, weight);
        }
        
        /// <summary>
        /// >> set_key
        /// </summary>
        public GenericExtrinsicCall SetKey(SubstrateNetApi.Model.SpRuntime.EnumMultiAddress @new)
        {
            return new GenericExtrinsicCall("Sudo", "set_key", @new);
        }
        
        /// <summary>
        /// >> sudo_as
        /// </summary>
        public GenericExtrinsicCall SudoAs(SubstrateNetApi.Model.SpRuntime.EnumMultiAddress who, SubstrateNetApi.Model.NodeRuntime.EnumNodeCall call)
        {
            return new GenericExtrinsicCall("Sudo", "sudo_as", who, call);
        }
    }
}
