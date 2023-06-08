using System.ComponentModel;

namespace BilPrima
{
    public partial class Form1 : Form
    {
        private int maxNumber;
        private bool isCalculating;
        private bool isCalculating1;
        private bool isCalculating2;

        public Form1()
        {
            InitializeComponent();
            bgWorker1 = new BackgroundWorker();
            bgWorker1.WorkerReportsProgress = true;
            bgWorker1.WorkerSupportsCancellation = true;
            bgWorker1.DoWork += new DoWorkEventHandler(bgWorker1_DoWork);
            bgWorker1.ProgressChanged += new ProgressChangedEventHandler(bgWorker1_ProgressChanged);
            bgWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker1_RunWorkerCompleted);
            isCalculating1 = false;

            bgWorker = new BackgroundWorker();
            bgWorker.WorkerReportsProgress = true;
            bgWorker.WorkerSupportsCancellation = true;
            bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
            bgWorker.ProgressChanged += new ProgressChangedEventHandler(bgWorker_ProgressChanged);
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_RunWorkerCompleted);
            isCalculating = false;

            bgWorker2 = new BackgroundWorker();
            bgWorker2.WorkerReportsProgress = true;
            bgWorker2.WorkerSupportsCancellation = true;
            bgWorker2.DoWork += new DoWorkEventHandler(bgWorker2_DoWork);
            bgWorker2.ProgressChanged += new ProgressChangedEventHandler(bgWorker2_ProgressChanged);
            bgWorker2.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker2_RunWorkerCompleted);
            isCalculating2 = false;
        }

        private void bgWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            for (int i = 2; i <= maxNumber; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    worker.ReportProgress(0, i);
                    Thread.Sleep(1000);  //simulating work
                }
            }
        }

        private void bgWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
                     int primeNumber = (int)e.UserState;
                   listBox2.Items.Add(primeNumber);
             }

            private void bgWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
            {
                    if (e.Cancelled)
                  {
                    listBox2.Items.Add("Operation cancelled.");
                  MessageBox.Show("Operasi dibatalkan", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                 }
                 else if (e.Error != null)
                 {
                   listBox2.Items.Add("Error: " + e.Error.Message);
                     MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                 else
                 {
                   listBox2.Items.Add("Operation completed.");
                 MessageBox.Show("Operasi Selesai", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.None);
                 }

                            isCalculating1 = false;
                          btnStart2.Enabled = true;
            }
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isCalculating) return;

            if (!int.TryParse(numericUpDown1.Text, out maxNumber))
            {
                MessageBox.Show("Input is not a valid integer.");
                return;
            }

            listBox1.Items.Clear();
            isCalculating = true;
            btnStart.Enabled = false;
            bgWorker.RunWorkerAsync();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (!isCalculating) return;

            bgWorker.CancelAsync();
            isCalculating = false;
            btnStart.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            if (isCalculating1) return;

            if (!int.TryParse(numericUpDown2.Text, out maxNumber))
            {
             MessageBox.Show("Input is not a valid integer.");
                //return;
            }

            listBox2.Items.Clear();
            isCalculating1 = true;
            btnStart2.Enabled = false;
            bgWorker1.RunWorkerAsync();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
          BackgroundWorker worker = sender as BackgroundWorker;
            for (int i = 2; i <= maxNumber; i++)
            {
                if (worker.CancellationPending)
               {
                   e.Cancel = true;
                    break;
               }

                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                  if (i % j == 0)
                {
                  isPrime = false;
                break;
          }
                }

                if (isPrime)
                {
                  worker.ReportProgress(0, i);
                Thread.Sleep(1000); // simulating work
          }
    }
        }

    private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
            {
               int primeNumber = (int)e.UserState;
            listBox1.Items.Add(primeNumber);
           }
        
            private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
            {
                if (e.Cancelled)
                {
                    listBox1.Items.Add("Operation cancelled.");
                    MessageBox.Show("Operasi dibatalkan", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (e.Error != null)
                {
                    listBox1.Items.Add("Error: " + e.Error.Message);
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    listBox1.Items.Add("Operation completed.");
                    MessageBox.Show("Operasi Selesai", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.None);
                }

                isCalculating = false;
                btnStart.Enabled = true;
            }

        private void btnStop2_Click(object sender, EventArgs e)
        {
            if (!isCalculating1) return;

            bgWorker1.CancelAsync();
            isCalculating1 = false;
            btnStart2.Enabled = true;
        }

        private void btnStart3_Click(object sender, EventArgs e)
        {
            if (isCalculating2) return;

            if (!int.TryParse(numericUpDown3.Text, out maxNumber))
            {
                MessageBox.Show("Input is not a valid integer.");
                //return;
            }

            listBox3.Items.Clear();
            isCalculating2 = true;
            btnStart3.Enabled = false;
            bgWorker2.RunWorkerAsync();
        }

        private void btnStop3_Click(object sender, EventArgs e)
        {

        }

        private void bgWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            for (int i = 2; i <= maxNumber; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    worker.ReportProgress(0, i);
                    Thread.Sleep(1000); // simulating work
                }
            }
        }
        private void bgWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int primeNumber = (int)e.UserState;
            listBox3.Items.Add(primeNumber);
        }

        private void bgWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                listBox3.Items.Add("Operation cancelled.");
                MessageBox.Show("Operasi dibatalkan", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (e.Error != null)
            {
                listBox3.Items.Add("Error: " + e.Error.Message);
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox3.Items.Add("Operation completed.");
                MessageBox.Show("Operasi Selesai", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

            isCalculating2 = false;
            btnStart3.Enabled = true;
        }
    }
}