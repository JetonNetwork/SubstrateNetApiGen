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


namespace SubstrateNetApi.Model.PalletDemocracy
{
    
    
    /// <summary>
    /// >> Path: pallet_democracy.types.Tally
    /// </summary>
    public sealed class Tally : BaseType
    {
        
        private SubstrateNetApi.Model.Types.Primitive.U128 _ayes;
        
        private SubstrateNetApi.Model.Types.Primitive.U128 _nays;
        
        private SubstrateNetApi.Model.Types.Primitive.U128 _turnout;
        
        public SubstrateNetApi.Model.Types.Primitive.U128 Ayes
        {
            get
            {
                return this._ayes;
            }
            set
            {
                this._ayes = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U128 Nays
        {
            get
            {
                return this._nays;
            }
            set
            {
                this._nays = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U128 Turnout
        {
            get
            {
                return this._turnout;
            }
            set
            {
                this._turnout = value;
            }
        }
        
        public override string TypeName()
        {
            return "Tally";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Ayes.Encode());
            result.AddRange(Nays.Encode());
            result.AddRange(Turnout.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Ayes = new SubstrateNetApi.Model.Types.Primitive.U128();
            Ayes.Decode(byteArray, ref p);
            Nays = new SubstrateNetApi.Model.Types.Primitive.U128();
            Nays.Decode(byteArray, ref p);
            Turnout = new SubstrateNetApi.Model.Types.Primitive.U128();
            Turnout.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}