using SoccerFieldManager.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Data.SQLite;

namespace SoccerFieldManager.DataAccess
{
    public class AppDataSoccerField
    {

        private static string stringDB = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static AppDataSoccerField _instance = null;

        public AppDataSoccerField()
        {

        }

        public static AppDataSoccerField Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AppDataSoccerField();
                }
                return _instance;
            }
        }

        public bool Save(SoccerFieldEntity soccerFieldEntity)
        {
            bool response = true;

            using (SQLiteConnection connection = new SQLiteConnection(stringDB))
            {
                connection.Open();
                string queryInsert = "INSERT INTO " +
                "SoccerField (IdFatherSoccerField, Name, Price) " +
                "values (@IdFatherSoccerField, @Name, @Price)";
                SQLiteCommand cmd = new SQLiteCommand(queryInsert, connection);
                cmd.Parameters.Add(new SQLiteParameter("@IdFatherSoccerField", soccerFieldEntity.IdFatherSoccerField));
                cmd.Parameters.Add(new SQLiteParameter("@Name", soccerFieldEntity.Name));
                cmd.Parameters.Add(new SQLiteParameter("@Price", soccerFieldEntity.Price));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    response = false;
                }
            }
            return response;
        }

        public List<SoccerFieldEntity> GetSoccerFields()
        {
            List<SoccerFieldEntity> soccerFieldList = new List<SoccerFieldEntity>();
            using (SQLiteConnection connection = new SQLiteConnection(stringDB))
            {
                connection.Open();
                string querySelectFrom = "SELECT * FROM SoccerField";
                SQLiteCommand cmd = new SQLiteCommand(querySelectFrom, connection);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        soccerFieldList.Add(new SoccerFieldEntity()
                        {
                            Id = Convert.ToInt64(dataReader["Id"].ToString()),
                            IdFatherSoccerField = Convert.ToInt64(dataReader["IdFatherSoccerField"].ToString()),
                            Name = dataReader["Name"].ToString(),
                            Price = Convert.ToInt64(dataReader["Price"])
                        });
                    }
                }
            }
            return soccerFieldList;
        }
    }

}
