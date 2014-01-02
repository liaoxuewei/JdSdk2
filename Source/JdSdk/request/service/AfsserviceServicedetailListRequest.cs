﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Service;

namespace JdSdk.Request.Service
{
﻿    public class AfsserviceServicedetailListRequest : JdRequestBase<AfsserviceServicedetailListResponse>
    {
        public Nullable<Int32> AfsServiceId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.afsservice.servicedetail.list"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("afsServiceId" ,this.AfsServiceId);
        }

    }

}
