
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.termékHozzáadásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termékTörlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terhozzadButt = new System.Windows.Forms.Button();
            this.terhozzAD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.terKivitButt = new System.Windows.Forms.Button();
            this.terKivitText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.termékTörlésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1003, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // termékHozzáadásToolStripMenuItem
            // 
            this.termékHozzáadásToolStripMenuItem.Name = "termékHozzáadásToolStripMenuItem";
            this.termékHozzáadásToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.termékHozzáadásToolStripMenuItem.Text = "Új termék hozzáadása";
            this.termékHozzáadásToolStripMenuItem.Click += new System.EventHandler(this.termékHozzáadásToolStripMenuItem_Click_1);
            // 
            // termékTörlésToolStripMenuItem
            // 
            this.termékTörlésToolStripMenuItem.Name = "termékTörlésToolStripMenuItem";
            this.termékTörlésToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.termékTörlésToolStripMenuItem.Text = "Termék törlés";
            // 
            // terhozzadButt
            // 
            this.terhozzadButt.Location = new System.Drawing.Point(679, 144);
            this.terhozzadButt.Name = "terhozzadButt";
            this.terhozzadButt.Size = new System.Drawing.Size(179, 37);
            this.terhozzadButt.TabIndex = 15;
            this.terhozzadButt.Text = "Termék bevitele";
            this.terhozzadButt.UseVisualStyleBackColor = true;
            // 
            // terhozzAD
            // 
            this.terhozzAD.Location = new System.Drawing.Point(679, 84);
            this.terhozzAD.Name = "terhozzAD";
            this.terhozzAD.Size = new System.Drawing.Size(179, 22);
            this.terhozzAD.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Meglévő termék darab hozzá adása";
            // 
            // terKivitButt
            // 
            this.terKivitButt.Location = new System.Drawing.Point(679, 403);
            this.terKivitButt.Name = "terKivitButt";
            this.terKivitButt.Size = new System.Drawing.Size(179, 37);
            this.terKivitButt.TabIndex = 12;
            this.terKivitButt.Text = "Termék kivitele";
            this.terKivitButt.UseVisualStyleBackColor = true;
            // 
            // terKivitText
            // 
            this.terKivitText.Location = new System.Drawing.Point(679, 343);
            this.terKivitText.Name = "terKivitText";
            this.terKivitText.Size = new System.Drawing.Size(179, 22);
            this.terKivitText.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kivinni kívánt termék mennyisége";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 514);
            this.Controls.Add(this.terhozzadButt);
            this.Controls.Add(this.terhozzAD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.terKivitButt);
            this.Controls.Add(this.terKivitText);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem termékHozzáadásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem termékTörlésToolStripMenuItem;
        private System.Windows.Forms.Button terhozzadButt;
        private System.Windows.Forms.TextBox terhozzAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button terKivitButt;
        private System.Windows.Forms.TextBox terKivitText;
        private System.Windows.Forms.Label label1;
    }
}

