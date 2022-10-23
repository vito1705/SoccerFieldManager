using SoccerFieldManager.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;

namespace SoccerFieldManager.DataAccess
{
    public class AppData
    {
        private static string stringDB = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static AppData _instance = null;

        public AppData()
        {

        }

        public static AppData Instance
        {
            get
            { 
                if (_instance == null){
                    _instance = new AppData();
                }
                return _instance;
            }            
        }

        public bool Save(UserEntity user)
        {
            bool response = true;

            using (SQLiteConnection connection = new SQLiteConnection(stringDB))
            {
                connection.Open();
                string queryInsert = "INSERT INTO " +
                "Clients (Id,FirstName,LastName,CellPhone,CellPhoneT,Email) " +
                "values (@Id, @FirstName, @LastName, @CellPhone, @CellPhoneT, @Email)";
                SQLiteCommand cmd = new SQLiteCommand(queryInsert, connection);
                cmd.Parameters.Add(new SQLiteParameter("@Id", user.Id));
                cmd.Parameters.Add(new SQLiteParameter("@FirstName", user.FirstName));
                cmd.Parameters.Add(new SQLiteParameter("@LastName", user.LastName));
                cmd.Parameters.Add(new SQLiteParameter("@CellPhone", user.CellPhone));
                cmd.Parameters.Add(new SQLiteParameter("@CellPhoneT", user.CellPhoneT));
                cmd.Parameters.Add(new SQLiteParameter("@Email", user.Email));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    response = false;
                }
            }
            return response;
        }

        public List<UserEntity> GetUsers()
        {
            List<UserEntity> userList = new List<UserEntity>();
            using (SQLiteConnection connection = new SQLiteConnection(stringDB))
            { 
                connection.Open();
                string querySelectFrom = "SELECT * FROM Clients";
                SQLiteCommand cmd = new SQLiteCommand(querySelectFrom, connection);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        userList.Add(new UserEntity()
                        {
                            Id = Convert.ToInt64(dataReader["Id"].ToString()),
                            FirstName = dataReader["FirstName"].ToString(),
                            LastName = dataReader["LastName"].ToString(),
                            CellPhone = Convert.ToInt64(dataReader["CellPhone"].ToString()),
                            CellPhoneT = Convert.ToInt64(dataReader["CellPhoneT"].ToString()),
                            Email = dataReader["Email"].ToString()
                        });
                    }
                }
            }
            return userList;
        }
    }
}
