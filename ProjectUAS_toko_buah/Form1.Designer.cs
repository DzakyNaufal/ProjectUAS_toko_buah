namespace ProjectUAS_toko_buah
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pemasokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailBeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailJualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buahRusakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.buahToolStripMenuItem,
            this.pemasokToolStripMenuItem,
            this.detailBeliToolStripMenuItem,
            this.detailJualToolStripMenuItem,
            this.buahRusakToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(104, 24);
            this.toolStripDropDownButton1.Text = "TOKO BUAH";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // buahToolStripMenuItem
            // 
            this.buahToolStripMenuItem.Name = "buahToolStripMenuItem";
            this.buahToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.buahToolStripMenuItem.Text = "Buah";
            this.buahToolStripMenuItem.Click += new System.EventHandler(this.buahToolStripMenuItem_Click);
            // 
            // pemasokToolStripMenuItem
            // 
            this.pemasokToolStripMenuItem.Name = "pemasokToolStripMenuItem";
            this.pemasokToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pemasokToolStripMenuItem.Text = "Pemasok";
            this.pemasokToolStripMenuItem.Click += new System.EventHandler(this.pemasokToolStripMenuItem_Click);
            // 
            // detailBeliToolStripMenuItem
            // 
            this.detailBeliToolStripMenuItem.Name = "detailBeliToolStripMenuItem";
            this.detailBeliToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.detailBeliToolStripMenuItem.Text = "Detail Beli";
            this.detailBeliToolStripMenuItem.Click += new System.EventHandler(this.detailBeliToolStripMenuItem_Click);
            // 
            // detailJualToolStripMenuItem
            // 
            this.detailJualToolStripMenuItem.Name = "detailJualToolStripMenuItem";
            this.detailJualToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.detailJualToolStripMenuItem.Text = "Detail Jual";
            this.detailJualToolStripMenuItem.Click += new System.EventHandler(this.detailJualToolStripMenuItem_Click);
            // 
            // buahRusakToolStripMenuItem
            // 
            this.buahRusakToolStripMenuItem.Name = "buahRusakToolStripMenuItem";
            this.buahRusakToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.buahRusakToolStripMenuItem.Text = "Buah Rusak";
            this.buahRusakToolStripMenuItem.Click += new System.EventHandler(this.buahRusakToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Toko Buah";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pemasokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailBeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailJualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buahRusakToolStripMenuItem;
    }
}

