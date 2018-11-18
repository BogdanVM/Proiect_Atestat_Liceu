using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Atestat
{
    class Functions
    {

        public string getDBPath(string DBName)
        {
            string location = System.Reflection.Assembly.GetEntryAssembly().Location;
            string[] paths = location.Split('\\');

            string path = "";

            for (int index = 0; index < paths.Length - 3; index++)
            {
                path += paths[index] + '\\';
            }

            path += DBName;

            return path;
        }

        public bool duplicateMail(string email)
        {
            string connString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + getDBPath("GOOD_FOOD.mdf") + ";Integrated Security=True;User Instance=True";


            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT TOP 1 id_client FROM Clienti WHERE email = @mail", con);

                cmd.Parameters.AddWithValue("@mail", email);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                if (reader.HasRows) return true;
            }


            return false;
        }

        public bool validMail(string email)
        {
            string[] firstParts = email.Split('@');
            if (firstParts.Length != 2) return false;
            if (firstParts[0] == "") return false;

            firstParts = firstParts[1].Split('.');
            if (firstParts.Length < 2) return false;

            return true;
        }

        public void mesajEroare(Form context, string text, string caption)
        {
            MessageBox.Show(context, text, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }


    }
}
