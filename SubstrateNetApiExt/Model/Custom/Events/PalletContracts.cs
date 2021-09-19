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


namespace SubstrateNetApi.Model.Custom.Events
{
    
    
    /// <summary>
    /// >> Path: pallet_contracts.pallet.Event
    /// 
    ///			The [event](https://substrate.dev/docs/en/knowledgebase/runtime/events) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class PalletContracts
    {
        
        /// <summary>
        /// >> Event: Instantiated
        /// Contract deployed by address at the specified address. \[deployer, contract\]
        /// </summary>
        public sealed class Instantiated : BaseTuple<AccountId32, AccountId32>
        {
        }
        
        /// <summary>
        /// >> Event: Terminated
        /// Contract has been removed.
        /// \[contract, beneficiary\]
        /// 
        /// # Params
        /// 
        /// - `contract`: The contract that was terminated.
        /// - `beneficiary`: The account that received the contracts remaining balance.
        /// 
        /// # Note
        /// 
        /// The only way for a contract to be removed and emitting this event is by calling
        /// `seal_terminate`.
        /// </summary>
        public sealed class Terminated : BaseTuple<AccountId32, AccountId32>
        {
        }
        
        /// <summary>
        /// >> Event: CodeStored
        /// Code with the specified hash has been stored. \[code_hash\]
        /// </summary>
        public sealed class CodeStored : BaseTuple<H256>
        {
        }
        
        /// <summary>
        /// >> Event: ScheduleUpdated
        /// Triggered when the current schedule is updated.
        /// \[version\]
        /// 
        /// # Params
        /// 
        /// - `version`: The version of the newly set schedule.
        /// </summary>
        public sealed class ScheduleUpdated : BaseTuple<U32>
        {
        }
        
        /// <summary>
        /// >> Event: ContractEmitted
        /// A custom event emitted by the contract.
        /// \[contract, data\]
        /// 
        /// # Params
        /// 
        /// - `contract`: The contract that emitted the event.
        /// - `data`: Data supplied by the contract. Metadata generated during contract compilation
        ///   is needed to decode it.
        /// </summary>
        public sealed class ContractEmitted : BaseTuple<AccountId32, BaseVec<U8>>
        {
        }
        
        /// <summary>
        /// >> Event: CodeRemoved
        /// A code with the specified hash was removed.
        /// \[code_hash\]
        /// 
        /// This happens when the last contract that uses this code hash was removed.
        /// </summary>
        public sealed class CodeRemoved : BaseTuple<H256>
        {
        }
    }
}
