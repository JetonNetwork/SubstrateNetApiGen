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


namespace SubstrateNetApi.Model.PalletContracts
{
    
    
    /// <summary>
    /// >> 409 - Composite[pallet_contracts.schedule.HostFnWeights]
    /// </summary>
    public sealed class HostFnWeights : BaseType
    {
        
        /// <summary>
        /// >> caller
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _caller;
        
        /// <summary>
        /// >> address
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _address;
        
        /// <summary>
        /// >> gas_left
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _gasLeft;
        
        /// <summary>
        /// >> balance
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _balance;
        
        /// <summary>
        /// >> value_transferred
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _valueTransferred;
        
        /// <summary>
        /// >> minimum_balance
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _minimumBalance;
        
        /// <summary>
        /// >> contract_deposit
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _contractDeposit;
        
        /// <summary>
        /// >> block_number
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _blockNumber;
        
        /// <summary>
        /// >> now
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _now;
        
        /// <summary>
        /// >> weight_to_fee
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _weightToFee;
        
        /// <summary>
        /// >> gas
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _gas;
        
        /// <summary>
        /// >> input
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _input;
        
        /// <summary>
        /// >> input_per_byte
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _inputPerByte;
        
        /// <summary>
        /// >> r#return
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _rHreturn;
        
        /// <summary>
        /// >> return_per_byte
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _returnPerByte;
        
        /// <summary>
        /// >> terminate
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _terminate;
        
        /// <summary>
        /// >> random
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _random;
        
        /// <summary>
        /// >> deposit_event
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _depositEvent;
        
        /// <summary>
        /// >> deposit_event_per_topic
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _depositEventPerTopic;
        
        /// <summary>
        /// >> deposit_event_per_byte
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _depositEventPerByte;
        
        /// <summary>
        /// >> debug_message
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _debugMessage;
        
        /// <summary>
        /// >> set_storage
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _setStorage;
        
        /// <summary>
        /// >> set_storage_per_byte
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _setStoragePerByte;
        
        /// <summary>
        /// >> clear_storage
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _clearStorage;
        
        /// <summary>
        /// >> get_storage
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _getStorage;
        
        /// <summary>
        /// >> get_storage_per_byte
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _getStoragePerByte;
        
        /// <summary>
        /// >> transfer
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _transfer;
        
        /// <summary>
        /// >> call
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _call;
        
        /// <summary>
        /// >> call_transfer_surcharge
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _callTransferSurcharge;
        
        /// <summary>
        /// >> call_per_input_byte
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _callPerInputByte;
        
        /// <summary>
        /// >> call_per_output_byte
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _callPerOutputByte;
        
        /// <summary>
        /// >> instantiate
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _instantiate;
        
        /// <summary>
        /// >> instantiate_per_input_byte
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _instantiatePerInputByte;
        
        /// <summary>
        /// >> instantiate_per_output_byte
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _instantiatePerOutputByte;
        
        /// <summary>
        /// >> instantiate_per_salt_byte
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _instantiatePerSaltByte;
        
        /// <summary>
        /// >> hash_sha2_256
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _hashSha2256;
        
        /// <summary>
        /// >> hash_sha2_256_per_byte
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _hashSha2256PerByte;
        
        /// <summary>
        /// >> hash_keccak_256
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _hashKeccak256;
        
        /// <summary>
        /// >> hash_keccak_256_per_byte
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _hashKeccak256PerByte;
        
        /// <summary>
        /// >> hash_blake2_256
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _hashBlake2256;
        
        /// <summary>
        /// >> hash_blake2_256_per_byte
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _hashBlake2256PerByte;
        
        /// <summary>
        /// >> hash_blake2_128
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _hashBlake2128;
        
        /// <summary>
        /// >> hash_blake2_128_per_byte
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _hashBlake2128PerByte;
        
        /// <summary>
        /// >> ecdsa_recover
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _ecdsaRecover;
        
