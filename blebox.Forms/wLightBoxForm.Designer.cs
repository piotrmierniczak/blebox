
namespace blebox.Forms
{
    partial class wLightBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wLightBoxForm));
            this.channel1TrackBar = new System.Windows.Forms.TrackBar();
            this.channel1Panel = new System.Windows.Forms.Panel();
            this.channel1ValueLabel = new System.Windows.Forms.Label();
            this.channel1Label = new System.Windows.Forms.Label();
            this.connectionPanel = new System.Windows.Forms.Panel();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressButton = new System.Windows.Forms.Button();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.closeLabel = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.effectPanel = new System.Windows.Forms.Panel();
            this.bellButton = new System.Windows.Forms.Button();
            this.stroboButton = new System.Windows.Forms.Button();
            this.relaxButton = new System.Windows.Forms.Button();
            this.policeButton = new System.Windows.Forms.Button();
            this.rgbButton = new System.Windows.Forms.Button();
            this.fadeButton = new System.Windows.Forms.Button();
            this.noneButton = new System.Windows.Forms.Button();
            this.effectLabel = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonPanel2 = new System.Windows.Forms.Panel();
            this.azureButton = new System.Windows.Forms.Button();
            this.orangeButton = new System.Windows.Forms.Button();
            this.cyanButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.pinkButton = new System.Windows.Forms.Button();
            this.buttonPanel1 = new System.Windows.Forms.Panel();
            this.offButton = new System.Windows.Forms.Button();
            this.whiteColdButton = new System.Windows.Forms.Button();
            this.whiteWarmButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.buttonDescriptionLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.channel5Panel = new System.Windows.Forms.Panel();
            this.channel5TrackBar = new System.Windows.Forms.TrackBar();
            this.channel5ValueLabel = new System.Windows.Forms.Label();
            this.channel5Label = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.channel4Panel = new System.Windows.Forms.Panel();
            this.channel4TrackBar = new System.Windows.Forms.TrackBar();
            this.channel4ValueLabel = new System.Windows.Forms.Label();
            this.channel4Label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.channel3Panel = new System.Windows.Forms.Panel();
            this.channel3TrackBar = new System.Windows.Forms.TrackBar();
            this.channel3ValueLabel = new System.Windows.Forms.Label();
            this.channel3Label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.channel2Panel = new System.Windows.Forms.Panel();
            this.channel2TrackBar = new System.Windows.Forms.TrackBar();
            this.channel2ValueLabel = new System.Windows.Forms.Label();
            this.channel2Label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.infoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timerPost = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.channel1TrackBar)).BeginInit();
            this.channel1Panel.SuspendLayout();
            this.connectionPanel.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.effectPanel.SuspendLayout();
            this.buttonPanel2.SuspendLayout();
            this.buttonPanel1.SuspendLayout();
            this.channel5Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channel5TrackBar)).BeginInit();
            this.channel4Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channel4TrackBar)).BeginInit();
            this.channel3Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channel3TrackBar)).BeginInit();
            this.channel2Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channel2TrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // channel1TrackBar
            // 
            this.channel1TrackBar.BackColor = System.Drawing.Color.Red;
            this.channel1TrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.channel1TrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channel1TrackBar.Location = new System.Drawing.Point(64, 0);
            this.channel1TrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.channel1TrackBar.Maximum = 255;
            this.channel1TrackBar.Name = "channel1TrackBar";
            this.channel1TrackBar.Size = new System.Drawing.Size(496, 25);
            this.channel1TrackBar.TabIndex = 0;
            this.channel1TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.channel1TrackBar.ValueChanged += new System.EventHandler(this.Channel1TrackBar_ValueChanged);
            // 
            // channel1Panel
            // 
            this.channel1Panel.Controls.Add(this.channel1TrackBar);
            this.channel1Panel.Controls.Add(this.channel1ValueLabel);
            this.channel1Panel.Controls.Add(this.channel1Label);
            this.channel1Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.channel1Panel.Location = new System.Drawing.Point(0, 15);
            this.channel1Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.channel1Panel.Name = "channel1Panel";
            this.channel1Panel.Size = new System.Drawing.Size(600, 25);
            this.channel1Panel.TabIndex = 1;
            // 
            // channel1ValueLabel
            // 
            this.channel1ValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.channel1ValueLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.channel1ValueLabel.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.channel1ValueLabel.ForeColor = System.Drawing.Color.Black;
            this.channel1ValueLabel.Location = new System.Drawing.Point(560, 0);
            this.channel1ValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.channel1ValueLabel.Name = "channel1ValueLabel";
            this.channel1ValueLabel.Size = new System.Drawing.Size(40, 25);
            this.channel1ValueLabel.TabIndex = 3;
            this.channel1ValueLabel.Text = "0";
            this.channel1ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // channel1Label
            // 
            this.channel1Label.BackColor = System.Drawing.Color.Transparent;
            this.channel1Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.channel1Label.ForeColor = System.Drawing.Color.Black;
            this.channel1Label.Location = new System.Drawing.Point(0, 0);
            this.channel1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.channel1Label.Name = "channel1Label";
            this.channel1Label.Size = new System.Drawing.Size(64, 25);
            this.channel1Label.TabIndex = 1;
            this.channel1Label.Text = "Kanał 1";
            this.channel1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // connectionPanel
            // 
            this.connectionPanel.BackColor = System.Drawing.Color.Black;
            this.connectionPanel.Controls.Add(this.addressTextBox);
            this.connectionPanel.Controls.Add(this.addressButton);
            this.connectionPanel.Controls.Add(this.connectionStatusLabel);
            this.connectionPanel.Controls.Add(this.addressLabel);
            this.connectionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.connectionPanel.Location = new System.Drawing.Point(0, 36);
            this.connectionPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectionPanel.Name = "connectionPanel";
            this.connectionPanel.Size = new System.Drawing.Size(600, 30);
            this.connectionPanel.TabIndex = 2;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.addressTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressTextBox.Location = new System.Drawing.Point(83, 0);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(311, 27);
            this.addressTextBox.TabIndex = 1;
            this.addressTextBox.Text = "http://192.168.18.88";
            // 
            // addressButton
            // 
            this.addressButton.BackColor = System.Drawing.Color.Black;
            this.addressButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addressButton.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addressButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addressButton.Location = new System.Drawing.Point(394, 0);
            this.addressButton.Name = "addressButton";
            this.addressButton.Size = new System.Drawing.Size(161, 30);
            this.addressButton.TabIndex = 2;
            this.addressButton.Text = "Sprawdź połączenie";
            this.addressButton.UseVisualStyleBackColor = false;
            this.addressButton.Click += new System.EventHandler(this.AddressButton_Click);
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.BackColor = System.Drawing.Color.Black;
            this.connectionStatusLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.connectionStatusLabel.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectionStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.connectionStatusLabel.Location = new System.Drawing.Point(555, 0);
            this.connectionStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(45, 30);
            this.connectionStatusLabel.TabIndex = 3;
            this.connectionStatusLabel.Text = "?";
            this.connectionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.connectionStatusLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FMouseDown);
            this.connectionStatusLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FMouseMove);
            this.connectionStatusLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FMouseUp);
            // 
            // addressLabel
            // 
            this.addressLabel.BackColor = System.Drawing.Color.Black;
            this.addressLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.addressLabel.ForeColor = System.Drawing.Color.White;
            this.addressLabel.Location = new System.Drawing.Point(0, 0);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(83, 30);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "Adres URL:";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addressLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FMouseDown);
            this.addressLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FMouseMove);
            this.addressLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FMouseUp);
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.BackColor = System.Drawing.Color.Black;
            this.descriptionPanel.Controls.Add(this.closeLabel);
            this.descriptionPanel.Controls.Add(this.logoPictureBox);
            this.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionPanel.Location = new System.Drawing.Point(0, 0);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(600, 36);
            this.descriptionPanel.TabIndex = 3;
            this.descriptionPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FMouseDown);
            this.descriptionPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FMouseMove);
            this.descriptionPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FMouseUp);
            // 
            // closeLabel
            // 
            this.closeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeLabel.Image = ((System.Drawing.Image)(resources.GetObject("closeLabel.Image")));
            this.closeLabel.InitialImage = null;
            this.closeLabel.Location = new System.Drawing.Point(560, 0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(40, 36);
            this.closeLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeLabel.TabIndex = 1;
            this.closeLabel.TabStop = false;
            this.closeLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close_MouseClick);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.InitialImage = null;
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(102, 36);
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FMouseDown);
            this.logoPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FMouseMove);
            this.logoPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FMouseUp);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.DarkKhaki;
            this.mainPanel.Controls.Add(this.effectPanel);
            this.mainPanel.Controls.Add(this.effectLabel);
            this.mainPanel.Controls.Add(this.panel7);
            this.mainPanel.Controls.Add(this.buttonPanel2);
            this.mainPanel.Controls.Add(this.buttonPanel1);
            this.mainPanel.Controls.Add(this.buttonDescriptionLabel);
            this.mainPanel.Controls.Add(this.panel6);
            this.mainPanel.Controls.Add(this.channel5Panel);
            this.mainPanel.Controls.Add(this.panel5);
            this.mainPanel.Controls.Add(this.channel4Panel);
            this.mainPanel.Controls.Add(this.panel4);
            this.mainPanel.Controls.Add(this.channel3Panel);
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.channel2Panel);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.channel1Panel);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 66);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(600, 384);
            this.mainPanel.TabIndex = 4;
            // 
            // effectPanel
            // 
            this.effectPanel.Controls.Add(this.bellButton);
            this.effectPanel.Controls.Add(this.stroboButton);
            this.effectPanel.Controls.Add(this.relaxButton);
            this.effectPanel.Controls.Add(this.policeButton);
            this.effectPanel.Controls.Add(this.rgbButton);
            this.effectPanel.Controls.Add(this.fadeButton);
            this.effectPanel.Controls.Add(this.noneButton);
            this.effectPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.effectPanel.Location = new System.Drawing.Point(0, 350);
            this.effectPanel.Name = "effectPanel";
            this.effectPanel.Size = new System.Drawing.Size(600, 35);
            this.effectPanel.TabIndex = 31;
            // 
            // bellButton
            // 
            this.bellButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bellButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.bellButton.ForeColor = System.Drawing.Color.Black;
            this.bellButton.Location = new System.Drawing.Point(520, 0);
            this.bellButton.Name = "bellButton";
            this.bellButton.Size = new System.Drawing.Size(80, 35);
            this.bellButton.TabIndex = 19;
            this.bellButton.Text = "dzwonek";
            this.bellButton.UseVisualStyleBackColor = false;
            this.bellButton.Click += new System.EventHandler(this.BellButton_Click);
            // 
            // stroboButton
            // 
            this.stroboButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.stroboButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.stroboButton.ForeColor = System.Drawing.Color.Black;
            this.stroboButton.Location = new System.Drawing.Point(420, 0);
            this.stroboButton.Name = "stroboButton";
            this.stroboButton.Size = new System.Drawing.Size(100, 35);
            this.stroboButton.TabIndex = 18;
            this.stroboButton.Text = "stroboskop";
            this.stroboButton.UseVisualStyleBackColor = false;
            this.stroboButton.Click += new System.EventHandler(this.StroboButton_Click);
            // 
            // relaxButton
            // 
            this.relaxButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.relaxButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.relaxButton.ForeColor = System.Drawing.Color.Black;
            this.relaxButton.Location = new System.Drawing.Point(340, 0);
            this.relaxButton.Name = "relaxButton";
            this.relaxButton.Size = new System.Drawing.Size(80, 35);
            this.relaxButton.TabIndex = 17;
            this.relaxButton.Text = "relaks";
            this.relaxButton.UseVisualStyleBackColor = false;
            this.relaxButton.Click += new System.EventHandler(this.RelaxButton_Click);
            // 
            // policeButton
            // 
            this.policeButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.policeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.policeButton.ForeColor = System.Drawing.Color.Black;
            this.policeButton.Location = new System.Drawing.Point(260, 0);
            this.policeButton.Name = "policeButton";
            this.policeButton.Size = new System.Drawing.Size(80, 35);
            this.policeButton.TabIndex = 16;
            this.policeButton.Text = "policja";
            this.policeButton.UseVisualStyleBackColor = false;
            this.policeButton.Click += new System.EventHandler(this.PoliceButton_Click);
            // 
            // rgbButton
            // 
            this.rgbButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.rgbButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.rgbButton.ForeColor = System.Drawing.Color.Black;
            this.rgbButton.Location = new System.Drawing.Point(180, 0);
            this.rgbButton.Name = "rgbButton";
            this.rgbButton.Size = new System.Drawing.Size(80, 35);
            this.rgbButton.TabIndex = 15;
            this.rgbButton.Text = "rgb";
            this.rgbButton.UseVisualStyleBackColor = false;
            this.rgbButton.Click += new System.EventHandler(this.RgbButton_Click);
            // 
            // fadeButton
            // 
            this.fadeButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.fadeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.fadeButton.ForeColor = System.Drawing.Color.Black;
            this.fadeButton.Location = new System.Drawing.Point(80, 0);
            this.fadeButton.Name = "fadeButton";
            this.fadeButton.Size = new System.Drawing.Size(100, 35);
            this.fadeButton.TabIndex = 14;
            this.fadeButton.Text = "ściemnianie";
            this.fadeButton.UseVisualStyleBackColor = false;
            this.fadeButton.Click += new System.EventHandler(this.FadeButton_Click);
            // 
            // noneButton
            // 
            this.noneButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.noneButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.noneButton.ForeColor = System.Drawing.Color.Black;
            this.noneButton.Location = new System.Drawing.Point(0, 0);
            this.noneButton.Name = "noneButton";
            this.noneButton.Size = new System.Drawing.Size(80, 35);
            this.noneButton.TabIndex = 13;
            this.noneButton.Text = "brak";
            this.noneButton.UseVisualStyleBackColor = false;
            this.noneButton.Click += new System.EventHandler(this.NoneButton_Click);
            // 
            // effectLabel
            // 
            this.effectLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.effectLabel.Location = new System.Drawing.Point(0, 325);
            this.effectLabel.Name = "effectLabel";
            this.effectLabel.Size = new System.Drawing.Size(600, 25);
            this.effectLabel.TabIndex = 30;
            this.effectLabel.Text = "Efekty";
            this.effectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 310);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(600, 15);
            this.panel7.TabIndex = 25;
            // 
            // buttonPanel2
            // 
            this.buttonPanel2.Controls.Add(this.azureButton);
            this.buttonPanel2.Controls.Add(this.orangeButton);
            this.buttonPanel2.Controls.Add(this.cyanButton);
            this.buttonPanel2.Controls.Add(this.yellowButton);
            this.buttonPanel2.Controls.Add(this.pinkButton);
            this.buttonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel2.Location = new System.Drawing.Point(0, 275);
            this.buttonPanel2.Name = "buttonPanel2";
            this.buttonPanel2.Size = new System.Drawing.Size(600, 35);
            this.buttonPanel2.TabIndex = 24;
            // 
            // azureButton
            // 
            this.azureButton.BackColor = System.Drawing.Color.Azure;
            this.azureButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.azureButton.ForeColor = System.Drawing.Color.Black;
            this.azureButton.Location = new System.Drawing.Point(480, 0);
            this.azureButton.Name = "azureButton";
            this.azureButton.Size = new System.Drawing.Size(120, 35);
            this.azureButton.TabIndex = 17;
            this.azureButton.Text = "azure";
            this.azureButton.UseVisualStyleBackColor = false;
            this.azureButton.Click += new System.EventHandler(this.AzureButton_Click);
            // 
            // orangeButton
            // 
            this.orangeButton.BackColor = System.Drawing.Color.Orange;
            this.orangeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.orangeButton.ForeColor = System.Drawing.Color.Black;
            this.orangeButton.Location = new System.Drawing.Point(360, 0);
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Size = new System.Drawing.Size(120, 35);
            this.orangeButton.TabIndex = 16;
            this.orangeButton.Text = "pomarańczowy";
            this.orangeButton.UseVisualStyleBackColor = false;
            this.orangeButton.Click += new System.EventHandler(this.OrangeButton_Click);
            // 
            // cyanButton
            // 
            this.cyanButton.BackColor = System.Drawing.Color.Cyan;
            this.cyanButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.cyanButton.ForeColor = System.Drawing.Color.Black;
            this.cyanButton.Location = new System.Drawing.Point(240, 0);
            this.cyanButton.Name = "cyanButton";
            this.cyanButton.Size = new System.Drawing.Size(120, 35);
            this.cyanButton.TabIndex = 15;
            this.cyanButton.Text = "cyjan";
            this.cyanButton.UseVisualStyleBackColor = false;
            this.cyanButton.Click += new System.EventHandler(this.CyanButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.yellowButton.ForeColor = System.Drawing.Color.Black;
            this.yellowButton.Location = new System.Drawing.Point(120, 0);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(120, 35);
            this.yellowButton.TabIndex = 14;
            this.yellowButton.Text = "żółty";
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.YellowButton_Click);
            // 
            // pinkButton
            // 
            this.pinkButton.BackColor = System.Drawing.Color.Pink;
            this.pinkButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pinkButton.ForeColor = System.Drawing.Color.Black;
            this.pinkButton.Location = new System.Drawing.Point(0, 0);
            this.pinkButton.Name = "pinkButton";
            this.pinkButton.Size = new System.Drawing.Size(120, 35);
            this.pinkButton.TabIndex = 13;
            this.pinkButton.Text = "różowy";
            this.pinkButton.UseVisualStyleBackColor = false;
            this.pinkButton.Click += new System.EventHandler(this.PinkButton_Click);
            // 
            // buttonPanel1
            // 
            this.buttonPanel1.Controls.Add(this.offButton);
            this.buttonPanel1.Controls.Add(this.whiteColdButton);
            this.buttonPanel1.Controls.Add(this.whiteWarmButton);
            this.buttonPanel1.Controls.Add(this.blueButton);
            this.buttonPanel1.Controls.Add(this.greenButton);
            this.buttonPanel1.Controls.Add(this.redButton);
            this.buttonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel1.Location = new System.Drawing.Point(0, 240);
            this.buttonPanel1.Name = "buttonPanel1";
            this.buttonPanel1.Size = new System.Drawing.Size(600, 35);
            this.buttonPanel1.TabIndex = 23;
            // 
            // offButton
            // 
            this.offButton.BackColor = System.Drawing.Color.Black;
            this.offButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.offButton.ForeColor = System.Drawing.Color.White;
            this.offButton.Location = new System.Drawing.Point(500, 0);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(100, 35);
            this.offButton.TabIndex = 18;
            this.offButton.Text = "wyłącz";
            this.offButton.UseVisualStyleBackColor = false;
            this.offButton.Click += new System.EventHandler(this.OffButton_Click);
            // 
            // whiteColdButton
            // 
            this.whiteColdButton.BackColor = System.Drawing.Color.Snow;
            this.whiteColdButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.whiteColdButton.ForeColor = System.Drawing.Color.Black;
            this.whiteColdButton.Location = new System.Drawing.Point(400, 0);
            this.whiteColdButton.Name = "whiteColdButton";
            this.whiteColdButton.Size = new System.Drawing.Size(100, 35);
            this.whiteColdButton.TabIndex = 17;
            this.whiteColdButton.Text = "biały zimny";
            this.whiteColdButton.UseVisualStyleBackColor = false;
            this.whiteColdButton.Click += new System.EventHandler(this.WhiteColdButton_Click);
            // 
            // whiteWarmButton
            // 
            this.whiteWarmButton.BackColor = System.Drawing.Color.LightYellow;
            this.whiteWarmButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.whiteWarmButton.ForeColor = System.Drawing.Color.Black;
            this.whiteWarmButton.Location = new System.Drawing.Point(300, 0);
            this.whiteWarmButton.Name = "whiteWarmButton";
            this.whiteWarmButton.Size = new System.Drawing.Size(100, 35);
            this.whiteWarmButton.TabIndex = 16;
            this.whiteWarmButton.Text = "biały ciepły";
            this.whiteWarmButton.UseVisualStyleBackColor = false;
            this.whiteWarmButton.Click += new System.EventHandler(this.WhiteWarmButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.blueButton.ForeColor = System.Drawing.Color.White;
            this.blueButton.Location = new System.Drawing.Point(200, 0);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(100, 35);
            this.blueButton.TabIndex = 15;
            this.blueButton.Text = "niebieski";
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.BlueButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Green;
            this.greenButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.greenButton.ForeColor = System.Drawing.Color.White;
            this.greenButton.Location = new System.Drawing.Point(100, 0);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(100, 35);
            this.greenButton.TabIndex = 14;
            this.greenButton.Text = "zielony";
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.GreenButton_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.redButton.ForeColor = System.Drawing.Color.White;
            this.redButton.Location = new System.Drawing.Point(0, 0);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(100, 35);
            this.redButton.TabIndex = 13;
            this.redButton.Text = "czerwony";
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.RedButton_Click);
            // 
            // buttonDescriptionLabel
            // 
            this.buttonDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDescriptionLabel.Location = new System.Drawing.Point(0, 215);
            this.buttonDescriptionLabel.Name = "buttonDescriptionLabel";
            this.buttonDescriptionLabel.Size = new System.Drawing.Size(600, 25);
            this.buttonDescriptionLabel.TabIndex = 12;
            this.buttonDescriptionLabel.Text = "Naciśnij przycisk, aby zapisać aktualny kolor";
            this.buttonDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 200);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(600, 15);
            this.panel6.TabIndex = 11;
            // 
            // channel5Panel
            // 
            this.channel5Panel.Controls.Add(this.channel5TrackBar);
            this.channel5Panel.Controls.Add(this.channel5ValueLabel);
            this.channel5Panel.Controls.Add(this.channel5Label);
            this.channel5Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.channel5Panel.Location = new System.Drawing.Point(0, 175);
            this.channel5Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.channel5Panel.Name = "channel5Panel";
            this.channel5Panel.Size = new System.Drawing.Size(600, 25);
            this.channel5Panel.TabIndex = 6;
            // 
            // channel5TrackBar
            // 
            this.channel5TrackBar.BackColor = System.Drawing.Color.Snow;
            this.channel5TrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.channel5TrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channel5TrackBar.Location = new System.Drawing.Point(64, 0);
            this.channel5TrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.channel5TrackBar.Maximum = 255;
            this.channel5TrackBar.Name = "channel5TrackBar";
            this.channel5TrackBar.Size = new System.Drawing.Size(496, 25);
            this.channel5TrackBar.TabIndex = 0;
            this.channel5TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.channel5TrackBar.ValueChanged += new System.EventHandler(this.Channel5TrackBar_ValueChanged);
            // 
            // channel5ValueLabel
            // 
            this.channel5ValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.channel5ValueLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.channel5ValueLabel.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.channel5ValueLabel.ForeColor = System.Drawing.Color.Black;
            this.channel5ValueLabel.Location = new System.Drawing.Point(560, 0);
            this.channel5ValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.channel5ValueLabel.Name = "channel5ValueLabel";
            this.channel5ValueLabel.Size = new System.Drawing.Size(40, 25);
            this.channel5ValueLabel.TabIndex = 3;
            this.channel5ValueLabel.Text = "0";
            this.channel5ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // channel5Label
            // 
            this.channel5Label.BackColor = System.Drawing.Color.Transparent;
            this.channel5Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.channel5Label.ForeColor = System.Drawing.Color.Black;
            this.channel5Label.Location = new System.Drawing.Point(0, 0);
            this.channel5Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.channel5Label.Name = "channel5Label";
            this.channel5Label.Size = new System.Drawing.Size(64, 25);
            this.channel5Label.TabIndex = 1;
            this.channel5Label.Text = "Kanał 5";
            this.channel5Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 160);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(600, 15);
            this.panel5.TabIndex = 10;
            // 
            // channel4Panel
            // 
            this.channel4Panel.Controls.Add(this.channel4TrackBar);
            this.channel4Panel.Controls.Add(this.channel4ValueLabel);
            this.channel4Panel.Controls.Add(this.channel4Label);
            this.channel4Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.channel4Panel.Location = new System.Drawing.Point(0, 135);
            this.channel4Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.channel4Panel.Name = "channel4Panel";
            this.channel4Panel.Size = new System.Drawing.Size(600, 25);
            this.channel4Panel.TabIndex = 5;
            // 
            // channel4TrackBar
            // 
            this.channel4TrackBar.BackColor = System.Drawing.Color.LightYellow;
            this.channel4TrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.channel4TrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channel4TrackBar.Location = new System.Drawing.Point(64, 0);
            this.channel4TrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.channel4TrackBar.Maximum = 255;
            this.channel4TrackBar.Name = "channel4TrackBar";
            this.channel4TrackBar.Size = new System.Drawing.Size(496, 25);
            this.channel4TrackBar.TabIndex = 0;
            this.channel4TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.channel4TrackBar.ValueChanged += new System.EventHandler(this.Channel4TrackBar_ValueChanged);
            // 
            // channel4ValueLabel
            // 
            this.channel4ValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.channel4ValueLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.channel4ValueLabel.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.channel4ValueLabel.ForeColor = System.Drawing.Color.Black;
            this.channel4ValueLabel.Location = new System.Drawing.Point(560, 0);
            this.channel4ValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.channel4ValueLabel.Name = "channel4ValueLabel";
            this.channel4ValueLabel.Size = new System.Drawing.Size(40, 25);
            this.channel4ValueLabel.TabIndex = 3;
            this.channel4ValueLabel.Text = "0";
            this.channel4ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // channel4Label
            // 
            this.channel4Label.BackColor = System.Drawing.Color.Transparent;
            this.channel4Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.channel4Label.ForeColor = System.Drawing.Color.Black;
            this.channel4Label.Location = new System.Drawing.Point(0, 0);
            this.channel4Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.channel4Label.Name = "channel4Label";
            this.channel4Label.Size = new System.Drawing.Size(64, 25);
            this.channel4Label.TabIndex = 1;
            this.channel4Label.Text = "Kanał 4";
            this.channel4Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 15);
            this.panel4.TabIndex = 9;
            // 
            // channel3Panel
            // 
            this.channel3Panel.Controls.Add(this.channel3TrackBar);
            this.channel3Panel.Controls.Add(this.channel3ValueLabel);
            this.channel3Panel.Controls.Add(this.channel3Label);
            this.channel3Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.channel3Panel.Location = new System.Drawing.Point(0, 95);
            this.channel3Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.channel3Panel.Name = "channel3Panel";
            this.channel3Panel.Size = new System.Drawing.Size(600, 25);
            this.channel3Panel.TabIndex = 4;
            // 
            // channel3TrackBar
            // 
            this.channel3TrackBar.BackColor = System.Drawing.Color.Blue;
            this.channel3TrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.channel3TrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channel3TrackBar.Location = new System.Drawing.Point(64, 0);
            this.channel3TrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.channel3TrackBar.Maximum = 255;
            this.channel3TrackBar.Name = "channel3TrackBar";
            this.channel3TrackBar.Size = new System.Drawing.Size(496, 25);
            this.channel3TrackBar.TabIndex = 0;
            this.channel3TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.channel3TrackBar.ValueChanged += new System.EventHandler(this.Channel3TrackBar_ValueChanged);
            // 
            // channel3ValueLabel
            // 
            this.channel3ValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.channel3ValueLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.channel3ValueLabel.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.channel3ValueLabel.ForeColor = System.Drawing.Color.Black;
            this.channel3ValueLabel.Location = new System.Drawing.Point(560, 0);
            this.channel3ValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.channel3ValueLabel.Name = "channel3ValueLabel";
            this.channel3ValueLabel.Size = new System.Drawing.Size(40, 25);
            this.channel3ValueLabel.TabIndex = 3;
            this.channel3ValueLabel.Text = "0";
            this.channel3ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // channel3Label
            // 
            this.channel3Label.BackColor = System.Drawing.Color.Transparent;
            this.channel3Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.channel3Label.ForeColor = System.Drawing.Color.Black;
            this.channel3Label.Location = new System.Drawing.Point(0, 0);
            this.channel3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.channel3Label.Name = "channel3Label";
            this.channel3Label.Size = new System.Drawing.Size(64, 25);
            this.channel3Label.TabIndex = 1;
            this.channel3Label.Text = "Kanał 3";
            this.channel3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 15);
            this.panel3.TabIndex = 8;
            // 
            // channel2Panel
            // 
            this.channel2Panel.Controls.Add(this.channel2TrackBar);
            this.channel2Panel.Controls.Add(this.channel2ValueLabel);
            this.channel2Panel.Controls.Add(this.channel2Label);
            this.channel2Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.channel2Panel.Location = new System.Drawing.Point(0, 55);
            this.channel2Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.channel2Panel.Name = "channel2Panel";
            this.channel2Panel.Size = new System.Drawing.Size(600, 25);
            this.channel2Panel.TabIndex = 3;
            // 
            // channel2TrackBar
            // 
            this.channel2TrackBar.BackColor = System.Drawing.Color.Green;
            this.channel2TrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.channel2TrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channel2TrackBar.Location = new System.Drawing.Point(64, 0);
            this.channel2TrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.channel2TrackBar.Maximum = 255;
            this.channel2TrackBar.Name = "channel2TrackBar";
            this.channel2TrackBar.Size = new System.Drawing.Size(496, 25);
            this.channel2TrackBar.TabIndex = 0;
            this.channel2TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.channel2TrackBar.ValueChanged += new System.EventHandler(this.Channel2TrackBar_ValueChanged);
            // 
            // channel2ValueLabel
            // 
            this.channel2ValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.channel2ValueLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.channel2ValueLabel.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.channel2ValueLabel.ForeColor = System.Drawing.Color.Black;
            this.channel2ValueLabel.Location = new System.Drawing.Point(560, 0);
            this.channel2ValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.channel2ValueLabel.Name = "channel2ValueLabel";
            this.channel2ValueLabel.Size = new System.Drawing.Size(40, 25);
            this.channel2ValueLabel.TabIndex = 3;
            this.channel2ValueLabel.Text = "0";
            this.channel2ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // channel2Label
            // 
            this.channel2Label.BackColor = System.Drawing.Color.Transparent;
            this.channel2Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.channel2Label.ForeColor = System.Drawing.Color.Black;
            this.channel2Label.Location = new System.Drawing.Point(0, 0);
            this.channel2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.channel2Label.Name = "channel2Label";
            this.channel2Label.Size = new System.Drawing.Size(64, 25);
            this.channel2Label.TabIndex = 1;
            this.channel2Label.Text = "Kanał 2";
            this.channel2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 15);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 15);
            this.panel1.TabIndex = 2;
            // 
            // timerPost
            // 
            this.timerPost.Tick += new System.EventHandler(this.TimerPost_Tick);
            // 
            // wLightBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.connectionPanel);
            this.Controls.Add(this.descriptionPanel);
            this.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wLightBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ustawienia wLightBox";
            ((System.ComponentModel.ISupportInitialize)(this.channel1TrackBar)).EndInit();
            this.channel1Panel.ResumeLayout(false);
            this.channel1Panel.PerformLayout();
            this.connectionPanel.ResumeLayout(false);
            this.connectionPanel.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.effectPanel.ResumeLayout(false);
            this.buttonPanel2.ResumeLayout(false);
            this.buttonPanel1.ResumeLayout(false);
            this.channel5Panel.ResumeLayout(false);
            this.channel5Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channel5TrackBar)).EndInit();
            this.channel4Panel.ResumeLayout(false);
            this.channel4Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channel4TrackBar)).EndInit();
            this.channel3Panel.ResumeLayout(false);
            this.channel3Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channel3TrackBar)).EndInit();
            this.channel2Panel.ResumeLayout(false);
            this.channel2Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channel2TrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar channel1TrackBar;
        private System.Windows.Forms.Panel channel1Panel;
        private System.Windows.Forms.Panel connectionPanel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button addressButton;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.PictureBox closeLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolTip infoToolTip;
        private System.Windows.Forms.Label channel1ValueLabel;
        private System.Windows.Forms.Label channel1Label;
        private System.Windows.Forms.Panel channel5Panel;
        private System.Windows.Forms.TrackBar channel5TrackBar;
        private System.Windows.Forms.Label channel5ValueLabel;
        private System.Windows.Forms.Label channel5Label;
        private System.Windows.Forms.Panel channel4Panel;
        private System.Windows.Forms.TrackBar channel4TrackBar;
        private System.Windows.Forms.Label channel4ValueLabel;
        private System.Windows.Forms.Label channel4Label;
        private System.Windows.Forms.Panel channel3Panel;
        private System.Windows.Forms.TrackBar channel3TrackBar;
        private System.Windows.Forms.Label channel3ValueLabel;
        private System.Windows.Forms.Label channel3Label;
        private System.Windows.Forms.Panel channel2Panel;
        private System.Windows.Forms.TrackBar channel2TrackBar;
        private System.Windows.Forms.Label channel2ValueLabel;
        private System.Windows.Forms.Label channel2Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Label buttonDescriptionLabel;
        private System.Windows.Forms.Button whiteColdButton;
        private System.Windows.Forms.Button whiteWarmButton;
        private System.Windows.Forms.Panel buttonPanel1;
        private System.Windows.Forms.Panel buttonPanel2;
        private System.Windows.Forms.Button azureButton;
        private System.Windows.Forms.Button orangeButton;
        private System.Windows.Forms.Button cyanButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button pinkButton;
        private System.Windows.Forms.Panel effectPanel;
        private System.Windows.Forms.Button stroboButton;
        private System.Windows.Forms.Button relaxButton;
        private System.Windows.Forms.Button policeButton;
        private System.Windows.Forms.Button rgbButton;
        private System.Windows.Forms.Button fadeButton;
        private System.Windows.Forms.Button noneButton;
        private System.Windows.Forms.Label effectLabel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button offButton;
        private System.Windows.Forms.Button bellButton;
        private System.Windows.Forms.Timer timerPost;
    }
}

