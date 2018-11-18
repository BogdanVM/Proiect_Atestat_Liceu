namespace Atestat
{
    partial class Optiuni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CalculatorKCal = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dailyTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.weightTxt = new System.Windows.Forms.TextBox();
            this.heightTxt = new System.Windows.Forms.TextBox();
            this.varstaTxt = new System.Windows.Forms.TextBox();
            this.Comanda = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idprodusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireprodusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kcalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.felulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adauga = new System.Windows.Forms.DataGridViewButtonColumn();
            this.meniuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gOOD_FOODDataSet = new Atestat.GOOD_FOODDataSet();
            this.Grafic_Kcal = new System.Windows.Forms.TabPage();
            this.meniuTableAdapter = new Atestat.GOOD_FOODDataSetTableAdapters.MeniuTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.CalculatorKCal.SuspendLayout();
            this.Comanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meniuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOOD_FOODDataSet)).BeginInit();
            this.Grafic_Kcal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CalculatorKCal);
            this.tabControl1.Controls.Add(this.Comanda);
            this.tabControl1.Controls.Add(this.Grafic_Kcal);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(852, 474);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // CalculatorKCal
            // 
            this.CalculatorKCal.Controls.Add(this.button3);
            this.CalculatorKCal.Controls.Add(this.button2);
            this.CalculatorKCal.Controls.Add(this.label4);
            this.CalculatorKCal.Controls.Add(this.dailyTxt);
            this.CalculatorKCal.Controls.Add(this.label3);
            this.CalculatorKCal.Controls.Add(this.label1);
            this.CalculatorKCal.Controls.Add(this.label2);
            this.CalculatorKCal.Controls.Add(this.weightTxt);
            this.CalculatorKCal.Controls.Add(this.heightTxt);
            this.CalculatorKCal.Controls.Add(this.varstaTxt);
            this.CalculatorKCal.Location = new System.Drawing.Point(4, 22);
            this.CalculatorKCal.Name = "CalculatorKCal";
            this.CalculatorKCal.Size = new System.Drawing.Size(844, 448);
            this.CalculatorKCal.TabIndex = 0;
            this.CalculatorKCal.Text = "CalculatorKCal";
            this.CalculatorKCal.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Info;
            this.button3.Location = new System.Drawing.Point(486, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(336, 75);
            this.button3.TabIndex = 21;
            this.button3.Text = "&Iesire";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(486, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(336, 75);
            this.button2.TabIndex = 20;
            this.button2.Text = "&Calculeaza";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(569, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Necesar zilnic";
            // 
            // dailyTxt
            // 
            this.dailyTxt.BackColor = System.Drawing.SystemColors.Info;
            this.dailyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dailyTxt.Location = new System.Drawing.Point(713, 111);
            this.dailyTxt.Multiline = true;
            this.dailyTxt.Name = "dailyTxt";
            this.dailyTxt.ReadOnly = true;
            this.dailyTxt.Size = new System.Drawing.Size(109, 27);
            this.dailyTxt.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(8, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Greutate (kg)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(8, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Inaltime (cm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Varsta (ani)";
            // 
            // weightTxt
            // 
            this.weightTxt.BackColor = System.Drawing.SystemColors.Info;
            this.weightTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.weightTxt.Location = new System.Drawing.Point(165, 282);
            this.weightTxt.Multiline = true;
            this.weightTxt.Name = "weightTxt";
            this.weightTxt.Size = new System.Drawing.Size(233, 27);
            this.weightTxt.TabIndex = 14;
            // 
            // heightTxt
            // 
            this.heightTxt.BackColor = System.Drawing.SystemColors.Info;
            this.heightTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.heightTxt.Location = new System.Drawing.Point(165, 178);
            this.heightTxt.Multiline = true;
            this.heightTxt.Name = "heightTxt";
            this.heightTxt.Size = new System.Drawing.Size(233, 27);
            this.heightTxt.TabIndex = 13;
            // 
            // varstaTxt
            // 
            this.varstaTxt.BackColor = System.Drawing.SystemColors.Info;
            this.varstaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.varstaTxt.Location = new System.Drawing.Point(165, 65);
            this.varstaTxt.Multiline = true;
            this.varstaTxt.Name = "varstaTxt";
            this.varstaTxt.Size = new System.Drawing.Size(233, 27);
            this.varstaTxt.TabIndex = 12;
            // 
            // Comanda
            // 
            this.Comanda.Controls.Add(this.button4);
            this.Comanda.Controls.Add(this.button1);
            this.Comanda.Controls.Add(this.label7);
            this.Comanda.Controls.Add(this.textBox3);
            this.Comanda.Controls.Add(this.label6);
            this.Comanda.Controls.Add(this.textBox2);
            this.Comanda.Controls.Add(this.label5);
            this.Comanda.Controls.Add(this.textBox1);
            this.Comanda.Controls.Add(this.dataGridView1);
            this.Comanda.Location = new System.Drawing.Point(4, 22);
            this.Comanda.Name = "Comanda";
            this.Comanda.Size = new System.Drawing.Size(844, 448);
            this.Comanda.TabIndex = 1;
            this.Comanda.Text = "Comanda";
            this.Comanda.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Info;
            this.button4.Location = new System.Drawing.Point(476, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(336, 75);
            this.button4.TabIndex = 27;
            this.button4.Text = "&Iesire";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(476, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(336, 75);
            this.button1.TabIndex = 26;
            this.button1.Text = "&Comanda";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(32, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Pret Total";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox3.Location = new System.Drawing.Point(176, 357);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(109, 27);
            this.textBox3.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(32, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Total kcal";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(176, 308);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(109, 27);
            this.textBox2.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(32, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Necesar zilnic";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(176, 254);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(109, 27);
            this.textBox1.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodusDataGridViewTextBoxColumn,
            this.denumireprodusDataGridViewTextBoxColumn,
            this.descriereDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.kcalDataGridViewTextBoxColumn,
            this.felulDataGridViewTextBoxColumn,
            this.Cantitate,
            this.Adauga});
            this.dataGridView1.DataSource = this.meniuBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 226);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idprodusDataGridViewTextBoxColumn
            // 
            this.idprodusDataGridViewTextBoxColumn.DataPropertyName = "id_produs";
            this.idprodusDataGridViewTextBoxColumn.HeaderText = "id_produs";
            this.idprodusDataGridViewTextBoxColumn.Name = "idprodusDataGridViewTextBoxColumn";
            // 
            // denumireprodusDataGridViewTextBoxColumn
            // 
            this.denumireprodusDataGridViewTextBoxColumn.DataPropertyName = "denumire_produs";
            this.denumireprodusDataGridViewTextBoxColumn.HeaderText = "denumire_produs";
            this.denumireprodusDataGridViewTextBoxColumn.Name = "denumireprodusDataGridViewTextBoxColumn";
            // 
            // descriereDataGridViewTextBoxColumn
            // 
            this.descriereDataGridViewTextBoxColumn.DataPropertyName = "descriere";
            this.descriereDataGridViewTextBoxColumn.HeaderText = "descriere";
            this.descriereDataGridViewTextBoxColumn.Name = "descriereDataGridViewTextBoxColumn";
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            // 
            // kcalDataGridViewTextBoxColumn
            // 
            this.kcalDataGridViewTextBoxColumn.DataPropertyName = "kcal";
            this.kcalDataGridViewTextBoxColumn.HeaderText = "kcal";
            this.kcalDataGridViewTextBoxColumn.Name = "kcalDataGridViewTextBoxColumn";
            // 
            // felulDataGridViewTextBoxColumn
            // 
            this.felulDataGridViewTextBoxColumn.DataPropertyName = "felul";
            this.felulDataGridViewTextBoxColumn.HeaderText = "felul";
            this.felulDataGridViewTextBoxColumn.Name = "felulDataGridViewTextBoxColumn";
            // 
            // Cantitate
            // 
            this.Cantitate.HeaderText = "Cantitate";
            this.Cantitate.Name = "Cantitate";
            // 
            // Adauga
            // 
            this.Adauga.HeaderText = "Adauga";
            this.Adauga.Name = "Adauga";
            // 
            // meniuBindingSource
            // 
            this.meniuBindingSource.DataMember = "Meniu";
            this.meniuBindingSource.DataSource = this.gOOD_FOODDataSet;
            // 
            // gOOD_FOODDataSet
            // 
            this.gOOD_FOODDataSet.DataSetName = "GOOD_FOODDataSet";
            this.gOOD_FOODDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Grafic_Kcal
            // 
            this.Grafic_Kcal.Controls.Add(this.chart1);
            this.Grafic_Kcal.Location = new System.Drawing.Point(4, 22);
            this.Grafic_Kcal.Name = "Grafic_Kcal";
            this.Grafic_Kcal.Size = new System.Drawing.Size(844, 448);
            this.Grafic_Kcal.TabIndex = 3;
            this.Grafic_Kcal.Text = "Grafic Kcal";
            this.Grafic_Kcal.UseVisualStyleBackColor = true;
            // 
            // meniuTableAdapter
            // 
            this.meniuTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(844, 448);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Optiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 474);
            this.Controls.Add(this.tabControl1);
            this.Name = "Optiuni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optiuni";
            this.Load += new System.EventHandler(this.Optiuni_Load);
            this.tabControl1.ResumeLayout(false);
            this.CalculatorKCal.ResumeLayout(false);
            this.CalculatorKCal.PerformLayout();
            this.Comanda.ResumeLayout(false);
            this.Comanda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meniuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOOD_FOODDataSet)).EndInit();
            this.Grafic_Kcal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CalculatorKCal;
        private System.Windows.Forms.TabPage Comanda;
        private System.Windows.Forms.TabPage Grafic_Kcal;
        private System.Windows.Forms.TextBox weightTxt;
        private System.Windows.Forms.TextBox heightTxt;
        private System.Windows.Forms.TextBox varstaTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dailyTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GOOD_FOODDataSet gOOD_FOODDataSet;
        private System.Windows.Forms.BindingSource meniuBindingSource;
        private GOOD_FOODDataSetTableAdapters.MeniuTableAdapter meniuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireprodusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kcalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn felulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantitate;
        private System.Windows.Forms.DataGridViewButtonColumn Adauga;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}