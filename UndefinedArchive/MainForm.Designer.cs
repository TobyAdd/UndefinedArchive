
namespace UndefinedArchive
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelCaption = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMinimaze = new System.Windows.Forms.Button();
            this.textBoxArchivePath = new System.Windows.Forms.TextBox();
            this.buttonAddArchive = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonDAttack = new System.Windows.Forms.RadioButton();
            this.radioButtonBRwithMASK = new System.Windows.Forms.RadioButton();
            this.buttonAddD = new System.Windows.Forms.Button();
            this.buttonBRwithMASK = new System.Windows.Forms.Button();
            this.radioButtonBruteforce = new System.Windows.Forms.RadioButton();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxArchive = new System.Windows.Forms.GroupBox();
            this.groupBoxAttackType = new System.Windows.Forms.GroupBox();
            this.groupBoxBRwithMASK = new System.Windows.Forms.GroupBox();
            this.checkBoxSpace = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.textBoxLetters = new System.Windows.Forms.TextBox();
            this.checkBoxSS = new System.Windows.Forms.CheckBox();
            this.checkBoxAN = new System.Windows.Forms.CheckBox();
            this.checkBoxAL = new System.Windows.Forms.CheckBox();
            this.checkBoxLL = new System.Windows.Forms.CheckBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.groupBoxProgress = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelInfo = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelAboutA = new System.Windows.Forms.Label();
            this.groupBoxArchive.SuspendLayout();
            this.groupBoxAttackType.SuspendLayout();
            this.groupBoxBRwithMASK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            this.groupBoxProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCaption
            // 
            this.labelCaption.AutoSize = true;
            this.labelCaption.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCaption.Location = new System.Drawing.Point(12, 9);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(184, 30);
            this.labelCaption.TabIndex = 0;
            this.labelCaption.Text = "Undefined Archive";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(726, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(53, 41);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonMinimaze
            // 
            this.buttonMinimaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimaze.FlatAppearance.BorderSize = 0;
            this.buttonMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimaze.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinimaze.Location = new System.Drawing.Point(667, 12);
            this.buttonMinimaze.Name = "buttonMinimaze";
            this.buttonMinimaze.Size = new System.Drawing.Size(53, 41);
            this.buttonMinimaze.TabIndex = 2;
            this.buttonMinimaze.Text = "-";
            this.buttonMinimaze.UseVisualStyleBackColor = true;
            // 
            // textBoxArchivePath
            // 
            this.textBoxArchivePath.BackColor = System.Drawing.Color.DimGray;
            this.textBoxArchivePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxArchivePath.ForeColor = System.Drawing.Color.White;
            this.textBoxArchivePath.Location = new System.Drawing.Point(10, 42);
            this.textBoxArchivePath.Name = "textBoxArchivePath";
            this.textBoxArchivePath.Size = new System.Drawing.Size(630, 29);
            this.textBoxArchivePath.TabIndex = 3;
            this.textBoxArchivePath.TextChanged += new System.EventHandler(this.textBoxArchivePath_TextChanged);
            // 
            // buttonAddArchive
            // 
            this.buttonAddArchive.BackColor = System.Drawing.Color.Gray;
            this.buttonAddArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddArchive.Location = new System.Drawing.Point(646, 42);
            this.buttonAddArchive.Name = "buttonAddArchive";
            this.buttonAddArchive.Size = new System.Drawing.Size(106, 29);
            this.buttonAddArchive.TabIndex = 4;
            this.buttonAddArchive.Text = "Browse...";
            this.buttonAddArchive.UseVisualStyleBackColor = false;
            this.buttonAddArchive.Click += new System.EventHandler(this.buttonAddArchive_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Path to encrypred archive";
            // 
            // radioButtonDAttack
            // 
            this.radioButtonDAttack.AutoSize = true;
            this.radioButtonDAttack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonDAttack.Location = new System.Drawing.Point(10, 22);
            this.radioButtonDAttack.Name = "radioButtonDAttack";
            this.radioButtonDAttack.Size = new System.Drawing.Size(146, 25);
            this.radioButtonDAttack.TabIndex = 6;
            this.radioButtonDAttack.TabStop = true;
            this.radioButtonDAttack.Text = "Dictionary Attack";
            this.radioButtonDAttack.UseVisualStyleBackColor = true;
            this.radioButtonDAttack.CheckedChanged += new System.EventHandler(this.radioButtonDAttack_CheckedChanged);
            // 
            // radioButtonBRwithMASK
            // 
            this.radioButtonBRwithMASK.AutoSize = true;
            this.radioButtonBRwithMASK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonBRwithMASK.Location = new System.Drawing.Point(10, 51);
            this.radioButtonBRwithMASK.Name = "radioButtonBRwithMASK";
            this.radioButtonBRwithMASK.Size = new System.Drawing.Size(220, 25);
            this.radioButtonBRwithMASK.TabIndex = 7;
            this.radioButtonBRwithMASK.TabStop = true;
            this.radioButtonBRwithMASK.Text = "Bruteforce with mask attack";
            this.radioButtonBRwithMASK.UseVisualStyleBackColor = true;
            this.radioButtonBRwithMASK.CheckedChanged += new System.EventHandler(this.radioButtonBRwithMASK_CheckedChanged);
            // 
            // buttonAddD
            // 
            this.buttonAddD.BackColor = System.Drawing.Color.Gray;
            this.buttonAddD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddD.Location = new System.Drawing.Point(162, 24);
            this.buttonAddD.Name = "buttonAddD";
            this.buttonAddD.Size = new System.Drawing.Size(110, 24);
            this.buttonAddD.TabIndex = 9;
            this.buttonAddD.Text = "Add";
            this.buttonAddD.UseVisualStyleBackColor = false;
            this.buttonAddD.Visible = false;
            this.buttonAddD.Click += new System.EventHandler(this.buttonAddD_Click);
            // 
            // buttonBRwithMASK
            // 
            this.buttonBRwithMASK.BackColor = System.Drawing.Color.Gray;
            this.buttonBRwithMASK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBRwithMASK.Location = new System.Drawing.Point(236, 53);
            this.buttonBRwithMASK.Name = "buttonBRwithMASK";
            this.buttonBRwithMASK.Size = new System.Drawing.Size(106, 24);
            this.buttonBRwithMASK.TabIndex = 10;
            this.buttonBRwithMASK.Text = "Settings";
            this.buttonBRwithMASK.UseVisualStyleBackColor = false;
            this.buttonBRwithMASK.Visible = false;
            this.buttonBRwithMASK.Click += new System.EventHandler(this.buttonBRwithMASK_Click);
            // 
            // radioButtonBruteforce
            // 
            this.radioButtonBruteforce.AutoSize = true;
            this.radioButtonBruteforce.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonBruteforce.Location = new System.Drawing.Point(10, 82);
            this.radioButtonBruteforce.Name = "radioButtonBruteforce";
            this.radioButtonBruteforce.Size = new System.Drawing.Size(145, 25);
            this.radioButtonBruteforce.TabIndex = 11;
            this.radioButtonBruteforce.TabStop = true;
            this.radioButtonBruteforce.Text = "Bruteforce attack";
            this.radioButtonBruteforce.UseVisualStyleBackColor = true;
            this.radioButtonBruteforce.CheckedChanged += new System.EventHandler(this.radioButtonBruteforce_CheckedChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Gray;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(304, 51);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(148, 31);
            this.buttonStart.TabIndex = 13;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBoxArchive
            // 
            this.groupBoxArchive.Controls.Add(this.label2);
            this.groupBoxArchive.Controls.Add(this.textBoxArchivePath);
            this.groupBoxArchive.Controls.Add(this.buttonAddArchive);
            this.groupBoxArchive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxArchive.ForeColor = System.Drawing.Color.White;
            this.groupBoxArchive.Location = new System.Drawing.Point(17, 50);
            this.groupBoxArchive.Name = "groupBoxArchive";
            this.groupBoxArchive.Size = new System.Drawing.Size(762, 84);
            this.groupBoxArchive.TabIndex = 14;
            this.groupBoxArchive.TabStop = false;
            this.groupBoxArchive.Text = "Archive";
            // 
            // groupBoxAttackType
            // 
            this.groupBoxAttackType.Controls.Add(this.groupBoxBRwithMASK);
            this.groupBoxAttackType.Controls.Add(this.labelPath);
            this.groupBoxAttackType.Controls.Add(this.radioButtonDAttack);
            this.groupBoxAttackType.Controls.Add(this.radioButtonBRwithMASK);
            this.groupBoxAttackType.Controls.Add(this.buttonAddD);
            this.groupBoxAttackType.Controls.Add(this.radioButtonBruteforce);
            this.groupBoxAttackType.Controls.Add(this.buttonBRwithMASK);
            this.groupBoxAttackType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAttackType.ForeColor = System.Drawing.Color.White;
            this.groupBoxAttackType.Location = new System.Drawing.Point(17, 140);
            this.groupBoxAttackType.Name = "groupBoxAttackType";
            this.groupBoxAttackType.Size = new System.Drawing.Size(762, 128);
            this.groupBoxAttackType.TabIndex = 15;
            this.groupBoxAttackType.TabStop = false;
            this.groupBoxAttackType.Text = "Attack type";
            // 
            // groupBoxBRwithMASK
            // 
            this.groupBoxBRwithMASK.Controls.Add(this.checkBoxSpace);
            this.groupBoxBRwithMASK.Controls.Add(this.label4);
            this.groupBoxBRwithMASK.Controls.Add(this.numericUpDownMax);
            this.groupBoxBRwithMASK.Controls.Add(this.label3);
            this.groupBoxBRwithMASK.Controls.Add(this.numericUpDownMin);
            this.groupBoxBRwithMASK.Controls.Add(this.textBoxLetters);
            this.groupBoxBRwithMASK.Controls.Add(this.checkBoxSS);
            this.groupBoxBRwithMASK.Controls.Add(this.checkBoxAN);
            this.groupBoxBRwithMASK.Controls.Add(this.checkBoxAL);
            this.groupBoxBRwithMASK.Controls.Add(this.checkBoxLL);
            this.groupBoxBRwithMASK.ForeColor = System.Drawing.Color.White;
            this.groupBoxBRwithMASK.Location = new System.Drawing.Point(446, 11);
            this.groupBoxBRwithMASK.Name = "groupBoxBRwithMASK";
            this.groupBoxBRwithMASK.Size = new System.Drawing.Size(310, 111);
            this.groupBoxBRwithMASK.TabIndex = 15;
            this.groupBoxBRwithMASK.TabStop = false;
            this.groupBoxBRwithMASK.Text = "Bruteforce with mask attack";
            this.groupBoxBRwithMASK.Visible = false;
            // 
            // checkBoxSpace
            // 
            this.checkBoxSpace.AutoSize = true;
            this.checkBoxSpace.Checked = true;
            this.checkBoxSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSpace.Location = new System.Drawing.Point(144, 35);
            this.checkBoxSpace.Name = "checkBoxSpace";
            this.checkBoxSpace.Size = new System.Drawing.Size(57, 19);
            this.checkBoxSpace.TabIndex = 9;
            this.checkBoxSpace.Text = "Space";
            this.checkBoxSpace.UseVisualStyleBackColor = true;
            this.checkBoxSpace.CheckedChanged += new System.EventHandler(this.checkBoxLL_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(260, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownMax.ForeColor = System.Drawing.Color.White;
            this.numericUpDownMax.Location = new System.Drawing.Point(263, 76);
            this.numericUpDownMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(41, 23);
            this.numericUpDownMax.TabIndex = 7;
            this.numericUpDownMax.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownMax.ValueChanged += new System.EventHandler(this.numericUpDownMax_ValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(260, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Min:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownMin.ForeColor = System.Drawing.Color.White;
            this.numericUpDownMin.Location = new System.Drawing.Point(263, 31);
            this.numericUpDownMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(41, 23);
            this.numericUpDownMin.TabIndex = 5;
            this.numericUpDownMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMin.ValueChanged += new System.EventHandler(this.numericUpDownMin_ValueChanged);
            // 
            // textBoxLetters
            // 
            this.textBoxLetters.BackColor = System.Drawing.Color.DimGray;
            this.textBoxLetters.ForeColor = System.Drawing.Color.White;
            this.textBoxLetters.Location = new System.Drawing.Point(4, 76);
            this.textBoxLetters.Name = "textBoxLetters";
            this.textBoxLetters.Size = new System.Drawing.Size(253, 23);
            this.textBoxLetters.TabIndex = 4;
            this.textBoxLetters.Text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789&!@#$%^*()_+-=<>,./" +
    "?[][]~:;`\'\"|*\\ ";
            // 
            // checkBoxSS
            // 
            this.checkBoxSS.AutoSize = true;
            this.checkBoxSS.Checked = true;
            this.checkBoxSS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSS.Location = new System.Drawing.Point(104, 54);
            this.checkBoxSS.Name = "checkBoxSS";
            this.checkBoxSS.Size = new System.Drawing.Size(110, 19);
            this.checkBoxSS.TabIndex = 3;
            this.checkBoxSS.Text = "Special symbols";
            this.checkBoxSS.UseVisualStyleBackColor = true;
            this.checkBoxSS.CheckedChanged += new System.EventHandler(this.checkBoxLL_CheckedChanged);
            // 
            // checkBoxAN
            // 
            this.checkBoxAN.AutoSize = true;
            this.checkBoxAN.Checked = true;
            this.checkBoxAN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAN.Location = new System.Drawing.Point(8, 54);
            this.checkBoxAN.Name = "checkBoxAN";
            this.checkBoxAN.Size = new System.Drawing.Size(90, 19);
            this.checkBoxAN.TabIndex = 2;
            this.checkBoxAN.Text = "All numbers";
            this.checkBoxAN.UseVisualStyleBackColor = true;
            this.checkBoxAN.CheckedChanged += new System.EventHandler(this.checkBoxLL_CheckedChanged);
            // 
            // checkBoxAL
            // 
            this.checkBoxAL.AutoSize = true;
            this.checkBoxAL.Checked = true;
            this.checkBoxAL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAL.Location = new System.Drawing.Point(8, 35);
            this.checkBoxAL.Name = "checkBoxAL";
            this.checkBoxAL.Size = new System.Drawing.Size(132, 19);
            this.checkBoxAL.TabIndex = 1;
            this.checkBoxAL.Text = "All uppercase letters";
            this.checkBoxAL.UseVisualStyleBackColor = true;
            this.checkBoxAL.CheckedChanged += new System.EventHandler(this.checkBoxLL_CheckedChanged);
            // 
            // checkBoxLL
            // 
            this.checkBoxLL.AutoSize = true;
            this.checkBoxLL.Checked = true;
            this.checkBoxLL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLL.Location = new System.Drawing.Point(8, 17);
            this.checkBoxLL.Name = "checkBoxLL";
            this.checkBoxLL.Size = new System.Drawing.Size(130, 19);
            this.checkBoxLL.TabIndex = 0;
            this.checkBoxLL.Text = "All lowercase letters";
            this.checkBoxLL.UseVisualStyleBackColor = true;
            this.checkBoxLL.CheckedChanged += new System.EventHandler(this.checkBoxLL_CheckedChanged);
            // 
            // labelPath
            // 
            this.labelPath.Location = new System.Drawing.Point(278, 24);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(478, 24);
            this.labelPath.TabIndex = 14;
            this.labelPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxProgress
            // 
            this.groupBoxProgress.Controls.Add(this.progressBar);
            this.groupBoxProgress.Controls.Add(this.labelInfo);
            this.groupBoxProgress.Controls.Add(this.buttonStart);
            this.groupBoxProgress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxProgress.ForeColor = System.Drawing.Color.White;
            this.groupBoxProgress.Location = new System.Drawing.Point(17, 274);
            this.groupBoxProgress.Name = "groupBoxProgress";
            this.groupBoxProgress.Size = new System.Drawing.Size(762, 100);
            this.groupBoxProgress.TabIndex = 16;
            this.groupBoxProgress.TabStop = false;
            this.groupBoxProgress.Text = "Progress";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 22);
            this.progressBar.MarqueeAnimationSpeed = 10;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(750, 23);
            this.progressBar.TabIndex = 16;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(7, 59);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(102, 30);
            this.labelInfo.TabIndex = 15;
            this.labelInfo.Text = "Curent Password: \r\nTotal left:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All Suported Files (*.zip;*.rar;*.7z)|*.zip;*.rar;*.7z|All Files (*.*)|*.*";
            // 
            // labelAboutA
            // 
            this.labelAboutA.AutoSize = true;
            this.labelAboutA.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAboutA.ForeColor = System.Drawing.Color.Lime;
            this.labelAboutA.Location = new System.Drawing.Point(190, 9);
            this.labelAboutA.Name = "labelAboutA";
            this.labelAboutA.Size = new System.Drawing.Size(122, 30);
            this.labelAboutA.TabIndex = 17;
            this.labelAboutA.Text = "by TobyAdd";
            this.labelAboutA.Click += new System.EventHandler(this.labelAboutA_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(791, 398);
            this.Controls.Add(this.labelCaption);
            this.Controls.Add(this.labelAboutA);
            this.Controls.Add(this.groupBoxProgress);
            this.Controls.Add(this.groupBoxAttackType);
            this.Controls.Add(this.groupBoxArchive);
            this.Controls.Add(this.buttonMinimaze);
            this.Controls.Add(this.buttonClose);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Undefined Archive";
            this.groupBoxArchive.ResumeLayout(false);
            this.groupBoxArchive.PerformLayout();
            this.groupBoxAttackType.ResumeLayout(false);
            this.groupBoxAttackType.PerformLayout();
            this.groupBoxBRwithMASK.ResumeLayout(false);
            this.groupBoxBRwithMASK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            this.groupBoxProgress.ResumeLayout(false);
            this.groupBoxProgress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimaze;
        private System.Windows.Forms.TextBox textBoxArchivePath;
        private System.Windows.Forms.Button buttonAddArchive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonDAttack;
        private System.Windows.Forms.RadioButton radioButtonBRwithMASK;
        private System.Windows.Forms.Button buttonAddD;
        private System.Windows.Forms.Button buttonBRwithMASK;
        private System.Windows.Forms.RadioButton radioButtonBruteforce;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBoxArchive;
        private System.Windows.Forms.GroupBox groupBoxAttackType;
        private System.Windows.Forms.GroupBox groupBoxProgress;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.GroupBox groupBoxBRwithMASK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.TextBox textBoxLetters;
        private System.Windows.Forms.CheckBox checkBoxSS;
        private System.Windows.Forms.CheckBox checkBoxAN;
        private System.Windows.Forms.CheckBox checkBoxAL;
        private System.Windows.Forms.CheckBox checkBoxLL;
        private System.Windows.Forms.CheckBox checkBoxSpace;
        private System.Windows.Forms.Label labelAboutA;
    }
}

