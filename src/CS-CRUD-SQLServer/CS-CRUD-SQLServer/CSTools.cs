using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //for sql server

namespace CS_CRUD_SQLServer
{

    class CSVar
    {
        public static int userLevel = 0;

        public static int selected_id = 0;
        public static string selected_uname = "";
        public static string selected_fname = "";
        public static string selected_lname = "";
        public static string selected_email = "";
        public static int selected_userlevel = 0;

        public static void Clear()
        {
            CSVar.selected_id = 0;
            CSVar.selected_uname = "";
            CSVar.selected_fname = "";
            CSVar.selected_lname = "";
            CSVar.selected_email = "";
            CSVar.selected_userlevel = 0;
        }
    }

    class CSTool
    {
        public static int maxLoginChars = 20;

        public static string removeLastChar(string m)
        {
            return m.Remove(m.Length - 1);
        }
        public static void infoMessage(string m)
        {
            MessageBox.Show(m, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void errorMessage(string m)
        {
            MessageBox.Show(m, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static string sqlConnString()
        {
            string conn = "Data Source=.;Initial Catalog=DB_TEST;Persist Security Info=True;User ID=sa;Password=p@ssw0rd";
            return conn;
        }
    }

    class CSULevel
    {
        public static bool User()
        {
            if (CSVar.userLevel == 1)
            {
                return true;
            }
            else return false;
        }
        public static bool Support()
        {
            if (CSVar.userLevel == 2)
            {
                return true;
            }
            else return false;
        }
        public static bool Admin()
        {
            if (CSVar.userLevel == 9)
            {
                return true;
            }
            else return false;
        }
    }

    class CSKey
    {
        public const int Enter = 13;
    }
}
