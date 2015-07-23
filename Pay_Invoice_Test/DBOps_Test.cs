using NUnit.Framework;
using Pay_Invoice_BO;
using Pay_Invoice_Engine.Implentations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay_Invoice_Test
{
    [TestClass]
    public class DBOps_Test
    {
        [Test]
        public void AddConsultant_TestPass()
        {
           PayInvoice_DBOps dbOpsObj = new PayInvoice_DBOps();

           Consultant consultant = new Consultant();

           consultant.FirstName = "Dheeraj";
           consultant.LasttName = "Vatti";
           consultant.Email = "dheerajvatti@gmail.com";
           consultant.PhoneNumber = "12345678";
           consultant.SSN = "123";
           consultant.Address = "xyz street";

           dbOpsObj.AddConsultant(consultant);
        }

    }
}
