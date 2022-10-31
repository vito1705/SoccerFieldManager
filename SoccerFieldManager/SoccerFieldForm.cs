using SoccerFieldManager.DataAccess;
using SoccerFieldManager.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerFieldManager
{
    public partial class SoccerFieldForm : Form
    {
        public SoccerFieldForm()
        {
            InitializeComponent();
        }

        private void SoccerFieldForm_Load(object sender, EventArgs e)
        {
            refreshList();
        }

        public void refreshList()
        {
            List<string> list = new List<string>();
            list.Add("- - Agregar - -");
            
            AppDataSoccerField appDataSoccerField = new AppDataSoccerField();
            List<SoccerFieldEntity> soccerFieldList = appDataSoccerField.GetSoccerFields();
            foreach (SoccerFieldEntity soccerField in soccerFieldList)
            {
                list.Add(soccerField.Name);
            }
            soccerFieldCBX.DataSource = list;
            soccerFieldCBX.SelectedIndex = 0;
        }

        private void soccerFieldCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (soccerFieldCBX.SelectedIndex == 0)
            {
                savePanel.Enabled = true;
                editBt.Enabled = false;
                deleteBt.Enabled = false;
            }
            else
            {
                savePanel.Enabled = false;
                editBt.Enabled = true;
                deleteBt.Enabled = true;
            }
        }

        private void saveBtClick(object sender, EventArgs e)
        {
            long auxFatherSoccerfield = 0;
            if (!isChildrenChBx.Checked)
            {
                auxFatherSoccerfield = 0;
            }
            else
            {
                AppDataSoccerField appDataSoccerField = new AppDataSoccerField();
                List<SoccerFieldEntity> soccerFieldList = appDataSoccerField.GetSoccerFields();
                foreach (SoccerFieldEntity soccerField in soccerFieldList)
                {
                    if (combsoccerFieldFatherCBX.SelectedItem.ToString() == soccerField.Name)
                    {
                        auxFatherSoccerfield = soccerField.Id;
                    }
                }
            }
            SoccerFieldEntity soccerFieldEntity = new SoccerFieldEntity()
            {
                IdFatherSoccerField = Convert.ToInt64(auxFatherSoccerfield),
                Name = nameSoccerFieldTxB.Text,
                Price = Convert.ToInt64(priceTxB.Text)
            };
            bool response = AppDataSoccerField.Instance.Save(soccerFieldEntity);
            refreshList();
        }
    }
}
