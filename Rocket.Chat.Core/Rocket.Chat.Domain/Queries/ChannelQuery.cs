using System;
using System.Collections.Generic;

namespace Rocket.Chat.Domain.Queries
{
    public class ChannelQuery
    {
        public string RoomId { get; set; }

        protected Dictionary<string, string> GetByIdOrName(string roomId, string roomName)
        {
            var queryParams = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(roomId))
                queryParams.Add("roomId", roomId);
            else if (!string.IsNullOrEmpty(roomName) && !queryParams.ContainsKey("roomId"))
                queryParams.Add("roomName", roomName);
            return queryParams;
        }

        public class Channel : ChannelQuery
        {
            public string RoomName { get; set; }

            public string ToQueryString()
            {
                return QueryHelper.DicToQuerystring(GetByIdOrName(RoomId, RoomName));
            }
        }

        public class Messages: ChannelQuery
        {
            public string RoomName { get; set; }
            public int? Offset { get; set; }
            public int? Count { get; set; }
            public Sort Sort { get; set; }

            public string ToQueryString()
            {
                var queryParams = GetByIdOrName(RoomId, RoomName);

                if (Offset.HasValue)
                    queryParams.Add("offset", Offset.Value.ToString());
                if (Count.HasValue)
                    queryParams.Add("count", Count.Value.ToString());
                if (Sort != null)
                    queryParams.Add("sort", Sort.ToQueryString());

                return QueryHelper.DicToQuerystring(queryParams);
            }
        }

        public class Members : ChannelQuery
        {
            public string RoomName { get; set; }
            public int? Offset { get; set; }
            public int? Count { get; set; }
            public Sort Sort { get; set; }

            public string ToQueryString()
            {
                var queryParams = GetByIdOrName(RoomId, RoomName);

                if (Offset.HasValue)
                    queryParams.Add("offset", Offset.Value.ToString());
                if (Count.HasValue)
                    queryParams.Add("count", Count.Value.ToString());
                if (Sort != null)
                    queryParams.Add("sort", Sort.ToQueryString());

                return QueryHelper.DicToQuerystring(queryParams);
            }
        }

        public class Counters: ChannelQuery
        {
            public string RoomName { get; set; }
            public string UserId { get; set; }

            public string ToQueryString()
            {
                var queryParams = GetByIdOrName(RoomId, RoomName);

                if (!string.IsNullOrEmpty(UserId))
                    queryParams.Add("userId", UserId);

                return QueryHelper.DicToQuerystring(queryParams);
            }
        }

        public class History: ChannelQuery
        {
            public DateTime? Latest { get; set; }
            public DateTime? Oldest { get; set; }
            public bool Inclusive { get; set; }
            public int? Offset { get; set; }
            public int? Count { get; set; }
            public bool Unreads { get; set; }

            public string ToQueryString()
            {
                var queryParams = GetByIdOrName(RoomId, string.Empty);

                if (Latest.HasValue)
                    queryParams.Add("latest", Latest.Value.ToString(QueryHelper.DATE_FORMAT));
                if (Oldest.HasValue)
                    queryParams.Add("oldest", Oldest.Value.ToString(QueryHelper.DATE_FORMAT));
                if (Offset.HasValue)
                    queryParams.Add("offset", Offset.Value.ToString());
                if (Count.HasValue)
                    queryParams.Add("count", Count.Value.ToString());
                if (Inclusive)
                    queryParams.Add("inclusive", Inclusive.ToString().ToLower());
                if (Unreads)
                    queryParams.Add("unreads", Unreads.ToString().ToLower());

                return QueryHelper.DicToQuerystring(queryParams);
            }
        }
    }
}
