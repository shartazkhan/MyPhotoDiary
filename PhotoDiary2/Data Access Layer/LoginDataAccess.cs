using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoDiary2.Data_Access_Layer.Entities;

namespace PhotoDiary2.Data_Access_Layer
{
    class LoginDataAccess : DataAccess
    {
        public int UserLoginValidation(User user)
        {
            string sql = "SELECT * FROM Users WHERE Username='" + user.Username + "' AND Password='" + user.Password + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return 1; ;
            }
            return -1;
        }
    }
}
