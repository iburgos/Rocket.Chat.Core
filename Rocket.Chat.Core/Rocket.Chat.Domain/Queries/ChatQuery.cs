using System;
using System.Collections.Generic;

namespace Rocket.Chat.Domain.Queries
{
    public class ChatQuery
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

        public class Chat : ChatQuery
        {
            public string RoomName { get; set; }

            public string ToQueryString()
            {
                return QueryHelper.DicToQuerystring(GetByIdOrName(RoomId, RoomName));
            }
        }

        public class GetDeletedMessages : ChatQuery
        {
            public DateTime Since { get; set; }
            public int? Offset { get; set; }
            public int? Count { get; set; }

            public string ToQueryString()
            {
                var queryParams = GetByIdOrName(RoomId, string.Empty);

                queryParams.Add("since", Since.ToString(QueryHelper.DATE_FORMAT));

                if (Offset.HasValue)
                    queryParams.Add("offset", Offset.Value.ToString());
                if (Count.HasValue)
                    queryParams.Add("count", Count.Value.ToString());

                return QueryHelper.DicToQuerystring(queryParams);
            }
        }

        public class GetPinnedMessages : ChatQuery
        {
            public int? Offset { get; set; }
            public int? Count { get; set; }

            public string ToQueryString()
            {
                var queryParams = GetByIdOrName(RoomId, string.Empty);

                if (Offset.HasValue)
                    queryParams.Add("offset", Offset.Value.ToString());
                if (Count.HasValue)
                    queryParams.Add("count", Count.Value.ToString());

                return QueryHelper.DicToQuerystring(queryParams);
            }
        }

        public class GetStarredMessages : ChatQuery
        {
            public int? Offset { get; set; }
            public int? Count { get; set; }
            public Sort Sort { get; set; }

            public string ToQueryString()
            {
                var queryParams = GetByIdOrName(RoomId, string.Empty);

                if (Offset.HasValue)
                    queryParams.Add("offset", Offset.Value.ToString());
                if (Count.HasValue)
                    queryParams.Add("count", Count.Value.ToString());
                if (Sort != null)
                    queryParams.Add("sort", Sort.ToQueryString());

                return QueryHelper.DicToQuerystring(queryParams);
            }
        }

        public class GetThreadMessages : ChatQuery
        {
            public string ThreadMessageId { get; set; }
            public int? Offset { get; set; }
            public int? Count { get; set; }
            public Sort Sort { get; set; }

            public string ToQueryString()
            {
                var queryParams = GetByIdOrName(RoomId, string.Empty);

                queryParams.Add("tmid", ThreadMessageId);

                if (Offset.HasValue)
                    queryParams.Add("offset", Offset.Value.ToString());
                if (Count.HasValue)
                    queryParams.Add("count", Count.Value.ToString());
                if (Sort != null)
                    queryParams.Add("sort", Sort.ToQueryString());

                return QueryHelper.DicToQuerystring(queryParams);
            }
        }

        public class SyncThreadMessages : ChatQuery
        {
            public string ThreadMessageId { get; set; }
            public Sort Sort { get; set; }

            public string ToQueryString()
            {
                var queryParams = GetByIdOrName(RoomId, string.Empty);

                queryParams.Add("tmid", ThreadMessageId);

                if (Sort != null)
                    queryParams.Add("sort", Sort.ToQueryString());

                return QueryHelper.DicToQuerystring(queryParams);
            }
        }

        public class GetThreadList : ChatQuery
        {
            public int? Offset { get; set; }
            public int? Count { get; set; }
            public Sort Sort { get; set; }

            public string ToQueryString()
            {
                var queryParams = new Dictionary<string, string>();

                if (!string.IsNullOrEmpty(RoomId))
                    queryParams.Add("rid", RoomId);
                if (Offset.HasValue)
                    queryParams.Add("offset", Offset.Value.ToString());
                if (Count.HasValue)
                    queryParams.Add("count", Count.Value.ToString());
                if (Sort != null)
                    queryParams.Add("sort", Sort.ToQueryString());

                return QueryHelper.DicToQuerystring(queryParams);
            }
        }

        public class SyncThreadList : ChatQuery
        {
            public DateTime UpdatedSince { get; set; }
            public Sort Sort { get; set; }

            public string ToQueryString()
            {
                var queryParams = new Dictionary<string, string>();

                queryParams.Add("rid", RoomId);
                queryParams.Add("updatedSince", UpdatedSince.ToString(QueryHelper.DATE_FORMAT));

                if (Sort != null)
                    queryParams.Add("sort", Sort.ToQueryString());

                return QueryHelper.DicToQuerystring(queryParams);
            }
        }

        public class IgnoreUser : ChatQuery
        {
            public string UserId { get; set; }
            public bool? Ignore { get; set; }

            public string ToQueryString()
            {
                var queryParams = GetByIdOrName(RoomId, string.Empty);

                queryParams.Add("userId", UserId);

                if (Ignore.HasValue)
                    queryParams.Add("ignore", Ignore.Value.ToString().ToLower());

                return QueryHelper.DicToQuerystring(queryParams);
            }
        }

        public class Search : ChatQuery
        {
            public string SearchText { get; set; }
            public int? Count { get; set; }

            public string ToQueryString()
            {
                var queryParams = GetByIdOrName(RoomId, string.Empty);

                queryParams.Add("searchText", SearchText);

                if (Count.HasValue)
                    queryParams.Add("count", Count.Value.ToString());

                return QueryHelper.DicToQuerystring(queryParams);
            }
        }
    }
}