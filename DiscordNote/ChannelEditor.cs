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
    public partial class ChannelEditor : Form
    {
        public ChannelEditor()
        {
            InitializeComponent();
        }

        private void ChannelEditor_Load(object sender, EventArgs e)
        {

            populateList();
        }

        private void populateList()
        {
            lBox_channels.Items.Clear();
            foreach (Channel c in Channel.channels)
            {
                lBox_channels.Items.Add(c);
            }
        }

        private void saveList()
        {
            StringBuilder bs = new StringBuilder();
            foreach (Channel c in Channel.channels)
            {
                bs.Append(c.Name);
                bs.Append(";");
            }
            Console.WriteLine(bs.ToString());
            Properties.Settings.Default.Channels = bs.ToString();
            Properties.Settings.Default.Save();
        }

        private void btn_addChannel_Click(object sender, EventArgs e)
        {
            bool free = true;
            foreach(Channel c in Channel.channels)
            {
                if(c.Name == tbx_newChannel.Text || String.IsNullOrEmpty(tbx_newChannel.Text) || String.IsNullOrWhiteSpace(tbx_newChannel.Text))
                {
                    MessageBox.Show("Channel already in list or channel name is empty");
                    free = false;
                    break;
                }
            }

            if (free) { 
                new Channel(tbx_newChannel.Text); 
            }

            populateList();
            saveList();
        }

        private void btn_removeChannel_Click(object sender, EventArgs e)
        {
            bool found = false;
            Channel c = (Channel)lBox_channels.SelectedItem;
            if(c != null)
            {
                foreach (Channel ch in Channel.channels)
                {
                    if (c.Name == ch.Name)
                    {
                        found = true;
                    }
                }
            }
            if (found) Channel.channels.Remove(c);
            else MessageBox.Show("Item not found. Select item to delete in list and then press delete.");
            populateList();
            saveList();
        }
    }
}
