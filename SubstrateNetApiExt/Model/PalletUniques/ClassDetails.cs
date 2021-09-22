//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.SpCore;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletUniques
{
    
    
    /// <summary>
    /// >> 493 - Composite[pallet_uniques.types.ClassDetails]
    /// </summary>
    public sealed class ClassDetails : BaseType
    {
        
        /// <summary>
        /// >> owner
        /// </summary>
        private SubstrateNetApi.Model.SpCore.AccountId32 _owner;
        
        /// <summary>
        /// >> issuer
        /// </summary>
        private SubstrateNetApi.Model.SpCore.AccountId32 _issuer;
        
        /// <summary>
        /// >> admin
        /// </summary>
        private SubstrateNetApi.Model.SpCore.AccountId32 _admin;
        
        /// <summary>
        /// >> freezer
        /// </summary>
        private SubstrateNetApi.Model.SpCore.AccountId32 _freezer;
        
        /// <summary>
        /// >> total_deposit
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U128 _totalDeposit;
        
        /// <summary>
        /// >> free_holding
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.Bool _freeHolding;
        
        /// <summary>
        /// >> instances
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U32 _instances;
        
        /// <summary>
        /// >> instance_metadatas
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U32 _instanceMetadatas;
        
        /// <summary>
        /// >> attributes
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U32 _attributes;
        
        /// <summary>
        /// >> is_frozen
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.Bool _isFrozen;
        
        public SubstrateNetApi.Model.SpCore.AccountId32 Owner
        {
            get
            {
                return this._owner;
            }
            set
            {
                this._owner = value;
            }
        }
        
        public SubstrateNetApi.Model.SpCore.AccountId32 Issuer
        {
            get
            {
                return this._issuer;
            }
            set
            {
                this._issuer = value;
            }
        }
        
        public SubstrateNetApi.Model.SpCore.AccountId32 Admin
        {
            get
            {
                return this._admin;
            }
            set
            {
                this._admin = value;
            }
        }
        
        public SubstrateNetApi.Model.SpCore.AccountId32 Freezer
        {
            get
            {
                return this._freezer;
            }
            set
            {
                this._freezer = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U128 TotalDeposit
        {
            get
            {
                return this._totalDeposit;
            }
            set
            {
                this._totalDeposit = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.Bool FreeHolding
        {
            get
            {
                return this._freeHolding;
            }
            set
            {
                this._freeHolding = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U32 Instances
        {
            get
            {
                return this._instances;
            }
            set
            {
                this._instances = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U32 InstanceMetadatas
        {
            get
            {
                return this._instanceMetadatas;
            }
            set
            {
                this._instanceMetadatas = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U32 Attributes
        {
            get
            {
                return this._attributes;
            }
            set
            {
                this._attributes = value;
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
            return "ClassDetails";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Owner.Encode());
            result.AddRange(Issuer.Encode());
            result.AddRange(Admin.Encode());
            result.AddRange(Freezer.Encode());
            result.AddRange(TotalDeposit.Encode());
            result.AddRange(FreeHolding.Encode());
            result.AddRange(Instances.Encode());
            result.AddRange(InstanceMetadatas.Encode());
            result.AddRange(Attributes.Encode());
            result.AddRange(IsFrozen.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Owner = new SubstrateNetApi.Model.SpCore.AccountId32();
            Owner.Decode(byteArray, ref p);
            Issuer = new SubstrateNetApi.Model.SpCore.AccountId32();
            Issuer.Decode(byteArray, ref p);
            Admin = new SubstrateNetApi.Model.SpCore.AccountId32();
            Admin.Decode(byteArray, ref p);
            Freezer = new SubstrateNetApi.Model.SpCore.AccountId32();
            Freezer.Decode(byteArray, ref p);
            TotalDeposit = new SubstrateNetApi.Model.Types.Primitive.U128();
            TotalDeposit.Decode(byteArray, ref p);
            FreeHolding = new SubstrateNetApi.Model.Types.Primitive.Bool();
            FreeHolding.Decode(byteArray, ref p);
            Instances = new SubstrateNetApi.Model.Types.Primitive.U32();
            Instances.Decode(byteArray, ref p);
            InstanceMetadatas = new SubstrateNetApi.Model.Types.Primitive.U32();
            InstanceMetadatas.Decode(byteArray, ref p);
            Attributes = new SubstrateNetApi.Model.Types.Primitive.U32();
            Attributes.Decode(byteArray, ref p);
            IsFrozen = new SubstrateNetApi.Model.Types.Primitive.Bool();
            IsFrozen.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
