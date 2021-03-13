using System.Collections.Generic;

namespace MediaRentals.Domain.ValueObjects
{
    public class PostalAddress : ValueObject
    {
        public PostalAddress(string houseName, string city, PostCode postCode)
        {
            HouseName = houseName;
            City = city;
            PostCode = postCode;
        }
        public string HouseName { get; }

        public string AddressLine1 { get;  }
        
        public string AddressLine2 { get;  }
        
        public string AddressLine3 { get;  }
        
        public string AddressLine4 { get;  }
        
        public string AddressLine5 { get;  }
        
        public string Town { get;  }    
        
        public string County { get;  }    
        
        public Country Country { get;  }
        
        public string City { get; }
        
        public PostCode PostCode { get; }
        
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return HouseName;
            yield return City;
            yield return PostCode;
            yield return Country;
        }
    }
}