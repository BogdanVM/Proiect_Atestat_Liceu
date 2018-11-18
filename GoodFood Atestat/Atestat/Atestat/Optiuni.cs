using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Atestat
{
    public partial class Optiuni : Form
    {

        int suma = 0;
        Functions functions = new Functions();

        List<int> ids = new List<int>();
        List<int> quantities = new List<int>();

        public Optiuni()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!varstaTxt.Text.Equals(""))
            {
                if (!heightTxt.Text.Equals(""))
                {
                    if (!weightTxt.Text.Equals(""))
                    {
                        int age = int.Parse(varstaTxt.Text);
                        int height = int.Parse(heightTxt.Text);
                        int weight = int.Parse(weightTxt.Text);

                        suma = age + height + weight;

                        if (suma < 250)
                        {
                            Login.daily_kcal = "1800";
                        }

                        else if (suma >= 250 && suma <= 275)
                        {
                            Login.daily_kcal = "2200";
                        }

                        else
                        {
                            Login.daily_kcal = "2500";
                        }

                        string connString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + functions.getDBPath("GOOD_FOOD.mdf") + ";Integrated Security=True;User Instance=True";
                        using (SqlConnection con = new SqlConnection(connString))
                        {
                            try
                            {
                                con.Open();
                                SqlCommand cmd = new SqlCommand(@"UPDATE Clienti SET kcal_zilnice = @kcal WHERE id_client = @id", con);

                                cmd.Parameters.AddWithValue("@kcal", Login.daily_kcal);
                                cmd.Parameters.AddWithValue("@id", Login.id_client);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Necesarul zilnic calculat cu succes!");
                            }

                            catch (Exception ex)
                            {
                                //MessageBox.Show(this, "A avut loc o eroare!", "Eroare", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                                functions.mesajEroare(this, "A avut loc o eroare!", "Eroare");
                            }
                        }

                        dailyTxt.Text = Login.daily_kcal.ToString();
                        varstaTxt.Text = "";
                        heightTxt.Text = "";
                        weightTxt.Text = "";
                    }

                    else
                    {
                        functions.mesajEroare(this, "Completati toate campurile!", "Date incomplete");
                    }
                }

                else
                {
                    functions.mesajEroare(this, "Completati toate campurile!", "Date incomplete");
                }
            }

            else
            {
                functions.mesajEroare(this, "Completati toate campurile!", "Date incomplete");
            }
        }

        private void Optiuni_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gOOD_FOODDataSet.Meniu' table. You can move, or remove it, as needed.
            this.meniuTableAdapter.Fill(this.gOOD_FOODDataSet.Meniu);

            #region Meniu

            //StreamReader reader = new StreamReader(@"meniu.txt");

            //#region arrays


            //string[] columns = new string[30];
            


            //#endregion

            //reader.ReadLine();

            //for (int i = 0; i < 27; i++)
            //{
            //    string line = reader.ReadLine();

            //    columns = line.Split(';');

            //    string connString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + functions.getDBPath("GOOD_FOOD.mdf") + ";Integrated Security=True;User Instance=True";
            //    using (SqlConnection con = new SqlConnection(connString))
            //    {
            //        try
            //        {
            //            con.Open();
            //            SqlCommand cmd = new SqlCommand(@"INSERT INTO Meniu VALUES (@id, @den, @desc, @pret, @kcal, @fel)", con);

            //            cmd.Parameters.AddWithValue("@id", columns[0]);
            //            cmd.Parameters.AddWithValue("@den", columns[1]);
            //            cmd.Parameters.AddWithValue("@desc", columns[2]);
            //            cmd.Parameters.AddWithValue("@pret", columns[3]);
            //            cmd.Parameters.AddWithValue("@kcal", columns[4]);
            //            cmd.Parameters.AddWithValue("@fel", columns[5]);
                        

            //            cmd.ExecuteNonQuery();
            //        }

            //        catch (Exception ex)
            //        {
            //            //MessageBox.Show(this, "A avut loc o eroare!", "Eroare", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            //            functions.mesajEroare(this, "A avut loc o eroare!", "Eroare");
            //        }
            //    }


            //}

            #endregion
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                int kcal_necesar = int.Parse(textBox1.Text);
                int total_kcal = int.Parse(textBox2.Text);
                int total_pret = int.Parse(textBox3.Text);

                int cantitate = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                int kcals = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                int pret = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

                total_kcal += kcals * cantitate;
                total_pret += pret * cantitate;

                if (total_kcal <= kcal_necesar)
                {
                    ids.Add(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    quantities.Add(cantitate);


                    MessageBox.Show("Produsul a fost adaugat in cos!");

                    textBox1.Text = (kcal_necesar - total_kcal).ToString();
                    textBox2.Text = total_kcal.ToString();
                    textBox3.Text = total_pret.ToString();
                }

                else
                {
                    functions.mesajEroare(this, "Ati depasit numarul de calorii necesar!", "Numar calorii");
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                for (int index = 0; index < dataGridView1.Rows.Count; index++)
                {
                    dataGridView1.Rows[index].Cells[6].Value = 1;
                    dataGridView1.Rows[index].Cells[7].Value = "Adauga";
                }

                textBox1.Text = Login.daily_kcal;
                textBox2.Text = "0";
                textBox3.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string connString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + functions.getDBPath("GOOD_FOOD.mdf") + ";Integrated Security=True;User Instance=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                //try
                //{
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO Comenzi (id_client, data_comanda) OUTPUT INSERTED.id_comanda VALUES (@idc, @data)", con);

                    cmd.Parameters.AddWithValue("@idc", Login.id_client);
                    cmd.Parameters.AddWithValue("@data", DateTime.Now);

                    int id_comanda = (int)cmd.ExecuteScalar();


                    cmd.CommandText = @"INSERT INTO Subcomenzi (id_comanda, id_produs, cantitate) VALUES (@idcmd, @idp, @quant)";

                    for(int index = 0; index < ids.Count; index++)
                    {
                        cmd.Parameters.AddWithValue("@idcmd", id_comanda);
                        cmd.Parameters.AddWithValue("@idp", ids[index]);
                        cmd.Parameters.AddWithValue("@quant", quantities[index]);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }

                    ids.Clear();
                    quantities.Clear();

                    MessageBox.Show("Comanda a fost efectuata cu succes!");

                    this.Close();
                //}

                //catch (Exception ex)
                //{
                //    //MessageBox.Show(this, "A avut loc o eroare!", "Eroare", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                //    functions.mesajEroare(this, "A avut loc o eroare!", "Eroare");
                //}
            }
        }
    }
}
