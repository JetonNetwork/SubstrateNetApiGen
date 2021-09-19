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
    /// >> Path: pallet_membership.pallet.Call
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class PalletMembership
    {
        
        /// <summary>
        /// >> Extrinsic: add_member
        /// Add a member `who` to the set.
        /// 
        /// May only be called from `T::AddOrigin`.
        /// </summary>
        public GenericExtrinsicCall AddMember(AccountId32 who)
        {
            return new GenericExtrinsicCall("Membership", "add_member", who);
        }
        
        /// <summary>
        /// >> Extrinsic: remove_member
        /// Remove a member `who` from the set.
        /// 
        /// May only be called from `T::RemoveOrigin`.
        /// </summary>
        public GenericExtrinsicCall RemoveMember(AccountId32 who)
        {
            return new GenericExtrinsicCall("Membership", "remove_member", who);
        }
        
        /// <summary>
        /// >> Extrinsic: swap_member
        /// Swap out one member `remove` for another `add`.
        /// 
        /// May only be called from `T::SwapOrigin`.
        /// 
        /// Prime membership is *not* passed from `remove` to `add`, if extant.
        /// </summary>
        public GenericExtrinsicCall SwapMember(AccountId32 remove, AccountId32 add)
        {
            return new GenericExtrinsicCall("Membership", "swap_member", remove, add);
        }
        
        /// <summary>
        /// >> Extrinsic: reset_members
        /// Change the membership to a new set, disregarding the existing membership. Be nice and
        /// pass `members` pre-sorted.
        /// 
        /// May only be called from `T::ResetOrigin`.
        /// </summary>
        public GenericExtrinsicCall ResetMembers(BaseVec<AccountId32> members)
        {
            return new GenericExtrinsicCall("Membership", "reset_members", members);
        }
        
        /// <summary>
        /// >> Extrinsic: change_key
        /// Swap out the sending member for some other key `new`.
        /// 
        /// May only be called from `Signed` origin of a current member.
        /// 
        /// Prime membership is passed from the origin account to `new`, if extant.
        /// </summary>
        public GenericExtrinsicCall ChangeKey(AccountId32 @new)
        {
            return new GenericExtrinsicCall("Membership", "change_key", @new);
        }
        
        /// <summary>
        /// >> Extrinsic: set_prime
        /// Set the prime member. Must be a current member.
        /// 
        /// May only be called from `T::PrimeOrigin`.
        /// </summary>
        public GenericExtrinsicCall SetPrime(AccountId32 who)
        {
            return new GenericExtrinsicCall("Membership", "set_prime", who);
        }
        
        /// <summary>
        /// >> Extrinsic: clear_prime
        /// Remove the prime member if it exists.
        /// 
        /// May only be called from `T::PrimeOrigin`.
        /// </summary>
        public GenericExtrinsicCall ClearPrime()
        {
            return new GenericExtrinsicCall("Membership", "clear_prime");
        }
    }
}
