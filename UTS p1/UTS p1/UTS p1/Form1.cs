using System.ComponentModel;

namespace UTS_p1
{
    public partial class Form1 : Form
    {
        private BackgroundWorker bruteforceWorker;
        private BackgroundWorker bruteforceWorker1;
        private BackgroundWorker bruteforceWorker2;
        private int passwordLength = 3; // Panjang password yang akan dicoba
        private string targetPassword; // Password target yang akan di-bruteforce
        private string targetPassword1; // Password target yang akan di-bruteforce
        private string targetPassword2; // Password target yang akan di-bruteforce
        public Form1()
        {
            InitializeComponent();

            bruteforceWorker = new BackgroundWorker();
            bruteforceWorker.DoWork += BruteforceWorker_DoWork_1;
            bruteforceWorker.ProgressChanged += BruteforceWorker_ProgressChanged;
            bruteforceWorker.RunWorkerCompleted += BruteforceWorker_RunWorkerCompleted;
            bruteforceWorker.WorkerReportsProgress = true;
            bruteforceWorker.WorkerSupportsCancellation = true;

            bruteforceWorker1 = new BackgroundWorker();
            bruteforceWorker1.DoWork += BruteforceWorker1_DoWork;
            bruteforceWorker1.ProgressChanged += BruteforceWorker1_ProgressChanged;
            bruteforceWorker1.RunWorkerCompleted += BruteforceWorker1_RunWorkerCompleted;
            bruteforceWorker1.WorkerReportsProgress = true;
            bruteforceWorker1.WorkerSupportsCancellation = true;

            bruteforceWorker2 = new BackgroundWorker();
            bruteforceWorker2.DoWork += BruteforceWorker2_DoWork;
            bruteforceWorker2.ProgressChanged += BruteforceWorker2_ProgressChanged;
            bruteforceWorker2.RunWorkerCompleted += BruteforceWorker2_RunWorkerCompleted;
            bruteforceWorker2.WorkerReportsProgress = true;
            bruteforceWorker2.WorkerSupportsCancellation = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Inisialisasi UI
        }

        private void BruteforceWorker_DoWork_1(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int totalAttempts = (int)Math.Pow(chars.Length, passwordLength);

            for (int i = 0; i < totalAttempts; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                string password = GeneratePassword(i, chars);
                worker.ReportProgress((i + 1) * 100 / totalAttempts, password);

                if (password == targetPassword)
                {
                    e.Result = password;
                    break;
                }
            }
        }

        private void BruteforceWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            string password = e.UserState.ToString();
            listBoxAttempts.Items.Add(password);

            // Tambahkan penundaan 500 milidetik (0,5 detik) antara setiap pembaruan ListBox
            //Thread.Sleep(10);  //simulating work

        }

        private void BruteforceWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Bruteforce dibatalkan.");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Terjadi kesalahan saat menjalankan bruteforce: " + e.Error.Message);
            }
            else
            {
                string result = e.Result as string;
                if (result != null)
                {
                    txtResult.Text = "Password: " + result;
                }
                else
                {
                    txtResult.Text = "Password tidak ditemukan.";
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            targetPassword = txtPassword.Text;
            bruteforceWorker.RunWorkerAsync();
            targetPassword1 = txtPassword1.Text;
            bruteforceWorker1.RunWorkerAsync();
            targetPassword2 = txtPassword2.Text;
            bruteforceWorker2.RunWorkerAsync();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (bruteforceWorker.IsBusy)
            {
                bruteforceWorker.CancelAsync();
                bruteforceWorker1.CancelAsync();
                bruteforceWorker2.CancelAsync();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private string GeneratePassword(int index, string chars)
        {
            char[] password = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
            {
                password[i] = chars[index % chars.Length];
                index /= chars.Length;
            }
            return new string(password);
        }

        private void txtPassword1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxAttempts1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            targetPassword = txtPassword1.Text;
            bruteforceWorker1.RunWorkerAsync();
        }

        private void btnStop1_Click(object sender, EventArgs e)
        {
            if (bruteforceWorker1.IsBusy)
            {
                bruteforceWorker1.CancelAsync();
            }
        }

        private void BruteforceWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int totalAttempts = (int)Math.Pow(chars.Length, passwordLength);

            for (int i = 0; i < totalAttempts; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                string password = GeneratePassword(i, chars);
                worker.ReportProgress((i + 1) * 100 / totalAttempts, password);

                if (password == targetPassword1)
                {
                    e.Result = password;
                    break;
                }
            }
        }

        private void BruteforceWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            string password = e.UserState.ToString();
            listBoxAttempts1.Items.Add(password);

            // Tambahkan penundaan 500 milidetik (0,5 detik) antara setiap pembaruan ListBox
            //  Thread.Sleep(10);  //simulating work

        }

        private void BruteforceWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Bruteforce dibatalkan.");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Terjadi kesalahan saat menjalankan bruteforce: " + e.Error.Message);
            }
            else
            {
                string result = e.Result as string;
                if (result != null)
                {
                    txtResult1.Text = "Password: " + result;
                }
                else
                {
                    txtResult1.Text = "Password tidak ditemukan.";
                }
            }
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            targetPassword = txtPassword2.Text;
            bruteforceWorker2.RunWorkerAsync();
        }

        private void btnStop3_Click(object sender, EventArgs e)
        {
            if (bruteforceWorker2.IsBusy)
            {
                bruteforceWorker2.CancelAsync();
            }
        }

        private void BruteforceWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int totalAttempts = (int)Math.Pow(chars.Length, passwordLength);

            for (int i = 0; i < totalAttempts; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                string password = GeneratePassword(i, chars);
                worker.ReportProgress((i + 1) * 100 / totalAttempts, password);

                if (password == targetPassword2)
                {
                    e.Result = password;
                    break;
                }
            }
        }

        private void BruteforceWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            string password = e.UserState.ToString();
            listBoxAttempts2.Items.Add(password);

            // Tambahkan penundaan 500 milidetik (0,5 detik) antara setiap pembaruan ListBox
            //Thread.Sleep(10);  //simulating work

        }

        private void BruteforceWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Bruteforce dibatalkan.");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Terjadi kesalahan saat menjalankan bruteforce: " + e.Error.Message);
            }
            else
            {
                string result = e.Result as string;
                if (result != null)
                {
                    txtResult2.Text = "Password: " + result;
                }
                else
                {
                    txtResult2.Text = "Password tidak ditemukan.";
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}