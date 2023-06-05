namespace _18._6_ScrollBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sb_Piros_ValueChanged(object sender, EventArgs e)
        {
            Lb_Negyzet.BackColor = Color.FromArgb(Sb_Piros.Value,
                Sb_Zold.Value, Sb_Kek.Value);
        }

        private void Sb_Kek_ValueChanged(object sender, EventArgs e)
        {
            Lb_Negyzet.BackColor = Color.FromArgb(Sb_Piros.Value,
                Sb_Zold.Value, Sb_Kek.Value);
        }

        private void Sb_Zold_ValueChanged(object sender, EventArgs e)
        {
            Lb_Negyzet.BackColor = Color.FromArgb(Sb_Piros.Value,
                Sb_Zold.Value, Sb_Kek.Value);

        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            Lb_Negyzet.Width = Lb_Negyzet.Height = hScrollBar1.Value; 
            label5.Text = hScrollBar1.Value.ToString();
        }
    }
}