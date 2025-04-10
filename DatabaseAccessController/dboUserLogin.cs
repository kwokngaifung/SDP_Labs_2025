using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Asn1.Cms;

namespace DatabaseAccessController
{
    public class dboUserLogin : dboDatabaseController
    {
        public dboUserLogin(string connectionString) : base(connectionString)
        {
        }

        public int RegisterUser(string username, string password)
        {
            String sqlCmd = $"INSERT INTO `users` (`username`, `password`) VALUES ('{username}', '{password}')";
            return BatchUpdate(sqlCmd);
        }

        public DataTable LoginUser(string username, string password)
        {
            String sqlCmd = $"SELECT * FROM `users` WHERE username = '123' AND password = 'abc';";
            return GetData(sqlCmd);
        }
    }
}
