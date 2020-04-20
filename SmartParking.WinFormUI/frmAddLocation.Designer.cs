namespace SmartParking.WinFormUI
{
    partial class FrmAddLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddLocation));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtDesc = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.lblCurTab = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnAddContact = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.CamDropDown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(438, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(26, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = false;
            this.txtName.AcceptsTab = false;
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtName.BackgroundImage")));
            this.txtName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtName.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtName.BorderRadius = 30;
            this.txtName.BorderThickness = 1;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.DefaultText = "";
            this.txtName.FillColor = System.Drawing.Color.White;
            this.txtName.HideSelection = true;
            this.txtName.IconLeft = null;
            this.txtName.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtName.IconPadding = 10;
            this.txtName.IconRight = null;
            this.txtName.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtName.Location = new System.Drawing.Point(80, 106);
            this.txtName.MaxLength = 32767;
            this.txtName.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtName.Modified = false;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ReadOnly = false;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(311, 45);
            this.txtName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtName.TabIndex = 4;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TextMarginLeft = 5;
            this.txtName.TextPlaceholder = "Name";
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtDesc
            // 
            this.txtDesc.AcceptsReturn = false;
            this.txtDesc.AcceptsTab = false;
            this.txtDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtDesc.BackgroundImage")));
            this.txtDesc.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtDesc.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtDesc.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtDesc.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtDesc.BorderRadius = 20;
            this.txtDesc.BorderThickness = 1;
            this.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDesc.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDesc.DefaultText = "";
            this.txtDesc.FillColor = System.Drawing.Color.White;
            this.txtDesc.HideSelection = true;
            this.txtDesc.IconLeft = null;
            this.txtDesc.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtDesc.IconPadding = 0;
            this.txtDesc.IconRight = null;
            this.txtDesc.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtDesc.Location = new System.Drawing.Point(80, 168);
            this.txtDesc.MaxLength = 32767;
            this.txtDesc.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtDesc.Modified = false;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.ReadOnly = false;
            this.txtDesc.SelectedText = "";
            this.txtDesc.SelectionLength = 0;
            this.txtDesc.SelectionStart = 0;
            this.txtDesc.ShortcutsEnabled = true;
            this.txtDesc.Size = new System.Drawing.Size(311, 92);
            this.txtDesc.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtDesc.TabIndex = 5;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDesc.TextMarginLeft = 5;
            this.txtDesc.TextPlaceholder = "Description";
            this.txtDesc.UseSystemPasswordChar = false;
            // 
            // lblCurTab
            // 
            this.lblCurTab.AutoSize = true;
            this.lblCurTab.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblCurTab.ForeColor = System.Drawing.Color.DimGray;
            this.lblCurTab.Location = new System.Drawing.Point(154, 19);
            this.lblCurTab.Name = "lblCurTab";
            this.lblCurTab.Size = new System.Drawing.Size(159, 32);
            this.lblCurTab.TabIndex = 16;
            this.lblCurTab.Text = "Add Location";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-1, 54);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(476, 35);
            this.bunifuSeparator1.TabIndex = 17;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnAddContact
            // 
            this.btnAddContact.BackColor = System.Drawing.Color.Transparent;
            this.btnAddContact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddContact.BackgroundImage")));
            this.btnAddContact.ButtonText = "Add Location Profile";
            this.btnAddContact.ButtonTextMarginLeft = 0;
            this.btnAddContact.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddContact.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnAddContact.DisabledForecolor = System.Drawing.Color.White;
            this.btnAddContact.ForeColor = System.Drawing.Color.White;
            this.btnAddContact.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddContact.IconPadding = 10;
            this.btnAddContact.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddContact.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddContact.IdleBorderRadius = 35;
            this.btnAddContact.IdleBorderThickness = 0;
            this.btnAddContact.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddContact.IdleIconLeftImage = null;
            this.btnAddContact.IdleIconRightImage = null;
            this.btnAddContact.Location = new System.Drawing.Point(80, 438);
            this.btnAddContact.Name = "btnAddContact";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties9.BorderRadius = 35;
            stateProperties9.BorderThickness = 1;
            stateProperties9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties9.IconLeftImage = null;
            stateProperties9.IconRightImage = null;
            this.btnAddContact.onHoverState = stateProperties9;
            this.btnAddContact.Size = new System.Drawing.Size(311, 45);
            this.btnAddContact.TabIndex = 18;
            this.btnAddContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddContact.Click += new System.EventHandler(this.BtnAddContact_Click);
            // 
            // CamDropDown
            // 
            this.CamDropDown.BackColor = System.Drawing.Color.White;
            this.CamDropDown.BorderRadius = 3;
            this.CamDropDown.Color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.CamDropDown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.CamDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.CamDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CamDropDown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.CamDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CamDropDown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.CamDropDown.FillDropDown = false;
            this.CamDropDown.FillIndicator = false;
            this.CamDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CamDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CamDropDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CamDropDown.FormattingEnabled = true;
            this.CamDropDown.Icon = null;
            this.CamDropDown.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.CamDropDown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.CamDropDown.ItemBackColor = System.Drawing.Color.White;
            this.CamDropDown.ItemBorderColor = System.Drawing.Color.White;
            this.CamDropDown.ItemForeColor = System.Drawing.Color.Black;
            this.CamDropDown.ItemHeight = 26;
            this.CamDropDown.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.CamDropDown.Location = new System.Drawing.Point(80, 307);
            this.CamDropDown.Name = "CamDropDown";
            this.CamDropDown.Size = new System.Drawing.Size(311, 32);
            this.CamDropDown.TabIndex = 20;
            this.CamDropDown.Text = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(76, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Camera:";
            // 
            // frmAddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.CamDropDown);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblCurTab);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.bunifuImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddContact";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtName;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtDesc;
        private System.Windows.Forms.Label lblCurTab;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddContact;
        private Bunifu.UI.WinForms.BunifuDropdown CamDropDown;
        private System.Windows.Forms.Label label1;
    }
}