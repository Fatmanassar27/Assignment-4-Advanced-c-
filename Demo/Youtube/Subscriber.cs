using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Youtube
{
    internal class Subscriber
    {
        public string SubscriberName { get; set; }

        public void Notifi (Vedio vedio , Channel channel)
        {
            Console.WriteLine($"{channel} Added New Vedio ..! {SubscriberName}\n{vedio}\n\n ");
        }

        public override string ToString()
        {
            return $"Subscriber Name is {SubscriberName}";
        }
    }
}
