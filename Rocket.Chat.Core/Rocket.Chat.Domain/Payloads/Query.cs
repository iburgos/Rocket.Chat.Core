using System.Collections.Generic;

namespace Rocket.Chat.Domain.Payloads
{
    public class Query
    {
        public string RoomId { get; set; }
        public string RoomName { get; set; }
        /// <summary>
        /// number of items to “skip” in the query, is zero based so it starts off at 0 being the first item.
        /// </summary>
        public int? Offset { get; set; }
        /// <summary>
        /// the number of items to “get” in the query, is one based so to get only one you would pass in 1. If you want to get all of the records, then pass in 0 but this will only work if the setting (see below) allows it.
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// specify the order in which the results should be returned. Sort hash uses attribute name for key and value of 1 for asc, -1 for desc.
        /// </summary>
        public Sort Sort { get; set; }

        public Query()
        {
            RoomId = null;
            RoomName = null;
            Offset = null;
            Count = null;
            Sort = null;
        }

        public string ToQueryString()
        {
            var queryParams = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(RoomId))
                queryParams.Add("roomId", RoomId);
            else if (!string.IsNullOrEmpty(RoomName) && !queryParams.ContainsKey("roomId"))
                queryParams.Add("roomName", RoomName);

            if (Offset.HasValue)
                queryParams.Add("offset", Offset.Value.ToString());
            if (Count.HasValue)
                queryParams.Add("count", Offset.Value.ToString());
            if (Sort != null)
                queryParams.Add("sort", Sort.ToQueryString());

            return DicToQuerystring(queryParams);
        }

        private string DicToQuerystring(Dictionary<string, string> queryParams)
        {
            string queryString = "?";
            int count = 1;
            foreach (KeyValuePair<string, string> item in queryParams)
            {
                queryString += $"{item.Key}={item.Value}";
                if (count < queryParams.Count)
                    queryString += "&";

                count++;
            }
            return queryString;
        }
    }

    public class Sort
    {
        public List<SortField> Fields { get; set; }

        public string ToQueryString()
        {
            string sort = string.Empty;
            for (int i = 0; i < Fields.Count; i++)
            {
                var field = Fields[i];
                sort += field.ToQueryString();
                if (i < Fields.Count - 1)
                    sort += ",";
            }
            return $"{{{sort}}}";
        }
    }

    public class SortField
    {
        public string Name { get; set; }
        public int Direction { get; set; }

        public string ToQueryString() => $"\"{Name.ToLower()}\":{Direction}";
    }
}
