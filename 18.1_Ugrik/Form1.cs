namespace _18._1_Ugrik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBalFel_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }

        private void btnJobbFel_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
            Top = 0;
        }

        private void btnBalLe_Click(object sender, EventArgs e)
        {
            Left = 2;
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }

        private void btnJobbLe_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }
    }
}