﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public class OrderAccepted
    {
        public int OrderId { get; set; }
        public DateTime AcceptDate { get; set; }
        public string AcceptBy { get; set; }
    }
}
