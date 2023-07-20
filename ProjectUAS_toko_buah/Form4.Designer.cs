namespace ProjectUAS_toko_buah
{
    partial class Form4
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.toko_buahDataSet = new ProjectUAS_toko_buah.toko_buahDataSet();
            this.tokobuahDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toko_buahDataSet1 = new ProjectUAS_toko_buah.toko_buahDataSet1();
            this.pemasokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pemasokTableAdapter = new ProjectUAS_toko_buah.toko_buahDataSet1TableAdapters.pemasokTableAdapter();
            this.namapemasokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpemasokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notlpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbuahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_buahDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokobuahDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_buahDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemasokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namapemasokDataGridViewTextBoxColumn,
            this.idpemasokDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.notlpDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.idbuahDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pemasokBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(397, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Pemasok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id Pemasok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "No Hp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(578, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(578, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(578, 196);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(578, 241);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(186, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(578, 283);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(186, 22);
            this.textBox5.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(529, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(610, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 13;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectUAS_toko_buah.Properties.Resources.left_arrow;
            this.pictureBox2.Location = new System.Drawing.Point(28, 371);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(692, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 38);
            this.button4.TabIndex = 29;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // toko_buahDataSet
            // 
            this.toko_buahDataSet.DataSetName = "toko_buahDataSet";
            this.toko_buahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tokobuahDataSetBindingSource
            // 
            this.tokobuahDataSetBindingSource.DataSource = this.toko_buahDataSet;
            this.tokobuahDataSetBindingSource.Position = 0;
            // 
            // toko_buahDataSet1
            // 
            this.toko_buahDataSet1.DataSetName = "toko_buahDataSet1";
            this.toko_buahDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pemasokBindingSource
            // 
            this.pemasokBindingSource.DataMember = "pemasok";
            this.pemasokBindingSource.DataSource = this.toko_buahDataSet1;
            // 
            // pemasokTableAdapter
            // 
            this.pemasokTableAdapter.ClearBeforeFill = true;
            // 
            // namapemasokDataGridViewTextBoxColumn
            // 
            this.namapemasokDataGridViewTextBoxColumn.DataPropertyName = "nama_pemasok";
            this.namapemasokDataGridViewTextBoxColumn.HeaderText = "nama_pemasok";
            this.namapemasokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namapemasokDataGridViewTextBoxColumn.Name = "namapemasokDataGridViewTextBoxColumn";
            this.namapemasokDataGridViewTextBoxColumn.Width = 125;
            // 
            // idpemasokDataGridViewTextBoxColumn
            // 
            this.idpemasokDataGridViewTextBoxColumn.DataPropertyName = "id_pemasok";
            this.idpemasokDataGridViewTextBoxColumn.HeaderText = "id_pemasok";
            this.idpemasokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpemasokDataGridViewTextBoxColumn.Name = "idpemasokDataGridViewTextBoxColumn";
            this.idpemasokDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 125;
            // 
            // notlpDataGridViewTextBoxColumn
            // 
            this.notlpDataGridViewTextBoxColumn.DataPropertyName = "no_tlp";
            this.notlpDataGridViewTextBoxColumn.HeaderText = "no_tlp";
            this.notlpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notlpDataGridViewTextBoxColumn.Name = "notlpDataGridViewTextBoxColumn";
            this.notlpDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // idbuahDataGridViewTextBoxColumn
            // 
            this.idbuahDataGridViewTextBoxColumn.DataPropertyName = "id_buah";
            this.idbuahDataGridViewTextBoxColumn.HeaderText = "id_buah";
            this.idbuahDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbuahDataGridViewTextBoxColumn.Name = "idbuahDataGridViewTextBoxColumn";
            this.idbuahDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Pemasok";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_buahDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokobuahDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_buahDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemasokBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource tokobuahDataSetBindingSource;
        private toko_buahDataSet toko_buahDataSet;
        private toko_buahDataSet1 toko_buahDataSet1;
        private System.Windows.Forms.BindingSource pemasokBindingSource;
        private toko_buahDataSet1TableAdapters.pemasokTableAdapter pemasokTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapemasokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpemasokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notlpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbuahDataGridViewTextBoxColumn;
    }
}