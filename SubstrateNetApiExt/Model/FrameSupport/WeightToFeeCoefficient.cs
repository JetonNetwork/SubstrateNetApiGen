//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.SpArithmetic;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.FrameSupport
{
    
    
    /// <summary>
    /// >> 332 - Composite[frame_support.weights.WeightToFeeCoefficient]
    /// </summary>
    public sealed class WeightToFeeCoefficient : BaseType
    {
        
        /// <summary>
        /// >> coeff_integer
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U128 _coeffInteger;
        
        /// <summary>
        /// >> coeff_frac
        /// </summary>
        private SubstrateNetApi.Model.SpArithmetic.Perbill _coeffFrac;
        
        /// <summary>
        /// >> negative
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.Bool _negative;
        
        /// <summary>
        /// >> degree
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U8 _degree;
        
        public SubstrateNetApi.Model.Types.Primitive.U128 CoeffInteger
        {
            get
            {
                return this._coeffInteger;
            }
            set
            {
                this._coeffInteger = value;
            }
        }
        
        public SubstrateNetApi.Model.SpArithmetic.Perbill CoeffFrac
        {
            get
            {
                return this._coeffFrac;
            }
            set
            {
                this._coeffFrac = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.Bool Negative
        {
            get
            {
                return this._negative;
            }
            set
            {
                this._negative = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U8 Degree
        {
            get
            {
                return this._degree;
            }
            set
            {
                this._degree = value;
            }
        }
        
        public override string TypeName()
        {
            return "WeightToFeeCoefficient";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(CoeffInteger.Encode());
            result.AddRange(CoeffFrac.Encode());
            result.AddRange(Negative.Encode());
            result.AddRange(Degree.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            CoeffInteger = new SubstrateNetApi.Model.Types.Primitive.U128();
            CoeffInteger.Decode(byteArray, ref p);
            CoeffFrac = new SubstrateNetApi.Model.SpArithmetic.Perbill();
            CoeffFrac.Decode(byteArray, ref p);
            Negative = new SubstrateNetApi.Model.Types.Primitive.Bool();
            Negative.Decode(byteArray, ref p);
            Degree = new SubstrateNetApi.Model.Types.Primitive.U8();
            Degree.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
