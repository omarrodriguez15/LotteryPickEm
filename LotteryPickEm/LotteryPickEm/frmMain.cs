using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LotteryPickEm
{
    public partial class frmMain : Form
    {
        private List<Label> labels = new List<Label>();
        public frmMain()
        {
            InitializeComponent();
            labels.Add(lbl0);
            labels.Add(lbl1);
            labels.Add(lbl2);
            labels.Add(lbl3);
            labels.Add(lbl4);
            labels.Add(lbl5);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            List<int> num =  Numbers.GetNumbers();
            populateLabels(num);
        }

        private void populateLabels(List<int> numbers)
        {
            if (numbers.Count == labels.Count)
            {
                for (int i = 0; i < labels.Count; i++)
                {
                    labels[i].Text = numbers[i].ToString();
                }
            }
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            (new frmGenerateTickets()).ShowDialog();
        }

        private void btnCheckTickets_Click(object sender, EventArgs e)
        {
            (new frmCheckTickets()).ShowDialog();
        }
    }
}
