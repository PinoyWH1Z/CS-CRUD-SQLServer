using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CS_CRUD_SQLServer
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }


        private void AddNewUser()
        {
            SqlConnection conn = new SqlConnection(CSTool.sqlConnString());
            SqlCommand cmd = new SqlCommand("SP_AddUser2", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            txt_uname.Text = txt_uname.Text.Trim();

            cmd.Parameters.AddWithValue("@uname", txt_uname.Text);
            cmd.Parameters.AddWithValue("@pword", txt_pword.Text);
            cmd.Parameters.AddWithValue("@fname", txt_fname.Text);
            cmd.Parameters.AddWithValue("@lname", txt_lname.Text);
            cmd.Parameters.AddWithValue("@email", txt_email.Text);
            cmd.Parameters.AddWithValue("@ulevel", txt_ulevel.Text);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

            //refresh table content
            refreshUsersTable();

            //notif
            CSTool.infoMessage("Record has been added.");

            this.Close();
        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to add this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                AddNewUser();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void refreshUsersTable()
        {
            var UMInstance = Application.OpenForms.OfType<UserManagement>().Single();
            UMInstance.DGV_GetUsers();
        }
    }
}
