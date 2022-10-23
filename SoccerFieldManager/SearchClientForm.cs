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
    public partial class SearchClientForm : Form
    {
        public SearchClientForm()
        {
            InitializeComponent();
        }

        private void selectBtClick(object sender, EventArgs e)
        {

        }

        private void CancelBtClick(object sender, EventArgs e)
        {

        }

        private void SearchUserBtClick(object sender, EventArgs e)
        {

        }

        private void EditUserBTClick(object sender, EventArgs e)
        {

        }

        private void AddUserBtClick(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }
    }
}
