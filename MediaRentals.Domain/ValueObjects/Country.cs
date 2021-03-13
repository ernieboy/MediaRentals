using System.Collections.Generic;

namespace MediaRentals.Domain.ValueObjects
{
    public class Country : ValueObject
    {
        public Country(string isoAlphaTwoCode, string isoAlphaThreeCode, string name, string unCode)
        {
            IsoAlphaTwoCode = isoAlphaTwoCode;
            IsoAlphaThreeCode = isoAlphaThreeCode;
            Name = name;
            UnCode = unCode;
        }
        public string IsoAlphaTwoCode { get; }
        
        public string IsoAlphaThreeCode { get; }    
        
        public string Name { get; }

        public string UnCode { get; set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return IsoAlphaTwoCode;
            yield return IsoAlphaThreeCode;
            yield return Name;
            yield return UnCode;
        }
    }
}