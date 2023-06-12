namespace _18_10_szorzotabla
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
            this.lb_Joalasz = new System.Windows.Forms.Label();
            this.lb_Rosszvalasz = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Joalasz
            // 
            this.lb_Joalasz.AutoSize = true;
            this.lb_Joalasz.Location = new System.Drawing.Point(12, 348);
            this.lb_Joalasz.Name = "lb_Joalasz";
            this.lb_Joalasz.Size = new System.Drawing.Size(107, 15);
            this.lb_Joalasz.TabIndex = 1;
            this.lb_Joalasz.Text = "Jó válaszaid száma:";
            // 
            // lb_Rosszvalasz
            // 
            this.lb_Rosszvalasz.AutoSize = true;
            this.lb_Rosszvalasz.Location = new System.Drawing.Point(12, 374);
            this.lb_Rosszvalasz.Name = "lb_Rosszvalasz";
            this.lb_Rosszvalasz.Size = new System.Drawing.Size(125, 15);
            this.lb_Rosszvalasz.TabIndex = 2;
            this.lb_Rosszvalasz.Text = "Rossz válaszaid száma:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kilép";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(589, 317);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_Rosszvalasz);
            this.Controls.Add(this.lb_Joalasz);
            this.Name = "Form1";
            this.Text = "Szorzótábla";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lb_Joalasz;
        private Label lb_Rosszvalasz;
        private Button button1;
        private DataGridView dataGridView;
    }
}