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


namespace SubstrateNetApi.Model.PalletRecovery
{
    
    
    /// <summary>
    /// >> Path: pallet_recovery.pallet.Call
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class PalletRecoveryCall
    {
        
        /// <summary>
        /// >> Extrinsic: as_recovered
        /// Send a call through a recovered account.
        /// 
        /// The dispatch origin for this call must be _Signed_ and registered to
        /// be able to make calls on behalf of the recovered account.
        /// 
        /// Parameters:
        /// - `account`: The recovered account you want to make a call on-behalf-of.
        /// - `call`: The call you want to make with the recovered account.
        /// 
        /// # <weight>
        /// - The weight of the `call` + 10,000.
        /// - One storage lookup to check account is recovered by `who`. O(1)
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall AsRecovered(SubstrateNetApi.Model.SpCore.AccountId32 account, SubstrateNetApi.Model.NodeRuntime.EnumNodeCall call)
        {
            return new GenericExtrinsicCall("Recovery", "as_recovered", account, call);
        }
        
        /// <summary>
        /// >> Extrinsic: set_recovered
        /// Allow ROOT to bypass the recovery process and set an a rescuer account
        /// for a lost account directly.
        /// 
        /// The dispatch origin for this call must be _ROOT_.
        /// 
        /// Parameters:
        /// - `lost`: The "lost account" to be recovered.
        /// - `rescuer`: The "rescuer account" which can call as the lost account.
        /// 
        /// # <weight>
        /// - One storage write O(1)
        /// - One event
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall SetRecovered(SubstrateNetApi.Model.SpCore.AccountId32 lost, SubstrateNetApi.Model.SpCore.AccountId32 rescuer)
        {
            return new GenericExtrinsicCall("Recovery", "set_recovered", lost, rescuer);
        }
        
        /// <summary>
        /// >> Extrinsic: create_recovery
        /// Create a recovery configuration for your account. This makes your account recoverable.
        /// 
        /// Payment: `ConfigDepositBase` + `FriendDepositFactor` * #_of_friends balance
        /// will be reserved for storing the recovery configuration. This deposit is returned
        /// in full when the user calls `remove_recovery`.
        /// 
        /// The dispatch origin for this call must be _Signed_.
        /// 
        /// Parameters:
        /// - `friends`: A list of friends you trust to vouch for recovery attempts. Should be
        ///   ordered and contain no duplicate values.
        /// - `threshold`: The number of friends that must vouch for a recovery attempt before the
        ///   account can be recovered. Should be less than or equal to the length of the list of
        ///   friends.
        /// - `delay_period`: The number of blocks after a recovery attempt is initialized that
        ///   needs to pass before the account can be recovered.
        /// 
        /// # <weight>
        /// - Key: F (len of friends)
        /// - One storage read to check that account is not already recoverable. O(1).
        /// - A check that the friends list is sorted and unique. O(F)
        /// - One currency reserve operation. O(X)
        /// - One storage write. O(1). Codec O(F).
        /// - One event.
        /// 
        /// Total Complexity: O(F + X)
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall CreateRecovery(BaseVec<SubstrateNetApi.Model.SpCore.AccountId32> friends, SubstrateNetApi.Model.Types.Primitive.U16 threshold, SubstrateNetApi.Model.Types.Primitive.U32 delay_period)
        {
            return new GenericExtrinsicCall("Recovery", "create_recovery", friends, threshold, delay_period);
        }
        
        /// <summary>
        /// >> Extrinsic: initiate_recovery
        /// Initiate the process for recovering a recoverable account.
        /// 
        /// Payment: `RecoveryDeposit` balance will be reserved for initiating the
        /// recovery process. This deposit will always be repatriated to the account
        /// trying to be recovered. See `close_recovery`.
        /// 
        /// The dispatch origin for this call must be _Signed_.
        /// 
        /// Parameters:
        /// - `account`: The lost account that you want to recover. This account needs to be
        ///   recoverable (i.e. have a recovery configuration).
        /// 
        /// # <weight>
        /// - One storage read to check that account is recoverable. O(F)
        /// - One storage read to check that this recovery process hasn't already started. O(1)
        /// - One currency reserve operation. O(X)
        /// - One storage read to get the current block number. O(1)
        /// - One storage write. O(1).
        /// - One event.
        /// 
        /// Total Complexity: O(F + X)
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall InitiateRecovery(SubstrateNetApi.Model.SpCore.AccountId32 account)
        {
            return new GenericExtrinsicCall("Recovery", "initiate_recovery", account);
        }
        
        /// <summary>
        /// >> Extrinsic: vouch_recovery
        /// Allow a "friend" of a recoverable account to vouch for an active recovery
        /// process for that account.
        /// 
        /// The dispatch origin for this call must be _Signed_ and must be a "friend"
        /// for the recoverable account.
        /// 
        /// Parameters:
        /// - `lost`: The lost account that you want to recover.
        /// - `rescuer`: The account trying to rescue the lost account that you want to vouch for.
        /// 
        /// The combination of these two parameters must point to an active recovery
        /// process.
        /// 
        /// # <weight>
        /// Key: F (len of friends in config), V (len of vouching friends)
        /// - One storage read to get the recovery configuration. O(1), Codec O(F)
        /// - One storage read to get the active recovery process. O(1), Codec O(V)
        /// - One binary search to confirm caller is a friend. O(logF)
        /// - One binary search to confirm caller has not already vouched. O(logV)
        /// - One storage write. O(1), Codec O(V).
        /// - One event.
        /// 
        /// Total Complexity: O(F + logF + V + logV)
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall VouchRecovery(SubstrateNetApi.Model.SpCore.AccountId32 lost, SubstrateNetApi.Model.SpCore.AccountId32 rescuer)
        {
            return new GenericExtrinsicCall("Recovery", "vouch_recovery", lost, rescuer);
        }
        
        /// <summary>
        /// >> Extrinsic: claim_recovery
        /// Allow a successful rescuer to claim their recovered account.
        /// 
        /// The dispatch origin for this call must be _Signed_ and must be a "rescuer"
        /// who has successfully completed the account recovery process: collected
        /// `threshold` or more vouches, waited `delay_period` blocks since initiation.
        /// 
        /// Parameters:
        /// - `account`: The lost account that you want to claim has been successfully recovered by
        ///   you.
        /// 
        /// # <weight>
        /// Key: F (len of friends in config), V (len of vouching friends)
        /// - One storage read to get the recovery configuration. O(1), Codec O(F)
        /// - One storage read to get the active recovery process. O(1), Codec O(V)
        /// - One storage read to get the current block number. O(1)
        /// - One storage write. O(1), Codec O(V).
        /// - One event.
        /// 
        /// Total Complexity: O(F + V)
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall ClaimRecovery(SubstrateNetApi.Model.SpCore.AccountId32 account)
        {
            return new GenericExtrinsicCall("Recovery", "claim_recovery", account);
        }
        
        /// <summary>
        /// >> Extrinsic: close_recovery
        /// As the controller of a recoverable account, close an active recovery
        /// process for your account.
        /// 
        /// Payment: By calling this function, the recoverable account will receive
        /// the recovery deposit `RecoveryDeposit` placed by the rescuer.
        /// 
        /// The dispatch origin for this call must be _Signed_ and must be a
        /// recoverable account with an active recovery process for it.
        /// 
        /// Parameters:
        /// - `rescuer`: The account trying to rescue this recoverable account.
        /// 
        /// # <weight>
        /// Key: V (len of vouching friends)
        /// - One storage read/remove to get the active recovery process. O(1), Codec O(V)
        /// - One balance call to repatriate reserved. O(X)
        /// - One event.
        /// 
        /// Total Complexity: O(V + X)
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall CloseRecovery(SubstrateNetApi.Model.SpCore.AccountId32 rescuer)
        {
            return new GenericExtrinsicCall("Recovery", "close_recovery", rescuer);
        }
        
        /// <summary>
        /// >> Extrinsic: remove_recovery
        /// Remove the recovery process for your account. Recovered accounts are still accessible.
        /// 
        /// NOTE: The user must make sure to call `close_recovery` on all active
        /// recovery attempts before calling this function else it will fail.
        /// 
        /// Payment: By calling this function the recoverable account will unreserve
        /// their recovery configuration deposit.
        /// (`ConfigDepositBase` + `FriendDepositFactor` * #_of_friends)
        /// 
        /// The dispatch origin for this call must be _Signed_ and must be a
        /// recoverable account (i.e. has a recovery configuration).
        /// 
        /// # <weight>
        /// Key: F (len of friends)
        /// - One storage read to get the prefix iterator for active recoveries. O(1)
        /// - One storage read/remove to get the recovery configuration. O(1), Codec O(F)
        /// - One balance call to unreserved. O(X)
        /// - One event.
        /// 
        /// Total Complexity: O(F + X)
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall RemoveRecovery()
        {
            return new GenericExtrinsicCall("Recovery", "remove_recovery");
        }
        
        /// <summary>
        /// >> Extrinsic: cancel_recovered
        /// Cancel the ability to use `as_recovered` for `account`.
        /// 
        /// The dispatch origin for this call must be _Signed_ and registered to
        /// be able to make calls on behalf of the recovered account.
        /// 
        /// Parameters:
        /// - `account`: The recovered account you are able to call on-behalf-of.
        /// 
        /// # <weight>
        /// - One storage mutation to check account is recovered by `who`. O(1)
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall CancelRecovered(SubstrateNetApi.Model.SpCore.AccountId32 account)
        {
            return new GenericExtrinsicCall("Recovery", "cancel_recovered", account);
        }
    }
}
