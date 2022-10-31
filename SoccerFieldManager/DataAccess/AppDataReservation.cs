using SoccerFieldManager.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace SoccerFieldManager.DataAccess
{
    public class AppDataReservation
    {

        private static string stringDB = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static AppDataReservation _instance = null;

        public AppDataReservation()
        {

        }

        public static AppDataReservation Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AppDataReservation();
                }
                return _instance;
            }
        }

        public bool Save(ReservationEntity reservationEntity)
        {
            bool response = true;

            using (SQLiteConnection connection = new SQLiteConnection(stringDB))
            {
                connection.Open();
                string queryInsert = "INSERT INTO " +
                "Reservation (Id_Client, Id_SoccerField, DateReservation, StartTime, EndTime, Price) " +
                "values (@Id_Client, @Id_SoccerField, @DateReservation, @StartTime, @EndTime, @Price)";
                SQLiteCommand cmd = new SQLiteCommand(queryInsert, connection);
                cmd.Parameters.Add(new SQLiteParameter("@Id_Client", reservationEntity.Id_Client));
                cmd.Parameters.Add(new SQLiteParameter("@Id_SoccerField", reservationEntity.Id_SoccerField));
                cmd.Parameters.Add(new SQLiteParameter("@DateReservation", reservationEntity.DateReservation));
                cmd.Parameters.Add(new SQLiteParameter("@StartTime", reservationEntity.StartTime));
                cmd.Parameters.Add(new SQLiteParameter("@EndTime", reservationEntity.EndTime));
                cmd.Parameters.Add(new SQLiteParameter("@Price", reservationEntity.Price));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    response = false;
                }
            }
            return response;
        }

        public List<ReservationEntity> GetReservations()
        {
            List<ReservationEntity> reservationEntitiesList = new List<ReservationEntity>();
            using (SQLiteConnection connection = new SQLiteConnection(stringDB))
            {
                connection.Open();
                string querySelectFrom = "SELECT * FROM Reservation";
                SQLiteCommand cmd = new SQLiteCommand(querySelectFrom, connection);
                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        reservationEntitiesList.Add(new ReservationEntity()
                        {
                            Id_Client = Convert.ToInt64(dataReader["Id_Client"].ToString()),
                            Id_SoccerField = Convert.ToInt64(dataReader["Id_SoccerField"].ToString()),
                            DateReservation = Convert.ToDateTime(dataReader["DateReservation"].ToString()),
                            StartTime = TimeSpan.ParseExact(dataReader["StartTime"].ToString(), "HH:mm:tt", null),
                            EndTime = TimeSpan.ParseExact(dataReader["EndTime"].ToString(), "HH:mm:tt", null),
                            Price = Convert.ToInt64(dataReader["Price"].ToString())
                        });
                    }
                }
            }
            return reservationEntitiesList;
        }

    }
}
