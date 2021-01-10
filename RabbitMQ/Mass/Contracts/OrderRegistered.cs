using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public class OrderRegistered
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerNumber { get; set; }
    }
}
