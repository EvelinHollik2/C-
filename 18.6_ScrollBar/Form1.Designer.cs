namespace _18._6_ScrollBar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.Sb_Piros = new System.Windows.Forms.HScrollBar();
            this.Sb_Kek = new System.Windows.Forms.HScrollBar();
            this.Sb_Zold = new System.Windows.Forms.HScrollBar();
            this.Lb_Negyzet = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(150, 39);
            this.hScrollBar1.Maximum = 309;
            this.hScrollBar1.Minimum = 10;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(551, 22);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Value = 10;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // Sb_Piros
            // 
            this.Sb_Piros.Location = new System.Drawing.Point(182, 404);
            this.Sb_Piros.Name = "Sb_Piros";
            this.Sb_Piros.Size = new System.Drawing.Size(551, 22);
            this.Sb_Piros.TabIndex = 1;
            this.Sb_Piros.ValueChanged += new System.EventHandler(this.Sb_Piros_ValueChanged);
            // 
            // Sb_Kek
            // 
            this.Sb_Kek.Location = new System.Drawing.Point(182, 440);
            this.Sb_Kek.Name = "Sb_Kek";
            this.Sb_Kek.Size = new System.Drawing.Size(551, 22);
            this.Sb_Kek.TabIndex = 2;
            this.Sb_Kek.ValueChanged += new System.EventHandler(this.Sb_Kek_ValueChanged);
            // 
            // Sb_Zold
            // 
            this.Sb_Zold.Location = new System.Drawing.Point(182, 473);
            this.Sb_Zold.Name = "Sb_Zold";
            this.Sb_Zold.Size = new System.Drawing.Size(551, 22);
            this.Sb_Zold.TabIndex = 3;
            this.Sb_Zold.ValueChanged += new System.EventHandler(this.Sb_Zold_ValueChanged);
            // 
            // Lb_Negyzet
            // 
            this.Lb_Negyzet.BackColor = System.Drawing.Color.White;
            this.Lb_Negyzet.Location = new System.Drawing.Point(284, 78);
            this.Lb_Negyzet.Name = "Lb_Negyzet";
            this.Lb_Negyzet.Size = new System.Drawing.Size(277, 253);
            this.Lb_Negyzet.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Piros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(114, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kék";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(114, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Zöld";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(332, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Oldal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(483, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(821, 513);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lb_Negyzet);
            this.Controls.Add(this.Sb_Zold);
            this.Controls.Add(this.Sb_Kek);
            this.Controls.Add(this.Sb_Piros);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HScrollBar hScrollBar1;
        private HScrollBar Sb_Piros;
        private HScrollBar Sb_Kek;
        private HScrollBar Sb_Zold;
        private Panel Lb_Negyzet;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}