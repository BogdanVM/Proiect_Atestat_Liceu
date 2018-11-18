using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Atestat
{
    public partial class Form1 : Form
    {

        Functions functions = new Functions();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Creare_cont_client login = new Creare_cont_client();
            login.Closed += (s, args) => this.Show();

            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Closed += (s, args) => this.Show();

            login.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
