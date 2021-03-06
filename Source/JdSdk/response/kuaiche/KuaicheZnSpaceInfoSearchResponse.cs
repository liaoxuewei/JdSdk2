﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class KuaicheZnSpaceInfoSearchResponse : JdResponse
    {
        [JsonProperty("space_info_list")]
        public List<SpaceInfo> SpaceInfoList
        {
            get;
            set;
        }

    }

}
