﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class KuaicheZnScheduleBidDetailSearchResponse : JdResponse
    {
        [JsonProperty("Schedule_list")]
        public List<ScheduleVOJos> ScheduleList
        {
            get;
            set;
        }

    }

}
