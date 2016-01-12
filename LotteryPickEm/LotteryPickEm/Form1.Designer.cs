namespace LotteryPickEm
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.btnFlip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(165, 222);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(23, 30);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(38, 17);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "Main";
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Location = new System.Drawing.Point(23, 138);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(48, 17);
            this.lbl0.TabIndex = 2;
            this.lbl0.Text = "NONE";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(75, 138);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(48, 17);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "NONE";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(139, 138);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(48, 17);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "NONE";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(204, 138);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(48, 17);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "NONE";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(258, 138);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(48, 17);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "NONE";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(328, 138);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(48, 17);
            this.lbl5.TabIndex = 7;
            this.lbl5.Text = "NONE";
            // 
            // btnFlip
            // 
            this.btnFlip.Location = new System.Drawing.Point(350, 288);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(75, 23);
            this.btnFlip.TabIndex = 8;
            this.btnFlip.Text = "Flip";
            this.btnFlip.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 323);
            this.Controls.Add(this.btnFlip);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl0);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Button btnFlip;
    }
}

