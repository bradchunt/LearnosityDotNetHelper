﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LearnosityDotNetHelper
{
    public class ItemReference
    {
        [JsonProperty("reference")]

        public string? Reference { get; set; }
    }
}
