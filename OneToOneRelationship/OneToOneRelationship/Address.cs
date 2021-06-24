using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOneRelationship
{
    class Address
    {
        public Address(string city,string hometown,string division,string country)
        {
            City = city;
            Hometown = hometown;
            Division = division;
            Country = country;
        }
        public string City { get; set; }
        public string Hometown { get; set; }
        public string Division { get; set; }
        public string Country { get; set; }
    }
}
