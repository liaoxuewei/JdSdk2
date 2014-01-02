﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Workorder
{
﻿    [Serializable]
    public class RestWorkorderReplyResponse : JdResponse
    {
        [JsonProperty("workOrder")]
        public WorkOrderResponse WorkOrder
        {
            get;
            set;
        }

    }

}
