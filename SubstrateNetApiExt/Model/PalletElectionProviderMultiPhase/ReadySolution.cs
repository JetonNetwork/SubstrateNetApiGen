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


namespace SubstrateNetApi.Model.PalletElectionProviderMultiPhase
{
    
    
    /// <summary>
    /// >> Path: pallet_election_provider_multi_phase.ReadySolution
    /// </summary>
    public sealed class ReadySolution : BaseType
    {
        
        private BaseVec<BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.SpNposElections.Support>> _supports;
        
        private SubstrateNetApi.Model.Base.Arr3Special11 _score;
        
        private SubstrateNetApi.Model.PalletElectionProviderMultiPhase.EnumElectionCompute _compute;
        
        public BaseVec<BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.SpNposElections.Support>> Supports
        {
            get
            {
                return this._supports;
            }
            set
            {
                this._supports = value;
            }
        }
        
        public SubstrateNetApi.Model.Base.Arr3Special11 Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
            }
        }
        
        public SubstrateNetApi.Model.PalletElectionProviderMultiPhase.EnumElectionCompute Compute
        {
            get
            {
                return this._compute;
            }
            set
            {
                this._compute = value;
            }
        }
        
        public override string TypeName()
        {
            return "ReadySolution";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Supports.Encode());
            result.AddRange(Score.Encode());
            result.AddRange(Compute.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Supports = new BaseVec<BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.SpNposElections.Support>>();
            Supports.Decode(byteArray, ref p);
            Score = new SubstrateNetApi.Model.Base.Arr3Special11();
            Score.Decode(byteArray, ref p);
            Compute = new SubstrateNetApi.Model.PalletElectionProviderMultiPhase.EnumElectionCompute();
            Compute.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
