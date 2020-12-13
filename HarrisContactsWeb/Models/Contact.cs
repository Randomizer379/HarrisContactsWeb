using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisContactsWeb.Models
{
    public class Contact
    {
        public int ContactID { get; set; }
        public int Name { get; set; }
        public int Surname { get; set; }
        public int Email { get; set; }
        public int Phone { get; set; }
        public int Address { get; set; }
        public int City { get; set; }
        public int Postcode { get; set; }
        public int Type { get; set; }

    }
}
