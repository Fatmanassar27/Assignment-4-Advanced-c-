using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fifa
{
    internal class Player
    {
        public string Name { get; set; }
        public string TeamName { get; set; }

        public void Run(Ball ball)
        {
            Console.WriteLine($"player {Name} is running after ball {ball.Location}");
        }
    }
}
