﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WareVideobigfieldGetResponse : JdResponse
    {
        [JsonProperty("VideoBigFieldEntity")]
        public List<VideoBigFieldEntity> VideoBigFieldEntity
        {
            get;
            set;
        }

    }

}
