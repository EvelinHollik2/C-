using System;

namespace _18_8_halmazok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HalmazGeneral(LBx_A, Convert.ToInt32(TBx_A.Text));
            HalmazGeneral(LBx_B, Convert.ToInt32(TBx_B.Text));
            Metszet(LBx_A, LBx_B, LBx_Metsz);
            Unio(LBx_A, LBx_B, LBx_Unio);
            Minusz(LBx_A, LBx_B, LBx_A_B);
            Minusz(LBx_B, LBx_A, LBx_B_A);
        }
        private void HalmazGeneral(ListBox LB, int N)
        {
            Random random = new Random();
            int elem;
            LB.Items.Clear();
            for (int i = 0; i < N; i++)
            {
                do
                {
                    elem = random.Next(N * 5);
                }
                while (Bennevan(LB, elem));
                LB.Items.Add(elem);
            }
        }

        private bool Bennevan(ListBox LB, object elem)
        {
            for (int i = 0; i < LB.Items.Count; i++)
                if (LB.Items[i].Equals(elem))
                    return true;
            return false;
        }

        private void Unio(ListBox LBx_A, ListBox LBx_B, ListBox LBx_Unio)
        {
            LBx_Unio.Items.Clear();
            for (int i = 0; i < LBx_A.Items.Count; i++)
            {
                if (!Bennevan(LBx_Unio, LBx_A.Items[i]))
                {
                    LBx_Unio.Items.Add(LBx_A.Items[i]);
                }
            }
            for (int i = 0; i < LBx_B.Items.Count; i++)
            {
                if (!Bennevan(LBx_Unio, LBx_B.Items[i]))
                {
                    LBx_Unio.Items.Add(LBx_B.Items[i]);
                }
            }
        }

        private void Metszet(ListBox LBx_A, ListBox LBx_B, ListBox LBx_Metsz)
        {
            LBx_Metsz.Items.Clear();
            for (int i = 0; i < LBx_A.Items.Count; i++)
            {
                if (Bennevan(LBx_B, LBx_A.Items[i]))
                {
                    LBx_Metsz.Items.Add(LBx_A.Items[i]);
                }
            }
        }

        private void Minusz(ListBox LBx_A, ListBox LBx_B, ListBox LBx_A_B)
        {
            LBx_A_B.Items.Clear();
            for (int i = 0; i < LBx_A.Items.Count; i++)
            {
                if (!Bennevan(LBx_B, LBx_A.Items[i]))
                {
                    LBx_A_B.Items.Add(LBx_A.Items[i]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}