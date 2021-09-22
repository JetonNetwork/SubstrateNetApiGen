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
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletImOnline
{
    
    
    /// <summary>
    /// >> 415 - Composite[pallet_im_online.BoundedOpaqueNetworkState]
    /// </summary>
    public sealed class BoundedOpaqueNetworkState : BaseType
    {
        
        /// <summary>
        /// >> peer_id
        /// </summary>
        private SubstrateNetApi.Model.FrameSupport.WeakBoundedVec _peerId;
        
        /// <summary>
        /// >> external_addresses
        /// </summary>
        private SubstrateNetApi.Model.FrameSupport.WeakBoundedVec _externalAddresses;
        
        public SubstrateNetApi.Model.FrameSupport.WeakBoundedVec PeerId
        {
            get
            {
                return this._peerId;
            }
            set
            {
                this._peerId = value;
            }
        }
        
        public SubstrateNetApi.Model.FrameSupport.WeakBoundedVec ExternalAddresses
        {
            get
            {
                return this._externalAddresses;
            }
            set
            {
                this._externalAddresses = value;
            }
        }
        
        public override string TypeName()
        {
            return "BoundedOpaqueNetworkState";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(PeerId.Encode());
            result.AddRange(ExternalAddresses.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            PeerId = new SubstrateNetApi.Model.FrameSupport.WeakBoundedVec();
            PeerId.Decode(byteArray, ref p);
            ExternalAddresses = new SubstrateNetApi.Model.FrameSupport.WeakBoundedVec();
            ExternalAddresses.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}