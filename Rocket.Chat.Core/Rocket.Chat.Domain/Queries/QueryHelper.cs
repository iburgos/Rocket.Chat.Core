using System.Collections.Generic;

namespace Rocket.Chat.Domain.Queries
{
    public class QueryHelper
    {
        public const string DATE_FORMAT = "yyyy-MM-ddTHH:mm:ss.sssZ";

        public static string DicToQuerystring(Dictionary<string, string> queryParams)
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
}