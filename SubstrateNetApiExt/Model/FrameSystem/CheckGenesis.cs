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


namespace SubstrateNetApi.Model.FrameSystem
{
    
    
    /// <summary>
    /// >> 514 - Composite[frame_system.extensions.check_genesis.CheckGenesis]
    /// </summary>
    public sealed class CheckGenesis : BaseType
    {
        
        public override string TypeName()
        {
            return "CheckGenesis";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            TypeSize = p - start;
        }
    }
}
