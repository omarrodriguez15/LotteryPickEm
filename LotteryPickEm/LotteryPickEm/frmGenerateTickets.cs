using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryPickEm
{
    public partial class frmGenerateTickets : Form
    {
        public frmGenerateTickets()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GenerateTickets();
        }

        private void GenerateTickets()
        {
            string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Ticket.txt");
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                int numOfTickets = 0;
                int.TryParse(txBxNumTickets.Text, out numOfTickets);
                List<int> nums;

                for (int i = 0; i < numOfTickets; i++)
                {
                    nums = Numbers.GetNumbers();
                    sw.WriteLine(string.Format("{0},{1},{2},{3},{4},{5}", nums[0], nums[1], nums[2], nums[3], nums[4], nums[5])); 
                }

                txBxNumTickets.Clear();
                lblStatus.Text = "Ticket Created";
                lblStatus.ForeColor = Color.Green;
            }
        }

        private void txBxNumTickets_TextChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            lblStatus.ForeColor = Color.Black;
        }
    }
}
