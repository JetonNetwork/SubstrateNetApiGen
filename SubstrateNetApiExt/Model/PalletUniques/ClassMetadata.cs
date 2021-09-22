//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.FrameSupport;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletUniques
{
    
    
    /// <summary>
    /// >> 496 - Composite[pallet_uniques.types.ClassMetadata]
    /// </summary>
    public sealed class ClassMetadata : BaseType
    {
        
        /// <summary>
        /// >> deposit
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U128 _deposit;
        
        /// <summary>
        /// >> data
        /// </summary>
        private SubstrateNetApi.Model.FrameSupport.BoundedVec _data;
        
        /// <summary>
        /// >> is_frozen
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.Bool _isFrozen;
        
        public SubstrateNetApi.Model.Types.Primitive.U128 Deposit
        {
            get
            {
                return this._deposit;
            }
            set
            {
                this._deposit = value;
            }
        }
        
        public SubstrateNetApi.Model.FrameSupport.BoundedVec Data
        {
            get
            {
                return this._data;
            }
            set
            {
                this._data = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.Bool IsFrozen
        {
            get
            {
                return this._isFrozen;
            }
            set
            {
                this._isFrozen = value;
            }
        }
        
        public override string TypeName()
        {
            return "ClassMetadata";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Deposit.Encode());
            result.AddRange(Data.Encode());
            result.AddRange(IsFrozen.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Deposit = new SubstrateNetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            Data = new SubstrateNetApi.Model.FrameSupport.BoundedVec();
            Data.Decode(byteArray, ref p);
            IsFrozen = new SubstrateNetApi.Model.Types.Primitive.Bool();
            IsFrozen.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
