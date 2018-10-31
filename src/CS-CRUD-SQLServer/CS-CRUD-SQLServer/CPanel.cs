using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_CRUD_SQLServer
{
    public partial class CPanel : Form
    {
        public CPanel()
        {
            InitializeComponent();
        }

        private void CPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var LPanelInstance = Application.OpenForms.OfType<Login>().Single();
            LPanelInstance.Show();
        }

        private void btn_manageUser_Click(object sender, EventArgs e)
        {
            //SHOW USERMANAGEMENT
            UserManagement UManage = new UserManagement();
            UManage.Show();

            this.Hide();
        }
    }
}
