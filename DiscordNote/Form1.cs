using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordNote
{
    public partial class DiscordNoteForm : Form
    {
        
        public DiscordNoteForm()
        {
            InitializeComponent();
            Channel.channels = new List<Channel>();
            populateList();
            populateChannelComboBoxes();
            

        }

        public void populateList()
        {
            String[] channelString = Properties.Settings.Default.Channels.Split(';');

            foreach (String s in channelString)
            {
                if (!String.IsNullOrEmpty(s) || !String.IsNullOrWhiteSpace(s)) new Channel(s);
                Console.WriteLine(s);
            }
        }

        public void populateChannelComboBoxes()
        {
            cb_postedChannel.Items.Clear();
            cb_correctChannel.Items.Clear();
            foreach(Channel c in Channel.channels)
            {
                cb_correctChannel.Items.Add(c);
                cb_postedChannel.Items.Add(c);
            }
        }

        private void menuItem_addChannels_Click(object sender, EventArgs e)
        {
            using (ChannelEditor editor = new ChannelEditor())
            {
                editor.ShowDialog(this);
            }
            populateChannelComboBoxes();
        }

        private void btnIdPaste_Click(object sender, EventArgs e)
        {
            tbx_discordID.Text = Clipboard.GetText();
        }

        private void btn_postedPaste_Click(object sender, EventArgs e)
        {
            cb_postedChannel.Text = Clipboard.GetText();
        }

        private void btn_correctPaste_Click(object sender, EventArgs e)
        {
            if(cb_correctChannel.Enabled) cb_correctChannel.Text = Clipboard.GetText();
        }

        private void btn_customPaste_Click(object sender, EventArgs e)
        {
            if(rtbx_customText.Enabled) rtbx_customText.Text = Clipboard.GetText();
        }

        private void btn_userPaste_Click(object sender, EventArgs e)
        {
            rtbx_userMessage.Text = Clipboard.GetText();
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("!user <@" + tbx_discordID.Text + ">");
        }

        private void btn_Warn_Click(object sender, EventArgs e)
        {
            string text = "";
            switch ((string)cbox_Violations.SelectedItem)
            {
                case "4 Notes Within 90 Days":
                    text = "!w add <@" + tbx_discordID.Text + "> You've received 4 notes in 90 days, please listen to our server support and follow the rules outlined in the channel description. Any questions use help_desk.";
                    break;
                case "Valorant":
                    text = "!w add <@" + tbx_discordID.Text + "> Selling / Trading Valorant accounts isn’t allowed in Trade Central. This is warning number " + tbx_warningNumber.Text + ".";
                    break;
                case "Fortnite":
                    text = "!w add <@" + tbx_discordID.Text + "> Selling / Trading Fortnite accounts isn’t allowed in Trade Central. This is warning number " + tbx_warningNumber.Text + ".";
                    break;
                case "DM Advertising":
                    text = "!w add <@" + tbx_discordID.Text + "> DM advertising isnt allowed in Trade Central.";
                    break;
                case "Toxicity / Harassment":
                    text = "!w add <@" + tbx_discordID.Text + "> Any kind of toxicity or verbal harassment isn’t allowed in Trade Central.";
                    break;
                case "Invalid Name":
                    text = "!w add <@" + tbx_discordID.Text + "> We have changed your name because we found it inappropriate / it has LTB in the name, please change it.";
                    break;
                case "Invalid PFP":
                    text = "!w add <@" + tbx_discordID.Text + "> You have been kicked from the server due your profile picture. We found it inappropiate so please change it and join back when you have changed it.";
                    break;
            }
            Clipboard.SetText(text);

        }

        private void btn_warningMessage_Click(object sender, EventArgs e)
        {
            string text = "";
            switch ((string)cbox_Violations.SelectedItem)
            {
                case "Location":
                    text = "Hello <@" + tbx_discordID.Text + ">,\r\n\r\nI'm reaching out to you because of your post in **#" + cb_postedChannel.Text + "**:\r\n```" + rtbx_userMessage.Text + "```\r\n\r\nThis post is better suited for **#" + cb_correctChannel.Text + "**. As a result, your message has been deleted.\r\n\r\nIf you have any questions please let me know and I'd be happy to explain in further detail.\r\n\r\nTrade Central,\r\nhttps://imgur.com/1YquW2G.png";
                    break;
                case "Size":
                    text = "Hello <@" + tbx_discordID.Text + ">,\r\n\r\nI'm reaching out to you because of your post in **#" + cb_postedChannel.Text + "**:\r\n```" + rtbx_userMessage.Text + "```\r\n\r\nTrades in posts are limited to 8 lines, 1 trade per line. As a result, your message has been deleted.\r\n\r\nIf you have any questions please let me know and I'd be happy to explain in further detail.\r\n\r\nTrade Central,\r\nhttps://imgur.com/1YquW2G.png";
                    break;
                case "Quicksell":
                    text = "Hello <@" + tbx_discordID.Text + ">,\r\n\r\nI'm reaching out to you because of your post in **#" + cb_postedChannel.Text + "**:\r\n```" + rtbx_userMessage.Text + "```\r\n\r\nQuicksell offers of any kind are not allowed in Trade Central. As a result, your message has been deleted.\r\n\r\nIf you have any questions please let me know and I'd be happy to explain in further detail.\r\n\r\n\r\nTrade Central,\r\nhttps://imgur.com/1YquW2G.png";
                    break;
                case "Spam":
                    text = "Hello <@" + tbx_discordID.Text + ">,\r\n\r\nI'm reaching out to you because of your post in **#" + cb_postedChannel.Text + "**:\r\n```" + rtbx_userMessage.Text + "```\r\n\r\nPlease limit your posts to one post per screen. As a result, your message has been deleted.\r\n\r\nIf you have any questions please let me know and I'd be happy to explain in further detail.\r\n\r\nTrade Central,\r\nhttps://imgur.com/1YquW2G.png";
                    break;
                case "Custom":
                    text = "Hello <@" + tbx_discordID.Text + ">,\r\n\r\nI'm reaching out to you because of your post in **#" + cb_postedChannel.Text + "**:\r\n```" + rtbx_userMessage.Text + "```\r\n\r\n" + rtbx_customText.Text + ". As a result, your message has been deleted.\r\n\r\nIf you have any questions please let me know and I'd be happy to explain in further detail.\r\n\r\nTrade Central,\r\nhttps://imgur.com/1YquW2G.png";
                    break;
                case "Multiple":
                    string location = "", quicksell = "", size = "", spam = "";

                    if (check_Location.Checked) location = String.Format("\r\nLocation: This post is better suited for **#{0}**", cb_correctChannel.Text);
                    if (check_Quicksell.Checked) quicksell = "\r\nQuicksell: Quicksell offers of any kind are not allowed in Trade Central.";
                    if (check_Size.Checked) size = "\r\nSize: Trades in posts are limited to 8 lines, 1 trade per line.";
                    if (check_Spam.Checked) spam = "\r\nSpamming: Please limit your posts to one post per screen.";

                    text = String.Format("Hello <@{0}>," +
                        "\r\n" +
                        "\r\nI'm reaching out to you because of your post in **#{1}**:" +
                        "\r\n```{2}```" +
                        "\r\n" +
                        "\r\nThis post violates against multiple rules:" +
                        "\r\n" +
                        "{3}" +
                        "{4}" +
                        "{5}" +
                        "{6}" +
                        "\r\n" +
                        "\r\nAs a result, your message has been deleted." +
                        "\r\n" +
                        "\r\nIf you have any questions please let me know and I'd be happy to explain in further detail." +
                        "\r\n" +
                        "\r\nTrade Central," +
                        "\r\nhttps://imgur.com/1YquW2G.png",
                        tbx_discordID.Text // 0
                        ,cb_postedChannel.Text //1
                        ,rtbx_userMessage.Text //2
                        ,location //3
                        , quicksell //4
                        , size // 5
                        , spam // 6
                        );

                    /*
                     * text = "Hello <@***>,
                     * \r\n
                     * \r\nI'm reaching out to you because of your post in **#<postedChannel>**:
                     * \r\n```" + rtbx_userMessage.Text + "```
                     * \r\n
                     * \r\n" + rtbx_customText.Text + ". As a result, your message has been deleted.
                     * \r\n
                     * \r\nIf you have any questions please let me know and I'd be happy to explain in further detail.
                     * \r\n
                     * \r\nTrade Central,
                     * \r\nhttps://imgur.com/1YquW2G.png"
                     */

                    /*
                     * text = "Hello <@***>,
                     * \r\n
                     * \r\nI'm reaching out to you because of your post in **#<postedChannel>**:
                     * \r\nThis post violates multiple rules:
                     * \r\n Location: This post is better suited for **#" + cb_correctChannel.Text + "**
                     * \r\n Size: Trades in posts are limited to 8 lines, 1 trade per line.
                     * \r\n Quicksell: Quicksell offers of any kind are not allowed in Trade Central.
                     * \r\n Spamming: Please limit your posts to one post per screen.
                     * 
                     * \r\nAs a result, your message has been deleted.
                     * \r\n
                     * \r\nIf you have any questions please let me know and I'd be happy to explain in further detail.
                     * \r\n
                     * \r\nTrade Central,
                     * \r\nhttps://imgur.com/1YquW2G.png"
                     */
                    break;
            }
            Clipboard.SetText(text);
        }

        private void btn_Note_Click(object sender, EventArgs e)
        {
            string text = "";
            switch ((string)cbox_Violations.SelectedItem)
            {
                case "Location":
                    text = "!note add <@" + tbx_discordID.Text + "> Description: User has posted in an unsuitable channel. - Location: " + cb_postedChannel.Text + ". User has been informed.";
                    break;
                case "Size":
                    text = "!note add <@" + tbx_discordID.Text + "> Description: A user has posted an offer including more than 8 trades. - Location: " + cb_postedChannel.Text + ". User has been informed.";
                    break;
                case "Quicksell":
                    text = "!note add <@" + tbx_discordID.Text + "> Description: User has posted an offer involving quicksells. - Location: " + cb_postedChannel.Text + ". User has been informed.";
                    break;
                case "Spam":
                    text = "!note add <@" + tbx_discordID.Text + "> Description: User has purposely spammed one or more channels. - Location: " + cb_postedChannel.Text + ". User has been informed.";
                    break;
                case "Custom":
                    text = "!note add <@" + tbx_discordID.Text + "> Description: User has posted an invalid offer. - Location: " + cb_postedChannel.Text + ". User has been informed.";
                    break;
                case "Multiple":
                    text = String.Format("!note add <@{0}> Description: User has commited multiple violations. - Location: {1}. User has been informed.", tbx_discordID.Text , cb_postedChannel.Text);
                    break;
            }
            Clipboard.SetText(text);
        }

        private void ReplaceSpacesWithUnderscore(object sender, EventArgs e)
        {
            TextBox obj = (TextBox)sender;
            string text = obj.Text;
            obj.Text = text.Replace(" ", "_");
        }


        private void cbox_Violations_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbx_userMessage.Enabled = true;
            cb_postedChannel.Enabled = true;
            tbx_warningNumber.Enabled = false;
            cb_correctChannel.Enabled = false;
            rtbx_customText.Enabled = false;
            check_Location.Enabled = false;
            check_Quicksell.Enabled = false;
            check_Size.Enabled = false;
            check_Spam.Enabled = false;
            cb_correctChannel.Text = string.Empty;
            string text = (string)cbox_Violations.SelectedItem;
            if (text != null)
            {
                switch (text)
                {
                    case "Location":
                        cb_correctChannel.Enabled = true;
                        break;
                    case "Custom":
                        rtbx_customText.Enabled = true;
                        break;
                    case "4 Notes Within 90 Days":
                    case "DM Advertising":
                    case "Toxicity / Harassment":
                    case "Invalid Name":
                    case "Invalid PFP":
                        cb_postedChannel.Enabled = false;
                        rtbx_userMessage.Enabled = false;
                        break;
                    case "Valorant":
                    case "Fortnite":
                        cb_postedChannel.Enabled = false;
                        rtbx_userMessage.Enabled = false;
                        tbx_warningNumber.Enabled = true;
                        break;
                    case "Multiple":
                        check_Location.Enabled = true;
                        check_Quicksell.Enabled = true;
                        check_Size.Enabled = true;
                        check_Spam.Enabled = true;
                        if (check_Location.Checked) cb_correctChannel.Enabled = true;
                        else cb_correctChannel.Enabled = false;
                        break;
                }
            }
        }

        private void check_Location_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Location.Checked) cb_correctChannel.Enabled = true;
            else cb_correctChannel.Enabled = false;
        }
    }
}
