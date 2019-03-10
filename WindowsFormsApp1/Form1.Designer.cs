namespace WindowsFormsApp1
{
    partial class ATM
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
            this.components = new System.ComponentModel.Container();
            this.Insert = new System.Windows.Forms.Button();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.labelCard = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.CardExample = new System.Windows.Forms.Panel();
            this.Login = new System.Windows.Forms.Panel();
            this.PIN4 = new System.Windows.Forms.MaskedTextBox();
            this.PIN3 = new System.Windows.Forms.MaskedTextBox();
            this.PIN2 = new System.Windows.Forms.MaskedTextBox();
            this.PIN1 = new System.Windows.Forms.MaskedTextBox();
            this.labelPin = new System.Windows.Forms.Label();
            this.panelWithdraw = new System.Windows.Forms.Panel();
            this.Dollar = new System.Windows.Forms.Label();
            this.balBox = new System.Windows.Forms.TextBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.Cho = new System.Windows.Forms.Panel();
            this.moneyCho = new System.Windows.Forms.Button();
            this.money500 = new System.Windows.Forms.Button();
            this.money250 = new System.Windows.Forms.Button();
            this.money5 = new System.Windows.Forms.Button();
            this.money100 = new System.Windows.Forms.Button();
            this.money50 = new System.Windows.Forms.Button();
            this.Money10 = new System.Windows.Forms.Button();
            this.YourOption = new System.Windows.Forms.Panel();
            this.Dollar2 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonN1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonN2 = new System.Windows.Forms.Button();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.MoneyBox = new System.Windows.Forms.PictureBox();
            this.NrOfBills = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Ascuns = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.goodbye = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelMain.SuspendLayout();
            this.Login.SuspendLayout();
            this.panelWithdraw.SuspendLayout();
            this.Cho.SuspendLayout();
            this.YourOption.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyBox)).BeginInit();
            this.goodbye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.Transparent;
            this.Insert.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.insert;
            this.Insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Insert.Location = new System.Drawing.Point(502, 172);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(99, 48);
            this.Insert.TabIndex = 0;
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelMain.Controls.Add(this.labelCard);
            this.PanelMain.Controls.Add(this.labelWelcome);
            this.PanelMain.Controls.Add(this.CardExample);
            this.PanelMain.Location = new System.Drawing.Point(59, 97);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(326, 219);
            this.PanelMain.TabIndex = 1;
            // 
            // labelCard
            // 
            this.labelCard.AutoSize = true;
            this.labelCard.BackColor = System.Drawing.Color.Transparent;
            this.labelCard.Font = new System.Drawing.Font("Ink Free", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCard.Location = new System.Drawing.Point(137, 129);
            this.labelCard.Name = "labelCard";
            this.labelCard.Size = new System.Drawing.Size(175, 68);
            this.labelCard.TabIndex = 2;
            this.labelCard.Text = "Please insert\r\nyour card.";
            this.labelCard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Ink Free", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(151, 20);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(150, 68);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Welcome to\r\nour ATM!";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardExample
            // 
            this.CardExample.BackColor = System.Drawing.Color.Transparent;
            this.CardExample.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._014_atm_cash_dispenser_machine_money_credit_card_insert_hand_5121;
            this.CardExample.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CardExample.Location = new System.Drawing.Point(0, 0);
            this.CardExample.Name = "CardExample";
            this.CardExample.Size = new System.Drawing.Size(131, 217);
            this.CardExample.TabIndex = 0;
            this.CardExample.Paint += new System.Windows.Forms.PaintEventHandler(this.CardExample_Paint);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Login.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Login.Controls.Add(this.PIN4);
            this.Login.Controls.Add(this.PIN3);
            this.Login.Controls.Add(this.PIN2);
            this.Login.Controls.Add(this.PIN1);
            this.Login.Controls.Add(this.labelPin);
            this.Login.Location = new System.Drawing.Point(59, 97);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(326, 219);
            this.Login.TabIndex = 2;
            this.Login.Visible = false;
            this.Login.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Paint);
            // 
            // PIN4
            // 
            this.PIN4.AsciiOnly = true;
            this.PIN4.Enabled = false;
            this.PIN4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIN4.ImeMode = System.Windows.Forms.ImeMode.On;
            this.PIN4.Location = new System.Drawing.Point(220, 140);
            this.PIN4.Name = "PIN4";
            this.PIN4.PromptChar = '*';
            this.PIN4.Size = new System.Drawing.Size(20, 38);
            this.PIN4.TabIndex = 4;
            this.PIN4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PIN4.UseSystemPasswordChar = true;
            this.PIN4.ValidatingType = typeof(int);
            // 
            // PIN3
            // 
            this.PIN3.AsciiOnly = true;
            this.PIN3.Enabled = false;
            this.PIN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIN3.Location = new System.Drawing.Point(177, 140);
            this.PIN3.Name = "PIN3";
            this.PIN3.PromptChar = '*';
            this.PIN3.Size = new System.Drawing.Size(20, 38);
            this.PIN3.TabIndex = 3;
            this.PIN3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PIN3.UseSystemPasswordChar = true;
            this.PIN3.ValidatingType = typeof(int);
            this.PIN3.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.PIN3_MaskInputRejected);
            // 
            // PIN2
            // 
            this.PIN2.AsciiOnly = true;
            this.PIN2.Enabled = false;
            this.PIN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIN2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.PIN2.Location = new System.Drawing.Point(128, 140);
            this.PIN2.Name = "PIN2";
            this.PIN2.PromptChar = '*';
            this.PIN2.Size = new System.Drawing.Size(20, 38);
            this.PIN2.TabIndex = 2;
            this.PIN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PIN2.UseSystemPasswordChar = true;
            this.PIN2.ValidatingType = typeof(int);
            this.PIN2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.PIN2_MaskInputRejected);
            // 
            // PIN1
            // 
            this.PIN1.AsciiOnly = true;
            this.PIN1.Cursor = System.Windows.Forms.Cursors.Default;
            this.PIN1.Enabled = false;
            this.PIN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIN1.HidePromptOnLeave = true;
            this.PIN1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.PIN1.Location = new System.Drawing.Point(86, 140);
            this.PIN1.Mask = "0";
            this.PIN1.Name = "PIN1";
            this.PIN1.PromptChar = '*';
            this.PIN1.ReadOnly = true;
            this.PIN1.RejectInputOnFirstFailure = true;
            this.PIN1.Size = new System.Drawing.Size(20, 38);
            this.PIN1.TabIndex = 1;
            this.PIN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PIN1.UseSystemPasswordChar = true;
            this.PIN1.ValidatingType = typeof(int);
            this.PIN1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.PIN1_MaskInputRejected);
            // 
            // labelPin
            // 
            this.labelPin.AutoSize = true;
            this.labelPin.BackColor = System.Drawing.Color.Transparent;
            this.labelPin.Font = new System.Drawing.Font("Ink Free", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPin.Location = new System.Drawing.Point(71, 20);
            this.labelPin.Name = "labelPin";
            this.labelPin.Size = new System.Drawing.Size(169, 68);
            this.labelPin.TabIndex = 0;
            this.labelPin.Text = "Please enter\r\nyour pin.";
            this.labelPin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelWithdraw
            // 
            this.panelWithdraw.BackColor = System.Drawing.Color.Tan;
            this.panelWithdraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelWithdraw.Controls.Add(this.Dollar);
            this.panelWithdraw.Controls.Add(this.balBox);
            this.panelWithdraw.Controls.Add(this.labelBalance);
            this.panelWithdraw.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelWithdraw.Location = new System.Drawing.Point(59, 97);
            this.panelWithdraw.Name = "panelWithdraw";
            this.panelWithdraw.Size = new System.Drawing.Size(326, 219);
            this.panelWithdraw.TabIndex = 5;
            this.panelWithdraw.Visible = false;
            this.panelWithdraw.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWithdraw_Paint);
            // 
            // Dollar
            // 
            this.Dollar.AutoSize = true;
            this.Dollar.Enabled = false;
            this.Dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dollar.Location = new System.Drawing.Point(203, 153);
            this.Dollar.Name = "Dollar";
            this.Dollar.Size = new System.Drawing.Size(18, 20);
            this.Dollar.TabIndex = 4;
            this.Dollar.Text = "$";
            // 
            // balBox
            // 
            this.balBox.BackColor = System.Drawing.Color.Tan;
            this.balBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.balBox.Enabled = false;
            this.balBox.ForeColor = System.Drawing.Color.Black;
            this.balBox.HideSelection = false;
            this.balBox.Location = new System.Drawing.Point(97, 156);
            this.balBox.Name = "balBox";
            this.balBox.Size = new System.Drawing.Size(100, 13);
            this.balBox.TabIndex = 3;
            this.balBox.TextChanged += new System.EventHandler(this.balBox_TextChanged);
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Ink Free", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.Location = new System.Drawing.Point(55, 20);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(202, 34);
            this.labelBalance.TabIndex = 0;
            this.labelBalance.Text = "Your balance is:";
            // 
            // Cho
            // 
            this.Cho.BackColor = System.Drawing.Color.Tan;
            this.Cho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Cho.Controls.Add(this.moneyCho);
            this.Cho.Controls.Add(this.money500);
            this.Cho.Controls.Add(this.money250);
            this.Cho.Controls.Add(this.money5);
            this.Cho.Controls.Add(this.money100);
            this.Cho.Controls.Add(this.money50);
            this.Cho.Controls.Add(this.Money10);
            this.Cho.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cho.Location = new System.Drawing.Point(59, 97);
            this.Cho.Name = "Cho";
            this.Cho.Size = new System.Drawing.Size(326, 219);
            this.Cho.TabIndex = 6;
            this.Cho.Visible = false;
            this.Cho.Paint += new System.Windows.Forms.PaintEventHandler(this.Choice_Paint);
            // 
            // moneyCho
            // 
            this.moneyCho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.moneyCho.Location = new System.Drawing.Point(111, 171);
            this.moneyCho.Name = "moneyCho";
            this.moneyCho.Size = new System.Drawing.Size(85, 23);
            this.moneyCho.TabIndex = 7;
            this.moneyCho.Text = "Another option";
            this.moneyCho.UseVisualStyleBackColor = true;
            this.moneyCho.Click += new System.EventHandler(this.moneyCho_Click);
            // 
            // money500
            // 
            this.money500.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.money500.Location = new System.Drawing.Point(248, 102);
            this.money500.Name = "money500";
            this.money500.Size = new System.Drawing.Size(75, 23);
            this.money500.TabIndex = 6;
            this.money500.Text = "500$";
            this.money500.UseVisualStyleBackColor = true;
            this.money500.Click += new System.EventHandler(this.money500_Click);
            // 
            // money250
            // 
            this.money250.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.money250.Location = new System.Drawing.Point(248, 59);
            this.money250.Name = "money250";
            this.money250.Size = new System.Drawing.Size(75, 23);
            this.money250.TabIndex = 5;
            this.money250.Text = "250$";
            this.money250.UseVisualStyleBackColor = true;
            this.money250.Click += new System.EventHandler(this.money250_Click);
            // 
            // money5
            // 
            this.money5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.money5.Location = new System.Drawing.Point(-3, 15);
            this.money5.Name = "money5";
            this.money5.Size = new System.Drawing.Size(75, 23);
            this.money5.TabIndex = 4;
            this.money5.Text = "5$";
            this.money5.UseVisualStyleBackColor = true;
            this.money5.Click += new System.EventHandler(this.money5_Click);
            // 
            // money100
            // 
            this.money100.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.money100.Location = new System.Drawing.Point(248, 15);
            this.money100.Name = "money100";
            this.money100.Size = new System.Drawing.Size(75, 23);
            this.money100.TabIndex = 2;
            this.money100.Text = "100$";
            this.money100.UseVisualStyleBackColor = true;
            this.money100.Click += new System.EventHandler(this.money100_Click);
            // 
            // money50
            // 
            this.money50.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.money50.Location = new System.Drawing.Point(-3, 102);
            this.money50.Name = "money50";
            this.money50.Size = new System.Drawing.Size(75, 23);
            this.money50.TabIndex = 1;
            this.money50.Text = "50$";
            this.money50.UseVisualStyleBackColor = true;
            this.money50.Click += new System.EventHandler(this.money50_Click);
            // 
            // Money10
            // 
            this.Money10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Money10.ForeColor = System.Drawing.Color.Black;
            this.Money10.Location = new System.Drawing.Point(-3, 59);
            this.Money10.Name = "Money10";
            this.Money10.Size = new System.Drawing.Size(75, 23);
            this.Money10.TabIndex = 0;
            this.Money10.Text = "10$";
            this.Money10.UseVisualStyleBackColor = true;
            this.Money10.Click += new System.EventHandler(this.Money10_Click);
            // 
            // YourOption
            // 
            this.YourOption.BackColor = System.Drawing.Color.Tan;
            this.YourOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.YourOption.Controls.Add(this.Dollar2);
            this.YourOption.Controls.Add(this.info);
            this.YourOption.Controls.Add(this.Amount);
            this.YourOption.Cursor = System.Windows.Forms.Cursors.Default;
            this.YourOption.Location = new System.Drawing.Point(59, 97);
            this.YourOption.Name = "YourOption";
            this.YourOption.Size = new System.Drawing.Size(326, 219);
            this.YourOption.TabIndex = 8;
            this.YourOption.Visible = false;
            this.YourOption.Paint += new System.Windows.Forms.PaintEventHandler(this.YourOption_Paint);
            // 
            // Dollar2
            // 
            this.Dollar2.AutoSize = true;
            this.Dollar2.Enabled = false;
            this.Dollar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dollar2.Location = new System.Drawing.Point(217, 88);
            this.Dollar2.Name = "Dollar2";
            this.Dollar2.Size = new System.Drawing.Size(18, 20);
            this.Dollar2.TabIndex = 2;
            this.Dollar2.Text = "$";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(43, 15);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(229, 46);
            this.info.TabIndex = 1;
            this.info.Text = "Please enter the desired\r\namount of money.";
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Amount
            // 
            this.Amount.BackColor = System.Drawing.SystemColors.Window;
            this.Amount.Cursor = System.Windows.Forms.Cursors.Default;
            this.Amount.Enabled = false;
            this.Amount.Location = new System.Drawing.Point(111, 88);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(100, 20);
            this.Amount.TabIndex = 0;
            this.Amount.TextChanged += new System.EventHandler(this.Amount_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.buttonCancel);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.buttonClear);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Controls.Add(this.buttonEnter);
            this.flowLayoutPanel1.Controls.Add(this.buttonN1);
            this.flowLayoutPanel1.Controls.Add(this.button0);
            this.flowLayoutPanel1.Controls.Add(this.buttonN2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(391, 85);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(315, 231);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Visible = false;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Button1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 52);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Button2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(81, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 52);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Button3;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(159, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 52);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ButtonCancel;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Location = new System.Drawing.Point(237, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(72, 52);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Button4;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(3, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 52);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Button5;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(81, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 52);
            this.button5.TabIndex = 12;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Button6;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(159, 61);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 52);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ButtonClear;
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Location = new System.Drawing.Point(237, 61);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(72, 52);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Button7;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(3, 119);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 52);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Button8;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(81, 119);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 52);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Button9;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Location = new System.Drawing.Point(159, 119);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 52);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ButtonEnter;
            this.buttonEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEnter.Location = new System.Drawing.Point(237, 119);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(72, 52);
            this.buttonEnter.TabIndex = 18;
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonN1
            // 
            this.buttonN1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Button;
            this.buttonN1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonN1.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonN1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonN1.Location = new System.Drawing.Point(3, 177);
            this.buttonN1.Name = "buttonN1";
            this.buttonN1.Size = new System.Drawing.Size(72, 52);
            this.buttonN1.TabIndex = 14;
            this.buttonN1.UseVisualStyleBackColor = true;
            this.buttonN1.Click += new System.EventHandler(this.buttonN1_Click);
            // 
            // button0
            // 
            this.button0.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Button0;
            this.button0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button0.Location = new System.Drawing.Point(81, 177);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(72, 52);
            this.button0.TabIndex = 13;
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonN2
            // 
            this.buttonN2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Button;
            this.buttonN2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonN2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonN2.Location = new System.Drawing.Point(159, 177);
            this.buttonN2.Name = "buttonN2";
            this.buttonN2.Size = new System.Drawing.Size(72, 52);
            this.buttonN2.TabIndex = 15;
            this.buttonN2.UseVisualStyleBackColor = true;
            this.buttonN2.Click += new System.EventHandler(this.buttonN2_Click);
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Button;
            this.buttonWithdraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWithdraw.Font = new System.Drawing.Font("Arial", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdraw.Location = new System.Drawing.Point(0, 286);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(53, 30);
            this.buttonWithdraw.TabIndex = 16;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdraw.Visible = false;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            // 
            // MoneyBox
            // 
            this.MoneyBox.BackColor = System.Drawing.Color.Transparent;
            this.MoneyBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoneyBox.Location = new System.Drawing.Point(40, 358);
            this.MoneyBox.Name = "MoneyBox";
            this.MoneyBox.Size = new System.Drawing.Size(364, 58);
            this.MoneyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoneyBox.TabIndex = 8;
            this.MoneyBox.TabStop = false;
            this.MoneyBox.Click += new System.EventHandler(this.MoneyBox_Click);
            // 
            // NrOfBills
            // 
            this.NrOfBills.BackColor = System.Drawing.Color.Transparent;
            this.NrOfBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrOfBills.Location = new System.Drawing.Point(502, 376);
            this.NrOfBills.Name = "NrOfBills";
            this.NrOfBills.Size = new System.Drawing.Size(164, 23);
            this.NrOfBills.TabIndex = 0;
            this.NrOfBills.Click += new System.EventHandler(this.NrOfBills_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Ascuns
            // 
            this.Ascuns.AutoSize = true;
            this.Ascuns.BackColor = System.Drawing.Color.Transparent;
            this.Ascuns.Location = new System.Drawing.Point(565, 42);
            this.Ascuns.Name = "Ascuns";
            this.Ascuns.Size = new System.Drawing.Size(0, 13);
            this.Ascuns.TabIndex = 17;
            this.Ascuns.Visible = false;
            this.Ascuns.Click += new System.EventHandler(this.Ascuns_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // goodbye
            // 
            this.goodbye.BackColor = System.Drawing.SystemColors.HotTrack;
            this.goodbye.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.goodbye.Controls.Add(this.pictureBox1);
            this.goodbye.Controls.Add(this.label2);
            this.goodbye.Controls.Add(this.label1);
            this.goodbye.Cursor = System.Windows.Forms.Cursors.Default;
            this.goodbye.Location = new System.Drawing.Point(59, 97);
            this.goodbye.Name = "goodbye";
            this.goodbye.Size = new System.Drawing.Size(326, 219);
            this.goodbye.TabIndex = 9;
            this.goodbye.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please take back\r\nyour card!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thank you for\r\nusing our bank!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._014_atm_cash_dispenser_machine_money_credit_card_insert_hand_5121;
            this.pictureBox1.Location = new System.Drawing.Point(207, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ATM
            // 
            this.AccessibleDescription = "ATM Application.";
            this.AccessibleName = "ATM";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ATM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 419);
            this.Controls.Add(this.goodbye);
            this.Controls.Add(this.Ascuns);
            this.Controls.Add(this.YourOption);
            this.Controls.Add(this.NrOfBills);
            this.Controls.Add(this.MoneyBox);
            this.Controls.Add(this.Cho);
            this.Controls.Add(this.panelWithdraw);
            this.Controls.Add(this.buttonWithdraw);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.Insert);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ATM";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.panelWithdraw.ResumeLayout(false);
            this.panelWithdraw.PerformLayout();
            this.Cho.ResumeLayout(false);
            this.YourOption.ResumeLayout(false);
            this.YourOption.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoneyBox)).EndInit();
            this.goodbye.ResumeLayout(false);
            this.goodbye.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel CardExample;
        private System.Windows.Forms.Label labelCard;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel Login;
        private System.Windows.Forms.Label labelPin;
        private System.Windows.Forms.MaskedTextBox PIN2;
        private System.Windows.Forms.MaskedTextBox PIN3;
        private System.Windows.Forms.MaskedTextBox PIN4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        protected System.Windows.Forms.MaskedTextBox PIN1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonN1;
        private System.Windows.Forms.Button buttonN2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Panel panelWithdraw;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.TextBox balBox;
        private System.Windows.Forms.Label Dollar;
        private System.Windows.Forms.Panel Cho;
        private System.Windows.Forms.Button money500;
        private System.Windows.Forms.Button money250;
        private System.Windows.Forms.Button money5;
        private System.Windows.Forms.Button money100;
        private System.Windows.Forms.Button money50;
        private System.Windows.Forms.Button Money10;
        private System.Windows.Forms.Button moneyCho;
        private System.Windows.Forms.PictureBox MoneyBox;
        private System.Windows.Forms.Label NrOfBills;
        private System.Windows.Forms.Panel YourOption;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label Dollar2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Ascuns;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel goodbye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

