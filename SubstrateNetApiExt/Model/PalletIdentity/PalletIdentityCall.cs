//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Calls;
using SubstrateNetApi.Model.PalletIdentity;
using SubstrateNetApi.Model.SpCore;
using SubstrateNetApi.Model.SpRuntime;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletIdentity
{
    
    
    /// <summary>
    /// >> 242 - Variant[pallet_identity.pallet.Call]
    /// Identity pallet declaration.
    /// </summary>
    public sealed class PalletIdentityCall
    {
        
        /// <summary>
        /// >> add_registrar
        /// </summary>
        public GenericExtrinsicCall AddRegistrar(SubstrateNetApi.Model.SpCore.AccountId32 account)
        {
            return new GenericExtrinsicCall("Identity", "add_registrar", account);
        }
        
        /// <summary>
        /// >> set_identity
        /// </summary>
        public GenericExtrinsicCall SetIdentity(SubstrateNetApi.Model.PalletIdentity.IdentityInfo info)
        {
            return new GenericExtrinsicCall("Identity", "set_identity", info);
        }
        
        /// <summary>
        /// >> set_subs
        /// </summary>
        public GenericExtrinsicCall SetSubs(BaseVec<BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.PalletIdentity.EnumData>> subs)
        {
            return new GenericExtrinsicCall("Identity", "set_subs", subs);
        }
        
        /// <summary>
        /// >> clear_identity
        /// </summary>
        public GenericExtrinsicCall ClearIdentity()
        {
            return new GenericExtrinsicCall("Identity", "clear_identity");
        }
        
        /// <summary>
        /// >> request_judgement
        /// </summary>
        public GenericExtrinsicCall RequestJudgement(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> reg_index, BaseCom<SubstrateNetApi.Model.Types.Primitive.U128> max_fee)
        {
            return new GenericExtrinsicCall("Identity", "request_judgement", reg_index, max_fee);
        }
        
        /// <summary>
        /// >> cancel_request
        /// </summary>
        public GenericExtrinsicCall CancelRequest(SubstrateNetApi.Model.Types.Primitive.U32 reg_index)
        {
            return new GenericExtrinsicCall("Identity", "cancel_request", reg_index);
        }
        
        /// <summary>
        /// >> set_fee
        /// </summary>
        public GenericExtrinsicCall SetFee(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> index, BaseCom<SubstrateNetApi.Model.Types.Primitive.U128> fee)
        {
            return new GenericExtrinsicCall("Identity", "set_fee", index, fee);
        }
        
        /// <summary>
        /// >> set_account_id
        /// </summary>
        public GenericExtrinsicCall SetAccountId(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> index, SubstrateNetApi.Model.SpCore.AccountId32 @new)
        {
            return new GenericExtrinsicCall("Identity", "set_account_id", index, @new);
        }
        
        /// <summary>
        /// >> set_fields
        /// </summary>
        public GenericExtrinsicCall SetFields(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> index, SubstrateNetApi.Model.PalletIdentity.BitFlags fields)
        {
            return new GenericExtrinsicCall("Identity", "set_fields", index, fields);
        }
        
        /// <summary>
        /// >> provide_judgement
        /// </summary>
        public GenericExtrinsicCall ProvideJudgement(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> reg_index, SubstrateNetApi.Model.SpRuntime.EnumMultiAddress target, SubstrateNetApi.Model.PalletIdentity.EnumJudgement judgement)
        {
            return new GenericExtrinsicCall("Identity", "provide_judgement", reg_index, target, judgement);
        }
        
        /// <summary>
        /// >> kill_identity
        /// </summary>
        public GenericExtrinsicCall KillIdentity(SubstrateNetApi.Model.SpRuntime.EnumMultiAddress target)
        {
            return new GenericExtrinsicCall("Identity", "kill_identity", target);
        }
        
        /// <summary>
        /// >> add_sub
        /// </summary>
        public GenericExtrinsicCall AddSub(SubstrateNetApi.Model.SpRuntime.EnumMultiAddress sub, SubstrateNetApi.Model.PalletIdentity.EnumData data)
        {
            return new GenericExtrinsicCall("Identity", "add_sub", sub, data);
        }
        
        /// <summary>
        /// >> rename_sub
        /// </summary>
        public GenericExtrinsicCall RenameSub(SubstrateNetApi.Model.SpRuntime.EnumMultiAddress sub, SubstrateNetApi.Model.PalletIdentity.EnumData data)
        {
            return new GenericExtrinsicCall("Identity", "rename_sub", sub, data);
        }
        
        /// <summary>
        /// >> remove_sub
        /// </summary>
        public GenericExtrinsicCall RemoveSub(SubstrateNetApi.Model.SpRuntime.EnumMultiAddress sub)
        {
            return new GenericExtrinsicCall("Identity", "remove_sub", sub);
        }
        
        /// <summary>
        /// >> quit_sub
        /// </summary>
        public GenericExtrinsicCall QuitSub()
        {
            return new GenericExtrinsicCall("Identity", "quit_sub");
        }
    }
}
