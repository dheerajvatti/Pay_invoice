using MongoDB.Bson;
using MongoDB.Driver;
using Pay_Invoice_BO;
using Pay_Invoice_Engine.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay_Invoice_Engine.Implentations
{
    public class PayInvoice_DBOps
    {

        public IMongoDatabase Database;
        public MongoClient mongoClient;
        public IMongoCollection<BsonDocument> consultant_Collection;
        public PayInvoice_DBOps()
        {
            //mongodb://MongoLab_Invoice:S3fctAmuDZYgKoMgnJsaSlAnGLM_sr5n1XOhmSs.u8Q-@ds038888.mongolab.com:38888/MongoLab_Invoice
            mongoClient = new MongoClient("mongodb://localhost:27017");
            Database = mongoClient.GetDatabase("Pay_InvoiceDB");
            consultant_Collection = Database.GetCollection<BsonDocument>("Consultants");
        }




        public async Task AddConsultant(Consultant consultant, int employer_id)
        {
            var document = new BsonDocument
            {
               // {"Consultant_id",1},
              
                {"FirstName",consultant.FirstName},
                {"LastName",consultant.LasttName},
                {"Employer_ID",employer_id},
                {"Email",consultant.Email},
                {"PhoneNumber",consultant.PhoneNumber},
                {"Address",consultant.Address},
                {"SSN",consultant.SSN},
                {"DateAdded",DateTime.Now}
              
               };

            try
            {
                //TODO:Get distinct 
                //if (GetConsultantBySSN(consultant.SSN) == null)
                //  {
                await consultant_Collection.InsertOneAsync(document);
                //  }
            }
            catch (Exception e)
            {

            }

        }

        public Task<BsonDocument> GetConsultantBySSN(string SSN)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("SSN", SSN);
            var document = consultant_Collection.Find(filter).FirstAsync();
            return document;
        }


        public async Task AddEmployer(Employer employer, AuthorizedOfficial authorizedOfficial)
        {
            int[] testCOnsultantsIDs = new int[] { 1, 2, 3 };

            var document = new BsonDocument
            {
               // {"Consultant_id",1},
              
               {"Employer_ID",1},
               {"EmployeeName",employer.EmployeeName},
               {"EmployeePhone",employer.EmployeePhone},
               {"EmployeeAddress",employer.EmployeeAddress},
               {"TaxID",employer.TaxID},
               {"AuthorizedOfficial", new BsonDocument
                    {
                            {"FirstName",authorizedOfficial.FirstName},
                            {"LastName",authorizedOfficial.LastName},
                            {"Email",authorizedOfficial.Email},
                            {"PhoneNumber",authorizedOfficial.PhoneNumber}
                    }
               },             
               {"Consultants",new BsonArray
                    {
                            new BsonDocument { {"Consultant_id", 1}},
                            new BsonDocument { {"Consultant_id", 2}} 
                    }
               }
               };  
            

        }

    }
}
