namespace _18_7_2_Futas
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        double atlag; int osszeg, db, min = int.MaxValue, max = int.MinValue;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int i = random.Next(100) + 1;
            Label lb = new Label();
            lb.Location = new Point(e.X, e.Y);
            lb.Text = i.ToString();
            lb.AutoSize = true;
            Controls.Add(lb);
            db++;
            osszeg += i;
            atlag = osszeg / (double)db;
            if (min > i) min = i;
            if (max < i) max = i;
            lb_Eredmeny.Text = String.Format("Darabsz�m:{0},�sszeg:{1},�tlag:{2}," + "minimum:{3},maximum:{4}.", db, osszeg, atlag, min, max);

        }
    }
}