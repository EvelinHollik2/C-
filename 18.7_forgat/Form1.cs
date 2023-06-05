namespace _18._7_forgat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Pb_Bal_Click(object sender, EventArgs e)
        {
            Image s = Lb_1.BackgroundImage;
            Lb_1.BackgroundImage = Lb_2.BackgroundImage;
            Lb_2.BackgroundImage = Lb_3.BackgroundImage;
            Lb_3.BackgroundImage = Lb_4.BackgroundImage;
            Lb_4.BackgroundImage = Lb_5.BackgroundImage;
            Lb_5.BackgroundImage = Lb_6.BackgroundImage;
            Lb_6.BackgroundImage = Lb_7.BackgroundImage;
            Lb_7.BackgroundImage = Lb_8.BackgroundImage;
            Lb_8.BackgroundImage = s;
        }

        private void Pb_Jobb_Click(object sender, EventArgs e)
        {
            Image s = Lb_8.BackgroundImage;
            Lb_8.BackgroundImage = Lb_7.BackgroundImage;
            Lb_7.BackgroundImage = Lb_6.BackgroundImage;
            Lb_6.BackgroundImage = Lb_5.BackgroundImage;
            Lb_5.BackgroundImage = Lb_4.BackgroundImage;
            Lb_4.BackgroundImage = Lb_3.BackgroundImage;
            Lb_3.BackgroundImage = Lb_2.BackgroundImage;
            Lb_2.BackgroundImage = Lb_1.BackgroundImage;
            Lb_1.BackgroundImage = s;

        }
    }
}