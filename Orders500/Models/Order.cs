using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orders500.Models
{
    public class Order
    {
        public int storeID { get; set; }
        public int salesPersonID { get; set; }
        public int cdPrice { get; set; }
        public int cdID { get; set; }
        public DateTime date { get; set; }
    }
}
