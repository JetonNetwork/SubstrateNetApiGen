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
    
    
    public sealed class InstructionWeights : BaseType
    {
        
        private U32 _version;
        
        private U32 _i64const;
        
        private U32 _i64load;
        
        private U32 _i64store;
        
        private U32 _select;
        
        private U32 _rHif;
        
        private U32 _br;
        
        private U32 _brIf;
        
        private U32 _brTable;
        
        private U32 _brTablePerEntry;
        
        private U32 _call;
        
        private U32 _callIndirect;
        
        private U32 _callIndirectPerParam;
        
        private U32 _localGet;
        
        private U32 _localSet;
        
        private U32 _localTee;
        
        private U32 _globalGet;
        
        private U32 _globalSet;
        
        private U32 _memoryCurrent;
        
        private U32 _memoryGrow;
        
        private U32 _i64clz;
        
        private U32 _i64ctz;
        
        private U32 _i64popcnt;
        
        private U32 _i64eqz;
        
        private U32 _i64extendsi32;
        
        private U32 _i64extendui32;
        
        private U32 _i32wrapi64;
        
        private U32 _i64eq;
        
        private U32 _i64ne;
        
        private U32 _i64lts;
        
        private U32 _i64ltu;
        
        private U32 _i64gts;
        
        private U32 _i64gtu;
        
        private U32 _i64les;
        
        private U32 _i64leu;
        
        private U32 _i64ges;
        
        private U32 _i64geu;
        
        private U32 _i64add;
        
        private U32 _i64sub;
        
        private U32 _i64mul;
        
        private U32 _i64divs;
        
        private U32 _i64divu;
        
        private U32 _i64rems;
        
        private U32 _i64remu;
        
        private U32 _i64and;
        
        private U32 _i64or;
        
        private U32 _i64xor;
        
        private U32 _i64shl;
        
        private U32 _i64shrs;
        
        private U32 _i64shru;
        
        private U32 _i64rotl;
        
        private U32 _i64rotr;
        
        public U32 Version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }
        
        public U32 I64const
        {
            get
            {
                return this._i64const;
            }
            set
            {
                this._i64const = value;
            }
        }
        
        public U32 I64load
        {
            get
            {
                return this._i64load;
            }
            set
            {
                this._i64load = value;
            }
        }
        
        public U32 I64store
        {
            get
            {
                return this._i64store;
            }
            set
            {
                this._i64store = value;
            }
        }
        
        public U32 Select
        {
            get
            {
                return this._select;
            }
            set
            {
                this._select = value;
            }
        }
        
        public U32 RHif
        {
            get
            {
                return this._rHif;
            }
            set
            {
                this._rHif = value;
            }
        }
        
        public U32 Br
        {
            get
            {
                return this._br;
            }
            set
            {
                this._br = value;
            }
        }
        
        public U32 BrIf
        {
            get
            {
                return this._brIf;
            }
            set
            {
                this._brIf = value;
            }
        }
        
        public U32 BrTable
        {
            get
            {
                return this._brTable;
            }
            set
            {
                this._brTable = value;
            }
        }
        
        public U32 BrTablePerEntry
        {
            get
            {
                return this._brTablePerEntry;
            }
            set
            {
                this._brTablePerEntry = value;
            }
        }
        
        public U32 Call
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
        
        public U32 CallIndirect
        {
            get
            {
                return this._callIndirect;
            }
            set
            {
                this._callIndirect = value;
            }
        }
        
        public U32 CallIndirectPerParam
        {
            get
            {
                return this._callIndirectPerParam;
            }
            set
            {
                this._callIndirectPerParam = value;
            }
        }
        
        public U32 LocalGet
        {
            get
            {
                return this._localGet;
            }
            set
            {
                this._localGet = value;
            }
        }
        
        public U32 LocalSet
        {
            get
            {
                return this._localSet;
            }
            set
            {
                this._localSet = value;
            }
        }
        
        public U32 LocalTee
        {
            get
            {
                return this._localTee;
            }
            set
            {
                this._localTee = value;
            }
        }
        
        public U32 GlobalGet
        {
            get
            {
                return this._globalGet;
            }
            set
            {
                this._globalGet = value;
            }
        }
        
        public U32 GlobalSet
        {
            get
            {
                return this._globalSet;
            }
            set
            {
                this._globalSet = value;
            }
        }
        
        public U32 MemoryCurrent
        {
            get
            {
                return this._memoryCurrent;
            }
            set
            {
                this._memoryCurrent = value;
            }
        }
        
        public U32 MemoryGrow
        {
            get
            {
                return this._memoryGrow;
            }
            set
            {
                this._memoryGrow = value;
            }
        }
        
        public U32 I64clz
        {
            get
            {
                return this._i64clz;
            }
            set
            {
                this._i64clz = value;
            }
        }
        
        public U32 I64ctz
        {
            get
            {
                return this._i64ctz;
            }
            set
            {
                this._i64ctz = value;
            }
        }
        
        public U32 I64popcnt
        {
            get
            {
                return this._i64popcnt;
            }
            set
            {
                this._i64popcnt = value;
            }
        }
        
        public U32 I64eqz
        {
            get
            {
                return this._i64eqz;
            }
            set
            {
                this._i64eqz = value;
            }
        }
        
        public U32 I64extendsi32
        {
            get
            {
                return this._i64extendsi32;
            }
            set
            {
                this._i64extendsi32 = value;
            }
        }
        
        public U32 I64extendui32
        {
            get
            {
                return this._i64extendui32;
            }
            set
            {
                this._i64extendui32 = value;
            }
        }
        
        public U32 I32wrapi64
        {
            get
            {
                return this._i32wrapi64;
            }
            set
            {
                this._i32wrapi64 = value;
            }
        }
        
        public U32 I64eq
        {
            get
            {
                return this._i64eq;
            }
            set
            {
                this._i64eq = value;
            }
        }
        
        public U32 I64ne
        {
            get
            {
                return this._i64ne;
            }
            set
            {
                this._i64ne = value;
            }
        }
        
        public U32 I64lts
        {
            get
            {
                return this._i64lts;
            }
            set
            {
                this._i64lts = value;
            }
        }
        
        public U32 I64ltu
        {
            get
            {
                return this._i64ltu;
            }
            set
            {
                this._i64ltu = value;
            }
        }
        
        public U32 I64gts
        {
            get
            {
                return this._i64gts;
            }
            set
            {
                this._i64gts = value;
            }
        }
        
        public U32 I64gtu
        {
            get
            {
                return this._i64gtu;
            }
            set
            {
                this._i64gtu = value;
            }
        }
        
        public U32 I64les
        {
            get
            {
                return this._i64les;
            }
            set
            {
                this._i64les = value;
            }
        }
        
        public U32 I64leu
        {
            get
            {
                return this._i64leu;
            }
            set
            {
                this._i64leu = value;
            }
        }
        
        public U32 I64ges
        {
            get
            {
                return this._i64ges;
            }
            set
            {
                this._i64ges = value;
            }
        }
        
        public U32 I64geu
        {
            get
            {
                return this._i64geu;
            }
            set
            {
                this._i64geu = value;
            }
        }
        
        public U32 I64add
        {
            get
            {
                return this._i64add;
            }
            set
            {
                this._i64add = value;
            }
        }
        
        public U32 I64sub
        {
            get
            {
                return this._i64sub;
            }
            set
            {
                this._i64sub = value;
            }
        }
        
        public U32 I64mul
        {
            get
            {
                return this._i64mul;
            }
            set
            {
                this._i64mul = value;
            }
        }
        
        public U32 I64divs
        {
            get
            {
                return this._i64divs;
            }
            set
            {
                this._i64divs = value;
            }
        }
        
        public U32 I64divu
        {
            get
            {
                return this._i64divu;
            }
            set
            {
                this._i64divu = value;
            }
        }
        
        public U32 I64rems
        {
            get
            {
                return this._i64rems;
            }
            set
            {
                this._i64rems = value;
            }
        }
        
        public U32 I64remu
        {
            get
            {
                return this._i64remu;
            }
            set
            {
                this._i64remu = value;
            }
        }
        
        public U32 I64and
        {
            get
            {
                return this._i64and;
            }
            set
            {
                this._i64and = value;
            }
        }
        
        public U32 I64or
        {
            get
            {
                return this._i64or;
            }
            set
            {
                this._i64or = value;
            }
        }
        
        public U32 I64xor
        {
            get
            {
                return this._i64xor;
            }
            set
            {
                this._i64xor = value;
            }
        }
        
        public U32 I64shl
        {
            get
            {
                return this._i64shl;
            }
            set
            {
                this._i64shl = value;
            }
        }
        
        public U32 I64shrs
        {
            get
            {
                return this._i64shrs;
            }
            set
            {
                this._i64shrs = value;
            }
        }
        
        public U32 I64shru
        {
            get
            {
                return this._i64shru;
            }
            set
            {
                this._i64shru = value;
            }
        }
        
        public U32 I64rotl
        {
            get
            {
                return this._i64rotl;
            }
            set
            {
                this._i64rotl = value;
            }
        }
        
        public U32 I64rotr
        {
            get
            {
                return this._i64rotr;
            }
            set
            {
                this._i64rotr = value;
            }
        }
        
        public override string TypeName()
        {
            return "InstructionWeights";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Version.Encode());
            result.AddRange(I64const.Encode());
            result.AddRange(I64load.Encode());
            result.AddRange(I64store.Encode());
            result.AddRange(Select.Encode());
            result.AddRange(RHif.Encode());
            result.AddRange(Br.Encode());
            result.AddRange(BrIf.Encode());
            result.AddRange(BrTable.Encode());
            result.AddRange(BrTablePerEntry.Encode());
            result.AddRange(Call.Encode());
            result.AddRange(CallIndirect.Encode());
            result.AddRange(CallIndirectPerParam.Encode());
            result.AddRange(LocalGet.Encode());
            result.AddRange(LocalSet.Encode());
            result.AddRange(LocalTee.Encode());
            result.AddRange(GlobalGet.Encode());
            result.AddRange(GlobalSet.Encode());
            result.AddRange(MemoryCurrent.Encode());
            result.AddRange(MemoryGrow.Encode());
            result.AddRange(I64clz.Encode());
            result.AddRange(I64ctz.Encode());
            result.AddRange(I64popcnt.Encode());
            result.AddRange(I64eqz.Encode());
            result.AddRange(I64extendsi32.Encode());
            result.AddRange(I64extendui32.Encode());
            result.AddRange(I32wrapi64.Encode());
            result.AddRange(I64eq.Encode());
            result.AddRange(I64ne.Encode());
            result.AddRange(I64lts.Encode());
            result.AddRange(I64ltu.Encode());
            result.AddRange(I64gts.Encode());
            result.AddRange(I64gtu.Encode());
            result.AddRange(I64les.Encode());
            result.AddRange(I64leu.Encode());
            result.AddRange(I64ges.Encode());
            result.AddRange(I64geu.Encode());
            result.AddRange(I64add.Encode());
            result.AddRange(I64sub.Encode());
            result.AddRange(I64mul.Encode());
            result.AddRange(I64divs.Encode());
            result.AddRange(I64divu.Encode());
            result.AddRange(I64rems.Encode());
            result.AddRange(I64remu.Encode());
            result.AddRange(I64and.Encode());
            result.AddRange(I64or.Encode());
            result.AddRange(I64xor.Encode());
            result.AddRange(I64shl.Encode());
            result.AddRange(I64shrs.Encode());
            result.AddRange(I64shru.Encode());
            result.AddRange(I64rotl.Encode());
            result.AddRange(I64rotr.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Version = new U32();
            Version.Decode(byteArray, ref p);
            I64const = new U32();
            I64const.Decode(byteArray, ref p);
            I64load = new U32();
            I64load.Decode(byteArray, ref p);
            I64store = new U32();
            I64store.Decode(byteArray, ref p);
            Select = new U32();
            Select.Decode(byteArray, ref p);
            RHif = new U32();
            RHif.Decode(byteArray, ref p);
            Br = new U32();
            Br.Decode(byteArray, ref p);
            BrIf = new U32();
            BrIf.Decode(byteArray, ref p);
            BrTable = new U32();
            BrTable.Decode(byteArray, ref p);
            BrTablePerEntry = new U32();
            BrTablePerEntry.Decode(byteArray, ref p);
            Call = new U32();
            Call.Decode(byteArray, ref p);
            CallIndirect = new U32();
            CallIndirect.Decode(byteArray, ref p);
            CallIndirectPerParam = new U32();
            CallIndirectPerParam.Decode(byteArray, ref p);
            LocalGet = new U32();
            LocalGet.Decode(byteArray, ref p);
            LocalSet = new U32();
            LocalSet.Decode(byteArray, ref p);
            LocalTee = new U32();
            LocalTee.Decode(byteArray, ref p);
            GlobalGet = new U32();
            GlobalGet.Decode(byteArray, ref p);
            GlobalSet = new U32();
            GlobalSet.Decode(byteArray, ref p);
            MemoryCurrent = new U32();
            MemoryCurrent.Decode(byteArray, ref p);
            MemoryGrow = new U32();
            MemoryGrow.Decode(byteArray, ref p);
            I64clz = new U32();
            I64clz.Decode(byteArray, ref p);
            I64ctz = new U32();
            I64ctz.Decode(byteArray, ref p);
            I64popcnt = new U32();
            I64popcnt.Decode(byteArray, ref p);
            I64eqz = new U32();
            I64eqz.Decode(byteArray, ref p);
            I64extendsi32 = new U32();
            I64extendsi32.Decode(byteArray, ref p);
            I64extendui32 = new U32();
            I64extendui32.Decode(byteArray, ref p);
            I32wrapi64 = new U32();
            I32wrapi64.Decode(byteArray, ref p);
            I64eq = new U32();
            I64eq.Decode(byteArray, ref p);
            I64ne = new U32();
            I64ne.Decode(byteArray, ref p);
            I64lts = new U32();
            I64lts.Decode(byteArray, ref p);
            I64ltu = new U32();
            I64ltu.Decode(byteArray, ref p);
            I64gts = new U32();
            I64gts.Decode(byteArray, ref p);
            I64gtu = new U32();
            I64gtu.Decode(byteArray, ref p);
            I64les = new U32();
            I64les.Decode(byteArray, ref p);
            I64leu = new U32();
            I64leu.Decode(byteArray, ref p);
            I64ges = new U32();
            I64ges.Decode(byteArray, ref p);
            I64geu = new U32();
            I64geu.Decode(byteArray, ref p);
            I64add = new U32();
            I64add.Decode(byteArray, ref p);
            I64sub = new U32();
            I64sub.Decode(byteArray, ref p);
            I64mul = new U32();
            I64mul.Decode(byteArray, ref p);
            I64divs = new U32();
            I64divs.Decode(byteArray, ref p);
            I64divu = new U32();
            I64divu.Decode(byteArray, ref p);
            I64rems = new U32();
            I64rems.Decode(byteArray, ref p);
            I64remu = new U32();
            I64remu.Decode(byteArray, ref p);
            I64and = new U32();
            I64and.Decode(byteArray, ref p);
            I64or = new U32();
            I64or.Decode(byteArray, ref p);
            I64xor = new U32();
            I64xor.Decode(byteArray, ref p);
            I64shl = new U32();
            I64shl.Decode(byteArray, ref p);
            I64shrs = new U32();
            I64shrs.Decode(byteArray, ref p);
            I64shru = new U32();
            I64shru.Decode(byteArray, ref p);
            I64rotl = new U32();
            I64rotl.Decode(byteArray, ref p);
            I64rotr = new U32();
            I64rotr.Decode(byteArray, ref p);
            _typeSize = p - start;
        }
    }
}