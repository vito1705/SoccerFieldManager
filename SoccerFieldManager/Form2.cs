using SoccerFieldManager.DataAccess;
using SoccerFieldManager.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerFieldManager
{
    public partial class Form2 : Form
    {
        private static string stringDB = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        public Form2()
        {
            InitializeComponent();
        }

        private void bt_ReservationClick(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.ShowDialog();
        }

        private void configBtClick(object sender, EventArgs e)
        {

        }

        private void clientesBTClick(object sender, EventArgs e)
        {

        }

        private void soccerFieldBtClick(object sender, EventArgs e)
        {
            SoccerFieldForm soccerFieldForm = new SoccerFieldForm();
            soccerFieldForm.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string querySelectFrom = "SELECT * FROM Reservation";
            var dataAdapter = new SQLiteDataAdapter(querySelectFrom, stringDB);
            var commandBuilder = new SQLiteCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            reservationsDGV.ReadOnly = true;
            reservationsDGV.DataSource = ds.Tables[0];
            //reservationsDGV.DataSource = dtRecord;
        }
    }
}
