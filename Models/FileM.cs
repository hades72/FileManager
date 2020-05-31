using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Models
{
    public class FileM
    {
        public int iID { get; set; }

        public string sTitle { get; set; }

        public string sCategory { get; set; }

        public DateTime dtDateUpdate { get; set; }

        public string sNote { get; set; }

        public string sLinkPic { get; set; }
        
        public string sLinkFile { get; set; }

        public override string ToString()
        {
            return this.sTitle;
        }
    }
}
