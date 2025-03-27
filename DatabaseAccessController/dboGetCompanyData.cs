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

        public DataTable GetcustomerFirstNameData(String customerFirstName)
        {
            String sqlCmd = "SELECT * FROM customers where contactFirstName = '" + customerFirstName + "'";
            return GetData(sqlCmd);
        }
    }
}
