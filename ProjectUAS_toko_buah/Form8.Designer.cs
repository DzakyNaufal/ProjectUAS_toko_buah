namespace ProjectUAS_toko_buah
{
    partial class Form8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toko_buahDataSet = new ProjectUAS_toko_buah.toko_buahDataSet();
            this.buahrusakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buah_rusakTableAdapter = new ProjectUAS_toko_buah.toko_buahDataSetTableAdapters.buah_rusakTableAdapter();
            this.idrusakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglrusakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalrusakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idjualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_buahDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buahrusakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Rusak";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal Rusak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Rusak";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 274);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 312);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 22);
            this.textBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrusakDataGridViewTextBoxColumn,
            this.tglrusakDataGridViewTextBoxColumn,
            this.totalrusakDataGridViewTextBoxColumn,
            this.idjualDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.buahrusakBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(506, 192);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(436, 350);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(84, 30);
            this.Button3.TabIndex = 10;
            this.Button3.Text = "Save";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectUAS_toko_buah.Properties.Resources.left_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(33, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toko_buahDataSet
            // 
            this.toko_buahDataSet.DataSetName = "toko_buahDataSet";
            this.toko_buahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buahrusakBindingSource
            // 
            this.buahrusakBindingSource.DataMember = "buah_rusak";
            this.buahrusakBindingSource.DataSource = this.toko_buahDataSet;
            // 
            // buah_rusakTableAdapter
            // 
            this.buah_rusakTableAdapter.ClearBeforeFill = true;
            // 
            // idrusakDataGridViewTextBoxColumn
            // 
            this.idrusakDataGridViewTextBoxColumn.DataPropertyName = "id_rusak";
            this.idrusakDataGridViewTextBoxColumn.HeaderText = "id_rusak";
            this.idrusakDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idrusakDataGridViewTextBoxColumn.Name = "idrusakDataGridViewTextBoxColumn";
            this.idrusakDataGridViewTextBoxColumn.Width = 125;
            // 
            // tglrusakDataGridViewTextBoxColumn
            // 
            this.tglrusakDataGridViewTextBoxColumn.DataPropertyName = "tgl_rusak";
            this.tglrusakDataGridViewTextBoxColumn.HeaderText = "tgl_rusak";
            this.tglrusakDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tglrusakDataGridViewTextBoxColumn.Name = "tglrusakDataGridViewTextBoxColumn";
            this.tglrusakDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalrusakDataGridViewTextBoxColumn
            // 
            this.totalrusakDataGridViewTextBoxColumn.DataPropertyName = "total_rusak";
            this.totalrusakDataGridViewTextBoxColumn.HeaderText = "total_rusak";
            this.totalrusakDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalrusakDataGridViewTextBoxColumn.Name = "totalrusakDataGridViewTextBoxColumn";
            this.totalrusakDataGridViewTextBoxColumn.Width = 125;
            // 
            // idjualDataGridViewTextBoxColumn
            // 
            this.idjualDataGridViewTextBoxColumn.DataPropertyName = "id_jual";
            this.idjualDataGridViewTextBoxColumn.HeaderText = "id_jual";
            this.idjualDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idjualDataGridViewTextBoxColumn.Name = "idjualDataGridViewTextBoxColumn";
            this.idjualDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.Text = "Buah Rusak";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_buahDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buahrusakBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Button3;
        private toko_buahDataSet toko_buahDataSet;
        private System.Windows.Forms.BindingSource buahrusakBindingSource;
        private toko_buahDataSetTableAdapters.buah_rusakTableAdapter buah_rusakTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrusakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglrusakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalrusakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idjualDataGridViewTextBoxColumn;
    }
}