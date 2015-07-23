using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pay_Invoice_BO
{
    public class Employer
    {
        public int Employer_ID { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeePhone { get; set; }

        public string EmployeeAddress { get; set; }

        public int TaxID { get; set; }

        public List<AuthorizedOfficial> AuthorizedOfficials { get; set; }

        public List<Consultant> Consultants { get; set; }

       
    }

    public class AuthorizedOfficial
    {
               
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }

}