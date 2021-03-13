using System.Collections.Generic;

namespace MediaRentals.Domain.ValueObjects
{
    public class EmailAddress : ValueObject
    {
        public EmailAddress(string value)
        {
            Value = value;
        }
        public string Value { get;}
        
        public static explicit operator EmailAddress(string emailAddress)
        {
            return new EmailAddress(emailAddress);
        }
        
        public static implicit operator string(EmailAddress emailAddress)
        {
            return emailAddress.Value;
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}