
namespace Raktárkezelő
{
    partial class Termekhozzaadas
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
            this.termHozzadButt = new System.Windows.Forms.Button();
            this.termekDb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.termekKat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.termNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.termAz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // termHozzadButt
            // 
            this.termHozzadButt.Location = new System.Drawing.Point(135, 303);
            this.termHozzadButt.Name = "termHozzadButt";
            this.termHozzadButt.Size = new System.Drawing.Size(185, 41);
            this.termHozzadButt.TabIndex = 17;
            this.termHozzadButt.Text = "Termék hozzáadása";
            this.termHozzadButt.UseVisualStyleBackColor = true;
            // 
            // termekDb
            // 
            this.termekDb.Location = new System.Drawing.Point(182, 208);
            this.termekDb.Name = "termekDb";
            this.termekDb.Size = new System.Drawing.Size(226, 22);
            this.termekDb.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Termék darab";
            // 
            // termekKat
            // 
            this.termekKat.FormattingEnabled = true;
            this.termekKat.Location = new System.Drawing.Point(182, 136);
            this.termekKat.Name = "termekKat";
            this.termekKat.Size = new System.Drawing.Size(226, 24);
            this.termekKat.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Termék kategória";
            // 
            // termNev
            // 
            this.termNev.Location = new System.Drawing.Point(182, 79);
            this.termNev.Name = "termNev";
            this.termNev.Size = new System.Drawing.Size(226, 22);
            this.termNev.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Termék neve";
            // 
            // termAz
            // 
            this.termAz.Location = new System.Drawing.Point(182, 30);
            this.termAz.Name = "termAz";
            this.termAz.Size = new System.Drawing.Size(226, 22);
            this.termAz.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Termék azonosító";
            // 
            // Termekhozzaadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 378);
            this.Controls.Add(this.termHozzadButt);
            this.Controls.Add(this.termekDb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.termekKat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.termNev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.termAz);
            this.Controls.Add(this.label1);
            this.Name = "Termekhozzaadas";
            this.Text = "Termekhozzaadas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button termHozzadButt;
        private System.Windows.Forms.TextBox termekDb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox termekKat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox termNev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox termAz;
        private System.Windows.Forms.Label label1;
    }
}