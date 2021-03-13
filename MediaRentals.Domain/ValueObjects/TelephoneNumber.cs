using System.Collections.Generic;

namespace MediaRentals.Domain.ValueObjects
{
    public class TelephoneNumber: ValueObject
    {
        public string CountryCode { get; }

        public string Number { get; set; }
        
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return CountryCode;
            yield return Number;
        }
    }
}