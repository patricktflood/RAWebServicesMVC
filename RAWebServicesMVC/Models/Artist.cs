using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAWebServicesMVC
{
    public class Artist
    {
        public string name { get; set; }
        public string profileImage { get; set; }
        public string profileURL { get; set; }

        public Artist(string name, string profileImage, string profileURL)
        {
            this.name = name;
            this.profileImage = profileImage;
            this.profileURL = profileURL;
        }
    }
}
