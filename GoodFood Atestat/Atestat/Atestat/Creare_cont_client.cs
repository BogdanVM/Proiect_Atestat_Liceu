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
    public partial class Creare_cont_client : Form
    {
        public Creare_cont_client()
        {
            InitializeComponent();
        }

        Functions functions;

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string surname = surnameTxt.Text;
            string address = addressTxt.Text;
            string password = pwdTxt.Text;
            string email = mailTxt.Text;

            if (functions.validMail(email))
            {
                if (!functions.duplicateMail(email))
                {
                    if (pwdTxt.Text == confPwdTxt.Text)
                    {
                        string connString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + functions.getDBPath("GOOD_FOOD.mdf") + ";Integrated Security=True;User Instance=True";
                        using (SqlConnection con = new SqlConnection(connString))
                        {
                            try
                            {
                                con.Open();
                                SqlCommand cmd = new SqlCommand(@"INSERT INTO Clienti (parola, nume, prenume, adresa, email, kcal_zilnice) VALUES (@pass, @name, @surname, @address, @mail, 0)", con);

                                cmd.Parameters.AddWithValue("@pass", pwdTxt.Text);
                                cmd.Parameters.AddWithValue("@name", nameTxt.Text);
                                cmd.Parameters.AddWithValue("@surname", surnameTxt.Text);
                                cmd.Parameters.AddWithValue("@address", addressTxt.Text);
                                cmd.Parameters.AddWithValue("@mail", mailTxt.Text);

                                cmd.ExecuteNonQuery();
                            }

                            catch (Exception ex)
                            {
                                //MessageBox.Show(this, "A avut loc o eroare!", "Eroare", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                                functions.mesajEroare(this, "A avut loc o eroare!", "Eroare");
                            }
                        }

                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Parolele nu se potrivesc!");
                        pwdTxt.Text = "";
                        confPwdTxt.Text = "";
                    }
                }

                else
                {
                    MessageBox.Show("Emailul exista deja in baza de date!");
                    mailTxt.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Emailul nu este valid!");
                mailTxt.Text = "";

                //nameTxt.Text = "";
                //surnameTxt.Text = "";
                //addressTxt.Text = "";
                //pwdTxt.Text = "";
                //confPwdTxt.Text = "";
                //mailTxt.Text = "";
            }
        }

        private void Creare_cont_client_Load(object sender, EventArgs e)
        {
            functions = new Functions();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
