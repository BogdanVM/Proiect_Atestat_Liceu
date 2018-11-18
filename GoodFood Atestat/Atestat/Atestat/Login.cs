using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Atestat
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string name, surname, address, email, daily_kcal;
        public static int id_client;

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Functions functions = new Functions();

            string connString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + functions.getDBPath("GOOD_FOOD.mdf") + @";Integrated Security=True;User Instance=True";

            using (SqlConnection con = new SqlConnection(connString))
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT * FROM Clienti WHERE parola = @pass AND email = @mail", con);

                    cmd.Parameters.AddWithValue("@pass", pwdTxt.Text);
                    cmd.Parameters.AddWithValue("@mail", mailTxt.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["admin"].ToString().Trim().Equals("NU"))
                        {
                            id_client = int.Parse(reader["id_client"].ToString());
                            daily_kcal = reader["kcal_zilnice"].ToString();

                            this.Hide();
                            Optiuni login = new Optiuni();
                            login.Closed += (s, args) => this.Show();

                            login.Show();
                        }

                        else
                        {
                            this.Hide();
                            Admin login = new Admin();
                            login.Closed += (s, args) => this.Show();

                            login.Show();
                        }

                        mailTxt.Text = "";
                        pwdTxt.Text = "";
                    }

                    else
                    {
                        functions.mesajEroare(this, "Datele introduse sunt gresite!", "Date gresite");
                    }
                }

                catch (Exception ex)
                {
                    functions.mesajEroare(this, "A avut loc o eroare!", "Eroare"); 
                }
                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
