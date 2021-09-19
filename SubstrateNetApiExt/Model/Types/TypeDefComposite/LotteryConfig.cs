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
    
    
    public sealed class LotteryConfig : BaseType
    {
        
        private U128 _price;
        
        private U32 _start;
        
        private U32 _length;
        
        private U32 _delay;
        
        private Bool _repeat;
        
        public U128 Price
        {
            get
            {
                return this._price;
            }
            set
            {
                this._price = value;
            }
        }
        
        public U32 Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        public U32 Length
        {
            get
            {
                return this._length;
            }
            set
            {
                this._length = value;
            }
        }
        
        public U32 Delay
        {
            get
            {
                return this._delay;
            }
            set
            {
                this._delay = value;
            }
        }
        
        public Bool Repeat
        {
            get
            {
                return this._repeat;
            }
            set
            {
                this._repeat = value;
            }
        }
        
        public override string TypeName()
        {
            return "LotteryConfig";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Price.Encode());
            result.AddRange(Start.Encode());
            result.AddRange(Length.Encode());
            result.AddRange(Delay.Encode());
            result.AddRange(Repeat.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Price = new U128();
            Price.Decode(byteArray, ref p);
            Start = new U32();
            Start.Decode(byteArray, ref p);
            Length = new U32();
            Length.Decode(byteArray, ref p);
            Delay = new U32();
            Delay.Decode(byteArray, ref p);
            Repeat = new Bool();
            Repeat.Decode(byteArray, ref p);
            _typeSize = p - start;
        }
    }
}
