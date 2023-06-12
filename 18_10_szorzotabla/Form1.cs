using System.Windows.Forms;

namespace _18_10_szorzotabla
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int joValasz, rosszValasz;
        int N = 10;
        int aktI;
        int aktJ;

        public Form1()
        {
            InitializeComponent();
            TablaEpit();
            Sorsol();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Sorsol()
        {
            do
            {
                aktI = random.Next(N) + 1;
                aktJ = random.Next(N) + 1;
            } while (dataGridView[aktJ, aktI].Value != null);
            dataGridView[aktJ, aktI].Style.BackColor =
               dataGridView[0, aktI].Style.BackColor =
               dataGridView[aktJ, 0].Style.BackColor = Color.PowderBlue;
        }
        private void TablaEpit()
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            dataGridView.Width = 35 * (N + 1) + 3;
            for (int j = 0; j <= N; j++)
            {
                dataGridView.Columns.Add(String.Empty, String.Empty);
                dataGridView.Columns[j].Width = 35;
            }
            for (int i = 0; i <= N; i++)
            {
                object[] intArrray = new object[N];
                dataGridView.Rows.Add(intArrray);
            }
            for (int i = 1; i <= N; i++)
            {
                dataGridView[i, 0].Value = i;
                dataGridView[i, 0].Style.Font = new Font(dataGridView.Font,
                                              FontStyle.Bold);
            }

            for (int j = 1; j <= N; j++)
            {
                dataGridView[0, j].Value = j;
                dataGridView[0, j].Style.Font = new Font(dataGridView.Font,
                                              FontStyle.Bold);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView[aktJ, aktI].Value == null) return;

            if (aktI * aktJ == Convert.ToInt32(dataGridView[aktJ, aktI].Value))
            {
                dataGridView[aktJ, aktI].Style.BackColor =
                       dataGridView.DefaultCellStyle.BackColor;
                dataGridView[0, aktI].Style.BackColor =
                   dataGridView[aktJ, 0].Style.BackColor =
                   dataGridView.DefaultCellStyle.BackColor;
                joValasz++;
                lb_Joalasz.Text = String.Format("Jó válaszaid száma: {0}",
                                        joValasz);
                if (joValasz < N * N)
                { Sorsol(); }
                else
                {
                    MessageBox.Show("Gratulálok, kész a szorzótábla!");
                    dataGridView.Enabled = false;
                }
            }
            else
            {
                dataGridView[aktJ, aktI].Value = null;
                rosszValasz++;
                lb_Rosszvalasz.Text = String.Format("Rossz válaszaid száma:"
                                           + "{0}", rosszValasz);
                MessageBox.Show("Rossz válasz!");
            }

        }
    }
}