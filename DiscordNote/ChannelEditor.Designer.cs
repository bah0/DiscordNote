namespace DiscordNote
{
    partial class ChannelEditor
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
            this.lBox_channels = new System.Windows.Forms.ListBox();
            this.lbl_ChannelList = new System.Windows.Forms.Label();
            this.btn_addChannel = new System.Windows.Forms.Button();
            this.tbx_newChannel = new System.Windows.Forms.TextBox();
            this.lbl_ChannelName = new System.Windows.Forms.Label();
            this.btn_removeChannel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBox_channels
            // 
            this.lBox_channels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lBox_channels.FormattingEnabled = true;
            this.lBox_channels.Location = new System.Drawing.Point(15, 25);
            this.lBox_channels.Name = "lBox_channels";
            this.lBox_channels.Size = new System.Drawing.Size(247, 251);
            this.lBox_channels.TabIndex = 0;
            // 
            // lbl_ChannelList
            // 
            this.lbl_ChannelList.AutoSize = true;
            this.lbl_ChannelList.Location = new System.Drawing.Point(12, 9);
            this.lbl_ChannelList.Name = "lbl_ChannelList";
            this.lbl_ChannelList.Size = new System.Drawing.Size(65, 13);
            this.lbl_ChannelList.TabIndex = 1;
            this.lbl_ChannelList.Text = "Channel List";
            // 
            // btn_addChannel
            // 
            this.btn_addChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addChannel.Location = new System.Drawing.Point(166, 315);
            this.btn_addChannel.Name = "btn_addChannel";
            this.btn_addChannel.Size = new System.Drawing.Size(96, 23);
            this.btn_addChannel.TabIndex = 2;
            this.btn_addChannel.Text = "Add";
            this.btn_addChannel.UseVisualStyleBackColor = true;
            this.btn_addChannel.Click += new System.EventHandler(this.btn_addChannel_Click);
            // 
            // tbx_newChannel
            // 
            this.tbx_newChannel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_newChannel.Location = new System.Drawing.Point(96, 289);
            this.tbx_newChannel.Name = "tbx_newChannel";
            this.tbx_newChannel.Size = new System.Drawing.Size(166, 20);
            this.tbx_newChannel.TabIndex = 3;
            // 
            // lbl_ChannelName
            // 
            this.lbl_ChannelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ChannelName.AutoSize = true;
            this.lbl_ChannelName.Location = new System.Drawing.Point(13, 292);
            this.lbl_ChannelName.Name = "lbl_ChannelName";
            this.lbl_ChannelName.Size = new System.Drawing.Size(77, 13);
            this.lbl_ChannelName.TabIndex = 4;
            this.lbl_ChannelName.Text = "Channel Name";
            // 
            // btn_removeChannel
            // 
            this.btn_removeChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_removeChannel.Location = new System.Drawing.Point(15, 315);
            this.btn_removeChannel.Name = "btn_removeChannel";
            this.btn_removeChannel.Size = new System.Drawing.Size(87, 23);
            this.btn_removeChannel.TabIndex = 5;
            this.btn_removeChannel.Text = "Remove";
            this.btn_removeChannel.UseVisualStyleBackColor = true;
            this.btn_removeChannel.Click += new System.EventHandler(this.btn_removeChannel_Click);
            // 
            // ChannelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 351);
            this.Controls.Add(this.btn_removeChannel);
            this.Controls.Add(this.lbl_ChannelName);
            this.Controls.Add(this.tbx_newChannel);
            this.Controls.Add(this.btn_addChannel);
            this.Controls.Add(this.lbl_ChannelList);
            this.Controls.Add(this.lBox_channels);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(240, 0);
            this.Name = "ChannelEditor";
            this.ShowIcon = false;
            this.Text = "Channel Editor";
            this.Load += new System.EventHandler(this.ChannelEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBox_channels;
        private System.Windows.Forms.Label lbl_ChannelList;
        private System.Windows.Forms.Button btn_addChannel;
        private System.Windows.Forms.TextBox tbx_newChannel;
        private System.Windows.Forms.Label lbl_ChannelName;
        private System.Windows.Forms.Button btn_removeChannel;
    }
}