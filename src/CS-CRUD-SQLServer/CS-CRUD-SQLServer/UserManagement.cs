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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        public void DGV_GetUsers()
        {
            //to refresh content
            dgv_Users.DataSource = null;

            var conn = new SqlConnection(CSTool.sqlConnString());
            var cmd = new SqlCommand("SP_GetUsers", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();

            var dataAdapter = new SqlDataAdapter(cmd);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();

            dataAdapter.Fill(ds);
            dgv_Users.DataSource = ds.Tables[0];

            conn.Close();

            //Make Uneditable
            dgv_Users.ReadOnly = true;

            //Auto size specific columns

            dgv_Users.Columns[0].Width = 40;
            dgv_Users.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Users.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Users.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Users.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_Users.Columns[5].Width = 70;

            //hide row header
            dgv_Users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Users.RowHeadersVisible = false;

            //Disable row resize
            dgv_Users.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv_Users.AllowUserToResizeRows = false;

            //Remove extra row
            dgv_Users.AllowUserToAddRows = false;

        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            DGV_GetUsers();

            //RESTRICT ACCESS
            if (CSULevel.Admin()) btn_add.Visible = true;
            if (CSULevel.User() || CSULevel.Support() || CSULevel.Admin()) btn_view.Visible = true;
            if (CSULevel.Support() || CSULevel.Admin()) btn_edit.Visible = true;
            if (CSULevel.Admin()) btn_delete.Visible = true;
        }

        private void UserManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var CPanelInstance = Application.OpenForms.OfType<CPanel>().Single();
            CPanelInstance.Show();
        }

        private void dgv_Users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_edit.Enabled = true;
                btn_view.Enabled = true;
                btn_delete.Enabled = true;

                //DATA FROM DGV
                CSVar.selected_id = (int)dgv_Users.Rows[e.RowIndex].Cells[0].Value;
                CSVar.selected_uname = dgv_Users.Rows[e.RowIndex].Cells[1].Value.ToString();
                CSVar.selected_fname = dgv_Users.Rows[e.RowIndex].Cells[2].Value.ToString();
                CSVar.selected_lname = dgv_Users.Rows[e.RowIndex].Cells[3].Value.ToString();
                CSVar.selected_email = dgv_Users.Rows[e.RowIndex].Cells[4].Value.ToString();
                CSVar.selected_userlevel = (int)dgv_Users.Rows[e.RowIndex].Cells[5].Value;
            }
            else
            {
                btn_edit.Enabled = false;
                btn_view.Enabled = false;
                btn_delete.Enabled = false;
            }
        }

        private void dgv_Users_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                new ViewUser().ShowDialog();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            new EditUser().ShowDialog();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            new ViewUser().ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to permanently delete the selected User?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                deleteUser();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void deleteUser()
        {
            SqlConnection conn = new SqlConnection(CSTool.sqlConnString());
            SqlCommand cmd = new SqlCommand("SP_DeleteUser", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", CSVar.selected_id);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

            //refresh table content
            DGV_GetUsers();

            //notif
            CSTool.infoMessage("Record has been deleted.");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            new AddUser().ShowDialog();
        }
    }
}
