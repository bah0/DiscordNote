namespace DiscordNote
{
    partial class DiscordNoteForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_discordID = new System.Windows.Forms.Label();
            this.tbx_discordID = new System.Windows.Forms.TextBox();
            this.lbl_postedChannel = new System.Windows.Forms.Label();
            this.lbl_correctChannel = new System.Windows.Forms.Label();
            this.btnIdPaste = new System.Windows.Forms.Button();
            this.btn_postedPaste = new System.Windows.Forms.Button();
            this.btn_correctPaste = new System.Windows.Forms.Button();
            this.rtbx_customText = new System.Windows.Forms.RichTextBox();
            this.btn_customPaste = new System.Windows.Forms.Button();
            this.lbl_customMessage = new System.Windows.Forms.Label();
            this.lbl_warningNumber = new System.Windows.Forms.Label();
            this.tbx_warningNumber = new System.Windows.Forms.TextBox();
            this.rtbx_userMessage = new System.Windows.Forms.RichTextBox();
            this.lbl_userMessage = new System.Windows.Forms.Label();
            this.check_Location = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_User = new System.Windows.Forms.Button();
            this.btn_Note = new System.Windows.Forms.Button();
            this.btn_Warn = new System.Windows.Forms.Button();
            this.btn_warningMessage = new System.Windows.Forms.Button();
            this.cbox_Violations = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem_Channels = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_addChannels = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_postedChannel = new System.Windows.Forms.ComboBox();
            this.cb_correctChannel = new System.Windows.Forms.ComboBox();
            this.btn_userPaste = new System.Windows.Forms.Button();
            this.check_Size = new System.Windows.Forms.CheckBox();
            this.check_Quicksell = new System.Windows.Forms.CheckBox();
            this.check_Spam = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_discordID
            // 
            this.lbl_discordID.AutoSize = true;
            this.lbl_discordID.Location = new System.Drawing.Point(15, 66);
            this.lbl_discordID.Name = "lbl_discordID";
            this.lbl_discordID.Size = new System.Drawing.Size(60, 13);
            this.lbl_discordID.TabIndex = 0;
            this.lbl_discordID.Text = "Discord ID:";
            // 
            // tbx_discordID
            // 
            this.tbx_discordID.Location = new System.Drawing.Point(109, 63);
            this.tbx_discordID.Name = "tbx_discordID";
            this.tbx_discordID.Size = new System.Drawing.Size(170, 20);
            this.tbx_discordID.TabIndex = 1;
            // 
            // lbl_postedChannel
            // 
            this.lbl_postedChannel.AutoSize = true;
            this.lbl_postedChannel.Location = new System.Drawing.Point(15, 92);
            this.lbl_postedChannel.Name = "lbl_postedChannel";
            this.lbl_postedChannel.Size = new System.Drawing.Size(82, 13);
            this.lbl_postedChannel.TabIndex = 4;
            this.lbl_postedChannel.Text = "Posted Channel";
            // 
            // lbl_correctChannel
            // 
            this.lbl_correctChannel.AutoSize = true;
            this.lbl_correctChannel.Location = new System.Drawing.Point(14, 118);
            this.lbl_correctChannel.Name = "lbl_correctChannel";
            this.lbl_correctChannel.Size = new System.Drawing.Size(83, 13);
            this.lbl_correctChannel.TabIndex = 5;
            this.lbl_correctChannel.Text = "Correct Channel";
            // 
            // btnIdPaste
            // 
            this.btnIdPaste.Location = new System.Drawing.Point(285, 61);
            this.btnIdPaste.Name = "btnIdPaste";
            this.btnIdPaste.Size = new System.Drawing.Size(75, 23);
            this.btnIdPaste.TabIndex = 6;
            this.btnIdPaste.Text = "Paste";
            this.btnIdPaste.UseVisualStyleBackColor = true;
            this.btnIdPaste.Click += new System.EventHandler(this.btnIdPaste_Click);
            // 
            // btn_postedPaste
            // 
            this.btn_postedPaste.Location = new System.Drawing.Point(285, 87);
            this.btn_postedPaste.Name = "btn_postedPaste";
            this.btn_postedPaste.Size = new System.Drawing.Size(75, 23);
            this.btn_postedPaste.TabIndex = 7;
            this.btn_postedPaste.Text = "Paste";
            this.btn_postedPaste.UseVisualStyleBackColor = true;
            this.btn_postedPaste.Click += new System.EventHandler(this.btn_postedPaste_Click);
            // 
            // btn_correctPaste
            // 
            this.btn_correctPaste.Location = new System.Drawing.Point(285, 113);
            this.btn_correctPaste.Name = "btn_correctPaste";
            this.btn_correctPaste.Size = new System.Drawing.Size(75, 23);
            this.btn_correctPaste.TabIndex = 8;
            this.btn_correctPaste.Text = "Paste";
            this.btn_correctPaste.UseVisualStyleBackColor = true;
            this.btn_correctPaste.Click += new System.EventHandler(this.btn_correctPaste_Click);
            // 
            // rtbx_customText
            // 
            this.rtbx_customText.Location = new System.Drawing.Point(44, 160);
            this.rtbx_customText.Name = "rtbx_customText";
            this.rtbx_customText.Size = new System.Drawing.Size(235, 106);
            this.rtbx_customText.TabIndex = 9;
            this.rtbx_customText.Text = "";
            // 
            // btn_customPaste
            // 
            this.btn_customPaste.Location = new System.Drawing.Point(285, 160);
            this.btn_customPaste.Name = "btn_customPaste";
            this.btn_customPaste.Size = new System.Drawing.Size(75, 23);
            this.btn_customPaste.TabIndex = 10;
            this.btn_customPaste.Text = "Paste";
            this.btn_customPaste.UseVisualStyleBackColor = true;
            this.btn_customPaste.Click += new System.EventHandler(this.btn_customPaste_Click);
            // 
            // lbl_customMessage
            // 
            this.lbl_customMessage.AutoSize = true;
            this.lbl_customMessage.Location = new System.Drawing.Point(15, 144);
            this.lbl_customMessage.Name = "lbl_customMessage";
            this.lbl_customMessage.Size = new System.Drawing.Size(88, 13);
            this.lbl_customMessage.TabIndex = 11;
            this.lbl_customMessage.Text = "Custom Message";
            // 
            // lbl_warningNumber
            // 
            this.lbl_warningNumber.AutoSize = true;
            this.lbl_warningNumber.Location = new System.Drawing.Point(15, 286);
            this.lbl_warningNumber.Name = "lbl_warningNumber";
            this.lbl_warningNumber.Size = new System.Drawing.Size(87, 13);
            this.lbl_warningNumber.TabIndex = 12;
            this.lbl_warningNumber.Text = "Warning Number";
            // 
            // tbx_warningNumber
            // 
            this.tbx_warningNumber.Location = new System.Drawing.Point(109, 283);
            this.tbx_warningNumber.Name = "tbx_warningNumber";
            this.tbx_warningNumber.Size = new System.Drawing.Size(170, 20);
            this.tbx_warningNumber.TabIndex = 13;
            // 
            // rtbx_userMessage
            // 
            this.rtbx_userMessage.Location = new System.Drawing.Point(44, 328);
            this.rtbx_userMessage.Name = "rtbx_userMessage";
            this.rtbx_userMessage.Size = new System.Drawing.Size(235, 106);
            this.rtbx_userMessage.TabIndex = 14;
            this.rtbx_userMessage.Text = "";
            // 
            // lbl_userMessage
            // 
            this.lbl_userMessage.AutoSize = true;
            this.lbl_userMessage.Location = new System.Drawing.Point(15, 312);
            this.lbl_userMessage.Name = "lbl_userMessage";
            this.lbl_userMessage.Size = new System.Drawing.Size(75, 13);
            this.lbl_userMessage.TabIndex = 15;
            this.lbl_userMessage.Text = "User Message";
            // 
            // check_Location
            // 
            this.check_Location.AutoSize = true;
            this.check_Location.Enabled = false;
            this.check_Location.Location = new System.Drawing.Point(400, 38);
            this.check_Location.Name = "check_Location";
            this.check_Location.Size = new System.Drawing.Size(103, 17);
            this.check_Location.TabIndex = 17;
            this.check_Location.Text = "check_Location";
            this.check_Location.UseVisualStyleBackColor = true;
            this.check_Location.CheckedChanged += new System.EventHandler(this.check_Location_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Violations";
            // 
            // btn_User
            // 
            this.btn_User.Location = new System.Drawing.Point(11, 446);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(56, 23);
            this.btn_User.TabIndex = 19;
            this.btn_User.Text = "User";
            this.btn_User.UseVisualStyleBackColor = true;
            this.btn_User.Click += new System.EventHandler(this.btn_User_Click);
            // 
            // btn_Note
            // 
            this.btn_Note.Location = new System.Drawing.Point(73, 446);
            this.btn_Note.Name = "btn_Note";
            this.btn_Note.Size = new System.Drawing.Size(56, 23);
            this.btn_Note.TabIndex = 20;
            this.btn_Note.Text = "Note";
            this.btn_Note.UseVisualStyleBackColor = true;
            this.btn_Note.Click += new System.EventHandler(this.btn_Note_Click);
            // 
            // btn_Warn
            // 
            this.btn_Warn.Location = new System.Drawing.Point(135, 446);
            this.btn_Warn.Name = "btn_Warn";
            this.btn_Warn.Size = new System.Drawing.Size(56, 23);
            this.btn_Warn.TabIndex = 21;
            this.btn_Warn.Text = "Warn";
            this.btn_Warn.UseVisualStyleBackColor = true;
            this.btn_Warn.Click += new System.EventHandler(this.btn_Warn_Click);
            // 
            // btn_warningMessage
            // 
            this.btn_warningMessage.Location = new System.Drawing.Point(197, 446);
            this.btn_warningMessage.Name = "btn_warningMessage";
            this.btn_warningMessage.Size = new System.Drawing.Size(104, 23);
            this.btn_warningMessage.TabIndex = 22;
            this.btn_warningMessage.Text = "Warning Message";
            this.btn_warningMessage.UseVisualStyleBackColor = true;
            this.btn_warningMessage.Click += new System.EventHandler(this.btn_warningMessage_Click);
            // 
            // cbox_Violations
            // 
            this.cbox_Violations.FormattingEnabled = true;
            this.cbox_Violations.Items.AddRange(new object[] {
            "Location",
            "Size",
            "Quicksell",
            "Spam",
            "Custom",
            "4 Notes Within 90 Days",
            "Valorant",
            "Fortnite",
            "DM Advertising",
            "Toxicity / Harassment",
            "Invalid Name",
            "Invalid PFP",
            "Multiple"});
            this.cbox_Violations.Location = new System.Drawing.Point(109, 36);
            this.cbox_Violations.Name = "cbox_Violations";
            this.cbox_Violations.Size = new System.Drawing.Size(170, 21);
            this.cbox_Violations.TabIndex = 23;
            this.cbox_Violations.SelectedIndexChanged += new System.EventHandler(this.cbox_Violations_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Channels});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItem_Channels
            // 
            this.menuItem_Channels.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_addChannels});
            this.menuItem_Channels.Name = "menuItem_Channels";
            this.menuItem_Channels.Size = new System.Drawing.Size(68, 20);
            this.menuItem_Channels.Text = "Channels";
            // 
            // menuItem_addChannels
            // 
            this.menuItem_addChannels.Name = "menuItem_addChannels";
            this.menuItem_addChannels.Size = new System.Drawing.Size(94, 22);
            this.menuItem_addChannels.Text = "Edit";
            this.menuItem_addChannels.Click += new System.EventHandler(this.menuItem_addChannels_Click);
            // 
            // cb_postedChannel
            // 
            this.cb_postedChannel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_postedChannel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_postedChannel.FormattingEnabled = true;
            this.cb_postedChannel.Location = new System.Drawing.Point(109, 89);
            this.cb_postedChannel.Name = "cb_postedChannel";
            this.cb_postedChannel.Size = new System.Drawing.Size(170, 21);
            this.cb_postedChannel.TabIndex = 25;
            // 
            // cb_correctChannel
            // 
            this.cb_correctChannel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_correctChannel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_correctChannel.FormattingEnabled = true;
            this.cb_correctChannel.Location = new System.Drawing.Point(109, 115);
            this.cb_correctChannel.Name = "cb_correctChannel";
            this.cb_correctChannel.Size = new System.Drawing.Size(170, 21);
            this.cb_correctChannel.TabIndex = 26;
            // 
            // btn_userPaste
            // 
            this.btn_userPaste.Location = new System.Drawing.Point(285, 328);
            this.btn_userPaste.Name = "btn_userPaste";
            this.btn_userPaste.Size = new System.Drawing.Size(75, 23);
            this.btn_userPaste.TabIndex = 16;
            this.btn_userPaste.Text = "Paste";
            this.btn_userPaste.UseVisualStyleBackColor = true;
            this.btn_userPaste.Click += new System.EventHandler(this.btn_userPaste_Click);
            // 
            // check_Size
            // 
            this.check_Size.AutoSize = true;
            this.check_Size.Enabled = false;
            this.check_Size.Location = new System.Drawing.Point(400, 61);
            this.check_Size.Name = "check_Size";
            this.check_Size.Size = new System.Drawing.Size(82, 17);
            this.check_Size.TabIndex = 27;
            this.check_Size.Text = "check_Size";
            this.check_Size.UseVisualStyleBackColor = true;
            // 
            // check_Quicksell
            // 
            this.check_Quicksell.AutoSize = true;
            this.check_Quicksell.Enabled = false;
            this.check_Quicksell.Location = new System.Drawing.Point(400, 84);
            this.check_Quicksell.Name = "check_Quicksell";
            this.check_Quicksell.Size = new System.Drawing.Size(105, 17);
            this.check_Quicksell.TabIndex = 28;
            this.check_Quicksell.Text = "check_Quicksell";
            this.check_Quicksell.UseVisualStyleBackColor = true;
            // 
            // check_Spam
            // 
            this.check_Spam.AutoSize = true;
            this.check_Spam.Enabled = false;
            this.check_Spam.Location = new System.Drawing.Point(400, 107);
            this.check_Spam.Name = "check_Spam";
            this.check_Spam.Size = new System.Drawing.Size(89, 17);
            this.check_Spam.TabIndex = 29;
            this.check_Spam.Text = "check_Spam";
            this.check_Spam.UseVisualStyleBackColor = true;
            // 
            // DiscordNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 486);
            this.Controls.Add(this.check_Spam);
            this.Controls.Add(this.check_Quicksell);
            this.Controls.Add(this.check_Size);
            this.Controls.Add(this.cb_correctChannel);
            this.Controls.Add(this.cb_postedChannel);
            this.Controls.Add(this.cbox_Violations);
            this.Controls.Add(this.btn_warningMessage);
            this.Controls.Add(this.btn_Warn);
            this.Controls.Add(this.btn_Note);
            this.Controls.Add(this.btn_User);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check_Location);
            this.Controls.Add(this.btn_userPaste);
            this.Controls.Add(this.lbl_userMessage);
            this.Controls.Add(this.rtbx_userMessage);
            this.Controls.Add(this.tbx_warningNumber);
            this.Controls.Add(this.lbl_warningNumber);
            this.Controls.Add(this.lbl_customMessage);
            this.Controls.Add(this.btn_customPaste);
            this.Controls.Add(this.rtbx_customText);
            this.Controls.Add(this.btn_correctPaste);
            this.Controls.Add(this.btn_postedPaste);
            this.Controls.Add(this.btnIdPaste);
            this.Controls.Add(this.lbl_correctChannel);
            this.Controls.Add(this.lbl_postedChannel);
            this.Controls.Add(this.tbx_discordID);
            this.Controls.Add(this.lbl_discordID);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DiscordNoteForm";
            this.Text = "DiscordNote";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_discordID;
        private System.Windows.Forms.TextBox tbx_discordID;
        private System.Windows.Forms.Label lbl_postedChannel;
        private System.Windows.Forms.Label lbl_correctChannel;
        private System.Windows.Forms.Button btnIdPaste;
        private System.Windows.Forms.Button btn_postedPaste;
        private System.Windows.Forms.Button btn_correctPaste;
        private System.Windows.Forms.RichTextBox rtbx_customText;
        private System.Windows.Forms.Button btn_customPaste;
        private System.Windows.Forms.Label lbl_customMessage;
        private System.Windows.Forms.Label lbl_warningNumber;
        private System.Windows.Forms.TextBox tbx_warningNumber;
        private System.Windows.Forms.RichTextBox rtbx_userMessage;
        private System.Windows.Forms.Label lbl_userMessage;
        private System.Windows.Forms.CheckBox check_Location;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Button btn_Note;
        private System.Windows.Forms.Button btn_Warn;
        private System.Windows.Forms.Button btn_warningMessage;
        private System.Windows.Forms.ComboBox cbox_Violations;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Channels;
        private System.Windows.Forms.ToolStripMenuItem menuItem_addChannels;
        private System.Windows.Forms.ComboBox cb_postedChannel;
        private System.Windows.Forms.ComboBox cb_correctChannel;
        private System.Windows.Forms.Button btn_userPaste;
        private System.Windows.Forms.CheckBox check_Size;
        private System.Windows.Forms.CheckBox check_Quicksell;
        private System.Windows.Forms.CheckBox check_Spam;
    }
}

