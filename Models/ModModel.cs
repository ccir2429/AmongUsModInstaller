using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmongUsModLauncher.Models
{
    public class ModModel
    {
        public string Name { get; set; }        // release name - required
        public string Tag_name { get; set; }    // release tag - required
        public List<AssetModel> Assets { get; set; } // Assets - required if it is custom version
        public string Body { get; set; } // required - can be empty string
        /// <summary>
        /// tells the program if the mod contains required properties
        /// </summary>
        public bool Is_compatible { get; set; } // required - will be used at later date
        /// <summary>
        /// tells the program if the mod has the assets property 
        /// </summary>
        public bool Is_custom_version { get; set; } // optional 
        /// <summary>
        /// contains the developer name and mod(project) name separated by slash "/"
        /// </summary>
        public string Dev_mod { get; set; } // required
        public string Image_url { get; set; } // optional - will be used at later date
    }
}
