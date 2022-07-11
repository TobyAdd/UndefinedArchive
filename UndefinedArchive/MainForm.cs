using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UndefinedArchive
{
    public partial class MainForm : Form
    {
        List<string> dAttack = new List<string>();
        Thread attackThread = null;
        int CurentCount;
        bool flag = true;
        int totalcount;
        protected override void WndProc(ref Message m) {
            base.WndProc(ref m);
            if (m.Msg == 0x84)
                m.Result = (IntPtr)(0x2);
        }

        public MainForm()
        {
            InitializeComponent();
            Console.Title = "Undefined Archive Console";
            Console.WriteLine("Welcome to Undefined Archive!");
            Paint += (s, e) => { ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.White, ButtonBorderStyle.Solid); };
            FormClosing += (s, e) => { TerminateThread(); };
            buttonClose.Click += (s, e) => { Close(); };
            buttonMinimaze.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            labelAboutA.Click += (s, e) => { if (!Application.OpenForms.OfType<About>().Any()) { new About().Show(); } };
        }

        string GeneratorAttack(string file, char[] chars, int lengthMin, int lengthMax) => DictionaryAttack(file, Permutations(chars, lengthMax).Where(item => item.Length >= lengthMin));
        string DictionaryAttack(string file, IEnumerable<string> wordlist)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            ParallelOptions po = new ParallelOptions();
            po.CancellationToken = cts.Token;
            po.MaxDegreeOfParallelism = Environment.ProcessorCount;

            if (flag)
            {
                BeginInvoke((MethodInvoker)delegate () {
                    progressBar.Style = ProgressBarStyle.Marquee;
                });
                Console.WriteLine("Calculating how many rebounds left...");
                totalcount = wordlist.Count();
                BeginInvoke((MethodInvoker)delegate () {
                    progressBar.Style = ProgressBarStyle.Blocks;
                });
            }
            else
            {
                totalcount = 0;
                BeginInvoke((MethodInvoker)delegate () {
                    progressBar.Style = ProgressBarStyle.Marquee;
                });
            }                
            string password = string.Empty;
            try
            {
                Parallel.ForEach(wordlist, po, (word, loopState) =>
                {
                    BeginInvoke((MethodInvoker)delegate () {
                        if (flag)
                        {
                            progressBar.Maximum = totalcount;
                            CurentCount++; progressBar.Value = CurentCount;
                            labelInfo.Text = $"Curent Password: {word}\nTotal Left: {CurentCount.ToString()}/{totalcount.ToString()}";
                        }
                        else
                            labelInfo.Text = $"Curent Password: {word}\nTotal Left: Unknown";

                    });

                    if (IsPasswordCorrect(file, word))
                    {       
                        password = word;
                        cts.Cancel();
                    }
                });
            }
            catch (OperationCanceledException) { Console.WriteLine($"Password is \"{password}\"!"); }

            return password;
        }

        public static IEnumerable<string> Permutations(char[] chars, int length)
        {
            if (length <= 0) yield break;
            foreach (var a in chars)
            {
                yield return a.ToString();
                foreach (var b in Permutations(chars, length - 1)) yield return a + b;
            }
        }

        bool IsPasswordProtected(string filename)
        {
            bool result = false;
            using (Process p = new Process())
            {
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.FileName = "7z.exe";
                p.StartInfo.Arguments = $"l -slt \"{filename}\"";
                p.Start();
                string stdout = p.StandardOutput.ReadToEnd();
                string stderr = p.StandardError.ReadToEnd();
                p.WaitForExit();

                if (stdout.Contains("Encrypted = +"))
                    result = true;
            }
            return result;
        }

        bool IsPasswordCorrect(string filename, string password)
        {
            Console.WriteLine($"Checking {password} for {filename}");
            bool result = false;
            using (Process p = new Process())
            {
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.FileName = "7z.exe";
                p.StartInfo.Arguments = $"t \"{filename}\" -p{password}";
                p.Start();
                string stdout = p.StandardOutput.ReadToEnd();
                string stderr = p.StandardError.ReadToEnd();
                p.WaitForExit();

                if (stdout.Contains("Everything is Ok"))
                    result = true;
            }
            return result;
        }
        void TerminateThread()
        {
            if (attackThread != null)
            {
                if (attackThread.IsAlive)
                    attackThread.Abort();
                attackThread = null;
            }
        }

        private void textBoxArchivePath_TextChanged(object sender, EventArgs e)
        {
            if (textBoxArchivePath.Text != "")
                buttonAddArchive.Text = "Add";
            else
                buttonAddArchive.Text = "Browse...";
        }

        private void buttonAddArchive_Click(object sender, EventArgs e)
        {
            if (buttonAddArchive.Text == "Browse...")
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (IsPasswordProtected(openFileDialog.FileName))
                    {
                        textBoxArchivePath.ReadOnly = true;
                        textBoxArchivePath.Text = openFileDialog.FileName;
                        textBoxArchivePath.ForeColor = Color.Lime;
                        buttonAddArchive.Text = "Change";
                    }
                    else
                    {
                        MessageBox.Show("Archive is not protected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (buttonAddArchive.Text == "Add")
            {
                textBoxArchivePath.Text = textBoxArchivePath.Text.Replace("\"", "");
                if (!File.Exists(textBoxArchivePath.Text))
                {
                    MessageBox.Show("File not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (IsPasswordProtected(textBoxArchivePath.Text))
                    {
                        textBoxArchivePath.ReadOnly = true;
                        textBoxArchivePath.ForeColor = Color.Lime;
                        buttonAddArchive.Text = "Change";
                    }
                    else
                    {
                        MessageBox.Show("Archive is not protected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (buttonAddArchive.Text == "Change")
            {                
                textBoxArchivePath.ReadOnly = false;
                textBoxArchivePath.ForeColor = Color.White;
                buttonAddArchive.Text = "Add";
            }
        }

        private void radioButtonDAttack_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDAttack.Checked)
            {
                buttonAddD.Visible = true;
                buttonBRwithMASK.Visible = false;
                groupBoxBRwithMASK.Visible = false;
            }
        }

        private void radioButtonBRwithMASK_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBRwithMASK.Checked)
            {
                buttonAddD.Visible = false;
                buttonBRwithMASK.Visible = true;
            }
        }

        private void radioButtonBruteforce_CheckedChanged(object sender, EventArgs e)
        {
            buttonAddD.Visible = false;
            buttonBRwithMASK.Visible = false;
            groupBoxBRwithMASK.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var hui in dAttack)
            {
                Console.WriteLine(hui);
            }
        }

        private void buttonAddD_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "TXT File (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                labelPath.Text = openFile.FileName;
                dAttack = File.ReadLines(openFile.FileName).ToList();
            }           
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonStart.Text == "Start")
                {
                    if (textBoxArchivePath.ReadOnly)
                    {
                        if (radioButtonDAttack.Checked || radioButtonBRwithMASK.Checked || radioButtonBruteforce.Checked)
                        {
                            if (MessageBox.Show("Do you want to know how many rebounds are left? (It can take a very long time to count!)", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                flag = true;
                            else
                                flag = false;
                            buttonStart.Text = "Stop";
                            if (radioButtonDAttack.Checked)
                            {
                                TerminateThread();
                                attackThread = new Thread(() =>
                                {
                                    var result = DictionaryAttack(textBoxArchivePath.Text, File.ReadAllLines(labelPath.Text));
                                    if (result == string.Empty)
                                    {
                                        BeginInvoke((MethodInvoker)delegate ()
                                        {
                                            labelInfo.Text = $"Curent Password: {result}\nTotal Left: Fail!";
                                            progressBar.Value = 0;
                                            CurentCount = 0;
                                        });
                                        MessageBox.Show("None of the passwords on this list matched.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    else
                                    {
                                        BeginInvoke((MethodInvoker)delegate ()
                                        {
                                            buttonStart.Text = "Start";
                                            labelInfo.Text = $"Curent Password: {result}\nTotal Left: Done!";
                                            progressBar.Value = 0;
                                            CurentCount = 0;
                                        });
                                        MessageBox.Show($"A password \"{result}\"!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                });
                                attackThread.Start();
                            }
                            else if (radioButtonBRwithMASK.Checked)
                            {
                                TerminateThread();
                                attackThread = new Thread(() =>
                                {
                                    var result = GeneratorAttack(textBoxArchivePath.Text, textBoxLetters.Text.ToArray(), (int)numericUpDownMin.Value, (int)numericUpDownMax.Value);
                                    if (result == string.Empty)
                                    {
                                        BeginInvoke((MethodInvoker)delegate ()
                                        {
                                            labelInfo.Text = $"Curent Password: {result}\nTotal Left: Fail!";
                                            progressBar.Value = 0;
                                            CurentCount = 0;
                                        });
                                        MessageBox.Show("None of the passwords on this list matched.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    else
                                    {
                                        BeginInvoke((MethodInvoker)delegate ()
                                        {
                                            buttonStart.Text = "Start";
                                            labelInfo.Text = $"Curent Password: {result}\nTotal Left: Done!";
                                            progressBar.Value = 0;
                                            CurentCount = 0;
                                        });
                                        MessageBox.Show($"A password \"{result}\"!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                });
                                attackThread.Start();
                            }
                            else if (radioButtonBruteforce.Checked)
                            {
                                TerminateThread();
                                attackThread = new Thread(() =>
                                {
                                    var result = GeneratorAttack(textBoxArchivePath.Text, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789&!@#$%^*()_+-=<>,./?[][]~:;`'\" | *\\ ".ToArray(), 1, 100);
                                    if (result == string.Empty)
                                    {
                                        BeginInvoke((MethodInvoker)delegate ()
                                        {
                                            labelInfo.Text = $"Curent Password: {result}\nTotal Left: Fail!";
                                            progressBar.Value = 0;
                                            CurentCount = 0;
                                        });
                                        MessageBox.Show("None of the passwords on this list matched.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    else
                                    {
                                        BeginInvoke((MethodInvoker)delegate ()
                                        {
                                            buttonStart.Text = "Start";
                                            labelInfo.Text = $"Curent Password: {result}\nTotal Left: Done!";
                                            progressBar.Value = 0;
                                            CurentCount = 0;
                                        });
                                        MessageBox.Show($"A password \"{result}\"!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                });
                                attackThread.Start();
                            }
                            
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Please select archive, or select some type of attack.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (buttonStart.Text == "Stop")
                {
                    progressBar.Style = ProgressBarStyle.Blocks;
                    buttonStart.Text = "Start";
                    TerminateThread();
                    CurentCount = 0;
                    progressBar.Value = 0;                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong\nException: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxLL_CheckedChanged(object sender, EventArgs e)
        {
            textBoxLetters.Text = string.Empty;
            if (checkBoxLL.Checked)
            {
                textBoxLetters.Text = textBoxLetters.Text + "abcdefghijklmnopqrstuvwxyz";
            }
            if (checkBoxAL.Checked)
            {
                textBoxLetters.Text = textBoxLetters.Text + "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            if (checkBoxAN.Checked)
            {
                textBoxLetters.Text = textBoxLetters.Text + "0123456789";
            }
            if (checkBoxSS.Checked)
            {
                textBoxLetters.Text = textBoxLetters.Text + "&!@#$%^*()_+-=<>,./?[]{}~:;`'\"|*\\";
            }
            if (checkBoxSpace.Checked)
            {
                textBoxLetters.Text = textBoxLetters.Text + " ";
            }

        }

        private void numericUpDownMin_ValueChanged(object sender, EventArgs e) =>
            numericUpDownMax.Minimum = numericUpDownMin.Value;

        private void numericUpDownMax_ValueChanged(object sender, EventArgs e) =>
            numericUpDownMin.Maximum = numericUpDownMax.Value;

        private void buttonBRwithMASK_Click(object sender, EventArgs e)
        {
            if (groupBoxBRwithMASK.Visible)
                groupBoxBRwithMASK.Visible = false;
            else
                groupBoxBRwithMASK.Visible = true;
        }

        private void labelAboutA_Click(object sender, EventArgs e)
        {

        }
    }
}
