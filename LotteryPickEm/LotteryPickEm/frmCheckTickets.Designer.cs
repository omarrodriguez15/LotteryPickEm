namespace LotteryPickEm
{
    partial class frmCheckTickets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckTickets));
            this.ofdChooseTicket = new System.Windows.Forms.OpenFileDialog();
            this.btnChooseTicket = new System.Windows.Forms.Button();
            this.txBoxPath = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDirections1 = new System.Windows.Forms.Label();
            this.txtBoxWinningNumbers = new System.Windows.Forms.TextBox();
            this.btnCheckTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdChooseTicket
            // 
            this.ofdChooseTicket.FileName = "openFileDialog1";
            // 
            // btnChooseTicket
            // 
            this.btnChooseTicket.Location = new System.Drawing.Point(22, 283);
            this.btnChooseTicket.Name = "btnChooseTicket";
            this.btnChooseTicket.Size = new System.Drawing.Size(124, 23);
            this.btnChooseTicket.TabIndex = 0;
            this.btnChooseTicket.Text = "Choose Ticket";
            this.btnChooseTicket.UseVisualStyleBackColor = true;
            this.btnChooseTicket.Click += new System.EventHandler(this.btnChooseTicket_Click);
            // 
            // txBoxPath
            // 
            this.txBoxPath.Location = new System.Drawing.Point(152, 283);
            this.txBoxPath.Name = "txBoxPath";
            this.txBoxPath.Size = new System.Drawing.Size(384, 22);
            this.txBoxPath.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 41);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 42);
            this.lblStatus.TabIndex = 2;
            // 
            // lblDirections1
            // 
            this.lblDirections1.AutoSize = true;
            this.lblDirections1.Location = new System.Drawing.Point(19, 122);
            this.lblDirections1.Name = "lblDirections1";
            this.lblDirections1.Size = new System.Drawing.Size(334, 17);
            this.lblDirections1.TabIndex = 3;
            this.lblDirections1.Text = "Enter in the winning numbers seperated by commas";
            // 
            // txtBoxWinningNumbers
            // 
            this.txtBoxWinningNumbers.Location = new System.Drawing.Point(22, 142);
            this.txtBoxWinningNumbers.Name = "txtBoxWinningNumbers";
            this.txtBoxWinningNumbers.Size = new System.Drawing.Size(100, 22);
            this.txtBoxWinningNumbers.TabIndex = 4;
            // 
            // btnCheckTicket
            // 
            this.btnCheckTicket.Location = new System.Drawing.Point(22, 170);
            this.btnCheckTicket.Name = "btnCheckTicket";
            this.btnCheckTicket.Size = new System.Drawing.Size(75, 23);
            this.btnCheckTicket.TabIndex = 5;
            this.btnCheckTicket.Text = "Check";
            this.btnCheckTicket.UseVisualStyleBackColor = true;
            this.btnCheckTicket.Click += new System.EventHandler(this.btnCheckTicket_Click);
            // 
            // frmCheckTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 315);
            this.Controls.Add(this.btnCheckTicket);
            this.Controls.Add(this.txtBoxWinningNumbers);
            this.Controls.Add(this.lblDirections1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txBoxPath);
            this.Controls.Add(this.btnChooseTicket);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCheckTickets";
            this.Text = "Check Tickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdChooseTicket;
        private System.Windows.Forms.Button btnChooseTicket;
        private System.Windows.Forms.TextBox txBoxPath;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDirections1;
        private System.Windows.Forms.TextBox txtBoxWinningNumbers;
        private System.Windows.Forms.Button btnCheckTicket;
    }
}