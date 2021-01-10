using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
  public  class Payment
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CardNumber { get; set; }

        public double Value { get; set; }
    }
}
