using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FPageManager.Base
{
    public class PaginationSettings
    {
        public string Before { get; set; }

        public string After { get; set; }

        public Nullable<int> Limit { get; set; }

        public Uri Next { get; set; }

        public Uri Previous { get; set; }
    }
}
