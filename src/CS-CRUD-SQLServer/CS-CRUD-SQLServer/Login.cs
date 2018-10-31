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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(CSTool.sqlConnString());
            SqlCommand cmd = new SqlCommand("SP_Login", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@uname", txt_loginID.Text);
            cmd.Parameters.AddWithValue("@pass", txt_loginPW.Text);

            conn.Open();
            //cmd.ExecuteNonQuery();
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //ASSIGN USER LEVEL TO LOCAL VAR
                CSVar.userLevel = (int)reader[0];

                //CHECK IF LOGGED SUCCESSFULY
                if (CSVar.userLevel > 0)
                {
                    CSTool.infoMessage("Successfully logged in.");
                    //SHOW CPANEL if a valid user
                    if (CSULevel.User() || CSULevel.Support() || CSULevel.Admin())
                    {
                        //SHOW CPANEL
                        CPanel CPWindow = new CPanel();
                        CPWindow.Show();

                        //HIDE LOGIN PANEL
                        this.Hide();
                    }
                }else
                {
                    CSTool.errorMessage("Incorrect Username or password.");
                }
            }

            conn.Close();
        }

        private void txt_loginID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == CSKey.Enter) btn_Login.PerformClick(); 
        }

        private void txt_loginPW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == CSKey.Enter) btn_Login.PerformClick();
        }

        private void txt_loginID_TextChanged(object sender, EventArgs e)
        {
            if (txt_loginID.Text.Length > CSTool.maxLoginChars)
            {
                CSTool.errorMessage("Max username characters is " + CSTool.maxLoginChars);
                txt_loginID.Text = CSTool.removeLastChar(txt_loginID.Text);
            }
        }

        private void txt_loginPW_TextChanged(object sender, EventArgs e)
        {
            if (txt_loginPW.Text.Length > CSTool.maxLoginChars)
            {
                CSTool.errorMessage("Max password characters is " + CSTool.maxLoginChars);
                txt_loginPW.Text = CSTool.removeLastChar(txt_loginPW.Text);
                txt_loginPW.Clear();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
