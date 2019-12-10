using System;
using System.Collections.Generic;

namespace Rocket.Chat.Domain.Queries
{
    public class UserQuery
    {
        public class Presence : UserQuery
        {
            public DateTime? From { get; set; }

            public string ToQueryString()
            {
                var queryParams = new Dictionary<string, string>();
                if (From.HasValue)
                    queryParams.Add("from", From.Value.ToString(QueryHelper.DATE_FORMAT));
                
                return QueryHelper.DicToQuerystring(queryParams);
            }
        }

        public class List : UserQuery
        {
            public string Fields { get; set; }

            public string Query { get; set; }

            public string ToQueryString()
            {
                var queryParams = new Dictionary<string, string>();
                if (!string.IsNullOrEmpty(Fields))
                    queryParams.Add("fields", Fields);
                if (!string.IsNullOrEmpty(Query))
                    queryParams.Add("query", Query);

                return QueryHelper.DicToQuerystring(queryParams);
            }
        }
    }
}
