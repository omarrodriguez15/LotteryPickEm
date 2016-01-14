namespace LotteryPickEm
{
    partial class frmGenerateTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerateTickets));
            this.btnStart = new System.Windows.Forms.Button();
            this.lblNumOfTickets = new System.Windows.Forms.Label();
            this.txBxNumTickets = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rbtnUniqueTickets = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(114, 157);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Process";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblNumOfTickets
            // 
            this.lblNumOfTickets.AutoSize = true;
            this.lblNumOfTickets.Location = new System.Drawing.Point(92, 50);
            this.lblNumOfTickets.Name = "lblNumOfTickets";
            this.lblNumOfTickets.Size = new System.Drawing.Size(123, 17);
            this.lblNumOfTickets.TabIndex = 1;
            this.lblNumOfTickets.Text = "Number of Tickets";
            // 
            // txBxNumTickets
            // 
            this.txBxNumTickets.Location = new System.Drawing.Point(105, 90);
            this.txBxNumTickets.Name = "txBxNumTickets";
            this.txBxNumTickets.Size = new System.Drawing.Size(100, 22);
            this.txBxNumTickets.TabIndex = 2;
            this.txBxNumTickets.TextChanged += new System.EventHandler(this.txBxNumTickets_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(102, 115);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            this.lblStatus.TabIndex = 3;
            // 
            // rbtnUniqueTickets
            // 
            this.rbtnUniqueTickets.AutoSize = true;
            this.rbtnUniqueTickets.Location = new System.Drawing.Point(92, 118);
            this.rbtnUniqueTickets.Name = "rbtnUniqueTickets";
            this.rbtnUniqueTickets.Size = new System.Drawing.Size(123, 21);
            this.rbtnUniqueTickets.TabIndex = 4;
            this.rbtnUniqueTickets.TabStop = true;
            this.rbtnUniqueTickets.Text = "Unique Tickets";
            this.rbtnUniqueTickets.UseVisualStyleBackColor = true;
            // 
            // frmGenerateTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 276);
            this.Controls.Add(this.rbtnUniqueTickets);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txBxNumTickets);
            this.Controls.Add(this.lblNumOfTickets);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGenerateTickets";
            this.Text = "Generate Tickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblNumOfTickets;
        private System.Windows.Forms.TextBox txBxNumTickets;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton rbtnUniqueTickets;
    }
}