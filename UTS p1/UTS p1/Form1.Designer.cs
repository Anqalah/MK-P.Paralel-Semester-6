namespace UTS_p1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBoxAttempts = new ListBox();
            btnStart = new Button();
            btnStop = new Button();
            BruteforceWorker = new System.ComponentModel.BackgroundWorker();
            txtPassword = new TextBox();
            txtPassword1 = new TextBox();
            listBoxAttempts1 = new ListBox();
            txtPassword2 = new TextBox();
            listBoxAttempts2 = new ListBox();
            BruteforceWorker1 = new System.ComponentModel.BackgroundWorker();
            BruteforceWorker2 = new System.ComponentModel.BackgroundWorker();
            txtResult = new TextBox();
            txtResult1 = new TextBox();
            txtResult2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // listBoxAttempts
            // 
            listBoxAttempts.BackColor = Color.Linen;
            listBoxAttempts.FormattingEnabled = true;
            listBoxAttempts.ItemHeight = 25;
            listBoxAttempts.Location = new Point(76, 283);
            listBoxAttempts.Margin = new Padding(4, 5, 4, 5);
            listBoxAttempts.Name = "listBoxAttempts";
            listBoxAttempts.Size = new Size(231, 154);
            listBoxAttempts.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.WhiteSmoke;
            btnStart.Location = new Point(333, 620);
            btnStart.Margin = new Padding(4, 5, 4, 5);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(107, 38);
            btnStart.TabIndex = 1;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.WhiteSmoke;
            btnStop.Location = new Point(500, 620);
            btnStop.Margin = new Padding(4, 5, 4, 5);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(107, 38);
            btnStop.TabIndex = 2;
            btnStop.Text = "STOP";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // BruteforceWorker
            // 
            BruteforceWorker.WorkerReportsProgress = true;
            BruteforceWorker.WorkerSupportsCancellation = true;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Linen;
            txtPassword.Location = new Point(76, 227);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(231, 31);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtPassword1
            // 
            txtPassword1.BackColor = Color.Linen;
            txtPassword1.Location = new Point(451, 227);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.Size = new Size(231, 31);
            txtPassword1.TabIndex = 7;
            txtPassword1.TextChanged += txtPassword1_TextChanged;
            // 
            // listBoxAttempts1
            // 
            listBoxAttempts1.BackColor = Color.Linen;
            listBoxAttempts1.FormattingEnabled = true;
            listBoxAttempts1.ItemHeight = 25;
            listBoxAttempts1.Location = new Point(451, 278);
            listBoxAttempts1.Margin = new Padding(4, 5, 4, 5);
            listBoxAttempts1.Name = "listBoxAttempts1";
            listBoxAttempts1.Size = new Size(231, 154);
            listBoxAttempts1.TabIndex = 4;
            listBoxAttempts1.SelectedIndexChanged += listBoxAttempts1_SelectedIndexChanged;
            // 
            // txtPassword2
            // 
            txtPassword2.BackColor = Color.Linen;
            txtPassword2.Location = new Point(817, 227);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.Size = new Size(231, 31);
            txtPassword2.TabIndex = 11;
            // 
            // listBoxAttempts2
            // 
            listBoxAttempts2.BackColor = Color.Linen;
            listBoxAttempts2.FormattingEnabled = true;
            listBoxAttempts2.ItemHeight = 25;
            listBoxAttempts2.Location = new Point(817, 278);
            listBoxAttempts2.Margin = new Padding(4, 5, 4, 5);
            listBoxAttempts2.Name = "listBoxAttempts2";
            listBoxAttempts2.Size = new Size(231, 154);
            listBoxAttempts2.TabIndex = 8;
            // 
            // BruteforceWorker1
            // 
            BruteforceWorker1.WorkerReportsProgress = true;
            BruteforceWorker1.WorkerSupportsCancellation = true;
            BruteforceWorker1.DoWork += BruteforceWorker1_DoWork;
            // 
            // BruteforceWorker2
            // 
            BruteforceWorker2.WorkerReportsProgress = true;
            BruteforceWorker2.WorkerSupportsCancellation = true;
            BruteforceWorker2.DoWork += BruteforceWorker2_DoWork;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.Linen;
            txtResult.Location = new Point(86, 483);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(231, 31);
            txtResult.TabIndex = 13;
            // 
            // txtResult1
            // 
            txtResult1.BackColor = Color.Linen;
            txtResult1.Location = new Point(461, 483);
            txtResult1.Name = "txtResult1";
            txtResult1.Size = new Size(231, 31);
            txtResult1.TabIndex = 14;
            // 
            // txtResult2
            // 
            txtResult2.BackColor = Color.Linen;
            txtResult2.Location = new Point(827, 483);
            txtResult2.Name = "txtResult2";
            txtResult2.Size = new Size(231, 31);
            txtResult2.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(86, 455);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 16;
            label2.Text = "Output :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(461, 448);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 17;
            label3.Text = "Output :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(824, 448);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 18;
            label4.Text = "Output :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(76, 198);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 19;
            label5.Text = "Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(456, 198);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 20;
            label6.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(819, 198);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 21;
            label7.Text = "Password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Broadway", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(314, 23);
            label8.Name = "label8";
            label8.Size = new Size(503, 110);
            label8.TabIndex = 22;
            label8.Text = "UTS BRUTE FORCE\r\n KELOMPOK 7";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label8_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(677, 620);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 38);
            btnClear.TabIndex = 23;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 698);
            Controls.Add(btnClear);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtResult2);
            Controls.Add(txtResult1);
            Controls.Add(txtResult);
            Controls.Add(txtPassword2);
            Controls.Add(listBoxAttempts2);
            Controls.Add(txtPassword1);
            Controls.Add(listBoxAttempts1);
            Controls.Add(txtPassword);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(listBoxAttempts);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxAttempts;
        private Button btnStart;
        private Button btnStop;
        private System.ComponentModel.BackgroundWorker BruteforceWorker;
        private TextBox txtPassword;
        private TextBox txtPassword1;
        private ListBox listBoxAttempts1;
        private TextBox txtPassword2;
        private ListBox listBoxAttempts2;
        private System.ComponentModel.BackgroundWorker BruteforceWorker1;
        private System.ComponentModel.BackgroundWorker BruteforceWorker2;
        private TextBox txtResult;
        private TextBox txtResult1;
        private TextBox txtResult2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnClear;
    }
}