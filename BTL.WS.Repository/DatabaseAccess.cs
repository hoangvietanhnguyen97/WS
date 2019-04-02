using BTL.WS.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.WS.Repository
{
    public class DatabaseAccess
    {
        string _stringConnect = ConfigurationManager.ConnectionStrings["NVANH"].ToString();
        SqlConnection _sqlConnection;
        SqlCommand _sqlCommand;
        public DatabaseAccess(){
            if (_sqlConnection == null)
            {
                _sqlConnection = new SqlConnection(_stringConnect);
            }
            if (_sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
            _sqlCommand = _sqlConnection.CreateCommand();
        }
        
        /// <summary>
        /// Check thông tin account để đăng nhập
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        /// Created by NVANH (17/3/2019)
        public IEnumerable<Account> CheckAccount(string email)
        {
            _sqlCommand.CommandText = ("dbo.Proc_GetInforUser '"+email+"'");
            SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Account account = new Account();
                for(int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    string fieldname = sqlDataReader.GetName(i);
                    var value = sqlDataReader.GetValue(i);
                    var property = account.GetType().GetProperty(fieldname);
                    if (property != null && value != DBNull.Value)
                    {
                        property.SetValue(account, value);
                    }
                }
                yield return account;
            }
        }

        public void addAccount(Account account)
        {
            // _sqlCommand.CommandText = ("dbo.Proc_AddAccount '"+account.AccountID+"', '"+account.firstName+"', '"+account.lastName+"', '"+account.email+"', '"+account.password+"', '"+account.birthday+"', "+account.gender);
            _sqlCommand.CommandText = ("dbo.Proc_AddAccount");
            _sqlCommand.CommandType = CommandType.StoredProcedure;
            _sqlCommand.Parameters.AddWithValue("@UserFirstName", account.firstName);
            _sqlCommand.Parameters.AddWithValue("@UserLastName", account.lastName);
            _sqlCommand.Parameters.AddWithValue("@email", account.email);
            _sqlCommand.Parameters.AddWithValue("@password", account.password);
            _sqlCommand.Parameters.AddWithValue("@birthday", account.birthday);
            _sqlCommand.Parameters.AddWithValue("@gender", account.gender);
            //SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
            _sqlCommand.ExecuteNonQuery();
            
        }


    }
}
// k chay dc ak
