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


namespace SubstrateNetApi.Model.PalletAssets
{
    
    
    /// <summary>
    /// >> 481 - Composite[pallet_assets.types.AssetBalance]
    /// </summary>
    public sealed class AssetBalance : BaseType
    {
        
        /// <summary>
        /// >> balance
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U64 _balance;
        
        /// <summary>
        /// >> is_frozen
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.Bool _isFrozen;
        
        /// <summary>
        /// >> sufficient
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.Bool _sufficient;
        
        /// <summary>
        /// >> extra
        /// </summary>
        private BaseTuple _extra;
        
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
        
        public SubstrateNetApi.Model.Types.Primitive.Bool Sufficient
        {
            get
            {
                return this._sufficient;
            }
            set
            {
                this._sufficient = value;
            }
        }
        
        public BaseTuple Extra
        {
            get
            {
                return this._extra;
            }
            set
            {
                this._extra = value;
            }
        }
        
        public override string TypeName()
        {
            return "AssetBalance";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Balance.Encode());
            result.AddRange(IsFrozen.Encode());
            result.AddRange(Sufficient.Encode());
            result.AddRange(Extra.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Balance = new SubstrateNetApi.Model.Types.Primitive.U64();
            Balance.Decode(byteArray, ref p);
            IsFrozen = new SubstrateNetApi.Model.Types.Primitive.Bool();
            IsFrozen.Decode(byteArray, ref p);
            Sufficient = new SubstrateNetApi.Model.Types.Primitive.Bool();
            Sufficient.Decode(byteArray, ref p);
            Extra = new BaseTuple();
            Extra.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
