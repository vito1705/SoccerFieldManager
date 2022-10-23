using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoccerFieldManager.DataAccess;
using SoccerFieldManager.Entities;

namespace SoccerFieldManager
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void addUserBtClick(object sender, EventArgs e)
        {
            UserEntity user = new UserEntity()
            {
                Id = Convert.ToInt64(idTXTBX.Text),
                FirstName = firstNameTXTBX.Text,
                LastName = lastNameTXTBX.Text,
                CellPhone = Convert.ToInt64(cellPhoneTXTBX.Text),
                CellPhoneT = Convert.ToInt64(cellPhoneTTXTBX.Text),
                Email = emailTXTBX.Text
            };
            bool response = AppData.Instance.Save(user);

            if (response)
            {
                ShowUsers();
            }
        }

        public void ShowUsers()
        {
            AppData applicationData = new AppData();
            List<UserEntity> userList = applicationData.GetUsers();
            foreach (UserEntity user in userList)
            {
                Console.WriteLine(user.Id + user.FirstName + user.LastName);
            }
        }
    }
}
