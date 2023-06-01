namespace _18._1_Ugrik
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
            this.btnBalFel = new System.Windows.Forms.Button();
            this.btnJobbLe = new System.Windows.Forms.Button();
            this.btnJobbFel = new System.Windows.Forms.Button();
            this.btnBalLe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBalFel
            // 
            this.btnBalFel.BackColor = System.Drawing.Color.Cyan;
            this.btnBalFel.Location = new System.Drawing.Point(197, 86);
            this.btnBalFel.Name = "btnBalFel";
            this.btnBalFel.Size = new System.Drawing.Size(75, 23);
            this.btnBalFel.TabIndex = 0;
            this.btnBalFel.Text = "Balra, fel";
            this.btnBalFel.UseVisualStyleBackColor = false;
            this.btnBalFel.Click += new System.EventHandler(this.btnBalFel_Click);
            // 
            // btnJobbLe
            // 
            this.btnJobbLe.BackColor = System.Drawing.Color.Cyan;
            this.btnJobbLe.Location = new System.Drawing.Point(483, 232);
            this.btnJobbLe.Name = "btnJobbLe";
            this.btnJobbLe.Size = new System.Drawing.Size(75, 23);
            this.btnJobbLe.TabIndex = 1;
            this.btnJobbLe.Text = "Jobbra, le";
            this.btnJobbLe.UseVisualStyleBackColor = false;
            this.btnJobbLe.Click += new System.EventHandler(this.btnJobbLe_Click);
            // 
            // btnJobbFel
            // 
            this.btnJobbFel.BackColor = System.Drawing.Color.Cyan;
            this.btnJobbFel.Location = new System.Drawing.Point(483, 86);
            this.btnJobbFel.Name = "btnJobbFel";
            this.btnJobbFel.Size = new System.Drawing.Size(75, 23);
            this.btnJobbFel.TabIndex = 2;
            this.btnJobbFel.Text = "Jobbra, fel";
            this.btnJobbFel.UseVisualStyleBackColor = false;
            this.btnJobbFel.Click += new System.EventHandler(this.btnJobbFel_Click);
            // 
            // btnBalLe
            // 
            this.btnBalLe.BackColor = System.Drawing.Color.Cyan;
            this.btnBalLe.Location = new System.Drawing.Point(197, 232);
            this.btnBalLe.Name = "btnBalLe";
            this.btnBalLe.Size = new System.Drawing.Size(75, 23);
            this.btnBalLe.TabIndex = 3;
            this.btnBalLe.Text = "Balra, le";
            this.btnBalLe.UseVisualStyleBackColor = false;
            this.btnBalLe.Click += new System.EventHandler(this.btnBalLe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBalLe);
            this.Controls.Add(this.btnJobbFel);
            this.Controls.Add(this.btnJobbLe);
            this.Controls.Add(this.btnBalFel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnBalFel;
        private Button btnJobbLe;
        private Button btnJobbFel;
        private Button btnBalLe;
    }
}