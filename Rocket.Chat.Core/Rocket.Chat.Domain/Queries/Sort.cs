using System.Collections.Generic;

namespace Rocket.Chat.Domain.Queries
{
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