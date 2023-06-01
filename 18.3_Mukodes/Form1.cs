using System.Windows.Forms;

namespace _18._3_Mukodes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = String.Format("AzegérkoordinátáiX:{0},Y:{1}", e.X, e.Y);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            PanelIgazit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelIgazit();
        }
        private void PanelIgazit()
        {
            panel1.Left = (ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (ClientSize.Height - panel1.Height) / 2;
        }
    }
}