using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FPageManager.Base
{
    public class SearchField
    {
        public SearchField(string field)
        {
            this.Field = field;
        }

        public SearchField(string field, int limit)
        {
            this.Field = field;
            this.Limit = limit;
        }

        public string Field { get; set; }

        public List<SearchField> NextLevelFields{get;set;}

        public Nullable<int> Limit { get; set; }
    }
}
