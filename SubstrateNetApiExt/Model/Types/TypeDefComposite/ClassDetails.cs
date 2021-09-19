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


namespace SubstrateNetApi.Model.Types.TypeDefComposite
{
    
    
    public sealed class ClassDetails : BaseType
    {
        
        private AccountId32 _owner;
        
        private AccountId32 _issuer;
        
        private AccountId32 _admin;
        
        private AccountId32 _freezer;
        
        private U128 _totalDeposit;
        
        private Bool _freeHolding;
        
        private U32 _instances;
        
        private U32 _instanceMetadatas;
        
        private U32 _attributes;
        
        private Bool _isFrozen;
        
        public AccountId32 Owner
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
        
        public AccountId32 Issuer
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
        
        public AccountId32 Admin
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
        
        public AccountId32 Freezer
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
        
        public U128 TotalDeposit
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
        
        public Bool FreeHolding
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
        
        public U32 Instances
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
        
        public U32 InstanceMetadatas
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
        
        public U32 Attributes
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
        
        public Bool IsFrozen
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
            Owner = new AccountId32();
            Owner.Decode(byteArray, ref p);
            Issuer = new AccountId32();
            Issuer.Decode(byteArray, ref p);
            Admin = new AccountId32();
            Admin.Decode(byteArray, ref p);
            Freezer = new AccountId32();
            Freezer.Decode(byteArray, ref p);
            TotalDeposit = new U128();
            TotalDeposit.Decode(byteArray, ref p);
            FreeHolding = new Bool();
            FreeHolding.Decode(byteArray, ref p);
            Instances = new U32();
            Instances.Decode(byteArray, ref p);
            InstanceMetadatas = new U32();
            InstanceMetadatas.Decode(byteArray, ref p);
            Attributes = new U32();
            Attributes.Decode(byteArray, ref p);
            IsFrozen = new Bool();
            IsFrozen.Decode(byteArray, ref p);
            _typeSize = p - start;
        }
    }
}