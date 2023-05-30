using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinder
{
    public class User
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string photo { get; set; }
        public string gender { get; set; }
        public string description { get; set; }
        public int rating { get; set; }

        public Point ratingEndpoint => new Point((float)rating/5, 0);
        public bool hasOneStar => rating > 10;
    }
}
