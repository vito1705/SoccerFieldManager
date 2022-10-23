using SoccerFieldManager.DataAccess;
using SoccerFieldManager.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerFieldManager
{
    public partial class ReservationForm : Form
    {
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
    }
}
