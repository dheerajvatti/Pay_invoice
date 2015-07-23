using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pay_Invoice.Models
{
    public class Consultant
    {
        public int ConsultantID { get; set; }
        public string FirstName { get; set; }

        public string LasttName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string SSN { get; set; }
    }


}