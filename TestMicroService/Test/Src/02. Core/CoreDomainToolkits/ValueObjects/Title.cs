using CoreDomain.Exceptions;
using CoreDomain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDomainToolkits.ValueObjects
{
    public class Title : BaseValueObject<Title>
    {
        public static Title FromString(string value) => new Title(value);
        public Title(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new InvalidValueObjectStateException("ValidationErrorIsRequire", nameof(Title));
            }
            if (value.Length < 2 || value.Length > 250)
            {
                throw new InvalidValueObjectStateException("ValidationErrorStringLength", nameof(Title), "2", "250");
            }
            Value = value;
        }
        private Title()
        {

        }

        public string Value { get; private set; }

        public override int ObjectGetHashCode()
        {
            return Value.GetHashCode();
        }

        public override bool ObjectIsEqual(Title otherObject)
        {
            return Value == otherObject.Value;
        }
        public override string ToString()
        {
            return Value;
        }

        public static explicit operator string(Title title) => title.Value;
        public static implicit operator Title(string value) => new Title(value);

    }
}
