using CoreDomain.Exceptions;
using CoreDomain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDomainToolkits.ValueObjects
{
    public class Description : BaseValueObject<Description>
    {
        public static Description FromString(string value) => new Description(value);
        public Description(string value)
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Length > 500)
            {
                throw new InvalidValueObjectStateException("ValidationErrorIsRequire", nameof(Description), "0", "500");
            }

            Value = value;
        }
        private Description()
        {

        }

        public string Value { get; private set; }

        public override int ObjectGetHashCode()
        {
            return Value.GetHashCode();
        }

        public override bool ObjectIsEqual(Description otherObject)
        {
            return Value == otherObject.Value;
        }

        public static explicit operator string(Description description) => description.Value;
        public static implicit operator Description(string value) => new Description(value);
    }
}
