using System.Windows.Forms;
using System;

namespace _18_9_Matrix
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AdatokFeltolt(int N, int M)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            for (int j = 0; j < M; j++)
            {
                dataGridView.Columns.Add(String.Empty, String.Empty);
                dataGridView.Columns[j].Width = 35;
            }
            for (int i = 0; i < N; i++)
            {
                object[] intArrray = new object[M];
                for (int j = 0; j < M; j++)
                {
                    intArrray[j] = random.Next(N * M * 10) + 1;
                }
                dataGridView.Rows.Add(intArrray);
            }
        }
        private void EredmenyKiir(int N, int M)
        {
            int max = int.MinValue,
               min = int.MaxValue;

            int maxi, maxj, mini, minj;
            maxi = maxj = mini = minj = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if ((int)dataGridView[j, i].Value > max)
                    {
                        max = (int)dataGridView[j, i].Value;
                        maxi = i;
                        maxj = j;
                    }
                    if ((int)dataGridView[j, i].Value < min)
                    {
                        min = (int)dataGridView[j, i].Value;
                        mini = i;
                        minj = j;
                    }
                }
            }
            richTextBox.ResetText();

            richTextBox.AppendText(String.Format("A legnagyobb elem: {0}{1}",
                     max, Environment.NewLine));
            richTextBox.AppendText(String.Format("A legnagyobb elem indexe:"
                 + "({0},{1}){2}", maxi + 1, maxj + 1, Environment.NewLine));
            richTextBox.AppendText(String.Format("A legkisebb elem: {0}{1}",
                     min, Environment.NewLine));
            richTextBox.AppendText(String.Format("A legkisebb elem indexe:"
                 + "({0},{1}){2}", mini + 1, minj + 1, Environment.NewLine));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(a.Value);
            int o = Convert.ToInt32(b.Value);
            AdatokFeltolt(s, o);
            EredmenyKiir(s, o);
        }
    }
}