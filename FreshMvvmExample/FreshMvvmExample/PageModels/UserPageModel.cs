using System;
using System.Collections.Generic;
using System.Text;
using FreshMvvm;
using FreshMvvmExample.Model;

namespace FreshMvvmExample.PageModels
{
    public class UserPageModel : FreshBasePageModel
    {
        public Users User { get; set; }
        public override void Init(object initData)
        {
            base.Init(initData);
            User = initData as Users;

            //PageModelCoreMethods
        }

    }
}
