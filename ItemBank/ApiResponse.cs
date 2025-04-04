using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnosityDotNetHelper
{
    public class ApiResponse
    {
        public bool IsSuccess { get; set; }
        public int HttpStatusCode { get; set; }
        public string? RawResponseBody { get; set; }
        public dynamic? ParsedResponse { get; set; }
        public string? ErrorMessage { get; set; }
        public string? RequestUuid { get; set; }

    }

}
