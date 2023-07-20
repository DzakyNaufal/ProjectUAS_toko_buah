namespace ProjectUAS_toko_buah
{
    partial class Form6
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toko_buahDataSet = new ProjectUAS_toko_buah.toko_buahDataSet();
            this.detailjualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detail_jualTableAdapter = new ProjectUAS_toko_buah.toko_buahDataSetTableAdapters.detail_jualTableAdapter();
            this.idjualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgljualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaljualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbuahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_buahDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailjualBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idjualDataGridViewTextBoxColumn,
            this.tgljualDataGridViewTextBoxColumn,
            this.totaljualDataGridViewTextBoxColumn,
            this.idbuahDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.detailjualBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(546, 179);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Jual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanggal Jual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Jual";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 22);
            this.textBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(185, 294);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 334);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(518, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 9;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 11;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectUAS_toko_buah.Properties.Resources.left_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(34, 375);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toko_buahDataSet
            // 
            this.toko_buahDataSet.DataSetName = "toko_buahDataSet";
            this.toko_buahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailjualBindingSource
            // 
            this.detailjualBindingSource.DataMember = "detail_jual";
            this.detailjualBindingSource.DataSource = this.toko_buahDataSet;
            // 
            // detail_jualTableAdapter
            // 
            this.detail_jualTableAdapter.ClearBeforeFill = true;
            // 
            // idjualDataGridViewTextBoxColumn
            // 
            this.idjualDataGridViewTextBoxColumn.DataPropertyName = "id_jual";
            this.idjualDataGridViewTextBoxColumn.HeaderText = "id_jual";
            this.idjualDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idjualDataGridViewTextBoxColumn.Name = "idjualDataGridViewTextBoxColumn";
            this.idjualDataGridViewTextBoxColumn.Width = 125;
            // 
            // tgljualDataGridViewTextBoxColumn
            // 
            this.tgljualDataGridViewTextBoxColumn.DataPropertyName = "tgl_jual";
            this.tgljualDataGridViewTextBoxColumn.HeaderText = "tgl_jual";
            this.tgljualDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tgljualDataGridViewTextBoxColumn.Name = "tgljualDataGridViewTextBoxColumn";
            this.tgljualDataGridViewTextBoxColumn.Width = 125;
            // 
            // totaljualDataGridViewTextBoxColumn
            // 
            this.totaljualDataGridViewTextBoxColumn.DataPropertyName = "total_jual";
            this.totaljualDataGridViewTextBoxColumn.HeaderText = "total_jual";
            this.totaljualDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totaljualDataGridViewTextBoxColumn.Name = "totaljualDataGridViewTextBoxColumn";
            this.totaljualDataGridViewTextBoxColumn.Width = 125;
            // 
            // idbuahDataGridViewTextBoxColumn
            // 
            this.idbuahDataGridViewTextBoxColumn.DataPropertyName = "id_buah";
            this.idbuahDataGridViewTextBoxColumn.HeaderText = "id_buah";
            this.idbuahDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbuahDataGridViewTextBoxColumn.Name = "idbuahDataGridViewTextBoxColumn";
            this.idbuahDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Menjual";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_buahDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailjualBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private toko_buahDataSet toko_buahDataSet;
        private System.Windows.Forms.BindingSource detailjualBindingSource;
        private toko_buahDataSetTableAdapters.detail_jualTableAdapter detail_jualTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idjualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgljualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaljualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbuahDataGridViewTextBoxColumn;
    }
}