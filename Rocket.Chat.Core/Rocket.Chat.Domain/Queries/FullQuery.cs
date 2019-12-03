using System.Collections.Generic;

namespace Rocket.Chat.Domain.Queries
{

    public class BasicQuery
    {
        /// <summary>
        /// Room Id
        /// </summary>
        public string RoomId { get; set; }
        /// <summary>
        /// Room name
        /// </summary>
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

        public BasicQuery()
        {
            RoomId = null;
            RoomName = null;
            Offset = null;
            Count = null;
            Sort = null;
        }

        public string ToQueryString()
        {
            var queryParams = GetByIdOrName(RoomId, RoomName);
            TryAddField(Offset, "offset", queryParams);
            TryAddField(Count, "count", queryParams);
            TryAddField(Sort, "sort", queryParams);
            return QueryHelper.DicToQuerystring(queryParams);
        }

        protected void TryAddField(int? field, string name, Dictionary<string, string> queryParams)
        {
            if (field.HasValue)
                queryParams.Add(name, field.Value.ToString());
        }

        protected void TryAddField(string field, string name, Dictionary<string, string> queryParams)
        {
            if (!string.IsNullOrEmpty(field))
                queryParams.Add(name, field.ToString());
        }

        protected void TryAddField(Sort field, string name, Dictionary<string, string> queryParams)
        {
            if (field != null)
                queryParams.Add(name, field.ToQueryString());
        }

        protected Dictionary<string, string> GetByIdOrName(string roomId, string roomName)
        {
            var queryParams = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(roomId))
                queryParams.Add("roomId", roomId);
            else if (!string.IsNullOrEmpty(roomName) && !queryParams.ContainsKey("roomId"))
                queryParams.Add("roomName", roomName);
            return queryParams;
        }
    }

    public class FullQuery : BasicQuery
    {
        
        /// <summary>
        /// https://localhost:3000/api/v1/users.list?query={ "name": { "$regex": "g" } }
        /// </summary>
        public string Query { get; set; }
        /// <summary>
        /// http://localhost:3000/api/v1/users.list?fields={ "username": 1 }
        /// </summary>
        public string Fields { get; set; }

        public FullQuery() : base()
        {
            Query = null;
            Fields = null;
        }

        public string ToQueryString()
        {
            var queryParams = GetByIdOrName(RoomId, RoomName);
            TryAddField(Offset, "offset", queryParams);
            TryAddField(Count, "count", queryParams);
            TryAddField(Sort, "sort", queryParams);
            TryAddField(Query, "query", queryParams);
            TryAddField(Fields, "fields", queryParams);
            return QueryHelper.DicToQuerystring(queryParams);
        }
    }
}
