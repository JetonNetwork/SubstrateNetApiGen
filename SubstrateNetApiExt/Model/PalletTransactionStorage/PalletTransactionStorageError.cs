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


namespace SubstrateNetApi.Model.PalletTransactionStorage
{
    
    
    /// <summary>
    /// >> Path: pallet_transaction_storage.pallet.Error
    /// 
    ///			Custom [dispatch errors](https://substrate.dev/docs/en/knowledgebase/runtime/errors)
    ///			of this pallet.
    ///			
    /// </summary>
    public enum PalletTransactionStorageError
    {
        
        /// <summary>
        /// >> Event: InsufficientFunds
        /// Insufficient account balance.
        /// </summary>
        InsufficientFunds,
        
        /// <summary>
        /// >> Event: NotConfigured
        /// Invalid configuration.
        /// </summary>
        NotConfigured,
        
        /// <summary>
        /// >> Event: RenewedNotFound
        /// Renewed extrinsic is not found.
        /// </summary>
        RenewedNotFound,
        
        /// <summary>
        /// >> Event: EmptyTransaction
        /// Attempting to store empty transaction
        /// </summary>
        EmptyTransaction,
        
        /// <summary>
        /// >> Event: UnexpectedProof
        /// Proof was not expected in this block.
        /// </summary>
        UnexpectedProof,
        
        /// <summary>
        /// >> Event: InvalidProof
        /// Proof failed verification.
        /// </summary>
        InvalidProof,
        
        /// <summary>
        /// >> Event: MissingProof
        /// Missing storage proof.
        /// </summary>
        MissingProof,
        
        /// <summary>
        /// >> Event: MissingStateData
        /// Unable to verify proof becasue state data is missing.
        /// </summary>
        MissingStateData,
        
        /// <summary>
        /// >> Event: DoubleCheck
        /// Double proof check in the block.
        /// </summary>
        DoubleCheck,
        
        /// <summary>
        /// >> Event: ProofNotChecked
        /// Storage proof was not checked in the block.
        /// </summary>
        ProofNotChecked,
        
        /// <summary>
        /// >> Event: TransactionTooLarge
        /// Transaction is too large.
        /// </summary>
        TransactionTooLarge,
        
        /// <summary>
        /// >> Event: TooManyTransactions
        /// Too many transactions in the block.
        /// </summary>
        TooManyTransactions,
        
        /// <summary>
        /// >> Event: BadContext
        /// Attempted to call `store` outside of block execution.
        /// </summary>
        BadContext,
    }
}