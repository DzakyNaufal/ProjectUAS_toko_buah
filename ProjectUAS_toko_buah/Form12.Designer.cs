namespace ProjectUAS_toko_buah
{
    partial class Form12
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toko_buahDataSet = new ProjectUAS_toko_buah.toko_buahDataSet();
            this.memilikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memilikiTableAdapter = new ProjectUAS_toko_buah.toko_buahDataSetTableAdapters.MemilikiTableAdapter();
            this.idrusakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabuahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalrusakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbuahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_buahDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memilikiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrusakDataGridViewTextBoxColumn,
            this.namabuahDataGridViewTextBoxColumn,
            this.totalrusakDataGridViewTextBoxColumn,
            this.idbuahDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.memilikiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(356, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(410, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Rusak";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Buah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Rusak";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 22);
            this.textBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(31, 228);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(76, 32);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(234, 228);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(78, 32);
            this.Update.TabIndex = 11;
            this.Update.Text = "Save";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(133, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 22);
            this.textBox3.TabIndex = 31;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectUAS_toko_buah.Properties.Resources.left_arrow;
            this.pictureBox2.Location = new System.Drawing.Point(31, 361);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // toko_buahDataSet
            // 
            this.toko_buahDataSet.DataSetName = "toko_buahDataSet";
            this.toko_buahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memilikiBindingSource
            // 
            this.memilikiBindingSource.DataMember = "Memiliki";
            this.memilikiBindingSource.DataSource = this.toko_buahDataSet;
            // 
            // memilikiTableAdapter
            // 
            this.memilikiTableAdapter.ClearBeforeFill = true;
            // 
            // idrusakDataGridViewTextBoxColumn
            // 
            this.idrusakDataGridViewTextBoxColumn.DataPropertyName = "id_rusak";
            this.idrusakDataGridViewTextBoxColumn.HeaderText = "id_rusak";
            this.idrusakDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idrusakDataGridViewTextBoxColumn.Name = "idrusakDataGridViewTextBoxColumn";
            this.idrusakDataGridViewTextBoxColumn.Width = 125;
            // 
            // namabuahDataGridViewTextBoxColumn
            // 
            this.namabuahDataGridViewTextBoxColumn.DataPropertyName = "nama_buah";
            this.namabuahDataGridViewTextBoxColumn.HeaderText = "nama_buah";
            this.namabuahDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namabuahDataGridViewTextBoxColumn.Name = "namabuahDataGridViewTextBoxColumn";
            this.namabuahDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalrusakDataGridViewTextBoxColumn
            // 
            this.totalrusakDataGridViewTextBoxColumn.DataPropertyName = "total_rusak";
            this.totalrusakDataGridViewTextBoxColumn.HeaderText = "total_rusak";
            this.totalrusakDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalrusakDataGridViewTextBoxColumn.Name = "totalrusakDataGridViewTextBoxColumn";
            this.totalrusakDataGridViewTextBoxColumn.Width = 125;
            // 
            // idbuahDataGridViewTextBoxColumn
            // 
            this.idbuahDataGridViewTextBoxColumn.DataPropertyName = "id_buah";
            this.idbuahDataGridViewTextBoxColumn.HeaderText = "id_buah";
            this.idbuahDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbuahDataGridViewTextBoxColumn.Name = "idbuahDataGridViewTextBoxColumn";
            this.idbuahDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form12";
            this.Text = "Memiliki";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_buahDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memilikiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox3;
        private toko_buahDataSet toko_buahDataSet;
        private System.Windows.Forms.BindingSource memilikiBindingSource;
        private toko_buahDataSetTableAdapters.MemilikiTableAdapter memilikiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrusakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabuahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalrusakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbuahDataGridViewTextBoxColumn;
    }
}