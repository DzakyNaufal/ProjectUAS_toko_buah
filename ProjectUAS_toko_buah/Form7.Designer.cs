﻿namespace ProjectUAS_toko_buah
{
    partial class Form7
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Clear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toko_buahDataSet = new ProjectUAS_toko_buah.toko_buahDataSet();
            this.mengirimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mengirimTableAdapter = new ProjectUAS_toko_buah.toko_buahDataSetTableAdapters.MengirimTableAdapter();
            this.idpengirimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmrbuahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglkirimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resipengirimanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpemasokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbuahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_buahDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mengirimBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpengirimDataGridViewTextBoxColumn,
            this.nmrbuahDataGridViewTextBoxColumn,
            this.tglkirimDataGridViewTextBoxColumn,
            this.resipengirimanDataGridViewTextBoxColumn,
            this.idpemasokDataGridViewTextBoxColumn,
            this.idbuahDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mengirimBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(384, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(384, 239);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Pemasok";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id Buah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tanggal Kirim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Resi Pengiriman";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 197);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(33, 255);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(76, 32);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 32);
            this.button3.TabIndex = 11;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectUAS_toko_buah.Properties.Resources.left_arrow;
            this.pictureBox2.Location = new System.Drawing.Point(33, 371);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // toko_buahDataSet
            // 
            this.toko_buahDataSet.DataSetName = "toko_buahDataSet";
            this.toko_buahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mengirimBindingSource
            // 
            this.mengirimBindingSource.DataMember = "Mengirim";
            this.mengirimBindingSource.DataSource = this.toko_buahDataSet;
            // 
            // mengirimTableAdapter
            // 
            this.mengirimTableAdapter.ClearBeforeFill = true;
            // 
            // idpengirimDataGridViewTextBoxColumn
            // 
            this.idpengirimDataGridViewTextBoxColumn.DataPropertyName = "id_pengirim";
            this.idpengirimDataGridViewTextBoxColumn.HeaderText = "id_pengirim";
            this.idpengirimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpengirimDataGridViewTextBoxColumn.Name = "idpengirimDataGridViewTextBoxColumn";
            this.idpengirimDataGridViewTextBoxColumn.Width = 125;
            // 
            // nmrbuahDataGridViewTextBoxColumn
            // 
            this.nmrbuahDataGridViewTextBoxColumn.DataPropertyName = "nmr_buah";
            this.nmrbuahDataGridViewTextBoxColumn.HeaderText = "nmr_buah";
            this.nmrbuahDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nmrbuahDataGridViewTextBoxColumn.Name = "nmrbuahDataGridViewTextBoxColumn";
            this.nmrbuahDataGridViewTextBoxColumn.Width = 125;
            // 
            // tglkirimDataGridViewTextBoxColumn
            // 
            this.tglkirimDataGridViewTextBoxColumn.DataPropertyName = "tgl_kirim";
            this.tglkirimDataGridViewTextBoxColumn.HeaderText = "tgl_kirim";
            this.tglkirimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tglkirimDataGridViewTextBoxColumn.Name = "tglkirimDataGridViewTextBoxColumn";
            this.tglkirimDataGridViewTextBoxColumn.Width = 125;
            // 
            // resipengirimanDataGridViewTextBoxColumn
            // 
            this.resipengirimanDataGridViewTextBoxColumn.DataPropertyName = "resi_pengiriman";
            this.resipengirimanDataGridViewTextBoxColumn.HeaderText = "resi_pengiriman";
            this.resipengirimanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resipengirimanDataGridViewTextBoxColumn.Name = "resipengirimanDataGridViewTextBoxColumn";
            this.resipengirimanDataGridViewTextBoxColumn.Width = 125;
            // 
            // idpemasokDataGridViewTextBoxColumn
            // 
            this.idpemasokDataGridViewTextBoxColumn.DataPropertyName = "id_pemasok";
            this.idpemasokDataGridViewTextBoxColumn.HeaderText = "id_pemasok";
            this.idpemasokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpemasokDataGridViewTextBoxColumn.Name = "idpemasokDataGridViewTextBoxColumn";
            this.idpemasokDataGridViewTextBoxColumn.Width = 125;
            // 
            // idbuahDataGridViewTextBoxColumn
            // 
            this.idbuahDataGridViewTextBoxColumn.DataPropertyName = "id_buah";
            this.idbuahDataGridViewTextBoxColumn.HeaderText = "id_buah";
            this.idbuahDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbuahDataGridViewTextBoxColumn.Name = "idbuahDataGridViewTextBoxColumn";
            this.idbuahDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Mengirim";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_buahDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mengirimBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private toko_buahDataSet toko_buahDataSet;
        private System.Windows.Forms.BindingSource mengirimBindingSource;
        private toko_buahDataSetTableAdapters.MengirimTableAdapter mengirimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpengirimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmrbuahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglkirimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resipengirimanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpemasokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbuahDataGridViewTextBoxColumn;
    }
}