using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisas2.Models
{
    public class RememberRates
    {
        [PrimaryKey]
        public int LastQueryId { get; set; }

        public string CodeRateSource { get; set; }

        public string CodeRateTarget { get; set; }

        public override int GetHashCode()
        {
            return LastQueryId;
        }
    }
}
