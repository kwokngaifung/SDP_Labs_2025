using System.Data;

namespace DatabaseAccessController
{
    public class dboGetCompanyData : dboDatabaseController
    {
        public dboGetCompanyData(string connectionString) : base(connectionString)
        {
        }

        public DataTable GetAllCustomerData()
        {
            String sqlCmd = "SELECT * FROM customers";
            return GetData(sqlCmd);
        }
    }
}
