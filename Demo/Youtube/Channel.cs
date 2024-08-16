using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Youtube
{
    internal class Channel
    {
        public string ChannelName  { get; set; }

        public List<Vedio> Vedios { get; set; } = new List<Vedio>();

        public void AddVedio (Vedio vedio)
        {
            Vedios.Add (vedio);
            UploadVedio?.Invoke(vedio , this);
        }
        public event Action<Vedio, Channel>? UploadVedio;
        public override string ToString()
        {
            return $"Channel Name is {ChannelName}";
        }
    }
}
