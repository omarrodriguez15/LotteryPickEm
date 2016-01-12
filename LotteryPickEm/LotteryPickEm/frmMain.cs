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
        const int MAX_WHITE_BALL = 69;
        const int MAX_RED_BALL = 26;

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
            List<int> num =  GetNumbers();
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

        private List<int> GetNumbers()
        {
            List<int> numbers = new List<int>();
            Random rand = new Random();
            int temp;

            for (int i = 0;i < 6; )
            {
                if (numbers.Count <= 5)
                {
                    temp = rand.Next(MAX_RED_BALL);

                    if (!numbers.Contains(temp))
                    {
                        i++;
                        //pass in max number for random to reurn
                        numbers.Add(temp); 
                    }
                }
                else if (numbers.Count == 6)
                {
                    numbers.Add(rand.Next(MAX_WHITE_BALL));
                }
            } 
            return numbers;
        }
    }
}
