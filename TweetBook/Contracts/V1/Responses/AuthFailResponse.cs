using System.Collections.Generic;

namespace Tweetbook.Contracts.V1.Responses
{
    public class AuthFailResponse
    {
        public IEnumerable<string> Errors { get; set; }
    }
}
