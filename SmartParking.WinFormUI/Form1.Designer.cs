namespace SmartParking.WinFormUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.header = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StartDeteBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.StopDeteBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.camBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.overviewTab1 = new SmartParking.WinFormUI.OverviewTab();
            this.lblCurTab = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.locationsTab1 = new SmartParking.WinFormUI.LocationsTab();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.White;
            this.header.BorderRadius = 5;
            this.header.BottomSahddow = true;
            this.header.color = System.Drawing.Color.White;
            this.header.Controls.Add(this.bunifuImageButton1);
            this.header.Controls.Add(this.label1);
            this.header.LeftSahddow = false;
            this.header.Location = new System.Drawing.Point(-1, -7);
            this.header.Name = "header";
            this.header.RightSahddow = true;
            this.header.ShadowDepth = 20;
            this.header.Size = new System.Drawing.Size(1096, 86);
            this.header.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.header, "");
            this.bunifuToolTip1.SetToolTipIcon(this.header, null);
            this.bunifuToolTip1.SetToolTipTitle(this.header, "");
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1040, 31);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(26, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton1, "");
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "SMART PARKING | Dashboard";
            this.bunifuToolTip1.SetToolTip(this.label1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label1, "");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuFlatButton2);
            this.panel1.Controls.Add(this.btnTab);
            this.panel1.Location = new System.Drawing.Point(24, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 551);
            this.panel1.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
            // 
            // btnTab
            // 
            this.btnTab.Active = false;
            this.btnTab.Activecolor = System.Drawing.Color.White;
            this.btnTab.BackColor = System.Drawing.Color.White;
            this.btnTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTab.BorderRadius = 0;
            this.btnTab.ButtonText = "   Overview";
            this.btnTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTab.DisabledColor = System.Drawing.Color.Gray;
            this.btnTab.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTab.Iconimage")));
            this.btnTab.Iconimage_right = null;
            this.btnTab.Iconimage_right_Selected = null;
            this.btnTab.Iconimage_Selected = null;
            this.btnTab.IconMarginLeft = 0;
            this.btnTab.IconMarginRight = 0;
            this.btnTab.IconRightVisible = true;
            this.btnTab.IconRightZoom = 0D;
            this.btnTab.IconVisible = true;
            this.btnTab.IconZoom = 50D;
            this.btnTab.IsTab = false;
            this.btnTab.Location = new System.Drawing.Point(13, 21);
            this.btnTab.Name = "btnTab";
            this.btnTab.Normalcolor = System.Drawing.Color.White;
            this.btnTab.OnHovercolor = System.Drawing.Color.White;
            this.btnTab.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnTab.selected = false;
            this.btnTab.Size = new System.Drawing.Size(211, 48);
            this.btnTab.TabIndex = 0;
            this.btnTab.Text = "   Overview";
            this.btnTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTab.Textcolor = System.Drawing.Color.DimGray;
            this.btnTab.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btnTab, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnTab, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnTab, "");
            this.btnTab.Click += new System.EventHandler(this.BtnTab_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.StartDeteBtn);
            this.panel2.Controls.Add(this.StopDeteBtn);
            this.panel2.Controls.Add(this.camBtn);
            this.panel2.Controls.Add(this.overviewTab1);
            this.panel2.Controls.Add(this.lblCurTab);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Controls.Add(this.locationsTab1);
            this.panel2.Location = new System.Drawing.Point(268, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 551);
            this.panel2.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.panel2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel2, "");
            // 
            // StartDeteBtn
            // 
            this.StartDeteBtn.BackColor = System.Drawing.Color.Transparent;
            this.StartDeteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartDeteBtn.BackgroundImage")));
            this.StartDeteBtn.ButtonText = "Start";
            this.StartDeteBtn.ButtonTextMarginLeft = 0;
            this.StartDeteBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.StartDeteBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.StartDeteBtn.DisabledForecolor = System.Drawing.Color.White;
            this.StartDeteBtn.ForeColor = System.Drawing.Color.White;
            this.StartDeteBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.StartDeteBtn.IconPadding = 10;
            this.StartDeteBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.StartDeteBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.StartDeteBtn.IdleBorderRadius = 10;
            this.StartDeteBtn.IdleBorderThickness = 0;
            this.StartDeteBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.StartDeteBtn.IdleIconLeftImage = null;
            this.StartDeteBtn.IdleIconRightImage = null;
            this.StartDeteBtn.Location = new System.Drawing.Point(442, 21);
            this.StartDeteBtn.Name = "StartDeteBtn";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 10;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.StartDeteBtn.onHoverState = stateProperties1;
            this.StartDeteBtn.Size = new System.Drawing.Size(110, 30);
            this.StartDeteBtn.TabIndex = 12;
            this.StartDeteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.StartDeteBtn, "");
            this.bunifuToolTip1.SetToolTipIcon(this.StartDeteBtn, null);
            this.bunifuToolTip1.SetToolTipTitle(this.StartDeteBtn, "");
            this.StartDeteBtn.Click += new System.EventHandler(this.StartDeteBtn_Click);
            // 
            // StopDeteBtn
            // 
            this.StopDeteBtn.BackColor = System.Drawing.Color.Transparent;
            this.StopDeteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StopDeteBtn.BackgroundImage")));
            this.StopDeteBtn.ButtonText = "Stop";
            this.StopDeteBtn.ButtonTextMarginLeft = 0;
            this.StopDeteBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.StopDeteBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.StopDeteBtn.DisabledForecolor = System.Drawing.Color.White;
            this.StopDeteBtn.ForeColor = System.Drawing.Color.White;
            this.StopDeteBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.StopDeteBtn.IconPadding = 10;
            this.StopDeteBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.StopDeteBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.StopDeteBtn.IdleBorderRadius = 10;
            this.StopDeteBtn.IdleBorderThickness = 0;
            this.StopDeteBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.StopDeteBtn.IdleIconLeftImage = null;
            this.StopDeteBtn.IdleIconRightImage = null;
            this.StopDeteBtn.Location = new System.Drawing.Point(558, 21);
            this.StopDeteBtn.Name = "StopDeteBtn";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 10;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.StopDeteBtn.onHoverState = stateProperties2;
            this.StopDeteBtn.Size = new System.Drawing.Size(110, 30);
            this.StopDeteBtn.TabIndex = 11;
            this.StopDeteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.StopDeteBtn, "");
            this.bunifuToolTip1.SetToolTipIcon(this.StopDeteBtn, null);
            this.bunifuToolTip1.SetToolTipTitle(this.StopDeteBtn, "");
            this.StopDeteBtn.Click += new System.EventHandler(this.StopDeteBtn_Click);
            // 
            // camBtn
            // 
            this.camBtn.BackColor = System.Drawing.Color.Transparent;
            this.camBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("camBtn.BackgroundImage")));
            this.camBtn.ButtonText = "Refresh Devices";
            this.camBtn.ButtonTextMarginLeft = 0;
            this.camBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.camBtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.camBtn.DisabledForecolor = System.Drawing.Color.White;
            this.camBtn.ForeColor = System.Drawing.Color.White;
            this.camBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.camBtn.IconPadding = 10;
            this.camBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.camBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.camBtn.IdleBorderRadius = 10;
            this.camBtn.IdleBorderThickness = 0;
            this.camBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.camBtn.IdleIconLeftImage = null;
            this.camBtn.IdleIconRightImage = null;
            this.camBtn.Location = new System.Drawing.Point(674, 21);
            this.camBtn.Name = "camBtn";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 10;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.camBtn.onHoverState = stateProperties3;
            this.camBtn.Size = new System.Drawing.Size(110, 30);
            this.camBtn.TabIndex = 10;
            this.camBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.camBtn, "");
            this.bunifuToolTip1.SetToolTipIcon(this.camBtn, null);
            this.bunifuToolTip1.SetToolTipTitle(this.camBtn, "");
            this.camBtn.Visible = false;
            this.camBtn.Click += new System.EventHandler(this.RfrshCamsBtnClick);
            // 
            // overviewTab1
            // 
            this.overviewTab1.BackColor = System.Drawing.Color.White;
            this.overviewTab1.Location = new System.Drawing.Point(13, 75);
            this.overviewTab1.Name = "overviewTab1";
            this.overviewTab1.Size = new System.Drawing.Size(771, 463);
            this.overviewTab1.TabIndex = 8;
            this.bunifuToolTip1.SetToolTip(this.overviewTab1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.overviewTab1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.overviewTab1, "");
            // 
            // lblCurTab
            // 
            this.lblCurTab.AutoSize = true;
            this.lblCurTab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurTab.ForeColor = System.Drawing.Color.DimGray;
            this.lblCurTab.Location = new System.Drawing.Point(23, 21);
            this.lblCurTab.Name = "lblCurTab";
            this.lblCurTab.Size = new System.Drawing.Size(79, 21);
            this.lblCurTab.TabIndex = 3;
            this.lblCurTab.Text = "Overview";
            this.bunifuToolTip1.SetToolTip(this.lblCurTab, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblCurTab, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblCurTab, "");
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(13, 45);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(771, 24);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator1, "");
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // locationsTab1
            // 
            this.locationsTab1.BackColor = System.Drawing.Color.Transparent;
            this.locationsTab1.Location = new System.Drawing.Point(13, 75);
            this.locationsTab1.Name = "locationsTab1";
            this.locationsTab1.Size = new System.Drawing.Size(771, 463);
            this.locationsTab1.TabIndex = 9;
            this.bunifuToolTip1.SetToolTip(this.locationsTab1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.locationsTab1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.locationsTab1, "");
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "   Location Profile";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 50D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(13, 75);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(211, 48);
            this.bunifuFlatButton2.TabIndex = 1;
            this.bunifuFlatButton2.Text = "   Location Profile";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.bunifuFlatButton2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuFlatButton2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuFlatButton2, "");
            this.bunifuFlatButton2.Visible = false;
            this.bunifuFlatButton2.Click += new System.EventHandler(this.BtnTab_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1086, 669);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnTab;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lblCurTab;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private OverviewTab overviewTab1;
        private LocationsTab locationsTab1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton camBtn;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton StartDeteBtn;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton StopDeteBtn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;

        public LocationsTab LocationsTab1 { get => locationsTab1; set => locationsTab1 = value; }
    }
}

