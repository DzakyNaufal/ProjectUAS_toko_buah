namespace ProjectUAS_toko_buah
{
    partial class Form3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toko_buahDataSet = new ProjectUAS_toko_buah.toko_buahDataSet();
            this.buahBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buahTableAdapter = new ProjectUAS_toko_buah.toko_buahDataSetTableAdapters.buahTableAdapter();
            this.namabuahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbuahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokbuahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargajualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_buahDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buahBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namabuahDataGridViewTextBoxColumn,
            this.idbuahDataGridViewTextBoxColumn,
            this.stokbuahDataGridViewTextBoxColumn,
            this.hargajualDataGridViewTextBoxColumn,
            this.idadminDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.buahBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(527, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Buah";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 324);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Buy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectUAS_toko_buah.Properties.Resources.left_arrow;
            this.pictureBox2.Location = new System.Drawing.Point(32, 371);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // toko_buahDataSet
            // 
            this.toko_buahDataSet.DataSetName = "toko_buahDataSet";
            this.toko_buahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buahBindingSource
            // 
            this.buahBindingSource.DataMember = "buah";
            this.buahBindingSource.DataSource = this.toko_buahDataSet;
            // 
            // buahTableAdapter
            // 
            this.buahTableAdapter.ClearBeforeFill = true;
            // 
            // namabuahDataGridViewTextBoxColumn
            // 
            this.namabuahDataGridViewTextBoxColumn.DataPropertyName = "nama_buah";
            this.namabuahDataGridViewTextBoxColumn.HeaderText = "nama_buah";
            this.namabuahDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namabuahDataGridViewTextBoxColumn.Name = "namabuahDataGridViewTextBoxColumn";
            this.namabuahDataGridViewTextBoxColumn.Width = 125;
            // 
            // idbuahDataGridViewTextBoxColumn
            // 
            this.idbuahDataGridViewTextBoxColumn.DataPropertyName = "id_buah";
            this.idbuahDataGridViewTextBoxColumn.HeaderText = "id_buah";
            this.idbuahDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbuahDataGridViewTextBoxColumn.Name = "idbuahDataGridViewTextBoxColumn";
            this.idbuahDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokbuahDataGridViewTextBoxColumn
            // 
            this.stokbuahDataGridViewTextBoxColumn.DataPropertyName = "stok_buah";
            this.stokbuahDataGridViewTextBoxColumn.HeaderText = "stok_buah";
            this.stokbuahDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokbuahDataGridViewTextBoxColumn.Name = "stokbuahDataGridViewTextBoxColumn";
            this.stokbuahDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargajualDataGridViewTextBoxColumn
            // 
            this.hargajualDataGridViewTextBoxColumn.DataPropertyName = "harga_jual";
            this.hargajualDataGridViewTextBoxColumn.HeaderText = "harga_jual";
            this.hargajualDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargajualDataGridViewTextBoxColumn.Name = "hargajualDataGridViewTextBoxColumn";
            this.hargajualDataGridViewTextBoxColumn.Width = 125;
            // 
            // idadminDataGridViewTextBoxColumn
            // 
            this.idadminDataGridViewTextBoxColumn.DataPropertyName = "id_admin";
            this.idadminDataGridViewTextBoxColumn.HeaderText = "id_admin";
            this.idadminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idadminDataGridViewTextBoxColumn.Name = "idadminDataGridViewTextBoxColumn";
            this.idadminDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Buah";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_buahDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buahBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private toko_buahDataSet toko_buahDataSet;
        private System.Windows.Forms.BindingSource buahBindingSource;
        private toko_buahDataSetTableAdapters.buahTableAdapter buahTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabuahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbuahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokbuahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargajualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadminDataGridViewTextBoxColumn;
    }
}