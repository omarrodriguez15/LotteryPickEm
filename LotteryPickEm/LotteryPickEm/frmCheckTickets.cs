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
    public partial class frmCheckTickets : Form
    {
        private int ticketAmt = 0;
        public frmCheckTickets()
        {
            InitializeComponent();
        }

        private void btnChooseTicket_Click(object sender, EventArgs e)
        {
            ofdChooseTicket.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofdChooseTicket.ShowDialog();
            txBoxPath.Text = ofdChooseTicket.FileName;

            if (!ofdChooseTicket.FileName.Contains("Ticket"))
            {
                lblStatus.Text = "Not Valid ticket";
                lblStatus.ForeColor = Color.Red;
            }
        }

        private bool CheckTickets(string path, List<int> winningNums)
        {
            bool win = false;
            string line;
            int matches = 0;
            ticketAmt = 0;

            using (StreamReader sr = new StreamReader(path))
            {
                while (true)
                {
                    line = sr.ReadLine();
                    matches = 0;

                    if (line == null)
                    {
                        break;
                    }
                    ticketAmt++;
                    List<int> numsChoosen = parseLine(line);

                    if (numsChoosen.Count != winningNums.Count)
                    {
                        return false;
                    }

                    for (int i = 0; i < numsChoosen.Count; i++)
                    {
                        if (winningNums.Contains(numsChoosen[i]))
                        {
                            matches++;
                        }
                    }
                    if (matches == 6)
                    {
                        win = true;
                    }
                }
            }
            return win;
        }

        private List<int> parseLine(string line)
        {
            List<int> numbers = new List<int>();
            
            try
            {
                int numOut;
                var strs = line.Split(',');

                foreach (var num in strs)
                {
                    if(!int.TryParse(num, out numOut))
                    {
                        return new List<int>();
                    }
                    numbers.Add(numOut);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return numbers;
        }

        private void btnCheckTicket_Click(object sender, EventArgs e)
        {
            List<int> winNums = parseLine(txtBoxWinningNumbers.Text);
            //need to check that 6 numbers are entered in correct format
            if (string.IsNullOrEmpty(txtBoxWinningNumbers.Text) 
                || !ofdChooseTicket.CheckFileExists
                || winNums.Count < 6)
            {
                lblStatus.Text = "Rember to choose a proper file and winning numbers.";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            bool winner = CheckTickets(ofdChooseTicket.FileName, winNums);

            if (winner)
            {
                lblStatus.Text = string.Format("You actually won and you spent ${0} to do it!", ticketAmt*2);
                lblStatus.ForeColor = Color.Green;
            }
            else
            {
                //Having fun with ternary operator
                lblStatus.Text = string.Format("You lost ${0} {1}", ticketAmt * 2, (ticketAmt*2)>=100 ? "LOL what a waste of money!" : 
                    (ticketAmt * 2) > 20 ? "Ha you spent more than $20" : "");
                lblStatus.ForeColor = Color.Tomato;
            }
        }
    }
}