        public SubstrateNetApi.Model.Types.Primitive.U64 Caller
        {
            get
            {
                return this._caller;
            }
            set
            {
                this._caller = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 GasLeft
        {
            get
            {
                return this._gasLeft;
            }
            set
            {
                this._gasLeft = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 Balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                this._balance = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 ValueTransferred
        {
            get
            {
                return this._valueTransferred;
            }
            set
            {
                this._valueTransferred = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 MinimumBalance
        {
            get
            {
                return this._minimumBalance;
            }
            set
            {
                this._minimumBalance = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 ContractDeposit
        {
            get
            {
                return this._contractDeposit;
            }
            set
            {
                this._contractDeposit = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 BlockNumber
        {
            get
            {
                return this._blockNumber;
            }
            set
            {
                this._blockNumber = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 Now
        {
            get
            {
                return this._now;
            }
            set
            {
                this._now = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 WeightToFee
        {
            get
            {
                return this._weightToFee;
            }
            set
            {
                this._weightToFee = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 Gas
        {
            get
            {
                return this._gas;
            }
            set
            {
                this._gas = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 Input
        {
            get
            {
                return this._input;
            }
            set
            {
                this._input = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 InputPerByte
        {
            get
            {
                return this._inputPerByte;
            }
            set
            {
                this._inputPerByte = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 RHreturn
        {
            get
            {
                return this._rHreturn;
            }
            set
            {
                this._rHreturn = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 ReturnPerByte
        {
            get
            {
                return this._returnPerByte;
            }
            set
            {
                this._returnPerByte = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 Terminate
        {
            get
            {
                return this._terminate;
            }
            set
            {
                this._terminate = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 Random
        {
            get
            {
                return this._random;
            }
            set
            {
                this._random = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 DepositEvent
        {
            get
            {
                return this._depositEvent;
            }
            set
            {
                this._depositEvent = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 DepositEventPerTopic
        {
            get
            {
                return this._depositEventPerTopic;
            }
            set
            {
                this._depositEventPerTopic = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 DepositEventPerByte
        {
            get
            {
                return this._depositEventPerByte;
            }
            set
            {
                this._depositEventPerByte = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 DebugMessage
        {
            get
            {
                return this._debugMessage;
            }
            set
            {
                this._debugMessage = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 SetStorage
        {
            get
            {
                return this._setStorage;
            }
            set
            {
                this._setStorage = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 SetStoragePerByte
        {
            get
            {
                return this._setStoragePerByte;
            }
            set
            {
                this._setStoragePerByte = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 ClearStorage
        {
            get
            {
                return this._clearStorage;
            }
            set
            {
                this._clearStorage = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 GetStorage
        {
            get
            {
                return this._getStorage;
            }
            set
            {
                this._getStorage = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 GetStoragePerByte
        {
            get
            {
                return this._getStoragePerByte;
            }
            set
            {
                this._getStoragePerByte = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 Transfer
        {
            get
            {
                return this._transfer;
            }
            set
            {
                this._transfer = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 Call
        {
            get
            {
                return this._call;
            }
            set
            {
                this._call = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 CallTransferSurcharge
        {
            get
            {
                return this._callTransferSurcharge;
            }
            set
            {
                this._callTransferSurcharge = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 CallPerInputByte
        {
            get
            {
                return this._callPerInputByte;
            }
            set
            {
                this._callPerInputByte = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 CallPerOutputByte
        {
            get
            {
                return this._callPerOutputByte;
            }
            set
            {
                this._callPerOutputByte = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 Instantiate
        {
            get
            {
                return this._instantiate;
            }
            set
            {
                this._instantiate = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 InstantiatePerInputByte
        {
            get
            {
                return this._instantiatePerInputByte;
            }
            set
            {
                this._instantiatePerInputByte = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 InstantiatePerOutputByte
        {
            get
            {
                return this._instantiatePerOutputByte;
            }
            set
            {
                this._instantiatePerOutputByte = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 InstantiatePerSaltByte
        {
            get
            {
                return this._instantiatePerSaltByte;
            }
            set
            {
                this._instantiatePerSaltByte = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 HashSha2256
        {
            get
            {
                return this._hashSha2256;
            }
            set
            {
                this._hashSha2256 = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 HashSha2256PerByte
        {
            get
            {
                return this._hashSha2256PerByte;
            }
            set
            {
                this._hashSha2256PerByte = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 HashKeccak256
        {
            get
            {
                return this._hashKeccak256;
            }
            set
            {
                this._hashKeccak256 = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 HashKeccak256PerByte
        {
            get
            {
                return this._hashKeccak256PerByte;
            }
            set
            {
                this._hashKeccak256PerByte = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 HashBlake2256
        {
            get
            {
                return this._hashBlake2256;
            }
            set
            {
                this._hashBlake2256 = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 HashBlake2256PerByte
        {
            get
            {
                return this._hashBlake2256PerByte;
            }
            set
            {
                this._hashBlake2256PerByte = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 HashBlake2128
        {
            get
            {
                return this._hashBlake2128;
            }
            set
            {
                this._hashBlake2128 = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 HashBlake2128PerByte
        {
            get
            {
                return this._hashBlake2128PerByte;
            }
            set
            {
                this._hashBlake2128PerByte = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U64 EcdsaRecover
        {
            get
            {
                return this._ecdsaRecover;
            }
            set
            {
                this._ecdsaRecover = value;
            }
        }
        
        public override string TypeName()
        {
            return "HostFnWeights";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Caller.Encode());
            result.AddRange(Address.Encode());
            result.AddRange(GasLeft.Encode());
            result.AddRange(Balance.Encode());
            result.AddRange(ValueTransferred.Encode());
            result.AddRange(MinimumBalance.Encode());
            result.AddRange(ContractDeposit.Encode());
            result.AddRange(BlockNumber.Encode());
            result.AddRange(Now.Encode());
            result.AddRange(WeightToFee.Encode());
            result.AddRange(Gas.Encode());
            result.AddRange(Input.Encode());
            result.AddRange(InputPerByte.Encode());
            result.AddRange(RHreturn.Encode());
            result.AddRange(ReturnPerByte.Encode());
            result.AddRange(Terminate.Encode());
            result.AddRange(Random.Encode());
            result.AddRange(DepositEvent.Encode());
            result.AddRange(DepositEventPerTopic.Encode());
            result.AddRange(DepositEventPerByte.Encode());
            result.AddRange(DebugMessage.Encode());
            result.AddRange(SetStorage.Encode());
            result.AddRange(SetStoragePerByte.Encode());
            result.AddRange(ClearStorage.Encode());
            result.AddRange(GetStorage.Encode());
            result.AddRange(GetStoragePerByte.Encode());
            result.AddRange(Transfer.Encode());
            result.AddRange(Call.Encode());
            result.AddRange(CallTransferSurcharge.Encode());
            result.AddRange(CallPerInputByte.Encode());
            result.AddRange(CallPerOutputByte.Encode());
            result.AddRange(Instantiate.Encode());
            result.AddRange(InstantiatePerInputByte.Encode());
            result.AddRange(InstantiatePerOutputByte.Encode());
            result.AddRange(InstantiatePerSaltByte.Encode());
            result.AddRange(HashSha2256.Encode());
            result.AddRange(HashSha2256PerByte.Encode());
            result.AddRange(HashKeccak256.Encode());
            result.AddRange(HashKeccak256PerByte.Encode());
            result.AddRange(HashBlake2256.Encode());
            result.AddRange(HashBlake2256PerByte.Encode());
            result.AddRange(HashBlake2128.Encode());
            result.AddRange(HashBlake2128PerByte.Encode());
            result.AddRange(EcdsaRecover.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Caller = new SubstrateNetApi.Model.Types.Primitive.U64();
            Caller.Decode(byteArray, ref p);
            Address = new SubstrateNetApi.Model.Types.Primitive.U64();
            Address.Decode(byteArray, ref p);
            GasLeft = new SubstrateNetApi.Model.Types.Primitive.U64();
            GasLeft.Decode(byteArray, ref p);
            Balance = new SubstrateNetApi.Model.Types.Primitive.U64();
            Balance.Decode(byteArray, ref p);
            ValueTransferred = new SubstrateNetApi.Model.Types.Primitive.U64();
            ValueTransferred.Decode(byteArray, ref p);
            MinimumBalance = new SubstrateNetApi.Model.Types.Primitive.U64();
            MinimumBalance.Decode(byteArray, ref p);
            ContractDeposit = new SubstrateNetApi.Model.Types.Primitive.U64();
            ContractDeposit.Decode(byteArray, ref p);
            BlockNumber = new SubstrateNetApi.Model.Types.Primitive.U64();
            BlockNumber.Decode(byteArray, ref p);
            Now = new SubstrateNetApi.Model.Types.Primitive.U64();
            Now.Decode(byteArray, ref p);
            WeightToFee = new SubstrateNetApi.Model.Types.Primitive.U64();
            WeightToFee.Decode(byteArray, ref p);
            Gas = new SubstrateNetApi.Model.Types.Primitive.U64();
            Gas.Decode(byteArray, ref p);
            Input = new SubstrateNetApi.Model.Types.Primitive.U64();
            Input.Decode(byteArray, ref p);
            InputPerByte = new SubstrateNetApi.Model.Types.Primitive.U64();
            InputPerByte.Decode(byteArray, ref p);
            RHreturn = new SubstrateNetApi.Model.Types.Primitive.U64();
            RHreturn.Decode(byteArray, ref p);
            ReturnPerByte = new SubstrateNetApi.Model.Types.Primitive.U64();
            ReturnPerByte.Decode(byteArray, ref p);
            Terminate = new SubstrateNetApi.Model.Types.Primitive.U64();
            Terminate.Decode(byteArray, ref p);
            Random = new SubstrateNetApi.Model.Types.Primitive.U64();
            Random.Decode(byteArray, ref p);
            DepositEvent = new SubstrateNetApi.Model.Types.Primitive.U64();
            DepositEvent.Decode(byteArray, ref p);
            DepositEventPerTopic = new SubstrateNetApi.Model.Types.Primitive.U64();
            DepositEventPerTopic.Decode(byteArray, ref p);
            DepositEventPerByte = new SubstrateNetApi.Model.Types.Primitive.U64();
            DepositEventPerByte.Decode(byteArray, ref p);
            DebugMessage = new SubstrateNetApi.Model.Types.Primitive.U64();
            DebugMessage.Decode(byteArray, ref p);
            SetStorage = new SubstrateNetApi.Model.Types.Primitive.U64();
            SetStorage.Decode(byteArray, ref p);
            SetStoragePerByte = new SubstrateNetApi.Model.Types.Primitive.U64();
            SetStoragePerByte.Decode(byteArray, ref p);
            ClearStorage = new SubstrateNetApi.Model.Types.Primitive.U64();
            ClearStorage.Decode(byteArray, ref p);
            GetStorage = new SubstrateNetApi.Model.Types.Primitive.U64();
            GetStorage.Decode(byteArray, ref p);
            GetStoragePerByte = new SubstrateNetApi.Model.Types.Primitive.U64();
            GetStoragePerByte.Decode(byteArray, ref p);
            Transfer = new SubstrateNetApi.Model.Types.Primitive.U64();
            Transfer.Decode(byteArray, ref p);
            Call = new SubstrateNetApi.Model.Types.Primitive.U64();
            Call.Decode(byteArray, ref p);
            CallTransferSurcharge = new SubstrateNetApi.Model.Types.Primitive.U64();
            CallTransferSurcharge.Decode(byteArray, ref p);
            CallPerInputByte = new SubstrateNetApi.Model.Types.Primitive.U64();
            CallPerInputByte.Decode(byteArray, ref p);
            CallPerOutputByte = new SubstrateNetApi.Model.Types.Primitive.U64();
            CallPerOutputByte.Decode(byteArray, ref p);
            Instantiate = new SubstrateNetApi.Model.Types.Primitive.U64();
            Instantiate.Decode(byteArray, ref p);
            InstantiatePerInputByte = new SubstrateNetApi.Model.Types.Primitive.U64();
            InstantiatePerInputByte.Decode(byteArray, ref p);
            InstantiatePerOutputByte = new SubstrateNetApi.Model.Types.Primitive.U64();
            InstantiatePerOutputByte.Decode(byteArray, ref p);
            InstantiatePerSaltByte = new SubstrateNetApi.Model.Types.Primitive.U64();
            InstantiatePerSaltByte.Decode(byteArray, ref p);
            HashSha2256 = new SubstrateNetApi.Model.Types.Primitive.U64();
            HashSha2256.Decode(byteArray, ref p);
            HashSha2256PerByte = new SubstrateNetApi.Model.Types.Primitive.U64();
            HashSha2256PerByte.Decode(byteArray, ref p);
            HashKeccak256 = new SubstrateNetApi.Model.Types.Primitive.U64();
            HashKeccak256.Decode(byteArray, ref p);
            HashKeccak256PerByte = new SubstrateNetApi.Model.Types.Primitive.U64();
            HashKeccak256PerByte.Decode(byteArray, ref p);
            HashBlake2256 = new SubstrateNetApi.Model.Types.Primitive.U64();
            HashBlake2256.Decode(byteArray, ref p);
            HashBlake2256PerByte = new SubstrateNetApi.Model.Types.Primitive.U64();
            HashBlake2256PerByte.Decode(byteArray, ref p);
            HashBlake2128 = new SubstrateNetApi.Model.Types.Primitive.U64();
            HashBlake2128.Decode(byteArray, ref p);
            HashBlake2128PerByte = new SubstrateNetApi.Model.Types.Primitive.U64();
            HashBlake2128PerByte.Decode(byteArray, ref p);
            EcdsaRecover = new SubstrateNetApi.Model.Types.Primitive.U64();
            EcdsaRecover.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
