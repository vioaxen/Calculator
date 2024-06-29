namespace Calculator
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMinimazeWin = new System.Windows.Forms.Button();
            this.BtnFullScreen = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnRecent = new System.Windows.Forms.Button();
            this.TxtDisplay1 = new System.Windows.Forms.TextBox();
            this.TxtDisplay2 = new System.Windows.Forms.TextBox();
            this.HistoryPanel = new System.Windows.Forms.Panel();
            this.RtBoxDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.BtnClearHistory = new System.Windows.Forms.Button();
            this.BtnPM = new AxenvioButtons.AxenvioButton();
            this.Btn0 = new AxenvioButtons.AxenvioButton();
            this.BtnDot = new AxenvioButtons.AxenvioButton();
            this.BtnEquals = new AxenvioButtons.AxenvioButton();
            this.Btn1 = new AxenvioButtons.AxenvioButton();
            this.Btn2 = new AxenvioButtons.AxenvioButton();
            this.Btn3 = new AxenvioButtons.AxenvioButton();
            this.BtnAdd = new AxenvioButtons.AxenvioButton();
            this.Btn4 = new AxenvioButtons.AxenvioButton();
            this.Btn5 = new AxenvioButtons.AxenvioButton();
            this.Btn6 = new AxenvioButtons.AxenvioButton();
            this.BtnSubstuct = new AxenvioButtons.AxenvioButton();
            this.Btn7 = new AxenvioButtons.AxenvioButton();
            this.Btn8 = new AxenvioButtons.AxenvioButton();
            this.Btn9 = new AxenvioButtons.AxenvioButton();
            this.BtnMultiply = new AxenvioButtons.AxenvioButton();
            this.BtnDivisionX = new AxenvioButtons.AxenvioButton();
            this.BtnSquare = new AxenvioButtons.AxenvioButton();
            this.BtnSquareRoot = new AxenvioButtons.AxenvioButton();
            this.BtnDivision = new AxenvioButtons.AxenvioButton();
            this.axenvioButton10 = new AxenvioButtons.AxenvioButton();
            this.axenvioButton9 = new AxenvioButtons.AxenvioButton();
            this.axenvioButton8 = new AxenvioButtons.AxenvioButton();
            this.axenvioButton7 = new AxenvioButtons.AxenvioButton();
            this.axenvioButton6 = new AxenvioButtons.AxenvioButton();
            this.axenvioButton5 = new AxenvioButtons.AxenvioButton();
            this.BtnPercent = new AxenvioButtons.AxenvioButton();
            this.BtnCE = new AxenvioButtons.AxenvioButton();
            this.BtnC = new AxenvioButtons.AxenvioButton();
            this.BtnBackSpace = new AxenvioButtons.AxenvioButton();
            this.ellipseForm = new EllipseAxenvio.EllipseControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.HistoryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.BtnMinimazeWin);
            this.panel1.Controls.Add(this.BtnFullScreen);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 36);
            this.panel1.TabIndex = 0;
            // 
            // BtnMinimazeWin
            // 
            this.BtnMinimazeWin.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMinimazeWin.FlatAppearance.BorderSize = 0;
            this.BtnMinimazeWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimazeWin.Image = global::Calculator.Properties.Resources.minus;
            this.BtnMinimazeWin.Location = new System.Drawing.Point(212, 0);
            this.BtnMinimazeWin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMinimazeWin.Name = "BtnMinimazeWin";
            this.BtnMinimazeWin.Size = new System.Drawing.Size(36, 36);
            this.BtnMinimazeWin.TabIndex = 2;
            this.BtnMinimazeWin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnMinimazeWin.UseVisualStyleBackColor = true;
            this.BtnMinimazeWin.Click += new System.EventHandler(this.BtnMinimazeWin_Click);
            // 
            // BtnFullScreen
            // 
            this.BtnFullScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnFullScreen.FlatAppearance.BorderSize = 0;
            this.BtnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFullScreen.Image = global::Calculator.Properties.Resources.maximize;
            this.BtnFullScreen.Location = new System.Drawing.Point(248, 0);
            this.BtnFullScreen.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFullScreen.Name = "BtnFullScreen";
            this.BtnFullScreen.Size = new System.Drawing.Size(36, 36);
            this.BtnFullScreen.TabIndex = 1;
            this.BtnFullScreen.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnFullScreen.UseVisualStyleBackColor = true;
           
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = global::Calculator.Properties.Resources.x;
            this.BtnExit.Location = new System.Drawing.Point(284, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(36, 36);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.BtnMenu);
            this.panel2.Controls.Add(this.BtnRecent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 36);
            this.panel2.TabIndex = 1;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.Location = new System.Drawing.Point(0, 0);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(36, 36);
            this.BtnMenu.TabIndex = 2;
            this.BtnMenu.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnMenu.UseVisualStyleBackColor = true;
            // 
            // BtnRecent
            // 
            this.BtnRecent.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRecent.FlatAppearance.BorderSize = 0;
            this.BtnRecent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecent.Image = ((System.Drawing.Image)(resources.GetObject("BtnRecent.Image")));
            this.BtnRecent.Location = new System.Drawing.Point(284, 0);
            this.BtnRecent.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRecent.Name = "BtnRecent";
            this.BtnRecent.Size = new System.Drawing.Size(36, 36);
            this.BtnRecent.TabIndex = 0;
            this.BtnRecent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnRecent.UseVisualStyleBackColor = true;
            this.BtnRecent.Click += new System.EventHandler(this.BtnRecent_Click);
            // 
            // TxtDisplay1
            // 
            this.TxtDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay1.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.TxtDisplay1.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtDisplay1.Location = new System.Drawing.Point(0, 72);
            this.TxtDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay1.Multiline = true;
            this.TxtDisplay1.Name = "TxtDisplay1";
            this.TxtDisplay1.Size = new System.Drawing.Size(320, 20);
            this.TxtDisplay1.TabIndex = 2;
            this.TxtDisplay1.Text = "0";
            this.TxtDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtDisplay2
            // 
            this.TxtDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay2.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay2.Font = new System.Drawing.Font("Gadugi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDisplay2.Location = new System.Drawing.Point(0, 92);
            this.TxtDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay2.Multiline = true;
            this.TxtDisplay2.Name = "TxtDisplay2";
            this.TxtDisplay2.Size = new System.Drawing.Size(320, 56);
            this.TxtDisplay2.TabIndex = 3;
            this.TxtDisplay2.Text = "0";
            this.TxtDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HistoryPanel
            // 
            this.HistoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.HistoryPanel.Controls.Add(this.RtBoxDisplayHistory);
            this.HistoryPanel.Controls.Add(this.BtnClearHistory);
            this.HistoryPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HistoryPanel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryPanel.Location = new System.Drawing.Point(0, 515);
            this.HistoryPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HistoryPanel.Name = "HistoryPanel";
            this.HistoryPanel.Size = new System.Drawing.Size(320, 5);
            this.HistoryPanel.TabIndex = 4;
            // 
            // RtBoxDisplayHistory
            // 
            this.RtBoxDisplayHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.RtBoxDisplayHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtBoxDisplayHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtBoxDisplayHistory.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtBoxDisplayHistory.ForeColor = System.Drawing.Color.Silver;
            this.RtBoxDisplayHistory.Location = new System.Drawing.Point(0, 0);
            this.RtBoxDisplayHistory.Margin = new System.Windows.Forms.Padding(0);
            this.RtBoxDisplayHistory.Name = "RtBoxDisplayHistory";
            this.RtBoxDisplayHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.RtBoxDisplayHistory.Size = new System.Drawing.Size(320, 0);
            this.RtBoxDisplayHistory.TabIndex = 4;
            this.RtBoxDisplayHistory.Text = "";
            // 
            // BtnClearHistory
            // 
            this.BtnClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnClearHistory.FlatAppearance.BorderSize = 0;
            this.BtnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnClearHistory.Image")));
            this.BtnClearHistory.Location = new System.Drawing.Point(0, -31);
            this.BtnClearHistory.Name = "BtnClearHistory";
            this.BtnClearHistory.Size = new System.Drawing.Size(320, 36);
            this.BtnClearHistory.TabIndex = 2;
            this.BtnClearHistory.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnClearHistory.UseVisualStyleBackColor = true;
            this.BtnClearHistory.Click += new System.EventHandler(this.BtnClearHistory_Click);
            // 
            // BtnPM
            // 
            this.BtnPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnPM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnPM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnPM.BorderRadius = 15;
            this.BtnPM.BorderSize = 0;
            this.BtnPM.FlatAppearance.BorderSize = 0;
            this.BtnPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPM.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.BtnPM.Location = new System.Drawing.Point(10, 450);
            this.BtnPM.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPM.Name = "BtnPM";
            this.BtnPM.Size = new System.Drawing.Size(75, 50);
            this.BtnPM.TabIndex = 37;
            this.BtnPM.Text = "±";
            this.BtnPM.UseVisualStyleBackColor = false;
            this.BtnPM.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn0.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn0.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn0.BorderRadius = 15;
            this.Btn0.BorderSize = 0;
            this.Btn0.FlatAppearance.BorderSize = 0;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Btn0.Location = new System.Drawing.Point(85, 450);
            this.Btn0.Margin = new System.Windows.Forms.Padding(0);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(75, 50);
            this.Btn0.TabIndex = 36;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnDot
            // 
            this.BtnDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnDot.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnDot.BorderRadius = 15;
            this.BtnDot.BorderSize = 0;
            this.BtnDot.FlatAppearance.BorderSize = 0;
            this.BtnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDot.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.BtnDot.Location = new System.Drawing.Point(160, 450);
            this.BtnDot.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(75, 50);
            this.BtnDot.TabIndex = 35;
            this.BtnDot.Text = ".";
            this.BtnDot.UseVisualStyleBackColor = false;
            this.BtnDot.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(126)))));
            this.BtnEquals.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(126)))));
            this.BtnEquals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEquals.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnEquals.BorderRadius = 15;
            this.BtnEquals.BorderSize = 0;
            this.BtnEquals.FlatAppearance.BorderSize = 0;
            this.BtnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.BtnEquals.Location = new System.Drawing.Point(235, 450);
            this.BtnEquals.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(75, 50);
            this.BtnEquals.TabIndex = 34;
            this.BtnEquals.Text = "＝";
            this.BtnEquals.UseVisualStyleBackColor = false;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn1.BorderRadius = 15;
            this.Btn1.BorderSize = 0;
            this.Btn1.FlatAppearance.BorderSize = 0;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Btn1.Location = new System.Drawing.Point(10, 400);
            this.Btn1.Margin = new System.Windows.Forms.Padding(0);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(75, 50);
            this.Btn1.TabIndex = 33;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn2.BorderRadius = 15;
            this.Btn2.BorderSize = 0;
            this.Btn2.FlatAppearance.BorderSize = 0;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Btn2.Location = new System.Drawing.Point(85, 400);
            this.Btn2.Margin = new System.Windows.Forms.Padding(0);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(75, 50);
            this.Btn2.TabIndex = 32;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn3.BorderRadius = 15;
            this.Btn3.BorderSize = 0;
            this.Btn3.FlatAppearance.BorderSize = 0;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Btn3.Location = new System.Drawing.Point(160, 400);
            this.Btn3.Margin = new System.Windows.Forms.Padding(0);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(75, 50);
            this.Btn3.TabIndex = 31;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnAdd.BorderRadius = 15;
            this.BtnAdd.BorderSize = 0;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.BtnAdd.Location = new System.Drawing.Point(235, 400);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 50);
            this.BtnAdd.TabIndex = 30;
            this.BtnAdd.Text = "＋";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn4.BorderRadius = 15;
            this.Btn4.BorderSize = 0;
            this.Btn4.FlatAppearance.BorderSize = 0;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Btn4.Location = new System.Drawing.Point(10, 350);
            this.Btn4.Margin = new System.Windows.Forms.Padding(0);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(75, 50);
            this.Btn4.TabIndex = 29;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn5.BorderRadius = 15;
            this.Btn5.BorderSize = 0;
            this.Btn5.FlatAppearance.BorderSize = 0;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Btn5.Location = new System.Drawing.Point(85, 350);
            this.Btn5.Margin = new System.Windows.Forms.Padding(0);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(75, 50);
            this.Btn5.TabIndex = 28;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn6.BorderRadius = 15;
            this.Btn6.BorderSize = 0;
            this.Btn6.FlatAppearance.BorderSize = 0;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Btn6.Location = new System.Drawing.Point(160, 350);
            this.Btn6.Margin = new System.Windows.Forms.Padding(0);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(75, 50);
            this.Btn6.TabIndex = 27;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnSubstuct
            // 
            this.BtnSubstuct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnSubstuct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnSubstuct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSubstuct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnSubstuct.BorderRadius = 15;
            this.BtnSubstuct.BorderSize = 0;
            this.BtnSubstuct.FlatAppearance.BorderSize = 0;
            this.BtnSubstuct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubstuct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.BtnSubstuct.Location = new System.Drawing.Point(235, 350);
            this.BtnSubstuct.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSubstuct.Name = "BtnSubstuct";
            this.BtnSubstuct.Size = new System.Drawing.Size(75, 50);
            this.BtnSubstuct.TabIndex = 26;
            this.BtnSubstuct.Text = "－";
            this.BtnSubstuct.UseVisualStyleBackColor = false;
            this.BtnSubstuct.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn7.BorderRadius = 15;
            this.Btn7.BorderSize = 0;
            this.Btn7.FlatAppearance.BorderSize = 0;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Btn7.Location = new System.Drawing.Point(10, 300);
            this.Btn7.Margin = new System.Windows.Forms.Padding(0);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(75, 50);
            this.Btn7.TabIndex = 25;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn8.BorderRadius = 15;
            this.Btn8.BorderSize = 0;
            this.Btn8.FlatAppearance.BorderSize = 0;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Btn8.Location = new System.Drawing.Point(85, 300);
            this.Btn8.Margin = new System.Windows.Forms.Padding(0);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(75, 50);
            this.Btn8.TabIndex = 24;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn9.BorderRadius = 15;
            this.Btn9.BorderSize = 0;
            this.Btn9.FlatAppearance.BorderSize = 0;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Btn9.Location = new System.Drawing.Point(160, 300);
            this.Btn9.Margin = new System.Windows.Forms.Padding(0);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(75, 50);
            this.Btn9.TabIndex = 23;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnMultiply.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnMultiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMultiply.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnMultiply.BorderRadius = 15;
            this.BtnMultiply.BorderSize = 0;
            this.BtnMultiply.FlatAppearance.BorderSize = 0;
            this.BtnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.BtnMultiply.Location = new System.Drawing.Point(235, 300);
            this.BtnMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(75, 50);
            this.BtnMultiply.TabIndex = 22;
            this.BtnMultiply.Text = "✕";
            this.BtnMultiply.UseVisualStyleBackColor = false;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // BtnDivisionX
            // 
            this.BtnDivisionX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnDivisionX.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnDivisionX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDivisionX.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnDivisionX.BorderRadius = 15;
            this.BtnDivisionX.BorderSize = 0;
            this.BtnDivisionX.FlatAppearance.BorderSize = 0;
            this.BtnDivisionX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDivisionX.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivisionX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.BtnDivisionX.Location = new System.Drawing.Point(10, 250);
            this.BtnDivisionX.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDivisionX.Name = "BtnDivisionX";
            this.BtnDivisionX.Size = new System.Drawing.Size(75, 50);
            this.BtnDivisionX.TabIndex = 21;
            this.BtnDivisionX.Text = "⅟ₓ";
            this.BtnDivisionX.UseVisualStyleBackColor = false;
            this.BtnDivisionX.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnSquare
            // 
            this.BtnSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnSquare.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSquare.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnSquare.BorderRadius = 15;
            this.BtnSquare.BorderSize = 0;
            this.BtnSquare.FlatAppearance.BorderSize = 0;
            this.BtnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSquare.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSquare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.BtnSquare.Location = new System.Drawing.Point(85, 250);
            this.BtnSquare.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSquare.Name = "BtnSquare";
            this.BtnSquare.Size = new System.Drawing.Size(75, 50);
            this.BtnSquare.TabIndex = 20;
            this.BtnSquare.Text = "x²";
            this.BtnSquare.UseVisualStyleBackColor = false;
            this.BtnSquare.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnSquareRoot
            // 
            this.BtnSquareRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnSquareRoot.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnSquareRoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSquareRoot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnSquareRoot.BorderRadius = 15;
            this.BtnSquareRoot.BorderSize = 0;
            this.BtnSquareRoot.FlatAppearance.BorderSize = 0;
            this.BtnSquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSquareRoot.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSquareRoot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.BtnSquareRoot.Location = new System.Drawing.Point(160, 250);
            this.BtnSquareRoot.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSquareRoot.Name = "BtnSquareRoot";
            this.BtnSquareRoot.Size = new System.Drawing.Size(75, 50);
            this.BtnSquareRoot.TabIndex = 19;
            this.BtnSquareRoot.Text = "√ₓ";
            this.BtnSquareRoot.UseVisualStyleBackColor = false;
            this.BtnSquareRoot.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnDivision.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnDivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDivision.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnDivision.BorderRadius = 15;
            this.BtnDivision.BorderSize = 0;
            this.BtnDivision.FlatAppearance.BorderSize = 0;
            this.BtnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDivision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.BtnDivision.Location = new System.Drawing.Point(235, 250);
            this.BtnDivision.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(75, 50);
            this.BtnDivision.TabIndex = 18;
            this.BtnDivision.Text = "÷";
            this.BtnDivision.UseVisualStyleBackColor = false;
            this.BtnDivision.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // axenvioButton10
            // 
            this.axenvioButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.axenvioButton10.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.axenvioButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.axenvioButton10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.axenvioButton10.BorderRadius = 25;
            this.axenvioButton10.BorderSize = 0;
            this.axenvioButton10.FlatAppearance.BorderSize = 0;
            this.axenvioButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.axenvioButton10.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axenvioButton10.ForeColor = System.Drawing.Color.White;
            this.axenvioButton10.Location = new System.Drawing.Point(110, 160);
            this.axenvioButton10.Margin = new System.Windows.Forms.Padding(0);
            this.axenvioButton10.Name = "axenvioButton10";
            this.axenvioButton10.Size = new System.Drawing.Size(50, 25);
            this.axenvioButton10.TabIndex = 17;
            this.axenvioButton10.Text = "M+";
            this.axenvioButton10.UseVisualStyleBackColor = false;
            // 
            // axenvioButton9
            // 
            this.axenvioButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.axenvioButton9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.axenvioButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.axenvioButton9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.axenvioButton9.BorderRadius = 25;
            this.axenvioButton9.BorderSize = 0;
            this.axenvioButton9.FlatAppearance.BorderSize = 0;
            this.axenvioButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.axenvioButton9.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axenvioButton9.ForeColor = System.Drawing.Color.White;
            this.axenvioButton9.Location = new System.Drawing.Point(160, 160);
            this.axenvioButton9.Margin = new System.Windows.Forms.Padding(0);
            this.axenvioButton9.Name = "axenvioButton9";
            this.axenvioButton9.Size = new System.Drawing.Size(50, 25);
            this.axenvioButton9.TabIndex = 16;
            this.axenvioButton9.Text = "M-";
            this.axenvioButton9.UseVisualStyleBackColor = false;
            // 
            // axenvioButton8
            // 
            this.axenvioButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.axenvioButton8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.axenvioButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.axenvioButton8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.axenvioButton8.BorderRadius = 25;
            this.axenvioButton8.BorderSize = 0;
            this.axenvioButton8.FlatAppearance.BorderSize = 0;
            this.axenvioButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.axenvioButton8.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axenvioButton8.ForeColor = System.Drawing.Color.White;
            this.axenvioButton8.Location = new System.Drawing.Point(210, 160);
            this.axenvioButton8.Margin = new System.Windows.Forms.Padding(0);
            this.axenvioButton8.Name = "axenvioButton8";
            this.axenvioButton8.Size = new System.Drawing.Size(50, 25);
            this.axenvioButton8.TabIndex = 15;
            this.axenvioButton8.Text = "MS";
            this.axenvioButton8.UseVisualStyleBackColor = false;
            // 
            // axenvioButton7
            // 
            this.axenvioButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.axenvioButton7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.axenvioButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.axenvioButton7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.axenvioButton7.BorderRadius = 25;
            this.axenvioButton7.BorderSize = 0;
            this.axenvioButton7.FlatAppearance.BorderSize = 0;
            this.axenvioButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.axenvioButton7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axenvioButton7.ForeColor = System.Drawing.Color.White;
            this.axenvioButton7.Location = new System.Drawing.Point(260, 160);
            this.axenvioButton7.Margin = new System.Windows.Forms.Padding(0);
            this.axenvioButton7.Name = "axenvioButton7";
            this.axenvioButton7.Size = new System.Drawing.Size(50, 25);
            this.axenvioButton7.TabIndex = 14;
            this.axenvioButton7.Text = "M∨";
            this.axenvioButton7.UseVisualStyleBackColor = false;
            // 
            // axenvioButton6
            // 
            this.axenvioButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.axenvioButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.axenvioButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.axenvioButton6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.axenvioButton6.BorderRadius = 25;
            this.axenvioButton6.BorderSize = 0;
            this.axenvioButton6.FlatAppearance.BorderSize = 0;
            this.axenvioButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.axenvioButton6.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axenvioButton6.ForeColor = System.Drawing.Color.White;
            this.axenvioButton6.Location = new System.Drawing.Point(60, 160);
            this.axenvioButton6.Margin = new System.Windows.Forms.Padding(0);
            this.axenvioButton6.Name = "axenvioButton6";
            this.axenvioButton6.Size = new System.Drawing.Size(50, 25);
            this.axenvioButton6.TabIndex = 13;
            this.axenvioButton6.Text = "MR";
            this.axenvioButton6.UseVisualStyleBackColor = false;
            // 
            // axenvioButton5
            // 
            this.axenvioButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.axenvioButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.axenvioButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.axenvioButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.axenvioButton5.BorderRadius = 25;
            this.axenvioButton5.BorderSize = 0;
            this.axenvioButton5.FlatAppearance.BorderSize = 0;
            this.axenvioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.axenvioButton5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axenvioButton5.ForeColor = System.Drawing.Color.White;
            this.axenvioButton5.Location = new System.Drawing.Point(10, 160);
            this.axenvioButton5.Margin = new System.Windows.Forms.Padding(0);
            this.axenvioButton5.Name = "axenvioButton5";
            this.axenvioButton5.Size = new System.Drawing.Size(50, 25);
            this.axenvioButton5.TabIndex = 12;
            this.axenvioButton5.Text = "MC";
            this.axenvioButton5.UseVisualStyleBackColor = false;
            // 
            // BtnPercent
            // 
            this.BtnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnPercent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnPercent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPercent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnPercent.BorderRadius = 15;
            this.BtnPercent.BorderSize = 0;
            this.BtnPercent.FlatAppearance.BorderSize = 0;
            this.BtnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPercent.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.BtnPercent.Location = new System.Drawing.Point(10, 200);
            this.BtnPercent.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(75, 50);
            this.BtnPercent.TabIndex = 8;
            this.BtnPercent.Text = "％";
            this.BtnPercent.UseVisualStyleBackColor = false;
            this.BtnPercent.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnCE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnCE.BorderRadius = 15;
            this.BtnCE.BorderSize = 0;
            this.BtnCE.FlatAppearance.BorderSize = 0;
            this.BtnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCE.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.BtnCE.Location = new System.Drawing.Point(85, 200);
            this.BtnCE.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(75, 50);
            this.BtnCE.TabIndex = 7;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = false;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnC.BorderRadius = 15;
            this.BtnC.BorderSize = 0;
            this.BtnC.FlatAppearance.BorderSize = 0;
            this.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnC.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.BtnC.Location = new System.Drawing.Point(160, 200);
            this.BtnC.Margin = new System.Windows.Forms.Padding(0);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(75, 50);
            this.BtnC.TabIndex = 6;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnBackSpace
            // 
            this.BtnBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnBackSpace.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnBackSpace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBackSpace.BackgroundImage")));
            this.BtnBackSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBackSpace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnBackSpace.BorderRadius = 15;
            this.BtnBackSpace.BorderSize = 0;
            this.BtnBackSpace.FlatAppearance.BorderSize = 0;
            this.BtnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackSpace.ForeColor = System.Drawing.Color.White;
            this.BtnBackSpace.Location = new System.Drawing.Point(235, 200);
            this.BtnBackSpace.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBackSpace.Name = "BtnBackSpace";
            this.BtnBackSpace.Size = new System.Drawing.Size(75, 50);
            this.BtnBackSpace.TabIndex = 5;
            this.BtnBackSpace.UseVisualStyleBackColor = false;
            this.BtnBackSpace.Click += new System.EventHandler(this.BtnBackSpace_Click);
            // 
            // ellipseForm
            // 
            this.ellipseForm.CornerRadius = 20;
            this.ellipseForm.TargetControl = this;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(320, 520);
            this.Controls.Add(this.HistoryPanel);
            this.Controls.Add(this.BtnPM);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.BtnSubstuct);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.BtnDivisionX);
            this.Controls.Add(this.BtnSquare);
            this.Controls.Add(this.BtnSquareRoot);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.axenvioButton10);
            this.Controls.Add(this.axenvioButton9);
            this.Controls.Add(this.axenvioButton8);
            this.Controls.Add(this.axenvioButton7);
            this.Controls.Add(this.axenvioButton6);
            this.Controls.Add(this.axenvioButton5);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnBackSpace);
            this.Controls.Add(this.TxtDisplay2);
            this.Controls.Add(this.TxtDisplay1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.HistoryPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnMinimazeWin;
        private System.Windows.Forms.Button BtnFullScreen;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnRecent;
        private System.Windows.Forms.TextBox TxtDisplay1;
        private System.Windows.Forms.TextBox TxtDisplay2;
        private System.Windows.Forms.Panel HistoryPanel;
        private System.Windows.Forms.Button BtnClearHistory;
        private System.Windows.Forms.RichTextBox RtBoxDisplayHistory;
        private EllipseAxenvio.EllipseControl ellipseForm;
        private AxenvioButtons.AxenvioButton BtnBackSpace;
        private AxenvioButtons.AxenvioButton axenvioButton5;
        private AxenvioButtons.AxenvioButton BtnPercent;
        private AxenvioButtons.AxenvioButton BtnCE;
        private AxenvioButtons.AxenvioButton BtnC;
        private AxenvioButtons.AxenvioButton axenvioButton10;
        private AxenvioButtons.AxenvioButton axenvioButton9;
        private AxenvioButtons.AxenvioButton axenvioButton8;
        private AxenvioButtons.AxenvioButton axenvioButton7;
        private AxenvioButtons.AxenvioButton axenvioButton6;
        private AxenvioButtons.AxenvioButton BtnDivisionX;
        private AxenvioButtons.AxenvioButton BtnSquare;
        private AxenvioButtons.AxenvioButton BtnSquareRoot;
        private AxenvioButtons.AxenvioButton BtnDivision;
        private AxenvioButtons.AxenvioButton BtnPM;
        private AxenvioButtons.AxenvioButton Btn0;
        private AxenvioButtons.AxenvioButton BtnDot;
        private AxenvioButtons.AxenvioButton BtnEquals;
        private AxenvioButtons.AxenvioButton Btn1;
        private AxenvioButtons.AxenvioButton Btn2;
        private AxenvioButtons.AxenvioButton Btn3;
        private AxenvioButtons.AxenvioButton BtnAdd;
        private AxenvioButtons.AxenvioButton Btn4;
        private AxenvioButtons.AxenvioButton Btn5;
        private AxenvioButtons.AxenvioButton Btn6;
        private AxenvioButtons.AxenvioButton BtnSubstuct;
        private AxenvioButtons.AxenvioButton Btn7;
        private AxenvioButtons.AxenvioButton Btn8;
        private AxenvioButtons.AxenvioButton Btn9;
        private AxenvioButtons.AxenvioButton BtnMultiply;
    }
}

