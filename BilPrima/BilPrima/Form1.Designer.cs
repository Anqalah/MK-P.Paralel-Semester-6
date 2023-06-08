namespace BilPrima
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.btnStart3 = new System.Windows.Forms.Button();
            this.btnStart2 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.btnStop3 = new System.Windows.Forms.Button();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.bgWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(67, 423);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 38);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(271, 423);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(107, 38);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(67, 77);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 204);
            this.listBox1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = true;
            this.numericUpDown1.Location = new System.Drawing.Point(67, 322);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(171, 31);
            this.numericUpDown1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(484, 77);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(310, 204);
            this.listBox2.TabIndex = 4;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 25;
            this.listBox3.Location = new System.Drawing.Point(896, 77);
            this.listBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(310, 204);
            this.listBox3.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.AutoSize = true;
            this.numericUpDown2.Location = new System.Drawing.Point(484, 322);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(171, 31);
            this.numericUpDown2.TabIndex = 6;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.AutoSize = true;
            this.numericUpDown3.Location = new System.Drawing.Point(896, 322);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(171, 31);
            this.numericUpDown3.TabIndex = 7;
            // 
            // btnStart3
            // 
            this.btnStart3.Location = new System.Drawing.Point(896, 423);
            this.btnStart3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart3.Name = "btnStart3";
            this.btnStart3.Size = new System.Drawing.Size(107, 38);
            this.btnStart3.TabIndex = 8;
            this.btnStart3.Text = "Start";
            this.btnStart3.UseVisualStyleBackColor = true;
            this.btnStart3.Click += new System.EventHandler(this.btnStart3_Click);
            // 
            // btnStart2
            // 
            this.btnStart2.Location = new System.Drawing.Point(484, 423);
            this.btnStart2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(107, 38);
            this.btnStart2.TabIndex = 9;
            this.btnStart2.Text = "Start";
            this.btnStart2.UseVisualStyleBackColor = true;
            this.btnStart2.Click += new System.EventHandler(this.btnStart2_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.Location = new System.Drawing.Point(689, 423);
            this.btnStop2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(107, 38);
            this.btnStop2.TabIndex = 10;
            this.btnStop2.Text = "Stop";
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.btnStop2_Click);
            // 
            // btnStop3
            // 
            this.btnStop3.Location = new System.Drawing.Point(1100, 423);
            this.btnStop3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStop3.Name = "btnStop3";
            this.btnStop3.Size = new System.Drawing.Size(107, 38);
            this.btnStop3.TabIndex = 11;
            this.btnStop3.Text = "Stop";
            this.btnStop3.UseVisualStyleBackColor = true;
            this.btnStop3.Click += new System.EventHandler(this.btnStop3_Click);
            // 
            // bgWorker
            // 
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            // 
            // bgWorker2
            // 
            this.bgWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 525);
            this.Controls.Add(this.btnStop3);
            this.Controls.Add(this.btnStop2);
            this.Controls.Add(this.btnStart2);
            this.Controls.Add(this.btnStart3);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private ListBox listBox1;
        private NumericUpDown numericUpDown1;
        private ListBox listBox2;
        private ListBox listBox3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Button btnStart3;
        private Button btnStart2;
        private Button btnStop2;
        private Button btnStop3;
        private System.ComponentModel.BackgroundWorker bgWorker1;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.ComponentModel.BackgroundWorker bgWorker2;
    }
}