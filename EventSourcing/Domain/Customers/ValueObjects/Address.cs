﻿using Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Customers.ValueObjects
{
    public  class Address : ValueObject
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Street;
            yield return City;
            yield return Country;
            yield return ZipCode;
        }
    }
}
