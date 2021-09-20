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


namespace SubstrateNetApi.Model.PalletStaking
{
    
    
    /// <summary>
    /// >> Path: pallet_staking.pallet.pallet.Call
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class PalletStakingCall
    {
        
        /// <summary>
        /// >> Extrinsic: bond
        /// Take the origin account as a stash and lock up `value` of its balance. `controller` will
        /// be the account that controls it.
        /// 
        /// `value` must be more than the `minimum_balance` specified by `T::Currency`.
        /// 
        /// The dispatch origin for this call must be _Signed_ by the stash account.
        /// 
        /// Emits `Bonded`.
        /// # <weight>
        /// - Independent of the arguments. Moderate complexity.
        /// - O(1).
        /// - Three extra DB entries.
        /// 
        /// NOTE: Two of the storage writes (`Self::bonded`, `Self::payee`) are _never_ cleaned
        /// unless the `origin` falls below _existential deposit_ and gets removed as dust.
        /// ------------------
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall Bond(SubstrateNetApi.Model.SpRuntime.EnumMultiAddress controller, BaseCom<SubstrateNetApi.Model.Types.Primitive.U128> value, SubstrateNetApi.Model.PalletStaking.EnumRewardDestination payee)
        {
            return new GenericExtrinsicCall("Staking", "bond", controller, value, payee);
        }
        
        /// <summary>
        /// >> Extrinsic: bond_extra
        /// Add some extra amount that have appeared in the stash `free_balance` into the balance up
        /// for staking.
        /// 
        /// The dispatch origin for this call must be _Signed_ by the stash, not the controller.
        /// 
        /// Use this if there are additional funds in your stash account that you wish to bond.
        /// Unlike [`bond`](Self::bond) or [`unbond`](Self::unbond) this function does not impose
        /// any limitation on the amount that can be added.
        /// 
        /// Emits `Bonded`.
        /// 
        /// # <weight>
        /// - Independent of the arguments. Insignificant complexity.
        /// - O(1).
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall BondExtra(BaseCom<SubstrateNetApi.Model.Types.Primitive.U128> max_additional)
        {
            return new GenericExtrinsicCall("Staking", "bond_extra", max_additional);
        }
        
        /// <summary>
        /// >> Extrinsic: unbond
        /// Schedule a portion of the stash to be unlocked ready for transfer out after the bond
        /// period ends. If this leaves an amount actively bonded less than
        /// T::Currency::minimum_balance(), then it is increased to the full amount.
        /// 
        /// The dispatch origin for this call must be _Signed_ by the controller, not the stash.
        /// 
        /// Once the unlock period is done, you can call `withdraw_unbonded` to actually move
        /// the funds out of management ready for transfer.
        /// 
        /// No more than a limited number of unlocking chunks (see `MAX_UNLOCKING_CHUNKS`)
        /// can co-exists at the same time. In that case, [`Call::withdraw_unbonded`] need
        /// to be called first to remove some of the chunks (if possible).
        /// 
        /// If a user encounters the `InsufficientBond` error when calling this extrinsic,
        /// they should call `chill` first in order to free up their bonded funds.
        /// 
        /// Emits `Unbonded`.
        /// 
        /// See also [`Call::withdraw_unbonded`].
        /// </summary>
        public GenericExtrinsicCall Unbond(BaseCom<SubstrateNetApi.Model.Types.Primitive.U128> value)
        {
            return new GenericExtrinsicCall("Staking", "unbond", value);
        }
        
        /// <summary>
        /// >> Extrinsic: withdraw_unbonded
        /// Remove any unlocked chunks from the `unlocking` queue from our management.
        /// 
        /// This essentially frees up that balance to be used by the stash account to do
        /// whatever it wants.
        /// 
        /// The dispatch origin for this call must be _Signed_ by the controller.
        /// 
        /// Emits `Withdrawn`.
        /// 
        /// See also [`Call::unbond`].
        /// 
        /// # <weight>
        /// Complexity O(S) where S is the number of slashing spans to remove
        /// NOTE: Weight annotation is the kill scenario, we refund otherwise.
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall WithdrawUnbonded(SubstrateNetApi.Model.Types.Primitive.U32 num_slashing_spans)
        {
            return new GenericExtrinsicCall("Staking", "withdraw_unbonded", num_slashing_spans);
        }
        
        /// <summary>
        /// >> Extrinsic: validate
        /// Declare the desire to validate for the origin controller.
        /// 
        /// Effects will be felt at the beginning of the next era.
        /// 
        /// The dispatch origin for this call must be _Signed_ by the controller, not the stash.
        /// </summary>
        public GenericExtrinsicCall Validate(SubstrateNetApi.Model.PalletStaking.ValidatorPrefs prefs)
        {
            return new GenericExtrinsicCall("Staking", "validate", prefs);
        }
        
        /// <summary>
        /// >> Extrinsic: nominate
        /// Declare the desire to nominate `targets` for the origin controller.
        /// 
        /// Effects will be felt at the beginning of the next era.
        /// 
        /// The dispatch origin for this call must be _Signed_ by the controller, not the stash.
        /// 
        /// # <weight>
        /// - The transaction's complexity is proportional to the size of `targets` (N)
        /// which is capped at CompactAssignments::LIMIT (MAX_NOMINATIONS).
        /// - Both the reads and writes follow a similar pattern.
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall Nominate(BaseVec<SubstrateNetApi.Model.SpRuntime.EnumMultiAddress> targets)
        {
            return new GenericExtrinsicCall("Staking", "nominate", targets);
        }
        
        /// <summary>
        /// >> Extrinsic: chill
        /// Declare no desire to either validate or nominate.
        /// 
        /// Effects will be felt at the beginning of the next era.
        /// 
        /// The dispatch origin for this call must be _Signed_ by the controller, not the stash.
        /// 
        /// # <weight>
        /// - Independent of the arguments. Insignificant complexity.
        /// - Contains one read.
        /// - Writes are limited to the `origin` account key.
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall Chill()
        {
            return new GenericExtrinsicCall("Staking", "chill");
        }
        
        /// <summary>
        /// >> Extrinsic: set_payee
        /// (Re-)set the payment target for a controller.
        /// 
        /// Effects will be felt at the beginning of the next era.
        /// 
        /// The dispatch origin for this call must be _Signed_ by the controller, not the stash.
        /// 
        /// # <weight>
        /// - Independent of the arguments. Insignificant complexity.
        /// - Contains a limited number of reads.
        /// - Writes are limited to the `origin` account key.
        /// ---------
        /// - Weight: O(1)
        /// - DB Weight:
        ///     - Read: Ledger
        ///     - Write: Payee
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall SetPayee(SubstrateNetApi.Model.PalletStaking.EnumRewardDestination payee)
        {
            return new GenericExtrinsicCall("Staking", "set_payee", payee);
        }
        
        /// <summary>
        /// >> Extrinsic: set_controller
        /// (Re-)set the controller of a stash.
        /// 
        /// Effects will be felt at the beginning of the next era.
        /// 
        /// The dispatch origin for this call must be _Signed_ by the stash, not the controller.
        /// 
        /// # <weight>
        /// - Independent of the arguments. Insignificant complexity.
        /// - Contains a limited number of reads.
        /// - Writes are limited to the `origin` account key.
        /// ----------
        /// Weight: O(1)
        /// DB Weight:
        /// - Read: Bonded, Ledger New Controller, Ledger Old Controller
        /// - Write: Bonded, Ledger New Controller, Ledger Old Controller
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall SetController(SubstrateNetApi.Model.SpRuntime.EnumMultiAddress controller)
        {
            return new GenericExtrinsicCall("Staking", "set_controller", controller);
        }
        
        /// <summary>
        /// >> Extrinsic: set_validator_count
        /// Sets the ideal number of validators.
        /// 
        /// The dispatch origin must be Root.
        /// 
        /// # <weight>
        /// Weight: O(1)
        /// Write: Validator Count
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall SetValidatorCount(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> @new)
        {
            return new GenericExtrinsicCall("Staking", "set_validator_count", @new);
        }
        
        /// <summary>
        /// >> Extrinsic: increase_validator_count
        /// Increments the ideal number of validators.
        /// 
        /// The dispatch origin must be Root.
        /// 
        /// # <weight>
        /// Same as [`Self::set_validator_count`].
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall IncreaseValidatorCount(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> additional)
        {
            return new GenericExtrinsicCall("Staking", "increase_validator_count", additional);
        }
        
        /// <summary>
        /// >> Extrinsic: scale_validator_count
        /// Scale up the ideal number of validators by a factor.
        /// 
        /// The dispatch origin must be Root.
        /// 
        /// # <weight>
        /// Same as [`Self::set_validator_count`].
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall ScaleValidatorCount(SubstrateNetApi.Model.SpArithmetic.Percent factor)
        {
            return new GenericExtrinsicCall("Staking", "scale_validator_count", factor);
        }
        
        /// <summary>
        /// >> Extrinsic: force_no_eras
        /// Force there to be no new eras indefinitely.
        /// 
        /// The dispatch origin must be Root.
        /// 
        /// # Warning
        /// 
        /// The election process starts multiple blocks before the end of the era.
        /// Thus the election process may be ongoing when this is called. In this case the
        /// election will continue until the next era is triggered.
        /// 
        /// # <weight>
        /// - No arguments.
        /// - Weight: O(1)
        /// - Write: ForceEra
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall ForceNoEras()
        {
            return new GenericExtrinsicCall("Staking", "force_no_eras");
        }
        
        /// <summary>
        /// >> Extrinsic: force_new_era
        /// Force there to be a new era at the end of the next session. After this, it will be
        /// reset to normal (non-forced) behaviour.
        /// 
        /// The dispatch origin must be Root.
        /// 
        /// # Warning
        /// 
        /// The election process starts multiple blocks before the end of the era.
        /// If this is called just before a new era is triggered, the election process may not
        /// have enough blocks to get a result.
        /// 
        /// # <weight>
        /// - No arguments.
        /// - Weight: O(1)
        /// - Write ForceEra
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall ForceNewEra()
        {
            return new GenericExtrinsicCall("Staking", "force_new_era");
        }
        
        /// <summary>
        /// >> Extrinsic: set_invulnerables
        /// Set the validators who cannot be slashed (if any).
        /// 
        /// The dispatch origin must be Root.
        /// 
        /// # <weight>
        /// - O(V)
        /// - Write: Invulnerables
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall SetInvulnerables(BaseVec<SubstrateNetApi.Model.SpCore.AccountId32> invulnerables)
        {
            return new GenericExtrinsicCall("Staking", "set_invulnerables", invulnerables);
        }
        
        /// <summary>
        /// >> Extrinsic: force_unstake
        /// Force a current staker to become completely unstaked, immediately.
        /// 
        /// The dispatch origin must be Root.
        /// 
        /// # <weight>
        /// O(S) where S is the number of slashing spans to be removed
        /// Reads: Bonded, Slashing Spans, Account, Locks
        /// Writes: Bonded, Slashing Spans (if S > 0), Ledger, Payee, Validators, Nominators,
        /// Account, Locks Writes Each: SpanSlash * S
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall ForceUnstake(SubstrateNetApi.Model.SpCore.AccountId32 stash, SubstrateNetApi.Model.Types.Primitive.U32 num_slashing_spans)
        {
            return new GenericExtrinsicCall("Staking", "force_unstake", stash, num_slashing_spans);
        }
        
        /// <summary>
        /// >> Extrinsic: force_new_era_always
        /// Force there to be a new era at the end of sessions indefinitely.
        /// 
        /// The dispatch origin must be Root.
        /// 
        /// # Warning
        /// 
        /// The election process starts multiple blocks before the end of the era.
        /// If this is called just before a new era is triggered, the election process may not
        /// have enough blocks to get a result.
        /// 
        /// # <weight>
        /// - Weight: O(1)
        /// - Write: ForceEra
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall ForceNewEraAlways()
        {
            return new GenericExtrinsicCall("Staking", "force_new_era_always");
        }
        
        /// <summary>
        /// >> Extrinsic: cancel_deferred_slash
        /// Cancel enactment of a deferred slash.
        /// 
        /// Can be called by the `T::SlashCancelOrigin`.
        /// 
        /// Parameters: era and indices of the slashes for that era to kill.
        /// 
        /// # <weight>
        /// Complexity: O(U + S)
        /// with U unapplied slashes weighted with U=1000
        /// and S is the number of slash indices to be canceled.
        /// - Read: Unapplied Slashes
        /// - Write: Unapplied Slashes
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall CancelDeferredSlash(SubstrateNetApi.Model.Types.Primitive.U32 era, BaseVec<SubstrateNetApi.Model.Types.Primitive.U32> slash_indices)
        {
            return new GenericExtrinsicCall("Staking", "cancel_deferred_slash", era, slash_indices);
        }
        
        /// <summary>
        /// >> Extrinsic: payout_stakers
        /// Pay out all the stakers behind a single validator for a single era.
        /// 
        /// - `validator_stash` is the stash account of the validator. Their nominators, up to
        ///   `T::MaxNominatorRewardedPerValidator`, will also receive their rewards.
        /// - `era` may be any era between `[current_era - history_depth; current_era]`.
        /// 
        /// The origin of this call must be _Signed_. Any account can call this function, even if
        /// it is not one of the stakers.
        /// 
        /// # <weight>
        /// - Time complexity: at most O(MaxNominatorRewardedPerValidator).
        /// - Contains a limited number of reads and writes.
        /// -----------
        /// N is the Number of payouts for the validator (including the validator)
        /// Weight:
        /// - Reward Destination Staked: O(N)
        /// - Reward Destination Controller (Creating): O(N)
        /// 
        ///   NOTE: weights are assuming that payouts are made to alive stash account (Staked).
        ///   Paying even a dead controller is cheaper weight-wise. We don't do any refunds here.
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall PayoutStakers(SubstrateNetApi.Model.SpCore.AccountId32 validator_stash, SubstrateNetApi.Model.Types.Primitive.U32 era)
        {
            return new GenericExtrinsicCall("Staking", "payout_stakers", validator_stash, era);
        }
        
        /// <summary>
        /// >> Extrinsic: rebond
        /// Rebond a portion of the stash scheduled to be unlocked.
        /// 
        /// The dispatch origin must be signed by the controller.
        /// 
        /// # <weight>
        /// - Time complexity: O(L), where L is unlocking chunks
        /// - Bounded by `MAX_UNLOCKING_CHUNKS`.
        /// - Storage changes: Can't increase storage, only decrease it.
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall Rebond(BaseCom<SubstrateNetApi.Model.Types.Primitive.U128> value)
        {
            return new GenericExtrinsicCall("Staking", "rebond", value);
        }
        
        /// <summary>
        /// >> Extrinsic: set_history_depth
        /// Set `HistoryDepth` value. This function will delete any history information
        /// when `HistoryDepth` is reduced.
        /// 
        /// Parameters:
        /// - `new_history_depth`: The new history depth you would like to set.
        /// - `era_items_deleted`: The number of items that will be deleted by this dispatch. This
        ///   should report all the storage items that will be deleted by clearing old era history.
        ///   Needed to report an accurate weight for the dispatch. Trusted by `Root` to report an
        ///   accurate number.
        /// 
        /// Origin must be root.
        /// 
        /// # <weight>
        /// - E: Number of history depths removed, i.e. 10 -> 7 = 3
        /// - Weight: O(E)
        /// - DB Weight:
        ///     - Reads: Current Era, History Depth
        ///     - Writes: History Depth
        ///     - Clear Prefix Each: Era Stakers, EraStakersClipped, ErasValidatorPrefs
        ///     - Writes Each: ErasValidatorReward, ErasRewardPoints, ErasTotalStake,
        ///       ErasStartSessionIndex
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall SetHistoryDepth(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> new_history_depth, BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> era_items_deleted)
        {
            return new GenericExtrinsicCall("Staking", "set_history_depth", new_history_depth, era_items_deleted);
        }
        
        /// <summary>
        /// >> Extrinsic: reap_stash
        /// Remove all data structure concerning a staker/stash once its balance is at the minimum.
        /// This is essentially equivalent to `withdraw_unbonded` except it can be called by anyone
        /// and the target `stash` must have no funds left beyond the ED.
        /// 
        /// This can be called from any origin.
        /// 
        /// - `stash`: The stash account to reap. Its balance must be zero.
        /// 
        /// # <weight>
        /// Complexity: O(S) where S is the number of slashing spans on the account.
        /// DB Weight:
        /// - Reads: Stash Account, Bonded, Slashing Spans, Locks
        /// - Writes: Bonded, Slashing Spans (if S > 0), Ledger, Payee, Validators, Nominators,
        ///   Stash Account, Locks
        /// - Writes Each: SpanSlash * S
        /// # </weight>
        /// </summary>
        public GenericExtrinsicCall ReapStash(SubstrateNetApi.Model.SpCore.AccountId32 stash, SubstrateNetApi.Model.Types.Primitive.U32 num_slashing_spans)
        {
            return new GenericExtrinsicCall("Staking", "reap_stash", stash, num_slashing_spans);
        }
        
        /// <summary>
        /// >> Extrinsic: kick
        /// Remove the given nominations from the calling validator.
        /// 
        /// Effects will be felt at the beginning of the next era.
        /// 
        /// The dispatch origin for this call must be _Signed_ by the controller, not the stash.
        /// 
        /// - `who`: A list of nominator stash accounts who are nominating this validator which
        ///   should no longer be nominating this validator.
        /// 
        /// Note: Making this call only makes sense if you first set the validator preferences to
        /// block any further nominations.
        /// </summary>
        public GenericExtrinsicCall Kick(BaseVec<SubstrateNetApi.Model.SpRuntime.EnumMultiAddress> who)
        {
            return new GenericExtrinsicCall("Staking", "kick", who);
        }
        
        /// <summary>
        /// >> Extrinsic: set_staking_limits
        /// Update the various staking limits this pallet.
        /// 
        /// * `min_nominator_bond`: The minimum active bond needed to be a nominator.
        /// * `min_validator_bond`: The minimum active bond needed to be a validator.
        /// * `max_nominator_count`: The max number of users who can be a nominator at once. When
        ///   set to `None`, no limit is enforced.
        /// * `max_validator_count`: The max number of users who can be a validator at once. When
        ///   set to `None`, no limit is enforced.
        /// 
        /// Origin must be Root to call this function.
        /// 
        /// NOTE: Existing nominators and validators will not be affected by this update.
        /// to kick people under the new limits, `chill_other` should be called.
        /// </summary>
        public GenericExtrinsicCall SetStakingLimits(SubstrateNetApi.Model.Types.Primitive.U128 min_nominator_bond, SubstrateNetApi.Model.Types.Primitive.U128 min_validator_bond, BaseOpt<SubstrateNetApi.Model.Types.Primitive.U32> max_nominator_count, BaseOpt<SubstrateNetApi.Model.Types.Primitive.U32> max_validator_count, BaseOpt<SubstrateNetApi.Model.SpArithmetic.Percent> threshold)
        {
            return new GenericExtrinsicCall("Staking", "set_staking_limits", min_nominator_bond, min_validator_bond, max_nominator_count, max_validator_count, threshold);
        }
        
        /// <summary>
        /// >> Extrinsic: chill_other
        /// Declare a `controller` to stop participating as either a validator or nominator.
        /// 
        /// Effects will be felt at the beginning of the next era.
        /// 
        /// The dispatch origin for this call must be _Signed_, but can be called by anyone.
        /// 
        /// If the caller is the same as the controller being targeted, then no further checks are
        /// enforced, and this function behaves just like `chill`.
        /// 
        /// If the caller is different than the controller being targeted, the following conditions
        /// must be met:
        /// * A `ChillThreshold` must be set and checked which defines how close to the max
        ///   nominators or validators we must reach before users can start chilling one-another.
        /// * A `MaxNominatorCount` and `MaxValidatorCount` must be set which is used to determine
        ///   how close we are to the threshold.
        /// * A `MinNominatorBond` and `MinValidatorBond` must be set and checked, which determines
        ///   if this is a person that should be chilled because they have not met the threshold
        ///   bond required.
        /// 
        /// This can be helpful if bond requirements are updated, and we need to remove old users
        /// who do not satisfy these requirements.
        /// </summary>
        public GenericExtrinsicCall ChillOther(SubstrateNetApi.Model.SpCore.AccountId32 controller)
        {
            return new GenericExtrinsicCall("Staking", "chill_other", controller);
        }
    }
}