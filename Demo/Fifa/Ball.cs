using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fifa
{
    internal class Ball
    {
        public int Id { get; set; }

        private Location location ;

        public Location Location 
        {
            get { return location ; }

            set 
            {
                if (!location.Equals(value))
                {
                    location = value;
                    BallLocationChanged?.Invoke(this);
                }
            }
        }

        public event Action<Ball>? BallLocationChanged;

        public override string ToString()
        {
            return $"( id = {Id}  location {location})";
        }

    }
}
