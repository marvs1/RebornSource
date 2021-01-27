namespace MMReborn
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000061 RID: 97
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000062 RID: 98
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MMReborn.Form1));
			this.Casino = new global::System.Windows.Forms.TabControl();
			this.tabPageMain = new global::System.Windows.Forms.TabPage();
			this.lblNextEarnTime = new global::System.Windows.Forms.Label();
			this.lblCharName = new global::System.Windows.Forms.Label();
			this.txtEarnSpan = new global::System.Windows.Forms.TextBox();
			this.cbCaptchaLogin = new global::System.Windows.Forms.CheckBox();
			this.dtpLogOffTime = new global::System.Windows.Forms.DateTimePicker();
			this.txtCharName = new global::System.Windows.Forms.TextBox();
			this.btnLogin = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.lblEmail = new global::System.Windows.Forms.Label();
			this.txtPassword = new global::System.Windows.Forms.TextBox();
			this.txtEmail = new global::System.Windows.Forms.TextBox();
			this.btnStop = new global::System.Windows.Forms.Button();
			this.btnRefresh = new global::System.Windows.Forms.Button();
			this.geckoMain = new global::Gecko.GeckoWebBrowser();
			this.btnGo = new global::System.Windows.Forms.Button();
			this.tabPageEarn = new global::System.Windows.Forms.TabPage();
			this.lblForget = new global::System.Windows.Forms.Label();
			this.txtNumberToGenerate = new global::System.Windows.Forms.NumericUpDown();
			this.txtNumberToCheck = new global::System.Windows.Forms.NumericUpDown();
			this.btnEarnStop = new global::System.Windows.Forms.Button();
			this.lblEarn = new global::System.Windows.Forms.Label();
			this.txtEarnRandom = new global::System.Windows.Forms.ComboBox();
			this.lblEarnRandom = new global::System.Windows.Forms.Label();
			this.btnDW = new global::System.Windows.Forms.Button();
			this.lblEarnHeader = new global::System.Windows.Forms.Label();
			this.earnTxt = new global::System.Windows.Forms.RichTextBox();
			this.txtEarn = new global::System.Windows.Forms.ComboBox();
			this.btnEarn = new global::System.Windows.Forms.Button();
			this.tabPageCrime = new global::System.Windows.Forms.TabPage();
			this.chkBoxCrime = new global::System.Windows.Forms.CheckBox();
			this.txtCrime2 = new global::System.Windows.Forms.ComboBox();
			this.lblCrime2 = new global::System.Windows.Forms.Label();
			this.lblCrime1 = new global::System.Windows.Forms.Label();
			this.btnStopCrime = new global::System.Windows.Forms.Button();
			this.btnStartCrime = new global::System.Windows.Forms.Button();
			this.lblMessagePb = new global::System.Windows.Forms.Label();
			this.txtPBMessage = new global::System.Windows.Forms.TextBox();
			this.chkBoxPB = new global::System.Windows.Forms.CheckBox();
			this.lblMin = new global::System.Windows.Forms.Label();
			this.aggTxtWaitTime = new global::System.Windows.Forms.NumericUpDown();
			this.lblCrime = new global::System.Windows.Forms.Label();
			this.txtCrime = new global::System.Windows.Forms.ComboBox();
			this.lblCrimeHeader = new global::System.Windows.Forms.Label();
			this.aggTxt = new global::System.Windows.Forms.RichTextBox();
			this.tabPageCS = new global::System.Windows.Forms.TabPage();
			this.btnStopCS = new global::System.Windows.Forms.Button();
			this.csText = new global::System.Windows.Forms.RichTextBox();
			this.btnStartCS = new global::System.Windows.Forms.Button();
			this.txtCS = new global::System.Windows.Forms.ComboBox();
			this.lblCSHeader = new global::System.Windows.Forms.Label();
			this.tabPageDrug = new global::System.Windows.Forms.TabPage();
			this.btnStopDrug = new global::System.Windows.Forms.Button();
			this.btnStartDrug = new global::System.Windows.Forms.Button();
			this.lblDrug = new global::System.Windows.Forms.Label();
			this.drugTxt = new global::System.Windows.Forms.RichTextBox();
			this.tabPageJail = new global::System.Windows.Forms.TabPage();
			this.txtJailEarnRandom = new global::System.Windows.Forms.ComboBox();
			this.txtJailEarn = new global::System.Windows.Forms.ComboBox();
			this.jailGymTxt = new global::System.Windows.Forms.RichTextBox();
			this.jailEarnTxt = new global::System.Windows.Forms.RichTextBox();
			this.lblJailGymHeader = new global::System.Windows.Forms.Label();
			this.lblJailEarnHeader = new global::System.Windows.Forms.Label();
			this.btnStopJailGym = new global::System.Windows.Forms.Button();
			this.btnStartJailGym = new global::System.Windows.Forms.Button();
			this.btnStopJailEarn = new global::System.Windows.Forms.Button();
			this.btnStartJailEarn = new global::System.Windows.Forms.Button();
			this.tabPageCasino = new global::System.Windows.Forms.TabPage();
			this.btnStopCasino = new global::System.Windows.Forms.Button();
			this.btnStartCasino = new global::System.Windows.Forms.Button();
			this.casinoTxt = new global::System.Windows.Forms.RichTextBox();
			this.lblCasino = new global::System.Windows.Forms.Label();
			this.tabPageOther = new global::System.Windows.Forms.TabPage();
			this.lblProxyStatus = new global::System.Windows.Forms.Label();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.btnSetProxy = new global::System.Windows.Forms.Button();
			this.txtPort = new global::System.Windows.Forms.TextBox();
			this.txtProxy = new global::System.Windows.Forms.TextBox();
			this.lblProxyHeader = new global::System.Windows.Forms.Label();
			this.lblPort = new global::System.Windows.Forms.Label();
			this.lblProxy = new global::System.Windows.Forms.Label();
			this.tabPageGeckoEarn = new global::System.Windows.Forms.TabPage();
			this.geckoEarn = new global::Gecko.GeckoWebBrowser();
			this.tabPageGeckoCrime = new global::System.Windows.Forms.TabPage();
			this.geckoCrime = new global::Gecko.GeckoWebBrowser();
			this.tabPageGeckoOther = new global::System.Windows.Forms.TabPage();
			this.geckoOther = new global::Gecko.GeckoWebBrowser();
			this.tabPageGeckoCasino = new global::System.Windows.Forms.TabPage();
			this.geckoCasino = new global::Gecko.GeckoWebBrowser();
			this.earnTimer = new global::System.Windows.Forms.Timer(this.components);
			this.drugTimer = new global::System.Windows.Forms.Timer(this.components);
			this.aggTimer = new global::System.Windows.Forms.Timer(this.components);
			this.csTimer = new global::System.Windows.Forms.Timer(this.components);
			this.repairTimer = new global::System.Windows.Forms.Timer(this.components);
			this.dilligentTimer = new global::System.Windows.Forms.Timer(this.components);
			this.bizTimer = new global::System.Windows.Forms.Timer(this.components);
			this.jailEarnTimer = new global::System.Windows.Forms.Timer(this.components);
			this.jailGymTimer = new global::System.Windows.Forms.Timer(this.components);
			this.bmTimer = new global::System.Windows.Forms.Timer(this.components);
			this.paybackTimer = new global::System.Windows.Forms.Timer(this.components);
			this.relogTimer = new global::System.Windows.Forms.Timer(this.components);
			this.txtLastAction = new global::System.Windows.Forms.TextBox();
			this.lblLastAction = new global::System.Windows.Forms.Label();
			this.txtMainURL = new global::System.Windows.Forms.TextBox();
			this.Casino.SuspendLayout();
			this.tabPageMain.SuspendLayout();
			this.tabPageEarn.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.txtNumberToGenerate).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtNumberToCheck).BeginInit();
			this.tabPageCrime.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.aggTxtWaitTime).BeginInit();
			this.tabPageCS.SuspendLayout();
			this.tabPageDrug.SuspendLayout();
			this.tabPageJail.SuspendLayout();
			this.tabPageCasino.SuspendLayout();
			this.tabPageOther.SuspendLayout();
			this.tabPageGeckoEarn.SuspendLayout();
			this.tabPageGeckoCrime.SuspendLayout();
			this.tabPageGeckoOther.SuspendLayout();
			this.tabPageGeckoCasino.SuspendLayout();
			base.SuspendLayout();
			this.Casino.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.Casino.Controls.Add(this.tabPageMain);
			this.Casino.Controls.Add(this.tabPageEarn);
			this.Casino.Controls.Add(this.tabPageCrime);
			this.Casino.Controls.Add(this.tabPageCS);
			this.Casino.Controls.Add(this.tabPageDrug);
			this.Casino.Controls.Add(this.tabPageJail);
			this.Casino.Controls.Add(this.tabPageCasino);
			this.Casino.Controls.Add(this.tabPageOther);
			this.Casino.Controls.Add(this.tabPageGeckoEarn);
			this.Casino.Controls.Add(this.tabPageGeckoCrime);
			this.Casino.Controls.Add(this.tabPageGeckoOther);
			this.Casino.Controls.Add(this.tabPageGeckoCasino);
			this.Casino.Location = new global::System.Drawing.Point(-1, -1);
			this.Casino.Name = "Casino";
			this.Casino.SelectedIndex = 0;
			this.Casino.Size = new global::System.Drawing.Size(1063, 638);
			this.Casino.TabIndex = 0;
			this.tabPageMain.Controls.Add(this.txtMainURL);
			this.tabPageMain.Controls.Add(this.lblLastAction);
			this.tabPageMain.Controls.Add(this.txtLastAction);
			this.tabPageMain.Controls.Add(this.lblNextEarnTime);
			this.tabPageMain.Controls.Add(this.lblCharName);
			this.tabPageMain.Controls.Add(this.txtEarnSpan);
			this.tabPageMain.Controls.Add(this.cbCaptchaLogin);
			this.tabPageMain.Controls.Add(this.dtpLogOffTime);
			this.tabPageMain.Controls.Add(this.txtCharName);
			this.tabPageMain.Controls.Add(this.btnLogin);
			this.tabPageMain.Controls.Add(this.label1);
			this.tabPageMain.Controls.Add(this.lblEmail);
			this.tabPageMain.Controls.Add(this.txtPassword);
			this.tabPageMain.Controls.Add(this.txtEmail);
			this.tabPageMain.Controls.Add(this.btnStop);
			this.tabPageMain.Controls.Add(this.btnRefresh);
			this.tabPageMain.Controls.Add(this.geckoMain);
			this.tabPageMain.Controls.Add(this.btnGo);
			this.tabPageMain.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageMain.Name = "tabPageMain";
			this.tabPageMain.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageMain.Size = new global::System.Drawing.Size(1055, 612);
			this.tabPageMain.TabIndex = 0;
			this.tabPageMain.Text = "Main";
			this.tabPageMain.UseVisualStyleBackColor = true;
			this.lblNextEarnTime.AutoSize = true;
			this.lblNextEarnTime.Location = new global::System.Drawing.Point(648, 47);
			this.lblNextEarnTime.Name = "lblNextEarnTime";
			this.lblNextEarnTime.Size = new global::System.Drawing.Size(80, 13);
			this.lblNextEarnTime.TabIndex = 18;
			this.lblNextEarnTime.Text = "Next Earn Time";
			this.lblCharName.AutoSize = true;
			this.lblCharName.Location = new global::System.Drawing.Point(869, 49);
			this.lblCharName.Name = "lblCharName";
			this.lblCharName.Size = new global::System.Drawing.Size(60, 13);
			this.lblCharName.TabIndex = 17;
			this.lblCharName.Text = "Char Name";
			this.txtEarnSpan.Location = new global::System.Drawing.Point(734, 44);
			this.txtEarnSpan.Name = "txtEarnSpan";
			this.txtEarnSpan.ReadOnly = true;
			this.txtEarnSpan.Size = new global::System.Drawing.Size(129, 20);
			this.txtEarnSpan.TabIndex = 16;
			this.cbCaptchaLogin.AutoSize = true;
			this.cbCaptchaLogin.Checked = true;
			this.cbCaptchaLogin.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.cbCaptchaLogin.Location = new global::System.Drawing.Point(7, 46);
			this.cbCaptchaLogin.Name = "cbCaptchaLogin";
			this.cbCaptchaLogin.Size = new global::System.Drawing.Size(95, 17);
			this.cbCaptchaLogin.TabIndex = 14;
			this.cbCaptchaLogin.Text = "Captcha Login";
			this.cbCaptchaLogin.UseVisualStyleBackColor = true;
			this.dtpLogOffTime.CustomFormat = "MMMMdd, yyyy  |  hh:mm tt";
			this.dtpLogOffTime.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpLogOffTime.Location = new global::System.Drawing.Point(853, 9);
			this.dtpLogOffTime.Name = "dtpLogOffTime";
			this.dtpLogOffTime.Size = new global::System.Drawing.Size(194, 20);
			this.dtpLogOffTime.TabIndex = 13;
			this.txtCharName.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtCharName.Location = new global::System.Drawing.Point(935, 42);
			this.txtCharName.Name = "txtCharName";
			this.txtCharName.ReadOnly = true;
			this.txtCharName.Size = new global::System.Drawing.Size(100, 20);
			this.txtCharName.TabIndex = 12;
			this.btnLogin.Location = new global::System.Drawing.Point(698, 6);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new global::System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 11;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new global::System.EventHandler(this.btnLogin_Click);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(461, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(56, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Password:";
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new global::System.Drawing.Point(249, 9);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new global::System.Drawing.Size(35, 13);
			this.lblEmail.TabIndex = 9;
			this.lblEmail.Text = "Email:";
			this.txtPassword.Location = new global::System.Drawing.Point(518, 5);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new global::System.Drawing.Size(173, 20);
			this.txtPassword.TabIndex = 8;
			this.txtEmail.Location = new global::System.Drawing.Point(286, 6);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new global::System.Drawing.Size(173, 20);
			this.txtEmail.TabIndex = 7;
			this.btnStop.Location = new global::System.Drawing.Point(169, 6);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new global::System.Drawing.Size(75, 23);
			this.btnStop.TabIndex = 5;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new global::System.EventHandler(this.btnStop_Click);
			this.btnRefresh.Location = new global::System.Drawing.Point(88, 6);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new global::System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 1;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new global::System.EventHandler(this.btnRefresh_Click);
			this.geckoMain.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.geckoMain.Enabled = false;
			this.geckoMain.Location = new global::System.Drawing.Point(4, 72);
			this.geckoMain.Name = "geckoMain";
			this.geckoMain.Size = new global::System.Drawing.Size(1051, 545);
			this.geckoMain.TabIndex = 2;
			this.geckoMain.UseHttpActivityObserver = false;
			this.geckoMain.DocumentCompleted += new global::System.EventHandler<global::Gecko.Events.GeckoDocumentCompletedEventArgs>(this.geckoMain_DocumentCompleted);
			this.btnGo.Location = new global::System.Drawing.Point(7, 7);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new global::System.Drawing.Size(75, 23);
			this.btnGo.TabIndex = 1;
			this.btnGo.Text = "Go";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new global::System.EventHandler(this.btnGo_Click);
			this.tabPageEarn.Controls.Add(this.lblForget);
			this.tabPageEarn.Controls.Add(this.txtNumberToGenerate);
			this.tabPageEarn.Controls.Add(this.txtNumberToCheck);
			this.tabPageEarn.Controls.Add(this.btnEarnStop);
			this.tabPageEarn.Controls.Add(this.lblEarn);
			this.tabPageEarn.Controls.Add(this.txtEarnRandom);
			this.tabPageEarn.Controls.Add(this.lblEarnRandom);
			this.tabPageEarn.Controls.Add(this.btnDW);
			this.tabPageEarn.Controls.Add(this.lblEarnHeader);
			this.tabPageEarn.Controls.Add(this.earnTxt);
			this.tabPageEarn.Controls.Add(this.txtEarn);
			this.tabPageEarn.Controls.Add(this.btnEarn);
			this.tabPageEarn.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageEarn.Name = "tabPageEarn";
			this.tabPageEarn.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageEarn.Size = new global::System.Drawing.Size(1055, 612);
			this.tabPageEarn.TabIndex = 1;
			this.tabPageEarn.Text = "Earning";
			this.tabPageEarn.UseVisualStyleBackColor = true;
			this.lblForget.AutoSize = true;
			this.lblForget.Location = new global::System.Drawing.Point(657, 8);
			this.lblForget.Name = "lblForget";
			this.lblForget.Size = new global::System.Drawing.Size(218, 13);
			this.lblForget.TabIndex = 18;
			this.lblForget.Text = "Forget Parameter : - To Check/ To Generate";
			this.txtNumberToGenerate.Location = new global::System.Drawing.Point(927, 6);
			this.txtNumberToGenerate.Name = "txtNumberToGenerate";
			this.txtNumberToGenerate.Size = new global::System.Drawing.Size(40, 20);
			this.txtNumberToGenerate.TabIndex = 17;
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.txtNumberToGenerate;
			int[] array = new int[4];
			array[0] = 15;
			numericUpDown.Value = new decimal(array);
			this.txtNumberToCheck.Location = new global::System.Drawing.Point(881, 6);
			this.txtNumberToCheck.Name = "txtNumberToCheck";
			this.txtNumberToCheck.Size = new global::System.Drawing.Size(40, 20);
			this.txtNumberToCheck.TabIndex = 16;
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.txtNumberToCheck;
			int[] array2 = new int[4];
			array2[0] = 6;
			numericUpDown2.Value = new decimal(array2);
			this.btnEarnStop.Location = new global::System.Drawing.Point(551, 60);
			this.btnEarnStop.Name = "btnEarnStop";
			this.btnEarnStop.Size = new global::System.Drawing.Size(75, 23);
			this.btnEarnStop.TabIndex = 14;
			this.btnEarnStop.Text = "Stop";
			this.btnEarnStop.UseVisualStyleBackColor = true;
			this.btnEarnStop.Click += new global::System.EventHandler(this.btnEarnStop_Click);
			this.lblEarn.AutoSize = true;
			this.lblEarn.Location = new global::System.Drawing.Point(14, 61);
			this.lblEarn.Name = "lblEarn";
			this.lblEarn.Size = new global::System.Drawing.Size(29, 13);
			this.lblEarn.TabIndex = 13;
			this.lblEarn.Text = "Earn";
			this.txtEarnRandom.FormattingEnabled = true;
			this.txtEarnRandom.Items.AddRange(new object[]
			{
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"10"
			});
			this.txtEarnRandom.Location = new global::System.Drawing.Point(343, 61);
			this.txtEarnRandom.Name = "txtEarnRandom";
			this.txtEarnRandom.Size = new global::System.Drawing.Size(121, 21);
			this.txtEarnRandom.TabIndex = 12;
			this.lblEarnRandom.AutoSize = true;
			this.lblEarnRandom.Location = new global::System.Drawing.Point(259, 65);
			this.lblEarnRandom.Name = "lblEarnRandom";
			this.lblEarnRandom.Size = new global::System.Drawing.Size(80, 13);
			this.lblEarnRandom.TabIndex = 11;
			this.lblEarnRandom.Text = "Random Factor";
			this.btnDW.Location = new global::System.Drawing.Point(632, 59);
			this.btnDW.Name = "btnDW";
			this.btnDW.Size = new global::System.Drawing.Size(75, 23);
			this.btnDW.TabIndex = 9;
			this.btnDW.Text = "DW";
			this.btnDW.UseVisualStyleBackColor = true;
			this.btnDW.Click += new global::System.EventHandler(this.btnDW_Click);
			this.lblEarnHeader.AutoSize = true;
			this.lblEarnHeader.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 24f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblEarnHeader.Location = new global::System.Drawing.Point(10, 17);
			this.lblEarnHeader.Name = "lblEarnHeader";
			this.lblEarnHeader.Size = new global::System.Drawing.Size(89, 37);
			this.lblEarnHeader.TabIndex = 8;
			this.lblEarnHeader.Text = "Earn";
			this.earnTxt.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.earnTxt.Location = new global::System.Drawing.Point(9, 84);
			this.earnTxt.Name = "earnTxt";
			this.earnTxt.Size = new global::System.Drawing.Size(1038, 498);
			this.earnTxt.TabIndex = 7;
			this.earnTxt.Text = "";
			this.txtEarn.FormattingEnabled = true;
			this.txtEarn.Items.AddRange(new object[]
			{
				"Pizza",
				"711",
				"Bar",
				"Whore",
				"Pimp",
				"Joyride",
				"Streetfight",
				"Shoplift",
				"Cheques",
				"Drags",
				"Hack",
				"Scam",
				"Nurse",
				"Doctor",
				"Surgeon",
				"Hospital Director",
				"Mechanic",
				"Technician",
				"Engineer",
				"Chief Engineer",
				"Inspector",
				"Supervisor",
				"Superintendent",
				"Commissioner-General",
				"Volunteer Fire Fighter",
				"Fire Fighter",
				"Fire Chief",
				"Bank Teller",
				"Loan Officer",
				"Bank Manager",
				"Mort Assistant",
				"Mortician",
				"Undertaker",
				"Funeral Director",
				"Legal Secretary",
				"Lawyer",
				"Judge",
				"SC Judge",
				"Patrol",
				"Paper Work",
				"Arrest Criminals",
				"Commissioner",
				"Training Drills",
				"Weapons Training",
				"National Guard",
				"Operations Planning",
				"Commander",
				"Mayor",
				"Editor"
			});
			this.txtEarn.Location = new global::System.Drawing.Point(44, 60);
			this.txtEarn.Name = "txtEarn";
			this.txtEarn.Size = new global::System.Drawing.Size(212, 21);
			this.txtEarn.TabIndex = 6;
			this.btnEarn.Location = new global::System.Drawing.Point(470, 61);
			this.btnEarn.Name = "btnEarn";
			this.btnEarn.Size = new global::System.Drawing.Size(75, 23);
			this.btnEarn.TabIndex = 5;
			this.btnEarn.Text = "Start";
			this.btnEarn.UseVisualStyleBackColor = true;
			this.btnEarn.Click += new global::System.EventHandler(this.btnEarn_Click);
			this.tabPageCrime.Controls.Add(this.chkBoxCrime);
			this.tabPageCrime.Controls.Add(this.txtCrime2);
			this.tabPageCrime.Controls.Add(this.lblCrime2);
			this.tabPageCrime.Controls.Add(this.lblCrime1);
			this.tabPageCrime.Controls.Add(this.btnStopCrime);
			this.tabPageCrime.Controls.Add(this.btnStartCrime);
			this.tabPageCrime.Controls.Add(this.lblMessagePb);
			this.tabPageCrime.Controls.Add(this.txtPBMessage);
			this.tabPageCrime.Controls.Add(this.chkBoxPB);
			this.tabPageCrime.Controls.Add(this.lblMin);
			this.tabPageCrime.Controls.Add(this.aggTxtWaitTime);
			this.tabPageCrime.Controls.Add(this.lblCrime);
			this.tabPageCrime.Controls.Add(this.txtCrime);
			this.tabPageCrime.Controls.Add(this.lblCrimeHeader);
			this.tabPageCrime.Controls.Add(this.aggTxt);
			this.tabPageCrime.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageCrime.Name = "tabPageCrime";
			this.tabPageCrime.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageCrime.Size = new global::System.Drawing.Size(1055, 612);
			this.tabPageCrime.TabIndex = 2;
			this.tabPageCrime.Text = "Crime";
			this.tabPageCrime.UseVisualStyleBackColor = true;
			this.chkBoxCrime.AutoSize = true;
			this.chkBoxCrime.Location = new global::System.Drawing.Point(418, 52);
			this.chkBoxCrime.Name = "chkBoxCrime";
			this.chkBoxCrime.Size = new global::System.Drawing.Size(15, 14);
			this.chkBoxCrime.TabIndex = 17;
			this.chkBoxCrime.UseVisualStyleBackColor = true;
			this.chkBoxCrime.CheckedChanged += new global::System.EventHandler(this.chkBoxCrime_CheckedChanged);
			this.txtCrime2.FormattingEnabled = true;
			this.txtCrime2.Items.AddRange(new object[]
			{
				"pickpocket",
				"mugging",
				"breaking",
				"hack",
				"armed",
				"torchb"
			});
			this.txtCrime2.Location = new global::System.Drawing.Point(291, 48);
			this.txtCrime2.Name = "txtCrime2";
			this.txtCrime2.Size = new global::System.Drawing.Size(121, 21);
			this.txtCrime2.TabIndex = 16;
			this.lblCrime2.AutoSize = true;
			this.lblCrime2.Location = new global::System.Drawing.Point(257, 52);
			this.lblCrime2.Name = "lblCrime2";
			this.lblCrime2.Size = new global::System.Drawing.Size(28, 13);
			this.lblCrime2.TabIndex = 15;
			this.lblCrime2.Text = "2nd:";
			this.lblCrime1.AutoSize = true;
			this.lblCrime1.Location = new global::System.Drawing.Point(90, 52);
			this.lblCrime1.Name = "lblCrime1";
			this.lblCrime1.Size = new global::System.Drawing.Size(24, 13);
			this.lblCrime1.TabIndex = 14;
			this.lblCrime1.Text = "1st:";
			this.btnStopCrime.Location = new global::System.Drawing.Point(953, 47);
			this.btnStopCrime.Name = "btnStopCrime";
			this.btnStopCrime.Size = new global::System.Drawing.Size(75, 23);
			this.btnStopCrime.TabIndex = 13;
			this.btnStopCrime.Text = "Stop";
			this.btnStopCrime.UseVisualStyleBackColor = true;
			this.btnStopCrime.Click += new global::System.EventHandler(this.btnStopCrime_Click);
			this.btnStartCrime.Location = new global::System.Drawing.Point(872, 47);
			this.btnStartCrime.Name = "btnStartCrime";
			this.btnStartCrime.Size = new global::System.Drawing.Size(75, 23);
			this.btnStartCrime.TabIndex = 12;
			this.btnStartCrime.Text = "Start";
			this.btnStartCrime.UseVisualStyleBackColor = true;
			this.btnStartCrime.Click += new global::System.EventHandler(this.btnStartCrime_Click);
			this.lblMessagePb.AutoSize = true;
			this.lblMessagePb.Location = new global::System.Drawing.Point(707, 52);
			this.lblMessagePb.Name = "lblMessagePb";
			this.lblMessagePb.Size = new global::System.Drawing.Size(53, 13);
			this.lblMessagePb.TabIndex = 11;
			this.lblMessagePb.Text = "Message:";
			this.txtPBMessage.Location = new global::System.Drawing.Point(766, 49);
			this.txtPBMessage.Name = "txtPBMessage";
			this.txtPBMessage.Size = new global::System.Drawing.Size(100, 20);
			this.txtPBMessage.TabIndex = 10;
			this.chkBoxPB.AutoSize = true;
			this.chkBoxPB.Location = new global::System.Drawing.Point(591, 50);
			this.chkBoxPB.Name = "chkBoxPB";
			this.chkBoxPB.Size = new global::System.Drawing.Size(110, 17);
			this.chkBoxPB.TabIndex = 9;
			this.chkBoxPB.Text = "Auto PP Payback";
			this.chkBoxPB.UseVisualStyleBackColor = true;
			this.chkBoxPB.CheckedChanged += new global::System.EventHandler(this.chkBoxPB_CheckedChanged);
			this.lblMin.AutoSize = true;
			this.lblMin.Location = new global::System.Drawing.Point(444, 51);
			this.lblMin.Name = "lblMin";
			this.lblMin.Size = new global::System.Drawing.Size(95, 13);
			this.lblMin.TabIndex = 8;
			this.lblMin.Text = "Waiting Time(Min):";
			this.aggTxtWaitTime.Location = new global::System.Drawing.Point(545, 48);
			this.aggTxtWaitTime.Name = "aggTxtWaitTime";
			this.aggTxtWaitTime.Size = new global::System.Drawing.Size(40, 20);
			this.aggTxtWaitTime.TabIndex = 7;
			this.lblCrime.AutoSize = true;
			this.lblCrime.Location = new global::System.Drawing.Point(21, 52);
			this.lblCrime.Name = "lblCrime";
			this.lblCrime.Size = new global::System.Drawing.Size(66, 13);
			this.lblCrime.TabIndex = 6;
			this.lblCrime.Text = "Crime Type -";
			this.txtCrime.FormattingEnabled = true;
			this.txtCrime.Items.AddRange(new object[]
			{
				"pickpocket",
				"mugging",
				"breaking",
				"hack",
				"armed",
				"torchb"
			});
			this.txtCrime.Location = new global::System.Drawing.Point(120, 48);
			this.txtCrime.Name = "txtCrime";
			this.txtCrime.Size = new global::System.Drawing.Size(121, 21);
			this.txtCrime.TabIndex = 5;
			this.lblCrimeHeader.AutoSize = true;
			this.lblCrimeHeader.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 21.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCrimeHeader.Location = new global::System.Drawing.Point(9, 13);
			this.lblCrimeHeader.Name = "lblCrimeHeader";
			this.lblCrimeHeader.Size = new global::System.Drawing.Size(99, 33);
			this.lblCrimeHeader.TabIndex = 4;
			this.lblCrimeHeader.Text = "Crime";
			this.aggTxt.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.aggTxt.Location = new global::System.Drawing.Point(6, 76);
			this.aggTxt.Name = "aggTxt";
			this.aggTxt.Size = new global::System.Drawing.Size(1041, 474);
			this.aggTxt.TabIndex = 3;
			this.aggTxt.Text = "";
			this.tabPageCS.Controls.Add(this.btnStopCS);
			this.tabPageCS.Controls.Add(this.csText);
			this.tabPageCS.Controls.Add(this.btnStartCS);
			this.tabPageCS.Controls.Add(this.txtCS);
			this.tabPageCS.Controls.Add(this.lblCSHeader);
			this.tabPageCS.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageCS.Name = "tabPageCS";
			this.tabPageCS.Size = new global::System.Drawing.Size(1055, 612);
			this.tabPageCS.TabIndex = 5;
			this.tabPageCS.Text = "Community Service";
			this.tabPageCS.UseVisualStyleBackColor = true;
			this.btnStopCS.Location = new global::System.Drawing.Point(384, 58);
			this.btnStopCS.Name = "btnStopCS";
			this.btnStopCS.Size = new global::System.Drawing.Size(75, 23);
			this.btnStopCS.TabIndex = 7;
			this.btnStopCS.Text = "Stop";
			this.btnStopCS.UseVisualStyleBackColor = true;
			this.btnStopCS.Click += new global::System.EventHandler(this.btnStopCS_Click);
			this.csText.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.csText.Location = new global::System.Drawing.Point(15, 87);
			this.csText.Name = "csText";
			this.csText.Size = new global::System.Drawing.Size(1032, 471);
			this.csText.TabIndex = 6;
			this.csText.Text = "";
			this.btnStartCS.Location = new global::System.Drawing.Point(303, 58);
			this.btnStartCS.Name = "btnStartCS";
			this.btnStartCS.Size = new global::System.Drawing.Size(75, 23);
			this.btnStartCS.TabIndex = 2;
			this.btnStartCS.Text = "Start";
			this.btnStartCS.UseVisualStyleBackColor = true;
			this.btnStartCS.Click += new global::System.EventHandler(this.btnStartCS_Click);
			this.txtCS.FormattingEnabled = true;
			this.txtCS.Items.AddRange(new object[]
			{
				"gum",
				"tags",
				"weeding",
				"kids",
				"pamphlets",
				"delivery",
				"football",
				"suspect",
				"reading",
				"law_oot"
			});
			this.txtCS.Location = new global::System.Drawing.Point(15, 58);
			this.txtCS.Name = "txtCS";
			this.txtCS.Size = new global::System.Drawing.Size(281, 21);
			this.txtCS.TabIndex = 1;
			this.lblCSHeader.AutoSize = true;
			this.lblCSHeader.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 21.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCSHeader.Location = new global::System.Drawing.Point(9, 12);
			this.lblCSHeader.Name = "lblCSHeader";
			this.lblCSHeader.Size = new global::System.Drawing.Size(287, 33);
			this.lblCSHeader.TabIndex = 0;
			this.lblCSHeader.Text = "Community Service";
			this.tabPageDrug.Controls.Add(this.btnStopDrug);
			this.tabPageDrug.Controls.Add(this.btnStartDrug);
			this.tabPageDrug.Controls.Add(this.lblDrug);
			this.tabPageDrug.Controls.Add(this.drugTxt);
			this.tabPageDrug.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageDrug.Name = "tabPageDrug";
			this.tabPageDrug.Size = new global::System.Drawing.Size(1055, 612);
			this.tabPageDrug.TabIndex = 6;
			this.tabPageDrug.Text = "Drug";
			this.tabPageDrug.UseVisualStyleBackColor = true;
			this.btnStopDrug.Location = new global::System.Drawing.Point(96, 54);
			this.btnStopDrug.Name = "btnStopDrug";
			this.btnStopDrug.Size = new global::System.Drawing.Size(75, 23);
			this.btnStopDrug.TabIndex = 5;
			this.btnStopDrug.Text = "Stop";
			this.btnStopDrug.UseVisualStyleBackColor = true;
			this.btnStopDrug.Click += new global::System.EventHandler(this.btnStopDrug_Click);
			this.btnStartDrug.Location = new global::System.Drawing.Point(15, 54);
			this.btnStartDrug.Name = "btnStartDrug";
			this.btnStartDrug.Size = new global::System.Drawing.Size(75, 23);
			this.btnStartDrug.TabIndex = 4;
			this.btnStartDrug.Text = "Start";
			this.btnStartDrug.UseVisualStyleBackColor = true;
			this.btnStartDrug.Click += new global::System.EventHandler(this.btnStartDrug_Click);
			this.lblDrug.AutoSize = true;
			this.lblDrug.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 21.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblDrug.Location = new global::System.Drawing.Point(9, 10);
			this.lblDrug.Name = "lblDrug";
			this.lblDrug.Size = new global::System.Drawing.Size(82, 33);
			this.lblDrug.TabIndex = 3;
			this.lblDrug.Text = "Drug";
			this.drugTxt.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.drugTxt.BackColor = global::System.Drawing.SystemColors.Window;
			this.drugTxt.Location = new global::System.Drawing.Point(3, 83);
			this.drugTxt.Name = "drugTxt";
			this.drugTxt.Size = new global::System.Drawing.Size(1049, 467);
			this.drugTxt.TabIndex = 2;
			this.drugTxt.Text = "";
			this.tabPageJail.Controls.Add(this.txtJailEarnRandom);
			this.tabPageJail.Controls.Add(this.txtJailEarn);
			this.tabPageJail.Controls.Add(this.jailGymTxt);
			this.tabPageJail.Controls.Add(this.jailEarnTxt);
			this.tabPageJail.Controls.Add(this.lblJailGymHeader);
			this.tabPageJail.Controls.Add(this.lblJailEarnHeader);
			this.tabPageJail.Controls.Add(this.btnStopJailGym);
			this.tabPageJail.Controls.Add(this.btnStartJailGym);
			this.tabPageJail.Controls.Add(this.btnStopJailEarn);
			this.tabPageJail.Controls.Add(this.btnStartJailEarn);
			this.tabPageJail.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageJail.Name = "tabPageJail";
			this.tabPageJail.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageJail.Size = new global::System.Drawing.Size(1055, 612);
			this.tabPageJail.TabIndex = 9;
			this.tabPageJail.Text = "Jail";
			this.tabPageJail.UseVisualStyleBackColor = true;
			this.txtJailEarnRandom.FormattingEnabled = true;
			this.txtJailEarnRandom.Items.AddRange(new object[]
			{
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"10"
			});
			this.txtJailEarnRandom.Location = new global::System.Drawing.Point(153, 74);
			this.txtJailEarnRandom.Name = "txtJailEarnRandom";
			this.txtJailEarnRandom.Size = new global::System.Drawing.Size(92, 21);
			this.txtJailEarnRandom.TabIndex = 13;
			this.txtJailEarn.FormattingEnabled = true;
			this.txtJailEarn.Items.AddRange(new object[]
			{
				"laundry",
				"kitchen",
				"workshop",
				"makeshank"
			});
			this.txtJailEarn.Location = new global::System.Drawing.Point(19, 74);
			this.txtJailEarn.Name = "txtJailEarn";
			this.txtJailEarn.Size = new global::System.Drawing.Size(128, 21);
			this.txtJailEarn.TabIndex = 8;
			this.jailGymTxt.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom);
			this.jailGymTxt.Location = new global::System.Drawing.Point(631, 103);
			this.jailGymTxt.Name = "jailGymTxt";
			this.jailGymTxt.Size = new global::System.Drawing.Size(398, 509);
			this.jailGymTxt.TabIndex = 7;
			this.jailGymTxt.Text = "";
			this.jailEarnTxt.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.jailEarnTxt.Location = new global::System.Drawing.Point(19, 103);
			this.jailEarnTxt.Name = "jailEarnTxt";
			this.jailEarnTxt.Size = new global::System.Drawing.Size(398, 509);
			this.jailEarnTxt.TabIndex = 6;
			this.jailEarnTxt.Text = "";
			this.lblJailGymHeader.AutoSize = true;
			this.lblJailGymHeader.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 21.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblJailGymHeader.Location = new global::System.Drawing.Point(625, 19);
			this.lblJailGymHeader.Name = "lblJailGymHeader";
			this.lblJailGymHeader.Size = new global::System.Drawing.Size(139, 33);
			this.lblJailGymHeader.TabIndex = 5;
			this.lblJailGymHeader.Text = "Jail Gym";
			this.lblJailEarnHeader.AutoSize = true;
			this.lblJailEarnHeader.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 21.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblJailEarnHeader.Location = new global::System.Drawing.Point(13, 19);
			this.lblJailEarnHeader.Name = "lblJailEarnHeader";
			this.lblJailEarnHeader.Size = new global::System.Drawing.Size(138, 33);
			this.lblJailEarnHeader.TabIndex = 4;
			this.lblJailEarnHeader.Text = "Jail Earn";
			this.btnStopJailGym.Location = new global::System.Drawing.Point(954, 72);
			this.btnStopJailGym.Name = "btnStopJailGym";
			this.btnStopJailGym.Size = new global::System.Drawing.Size(75, 23);
			this.btnStopJailGym.TabIndex = 3;
			this.btnStopJailGym.Text = "Stop";
			this.btnStopJailGym.UseVisualStyleBackColor = true;
			this.btnStopJailGym.Click += new global::System.EventHandler(this.btnStopJailGym_Click);
			this.btnStartJailGym.Location = new global::System.Drawing.Point(873, 72);
			this.btnStartJailGym.Name = "btnStartJailGym";
			this.btnStartJailGym.Size = new global::System.Drawing.Size(75, 23);
			this.btnStartJailGym.TabIndex = 2;
			this.btnStartJailGym.Text = "Start";
			this.btnStartJailGym.UseVisualStyleBackColor = true;
			this.btnStartJailGym.Click += new global::System.EventHandler(this.btnStartJailGym_Click);
			this.btnStopJailEarn.Location = new global::System.Drawing.Point(332, 74);
			this.btnStopJailEarn.Name = "btnStopJailEarn";
			this.btnStopJailEarn.Size = new global::System.Drawing.Size(75, 23);
			this.btnStopJailEarn.TabIndex = 1;
			this.btnStopJailEarn.Text = "Stop";
			this.btnStopJailEarn.UseVisualStyleBackColor = true;
			this.btnStopJailEarn.Click += new global::System.EventHandler(this.btnStopJailEarn_Click);
			this.btnStartJailEarn.Location = new global::System.Drawing.Point(251, 74);
			this.btnStartJailEarn.Name = "btnStartJailEarn";
			this.btnStartJailEarn.Size = new global::System.Drawing.Size(75, 23);
			this.btnStartJailEarn.TabIndex = 0;
			this.btnStartJailEarn.Text = "Start";
			this.btnStartJailEarn.UseVisualStyleBackColor = true;
			this.btnStartJailEarn.Click += new global::System.EventHandler(this.btnStartJailEarn_Click);
			this.tabPageCasino.Controls.Add(this.btnStopCasino);
			this.tabPageCasino.Controls.Add(this.btnStartCasino);
			this.tabPageCasino.Controls.Add(this.casinoTxt);
			this.tabPageCasino.Controls.Add(this.lblCasino);
			this.tabPageCasino.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageCasino.Name = "tabPageCasino";
			this.tabPageCasino.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageCasino.Size = new global::System.Drawing.Size(1055, 612);
			this.tabPageCasino.TabIndex = 11;
			this.tabPageCasino.Text = "Casino";
			this.tabPageCasino.UseVisualStyleBackColor = true;
			this.btnStopCasino.Location = new global::System.Drawing.Point(96, 60);
			this.btnStopCasino.Name = "btnStopCasino";
			this.btnStopCasino.Size = new global::System.Drawing.Size(75, 23);
			this.btnStopCasino.TabIndex = 4;
			this.btnStopCasino.Text = "Stop";
			this.btnStopCasino.UseVisualStyleBackColor = true;
			this.btnStopCasino.Click += new global::System.EventHandler(this.btnStopCasino_Click);
			this.btnStartCasino.Location = new global::System.Drawing.Point(15, 60);
			this.btnStartCasino.Name = "btnStartCasino";
			this.btnStartCasino.Size = new global::System.Drawing.Size(75, 23);
			this.btnStartCasino.TabIndex = 3;
			this.btnStartCasino.Text = "Start";
			this.btnStartCasino.UseVisualStyleBackColor = true;
			this.btnStartCasino.Click += new global::System.EventHandler(this.btnStartCasino_Click);
			this.casinoTxt.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.casinoTxt.Location = new global::System.Drawing.Point(0, 99);
			this.casinoTxt.Name = "casinoTxt";
			this.casinoTxt.Size = new global::System.Drawing.Size(1055, 513);
			this.casinoTxt.TabIndex = 2;
			this.casinoTxt.Text = "";
			this.lblCasino.AutoSize = true;
			this.lblCasino.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 21.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCasino.Location = new global::System.Drawing.Point(9, 12);
			this.lblCasino.Name = "lblCasino";
			this.lblCasino.Size = new global::System.Drawing.Size(112, 33);
			this.lblCasino.TabIndex = 0;
			this.lblCasino.Text = "Casino";
			this.tabPageOther.Controls.Add(this.lblProxyStatus);
			this.tabPageOther.Controls.Add(this.lblStatus);
			this.tabPageOther.Controls.Add(this.btnSetProxy);
			this.tabPageOther.Controls.Add(this.txtPort);
			this.tabPageOther.Controls.Add(this.txtProxy);
			this.tabPageOther.Controls.Add(this.lblProxyHeader);
			this.tabPageOther.Controls.Add(this.lblPort);
			this.tabPageOther.Controls.Add(this.lblProxy);
			this.tabPageOther.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageOther.Name = "tabPageOther";
			this.tabPageOther.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageOther.Size = new global::System.Drawing.Size(1055, 612);
			this.tabPageOther.TabIndex = 3;
			this.tabPageOther.Text = "Others";
			this.tabPageOther.UseVisualStyleBackColor = true;
			this.lblProxyStatus.AutoSize = true;
			this.lblProxyStatus.Location = new global::System.Drawing.Point(213, 10);
			this.lblProxyStatus.Name = "lblProxyStatus";
			this.lblProxyStatus.Size = new global::System.Drawing.Size(79, 13);
			this.lblProxyStatus.TabIndex = 7;
			this.lblProxyStatus.Text = "Not Connected";
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new global::System.Drawing.Point(167, 10);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(40, 13);
			this.lblStatus.TabIndex = 6;
			this.lblStatus.Text = "Status:";
			this.btnSetProxy.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnSetProxy.Location = new global::System.Drawing.Point(19, 153);
			this.btnSetProxy.Name = "btnSetProxy";
			this.btnSetProxy.Size = new global::System.Drawing.Size(295, 36);
			this.btnSetProxy.TabIndex = 5;
			this.btnSetProxy.Text = "Set Proxy";
			this.btnSetProxy.UseVisualStyleBackColor = true;
			this.btnSetProxy.Click += new global::System.EventHandler(this.btnSetProxy_Click);
			this.txtPort.Location = new global::System.Drawing.Point(83, 112);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new global::System.Drawing.Size(231, 20);
			this.txtPort.TabIndex = 4;
			this.txtProxy.Location = new global::System.Drawing.Point(83, 85);
			this.txtProxy.Name = "txtProxy";
			this.txtProxy.Size = new global::System.Drawing.Size(231, 20);
			this.txtProxy.TabIndex = 3;
			this.lblProxyHeader.AutoSize = true;
			this.lblProxyHeader.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 36f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblProxyHeader.Location = new global::System.Drawing.Point(9, 10);
			this.lblProxyHeader.Name = "lblProxyHeader";
			this.lblProxyHeader.Size = new global::System.Drawing.Size(152, 55);
			this.lblProxyHeader.TabIndex = 2;
			this.lblProxyHeader.Text = "Proxy";
			this.lblPort.AutoSize = true;
			this.lblPort.Location = new global::System.Drawing.Point(16, 112);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new global::System.Drawing.Size(29, 13);
			this.lblPort.TabIndex = 1;
			this.lblPort.Text = "Port:";
			this.lblProxy.AutoSize = true;
			this.lblProxy.Location = new global::System.Drawing.Point(16, 85);
			this.lblProxy.Name = "lblProxy";
			this.lblProxy.Size = new global::System.Drawing.Size(61, 13);
			this.lblProxy.TabIndex = 0;
			this.lblProxy.Text = "IP Address:";
			this.tabPageGeckoEarn.Controls.Add(this.geckoEarn);
			this.tabPageGeckoEarn.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageGeckoEarn.Name = "tabPageGeckoEarn";
			this.tabPageGeckoEarn.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageGeckoEarn.Size = new global::System.Drawing.Size(1055, 612);
			this.tabPageGeckoEarn.TabIndex = 4;
			this.tabPageGeckoEarn.Text = "Gecko Earn";
			this.tabPageGeckoEarn.UseVisualStyleBackColor = true;
			this.geckoEarn.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.geckoEarn.Enabled = false;
			this.geckoEarn.Location = new global::System.Drawing.Point(0, 0);
			this.geckoEarn.Name = "geckoEarn";
			this.geckoEarn.Size = new global::System.Drawing.Size(1055, 616);
			this.geckoEarn.TabIndex = 0;
			this.geckoEarn.UseHttpActivityObserver = false;
			this.tabPageGeckoCrime.Controls.Add(this.geckoCrime);
			this.tabPageGeckoCrime.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageGeckoCrime.Name = "tabPageGeckoCrime";
			this.tabPageGeckoCrime.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageGeckoCrime.Size = new global::System.Drawing.Size(1055, 612);
			this.tabPageGeckoCrime.TabIndex = 7;
			this.tabPageGeckoCrime.Text = "Gecko Crime";
			this.tabPageGeckoCrime.UseVisualStyleBackColor = true;
			this.geckoCrime.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.geckoCrime.Enabled = false;
			this.geckoCrime.Location = new global::System.Drawing.Point(0, 0);
			this.geckoCrime.Name = "geckoCrime";
			this.geckoCrime.Size = new global::System.Drawing.Size(1055, 616);
			this.geckoCrime.TabIndex = 1;
			this.geckoCrime.UseHttpActivityObserver = false;
			this.tabPageGeckoOther.Controls.Add(this.geckoOther);
			this.tabPageGeckoOther.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageGeckoOther.Name = "tabPageGeckoOther";
			this.tabPageGeckoOther.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageGeckoOther.Size = new global::System.Drawing.Size(1055, 612);
			this.tabPageGeckoOther.TabIndex = 8;
			this.tabPageGeckoOther.Text = "Gecko Other";
			this.tabPageGeckoOther.UseVisualStyleBackColor = true;
			this.geckoOther.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.geckoOther.Enabled = false;
			this.geckoOther.Location = new global::System.Drawing.Point(0, 0);
			this.geckoOther.Name = "geckoOther";
			this.geckoOther.Size = new global::System.Drawing.Size(1055, 616);
			this.geckoOther.TabIndex = 2;
			this.geckoOther.UseHttpActivityObserver = false;
			this.tabPageGeckoCasino.Controls.Add(this.geckoCasino);
			this.tabPageGeckoCasino.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageGeckoCasino.Name = "tabPageGeckoCasino";
			this.tabPageGeckoCasino.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageGeckoCasino.Size = new global::System.Drawing.Size(1055, 612);
			this.tabPageGeckoCasino.TabIndex = 10;
			this.tabPageGeckoCasino.Text = "Gecko Casino";
			this.tabPageGeckoCasino.UseVisualStyleBackColor = true;
			this.geckoCasino.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.geckoCasino.Enabled = false;
			this.geckoCasino.Location = new global::System.Drawing.Point(0, -2);
			this.geckoCasino.Name = "geckoCasino";
			this.geckoCasino.Size = new global::System.Drawing.Size(1055, 616);
			this.geckoCasino.TabIndex = 3;
			this.geckoCasino.UseHttpActivityObserver = false;
			this.earnTimer.Interval = 182000;
			this.earnTimer.Tick += new global::System.EventHandler(this.earnTimer_Tick);
			this.drugTimer.Interval = 1204000;
			this.drugTimer.Tick += new global::System.EventHandler(this.drugTimer_Tick);
			this.aggTimer.Interval = 1320000;
			this.aggTimer.Tick += new global::System.EventHandler(this.aggTimer_Tick);
			this.csTimer.Interval = 1200500;
			this.csTimer.Tick += new global::System.EventHandler(this.csTimer_Tick);
			this.repairTimer.Interval = 185000;
			this.dilligentTimer.Interval = 810000;
			this.bizTimer.Interval = 500;
			this.jailEarnTimer.Interval = 180000;
			this.jailEarnTimer.Tick += new global::System.EventHandler(this.jailEarnTimer_Tick);
			this.jailGymTimer.Interval = 600000;
			this.jailGymTimer.Tick += new global::System.EventHandler(this.jailGymTimer_Tick);
			this.bmTimer.Interval = 610000;
			this.paybackTimer.Interval = 5000;
			this.paybackTimer.Tick += new global::System.EventHandler(this.paybackTimer_Tick);
			this.relogTimer.Interval = 600000;
			this.relogTimer.Tick += new global::System.EventHandler(this.relogTimer_Tick);
			this.txtLastAction.Location = new global::System.Drawing.Point(452, 42);
			this.txtLastAction.Name = "txtLastAction";
			this.txtLastAction.ReadOnly = true;
			this.txtLastAction.Size = new global::System.Drawing.Size(190, 20);
			this.txtLastAction.TabIndex = 19;
			this.lblLastAction.AutoSize = true;
			this.lblLastAction.Location = new global::System.Drawing.Point(386, 45);
			this.lblLastAction.Name = "lblLastAction";
			this.lblLastAction.Size = new global::System.Drawing.Size(60, 13);
			this.lblLastAction.TabIndex = 20;
			this.lblLastAction.Text = "Last Action";
			this.txtMainURL.Location = new global::System.Drawing.Point(147, 42);
			this.txtMainURL.Name = "txtMainURL";
			this.txtMainURL.ReadOnly = true;
			this.txtMainURL.Size = new global::System.Drawing.Size(233, 20);
			this.txtMainURL.TabIndex = 21;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1062, 638);
			base.Controls.Add(this.Casino);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			this.Text = "CrackedBorn";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.Casino.ResumeLayout(false);
			this.tabPageMain.ResumeLayout(false);
			this.tabPageMain.PerformLayout();
			this.tabPageEarn.ResumeLayout(false);
			this.tabPageEarn.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.txtNumberToGenerate).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtNumberToCheck).EndInit();
			this.tabPageCrime.ResumeLayout(false);
			this.tabPageCrime.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.aggTxtWaitTime).EndInit();
			this.tabPageCS.ResumeLayout(false);
			this.tabPageCS.PerformLayout();
			this.tabPageDrug.ResumeLayout(false);
			this.tabPageDrug.PerformLayout();
			this.tabPageJail.ResumeLayout(false);
			this.tabPageJail.PerformLayout();
			this.tabPageCasino.ResumeLayout(false);
			this.tabPageCasino.PerformLayout();
			this.tabPageOther.ResumeLayout(false);
			this.tabPageOther.PerformLayout();
			this.tabPageGeckoEarn.ResumeLayout(false);
			this.tabPageGeckoCrime.ResumeLayout(false);
			this.tabPageGeckoOther.ResumeLayout(false);
			this.tabPageGeckoCasino.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000037 RID: 55
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.TabControl Casino;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.TabPage tabPageMain;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.TabPage tabPageEarn;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Button btnGo;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.TabPage tabPageCrime;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Button btnRefresh;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Button btnLogin;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Label lblEmail;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.TextBox txtPassword;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.TextBox txtEmail;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Button btnStop;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.TextBox txtCharName;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.TabPage tabPageOther;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Button btnSetProxy;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.TextBox txtPort;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.TextBox txtProxy;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Label lblProxyHeader;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Label lblPort;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Label lblProxy;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Label lblProxyStatus;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Button btnDW;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Label lblEarnHeader;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.RichTextBox earnTxt;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.ComboBox txtEarn;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.Button btnEarn;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Timer earnTimer;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.Timer drugTimer;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.Timer aggTimer;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.Timer csTimer;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Timer repairTimer;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.Timer dilligentTimer;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.Timer bizTimer;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.Timer jailEarnTimer;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.Timer jailGymTimer;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.Timer bmTimer;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.Timer paybackTimer;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.Timer relogTimer;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.TabPage tabPageGeckoEarn;

		// Token: 0x04000060 RID: 96
		private global::Gecko.GeckoWebBrowser geckoEarn;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.TabPage tabPageCS;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.TabPage tabPageDrug;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.TabPage tabPageGeckoCrime;

		// Token: 0x04000064 RID: 100
		private global::Gecko.GeckoWebBrowser geckoCrime;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.TabPage tabPageGeckoOther;

		// Token: 0x04000066 RID: 102
		private global::Gecko.GeckoWebBrowser geckoOther;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.Label lblEarnRandom;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.ComboBox txtEarnRandom;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.Label lblEarn;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.Label lblMin;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.NumericUpDown aggTxtWaitTime;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.Label lblCrime;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.ComboBox txtCrime;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.Label lblCrimeHeader;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.RichTextBox aggTxt;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.CheckBox chkBoxPB;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.Label lblMessagePb;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.TextBox txtPBMessage;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.Button btnStopDrug;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.Button btnStartDrug;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.Label lblDrug;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.RichTextBox drugTxt;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.RichTextBox csText;

		// Token: 0x04000078 RID: 120
		private global::System.Windows.Forms.Button btnStartCS;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Forms.ComboBox txtCS;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.Label lblCSHeader;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Forms.Button btnStartCrime;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.Button btnStopCrime;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.Button btnStopCS;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.TabPage tabPageJail;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.ComboBox txtJailEarn;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.RichTextBox jailGymTxt;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.RichTextBox jailEarnTxt;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.Label lblJailGymHeader;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.Label lblJailEarnHeader;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.Button btnStopJailGym;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.Button btnStartJailGym;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.Button btnStopJailEarn;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Forms.Button btnStartJailEarn;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Forms.ComboBox txtJailEarnRandom;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.TabPage tabPageGeckoCasino;

		// Token: 0x0400008A RID: 138
		private global::Gecko.GeckoWebBrowser geckoCasino;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.TabPage tabPageCasino;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.Button btnStartCasino;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.RichTextBox casinoTxt;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.Label lblCasino;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.Button btnEarnStop;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.Button btnStopCasino;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.DateTimePicker dtpLogOffTime;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.ComboBox txtCrime2;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.Label lblCrime2;

		// Token: 0x04000094 RID: 148
		private global::System.Windows.Forms.Label lblCrime1;

		// Token: 0x04000095 RID: 149
		private global::System.Windows.Forms.NumericUpDown txtNumberToGenerate;

		// Token: 0x04000096 RID: 150
		private global::System.Windows.Forms.NumericUpDown txtNumberToCheck;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.Label lblForget;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.CheckBox chkBoxCrime;

		// Token: 0x04000099 RID: 153
		private global::Gecko.GeckoWebBrowser geckoMain;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.CheckBox cbCaptchaLogin;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.Label lblNextEarnTime;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.Label lblCharName;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.TextBox txtEarnSpan;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.Label lblLastAction;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Forms.TextBox txtLastAction;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.TextBox txtMainURL;
	}
}
