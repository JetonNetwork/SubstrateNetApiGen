using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Custom;
using System;

namespace SubstrateNetApi.Model.Calls
{
    public class ExtensionCall
    {

        //{
        //    name: do_something,
        //    args:
        //    [
        //      {
        //        name: something,
        //        type: u32
        //       }
        //    ],
        //    documentation:[
        //      An example dispatchable that takes a singles value as a parameter, writes the value to,
        //      storage and emits an event. This function must be dispatched by a signed extrinsic.
        //    ]
        //},
        public static GenericExtrinsicCall DoSomething(U32 something)
        {
            return new GenericExtrinsicCall("TemplateModule", "do_something", something);
        }
    }
}