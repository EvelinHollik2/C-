namespace _18._4_mozog
{
    public partial class Form1 : Form
    {
        private int meretezo = 10;  // Az eltolás mértéke
        public Form1()
        {
            InitializeComponent();
        }

        private void MCsok_Click(object sender, EventArgs e)
        {
            Width -= meretezo;
            Height -= meretezo;
        }

        private void AtlNov_Click(object sender, EventArgs e)
        {
            if (Opacity < 1.0) 
                Opacity += 0.1;
        }

        private void Kozep_Click(object sender, EventArgs e)
        {
            Left = (Screen.PrimaryScreen.Bounds.Width - Width) / 2; 
            Top = (Screen.PrimaryScreen.Bounds.Height - Height) / 2; 
            Bt_Le.Visible = Bt_Le_T.Visible = 
            Bt_Fel.Visible = Bt_Fel_T.Visible =
            Bt_Bal.Visible = Bt_Bal_T.Visible = 
            Bt_Jobb.Visible = Bt_Jobb_T.Visible = true;
        }

        private void Bt_Fel_T_Click(object sender, EventArgs e)
        {
            Top = 0; 
            Bt_Fel.Visible = Bt_Fel_T.Visible = false;
            Bt_Le.Visible = Bt_Le_T.Visible = true;
        }

        private void Bt_Fel_Click(object sender, EventArgs e)
        {
            if (Top - meretezo > 0) 
            { 
                Top -= meretezo; 
            } 
            else 
            {
                Top = 0; 
                Bt_Fel.Visible = Bt_Fel_T.Visible = false; 
            }
            Bt_Le.Visible = Bt_Le_T.Visible = true;
        }

        private void Bt_Le_Click(object sender, EventArgs e)
        {
            Top += 10;
            if (Top == (Screen.PrimaryScreen.Bounds.Height - Height))
            { 
                Bt_Le.Visible = Bt_Le_T.Visible = false;
            }
            Bt_Fel.Visible = Bt_Fel_T.Visible = true;
        }

        private void Bt_Le_T_Click(object sender, EventArgs e)
        {
            Top = (Screen.PrimaryScreen.Bounds.Height - Height);
            Bt_Le.Visible = Bt_Le_T.Visible = false;
            Bt_Fel.Visible = Bt_Fel_T.Visible = true;

        }

        private void Bt_Bal_Click(object sender, EventArgs e)
        {
            if (Left - meretezo > 0)
            {
                Left -= meretezo;
            }
            else
            {
                Left = 0;
                Bt_Bal.Visible = Bt_Bal_T.Visible = false;
            }
            Bt_Jobb.Visible = Bt_Jobb_T.Visible = true;
        }

        private void Bt_Bal_T_Click(object sender, EventArgs e)
        {
            Left = 0;
            Bt_Bal.Visible = Bt_Bal_T.Visible = false;
            Bt_Jobb.Visible = Bt_Jobb_T.Visible = true;
        }

        private void Bt_Jobb_Click(object sender, EventArgs e)
        {
            Left += 10;
            if (Left == (Screen.PrimaryScreen.Bounds.Width - Width))
            {
                Bt_Jobb.Visible = Bt_Jobb_T.Visible = false;
            }
            Bt_Bal.Visible = Bt_Bal_T.Visible = true;

        }

        private void Bt_Jobb_T_Click(object sender, EventArgs e)
        {
            Left = (Screen.PrimaryScreen.Bounds.Width - Width);
            Bt_Jobb.Visible = Bt_Jobb_T.Visible = false;
            Bt_Bal.Visible = Bt_Bal_T.Visible = true;

        }

        private void MNov_Click(object sender, EventArgs e)
        {
            Width += meretezo;
            Height += meretezo;

        }

        private void AtlCsok_Click(object sender, EventArgs e)
        {
            if (Opacity > 0.1)
                Opacity -= 0.1;

        }
    }
}