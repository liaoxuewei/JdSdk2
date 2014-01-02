﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Wms;

namespace JdSdk.Request.Wms
{
﻿    public class LogisticsOtherOutstoreQueryRequest : JdRequestBase<LogisticsOtherOutstoreQueryResponse>
    {
        public String JoslOutboundNo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.logistics.otherOutstore.query"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("josl_outbound_no" ,this.JoslOutboundNo);
        }

    }

}
