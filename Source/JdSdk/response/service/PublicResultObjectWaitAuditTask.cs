﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class PublicResultObjectWaitAuditTask : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("resultErrorMsg")]
        public String ResultErrorMsg
        {
            get;
            set;
        }

        [JsonProperty("waitAudit")]
        public PageWaitAuditTask WaitAudit
        {
            get;
            set;
        }

    }

}