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
    public class LegalNationalId : BaseValueObject<LegalNationalId>
    {
        public static LegalNationalId FromString(string value) => new LegalNationalId(value);
        public LegalNationalId(string value)
        {
            if (!value.IsLegalNationalIdValid())
            {
                throw new InvalidValueObjectStateException("ValidationErrorStringFormat", nameof(LegalNationalId));
            }

            Value = value;
        }
        private LegalNationalId()
        {

        }

        public string Value { get; private set; }

        public override int ObjectGetHashCode()
        {
            return Value.GetHashCode();
        }

        public override bool ObjectIsEqual(LegalNationalId otherObject)
        {
            return Value == otherObject.Value;
        }
        public override string ToString()
        {
            return Value;
        }

        public static explicit operator string(LegalNationalId title) => title.Value;
        public static implicit operator LegalNationalId(string value) => new LegalNationalId(value);

    }
}
