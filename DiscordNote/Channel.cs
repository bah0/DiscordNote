using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordNote
{
    class Channel : IComparable
    {
        public static List<Channel> channels;
        public string Name;
        public Channel(string name) 
        {
            this.Name = name;
            if(channels == null)
            {
                channels = new List<Channel>();
            }
            channels.Add(this);
            if(channels.Count > 2) channels.Sort();
        }

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(object obj)
        {
            return this.Name.CompareTo(obj.ToString());
        }

    }
}
