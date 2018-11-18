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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        int id;

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gOOD_FOODDataSet.Meniu' table. You can move, or remove it, as needed.
            this.meniuTableAdapter.Fill(this.gOOD_FOODDataSet.Meniu);

            
        }

        private void selectMeniu()
        {
            Functions functions = new Functions();

            string connString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + functions.getDBPath("GOOD_FOOD.mdf") + @";Integrated Security=True;User Instance=True";

            using (SqlConnection con = new SqlConnection(connString))
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT * FROM Meniu", con);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }

                catch (Exception ex)
                {
                    functions.mesajEroare(this, "A aparut o eroare!", "Eroare");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Functions functions = new Functions();

            string connString = @"Data Source=.\SQLEXPRESS;AttachDbFilename="+ functions.getDBPath("GOOD_FOOD.mdf") + @";Integrated Security=True;User Instance=True";

            using (SqlConnection con = new SqlConnection(connString))
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO Meniu (id_produs, denumire_produs, descriere, pret, kcal, felul) VALUES (@id, @den, @desc, @pret, @kcal, @fel)", con);

                    cmd.Parameters.AddWithValue("@id", dataGridView1.Rows.Count);
                    cmd.Parameters.AddWithValue("@den", nameTxt.Text);
                    cmd.Parameters.AddWithValue("@desc", textBox1.Text);
                    cmd.Parameters.AddWithValue("@pret", textBox2.Text);
                    cmd.Parameters.AddWithValue("@kcal", textBox3.Text);
                    cmd.Parameters.AddWithValue("@fel", textBox4.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Inserarea a avut loc cu succes!");


                    nameTxt.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";

                    selectMeniu();
                }

                catch (Exception ex)
                {
                    functions.mesajEroare(this, "A aparut o eroare!", "Eroare");
                }
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Functions functions = new Functions();

            string connString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + functions.getDBPath("GOOD_FOOD.mdf") + @";Integrated Security=True;User Instance=True";

            using (SqlConnection con = new SqlConnection(connString))
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"DELETE FROM Meniu WHERE id_produs = @id", con);

                    cmd.Parameters.AddWithValue("@id", id.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Stergerea a avut loc cu succes!");

                    selectMeniu();
                }

                catch (Exception ex)
                {
                    functions.mesajEroare(this, "A aparut o eroare!", "Eroare");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
