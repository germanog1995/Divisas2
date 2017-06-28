using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisas2.Models
{
    public class Taxes
    {
        [PrimaryKey]
        public int TaxesId { get; set; }
        public string Code { get; set; }    
        public double TaxRate { get; set; }
        public string Name { get; set; }

        public override int GetHashCode()
        {
            return TaxesId;
        }
    }

    
}
