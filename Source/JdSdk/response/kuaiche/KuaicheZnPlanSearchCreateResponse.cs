﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class KuaicheZnPlanSearchCreateResponse : JdResponse
    {
        [JsonProperty("result_status")]
        public ResultStatus ResultStatus
        {
            get;
            set;
        }

    }

}
