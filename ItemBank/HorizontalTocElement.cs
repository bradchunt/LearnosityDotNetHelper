using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LearnosityDotNetHelper
{
    public class HorizontalTocElement
    {
        [JsonProperty("show_itemcount")]
        public bool? ShowItemCount { get; set; }
    }

}
