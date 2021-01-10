using CoreDomain.Exceptions;
using CoreDomain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitie.Extentions;

namespace CoreDomainToolkits.ValueObjects
{
    public class NationalCode : BaseValueObject<NationalCode>
    {
        public static NationalCode FromString(string value) => new NationalCode(value);
        public NationalCode(string value)
        {
            if (!value.IsNationalCode())
            {
                throw new InvalidValueObjectStateException("ValidationErrorStringFormat", nameof(NationalCode));
            }

            Value = value;
        }
        private NationalCode()
        {

        }

        public string Value { get; private set; }

        public override int ObjectGetHashCode()
        {
            return Value.GetHashCode();
        }

        public override bool ObjectIsEqual(NationalCode otherObject)
        {
            return Value == otherObject.Value;
        }
        public override string ToString()
        {
            return Value;
        }

        public static explicit operator string(NationalCode title) => title.Value;
        public static implicit operator NationalCode(string value) => new NationalCode(value);

    }
}
