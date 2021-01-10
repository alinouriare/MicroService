using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public class OrderRejected
    {
        public int OrderId { get; set; }
        public DateTime RejectDate { get; set; }
        public string RejectBy { get; set; }
        public string Reason { get; set; }
    }
}
