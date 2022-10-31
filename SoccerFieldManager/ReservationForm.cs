using SoccerFieldManager.DataAccess;
using SoccerFieldManager.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerFieldManager
{
    public partial class ReservationForm : Form
    {
        long idClient = 0;
        long idSoccerField = 0;
        string initHour = "";
        string endHour = "";
        long auxPrice = 0;
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void btSearchClientClick(object sender, EventArgs e)
        {
            
            AppData applicationData = new AppData();
            List<UserEntity> userList = applicationData.GetUsers();
            foreach (UserEntity user in userList)
            {
                if (clientTXTBX.Text == user.Id.ToString())
                {
                    firstNameLb.Text = user.FirstName;
                    lastNameLb.Text = user.LastName;
                    cellPhoneLb.Text = user.CellPhone.ToString();
                    cellPhoneTLb.Text = user.CellPhoneT.ToString();
                    emailLb.Text = user.Email;
                    messageUserNotFoundLb.Visible = false;
                    idClient = user.Id;
                    return;
                }
            }
            messageUserNotFoundLb.Visible=true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addClientBtClick(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            controlInvalidEntriesLb.Visible = false;
            fieldsCBX.Items.Add("- - Seleccione una cancha - -");
            fieldsCBX.SelectedIndex = 0;
            AppDataSoccerField appDataSoccerField = new AppDataSoccerField();
            List<SoccerFieldEntity> soccerFieldList = appDataSoccerField.GetSoccerFields();
            foreach (SoccerFieldEntity soccerField in soccerFieldList)
            {
                fieldsCBX.Items.Add(soccerField.Name);
            }
        }

        private void makeReservationBtClick(object sender, EventArgs e)
        {
            if (!validateInputsMakeReservationClick()){ return; }
            if (idClient == 0) { controlInvalidEntriesLb.Text = "Debe Seleccionar al cliente"; return; }

            finalPriceLb.Text = auxPrice.ToString();
            string auxHourStart = amPmHour(startTimeFormatCBX.Text, startTimeHourCBX.Text);
            initHour = auxHourStart + ":" + startTimeMinuteCBX.Text;
            Console.WriteLine(initHour);

            string auxHourEnd = amPmHour(EndTimeFormatCBX.Text, EndTimeHourCBX.Text);
            endHour = auxHourEnd + ":" + EndTimeMinuteCBX.Text;
            Console.WriteLine(endHour);

            var timeStart = TimeSpan.ParseExact(initHour, "hh\\:mm", null);
            Console.WriteLine(timeStart);

            var timeEnd = TimeSpan.ParseExact(endHour, "hh\\:mm", null);
            Console.WriteLine(timeEnd);
            ReservationEntity reservationEntity = new ReservationEntity()
            {
                Id_Client = idClient,
                Id_SoccerField = idSoccerField,
                DateReservation = Convert.ToDateTime(dateReservationPck.Value.ToString("dd-MM-yyyy")),
                StartTime = timeStart,
                EndTime = timeEnd,
                Price = Convert.ToInt64(auxPrice)
            };
            bool response = AppDataReservation.Instance.Save(reservationEntity);

        }

        public string amPmHour(string format, string timeHour)
        {
            int auxHour = 0;
            if (format == "p.m")
            {
                if (timeHour == "12") { timeHour = "0"; }
                auxHour = Convert.ToInt32(timeHour) + 12;

                return auxHour.ToString();
            }
            else {
                if (timeHour == "12") { timeHour = "00"; }
                return timeHour;
            }
        }

        private bool validateInputsMakeReservationClick()
        {
            controlInvalidEntriesLb.ForeColor = Color.Brown;
            if (fieldsCBX.SelectedIndex == 0)
            {
                controlInvalidEntriesLb.Text = "Debe Seleccionar una cancha";
                controlInvalidEntriesLb.Visible = true; return false;
            }
            DateTime dt2 = DateTime.Now;
            if (dateReservationPck.Value < dt2)
            {
                controlInvalidEntriesLb.Text = "La fecha seleccionada ya pasó";
                controlInvalidEntriesLb.Visible = true; return false;
            }
            
            if (startTimeHourCBX.SelectedIndex == -1 || startTimeMinuteCBX.SelectedIndex == -1 || startTimeFormatCBX.SelectedIndex == -1)
            {
                controlInvalidEntriesLb.Text = "Debe llenar todos los campos de la hora inicial";
                controlInvalidEntriesLb.Visible = true; return false;
            }
            if (EndTimeHourCBX.SelectedIndex == -1 || EndTimeMinuteCBX.SelectedIndex == -1 || EndTimeFormatCBX.SelectedIndex == -1)
            {
                controlInvalidEntriesLb.Text = "Debe llenar todos los campos de la hora final¿?";
                controlInvalidEntriesLb.Visible = true; return false;
            }
            controlInvalidEntriesLb.Text = "Registro realizado con éxito";
            controlInvalidEntriesLb.ForeColor = Color.Green;
            controlInvalidEntriesLb.Visible = true;
            Console.WriteLine(fieldsCBX.SelectedItem.ToString());
            AppDataSoccerField appDataSoccerField = new AppDataSoccerField();
            List<SoccerFieldEntity> soccerFieldList = appDataSoccerField.GetSoccerFields();
            foreach (SoccerFieldEntity soccerField in soccerFieldList)
            {
                if (fieldsCBX.SelectedItem.ToString() == soccerField.Name)
                {
                    auxPrice = soccerField.Price;
                    idSoccerField = soccerField.Id;
                }
            }
            auxPrice = auxPrice + Convert.ToInt64(increaseTxb.Text);
            return true;
        }
    }
}
