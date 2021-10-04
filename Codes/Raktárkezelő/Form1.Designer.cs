
namespace Raktárkezelő
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.termékHozzáadásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termékTörlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termékKiviteleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(650, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(341, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-69, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(703, 448);
            this.dataGridView1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.termékHozzáadásToolStripMenuItem,
            this.termékTörlésToolStripMenuItem,
            this.termékKiviteleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1003, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // termékHozzáadásToolStripMenuItem
            // 
            this.termékHozzáadásToolStripMenuItem.Name = "termékHozzáadásToolStripMenuItem";
            this.termékHozzáadásToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.termékHozzáadásToolStripMenuItem.Text = "Termék hozzáadás";
            // 
            // termékTörlésToolStripMenuItem
            // 
            this.termékTörlésToolStripMenuItem.Name = "termékTörlésToolStripMenuItem";
            this.termékTörlésToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.termékTörlésToolStripMenuItem.Text = "Termék törlés";
            // 
            // termékKiviteleToolStripMenuItem
            // 
            this.termékKiviteleToolStripMenuItem.Name = "termékKiviteleToolStripMenuItem";
            this.termékKiviteleToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.termékKiviteleToolStripMenuItem.Text = "Termék kivitele";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 514);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Raktárkezelő";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem termékHozzáadásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem termékTörlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem termékKiviteleToolStripMenuItem;
    }
}

