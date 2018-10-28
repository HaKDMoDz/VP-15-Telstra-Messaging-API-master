namespace VP_15_Base_Project
{
    partial class keyEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(keyEntryForm));
            this.injectKeysBTN = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.useOldKeysTS = new MetroFramework.Controls.MetroToggle();
            this.idLBL = new MetroFramework.Controls.MetroLabel();
            this.secretLBL = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtIdEntry = new MetroFramework.Controls.MetroTextBox();
            this.txtSecretEntry = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.registerWB = new System.Windows.Forms.WebBrowser();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // injectKeysBTN
            // 
            this.injectKeysBTN.Enabled = false;
            this.injectKeysBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.injectKeysBTN.Image = null;
            this.injectKeysBTN.Location = new System.Drawing.Point(536, 194);
            this.injectKeysBTN.Name = "injectKeysBTN";
            this.injectKeysBTN.Size = new System.Drawing.Size(126, 43);
            this.injectKeysBTN.Style = MetroFramework.MetroColorStyle.White;
            this.injectKeysBTN.TabIndex = 0;
            this.injectKeysBTN.Text = "SAVE";
            this.injectKeysBTN.Theme = MetroFramework.MetroThemeStyle.Light;
            this.injectKeysBTN.UseSelectable = true;
            this.injectKeysBTN.UseStyleColors = true;
            this.injectKeysBTN.UseVisualStyleBackColor = true;
            this.injectKeysBTN.Visible = false;
            this.injectKeysBTN.Click += new System.EventHandler(this.injectKeysBTN_Click);
            // 
            // useOldKeysTS
            // 
            this.useOldKeysTS.AutoSize = true;
            this.useOldKeysTS.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.useOldKeysTS.Location = new System.Drawing.Point(227, 211);
            this.useOldKeysTS.Name = "useOldKeysTS";
            this.useOldKeysTS.Size = new System.Drawing.Size(80, 21);
            this.useOldKeysTS.Style = MetroFramework.MetroColorStyle.White;
            this.useOldKeysTS.TabIndex = 2;
            this.useOldKeysTS.Text = "Off";
            this.useOldKeysTS.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.useOldKeysTS.UseSelectable = true;
            this.useOldKeysTS.UseStyleColors = true;
            this.useOldKeysTS.CheckedChanged += new System.EventHandler(this.useOldKeysTS_CheckedChanged);
            // 
            // idLBL
            // 
            this.idLBL.AutoSize = true;
            this.idLBL.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.idLBL.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.idLBL.Location = new System.Drawing.Point(11, 126);
            this.idLBL.Name = "idLBL";
            this.idLBL.Size = new System.Drawing.Size(93, 25);
            this.idLBL.Style = MetroFramework.MetroColorStyle.Blue;
            this.idLBL.TabIndex = 4;
            this.idLBL.Text = "Client ID:";
            this.idLBL.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.idLBL.UseStyleColors = true;
            // 
            // secretLBL
            // 
            this.secretLBL.AutoSize = true;
            this.secretLBL.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.secretLBL.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.secretLBL.Location = new System.Drawing.Point(15, 158);
            this.secretLBL.Name = "secretLBL";
            this.secretLBL.Size = new System.Drawing.Size(128, 25);
            this.secretLBL.Style = MetroFramework.MetroColorStyle.Yellow;
            this.secretLBL.TabIndex = 5;
            this.secretLBL.Text = "Client Secret:";
            this.secretLBL.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.secretLBL.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(62, 209);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(129, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Restore Keys:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // txtIdEntry
            // 
            this.txtIdEntry.AllowDrop = true;
            // 
            // 
            // 
            this.txtIdEntry.CustomButton.Image = null;
            this.txtIdEntry.CustomButton.Location = new System.Drawing.Point(460, 1);
            this.txtIdEntry.CustomButton.Name = "";
            this.txtIdEntry.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdEntry.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdEntry.CustomButton.TabIndex = 1;
            this.txtIdEntry.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdEntry.CustomButton.UseSelectable = true;
            this.txtIdEntry.Icon = ((System.Drawing.Image)(resources.GetObject("txtIdEntry.Icon")));
            this.txtIdEntry.IconRight = true;
            this.txtIdEntry.Lines = new string[0];
            this.txtIdEntry.Location = new System.Drawing.Point(131, 127);
            this.txtIdEntry.MaxLength = 32767;
            this.txtIdEntry.Name = "txtIdEntry";
            this.txtIdEntry.PasswordChar = '\0';
            this.txtIdEntry.PromptText = "Press Blue Button to Paste Client id Key!";
            this.txtIdEntry.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdEntry.SelectedText = "";
            this.txtIdEntry.SelectionLength = 0;
            this.txtIdEntry.SelectionStart = 0;
            this.txtIdEntry.ShortcutsEnabled = true;
            this.txtIdEntry.ShowButton = true;
            this.txtIdEntry.Size = new System.Drawing.Size(482, 23);
            this.txtIdEntry.TabIndex = 7;
            this.txtIdEntry.UseSelectable = true;
            this.txtIdEntry.WaterMark = "Press Blue Button to Paste Client id Key!";
            this.txtIdEntry.WaterMarkColor = System.Drawing.Color.Black;
            this.txtIdEntry.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdEntry.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtIdEntry_ButtonClick);
            this.txtIdEntry.Enter += new System.EventHandler(this.txtIdEntry_Enter);
            // 
            // txtSecretEntry
            // 
            this.txtSecretEntry.AllowDrop = true;
            // 
            // 
            // 
            this.txtSecretEntry.CustomButton.Image = null;
            this.txtSecretEntry.CustomButton.Location = new System.Drawing.Point(460, 1);
            this.txtSecretEntry.CustomButton.Name = "";
            this.txtSecretEntry.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSecretEntry.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSecretEntry.CustomButton.TabIndex = 1;
            this.txtSecretEntry.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSecretEntry.CustomButton.UseSelectable = true;
            this.txtSecretEntry.Icon = ((System.Drawing.Image)(resources.GetObject("txtSecretEntry.Icon")));
            this.txtSecretEntry.IconRight = true;
            this.txtSecretEntry.Lines = new string[0];
            this.txtSecretEntry.Location = new System.Drawing.Point(180, 159);
            this.txtSecretEntry.MaxLength = 32767;
            this.txtSecretEntry.Name = "txtSecretEntry";
            this.txtSecretEntry.PasswordChar = '\0';
            this.txtSecretEntry.PromptText = "Press Blue Button to Paste Client Secret Key!";
            this.txtSecretEntry.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSecretEntry.SelectedText = "";
            this.txtSecretEntry.SelectionLength = 0;
            this.txtSecretEntry.SelectionStart = 0;
            this.txtSecretEntry.ShortcutsEnabled = true;
            this.txtSecretEntry.ShowButton = true;
            this.txtSecretEntry.Size = new System.Drawing.Size(482, 23);
            this.txtSecretEntry.TabIndex = 8;
            this.txtSecretEntry.UseSelectable = true;
            this.txtSecretEntry.WaterMark = "Press Blue Button to Paste Client Secret Key!";
            this.txtSecretEntry.WaterMarkColor = System.Drawing.Color.Black;
            this.txtSecretEntry.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSecretEntry.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtSecretEntry_ButtonClick);
            this.txtSecretEntry.Leave += new System.EventHandler(this.txtSecretEntry_Leave);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.registerWB);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(11, 246);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(651, 0);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // registerWB
            // 
            this.registerWB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerWB.Location = new System.Drawing.Point(0, 0);
            this.registerWB.MinimumSize = new System.Drawing.Size(20, 20);
            this.registerWB.Name = "registerWB";
            this.registerWB.ScriptErrorsSuppressed = true;
            this.registerWB.Size = new System.Drawing.Size(651, 20);
            this.registerWB.TabIndex = 2;
            this.registerWB.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.registerWB_DocumentCompleted);
            // 
            // keyEntryForm
            // 
            this.AcceptButton = this.injectKeysBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 263);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.txtSecretEntry);
            this.Controls.Add(this.txtIdEntry);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.secretLBL);
            this.Controls.Add(this.idLBL);
            this.Controls.Add(this.useOldKeysTS);
            this.Controls.Add(this.injectKeysBTN);
            this.MaximizeBox = false;
            this.Name = "keyEntryForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CLIENT KEY ENTRY";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.keyEntryForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton injectKeysBTN;
        private MetroFramework.Controls.MetroToggle useOldKeysTS;
        private MetroFramework.Controls.MetroLabel idLBL;
        private MetroFramework.Controls.MetroLabel secretLBL;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtIdEntry;
        private MetroFramework.Controls.MetroTextBox txtSecretEntry;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.WebBrowser registerWB;
    }
}