using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Models
{
    [Table("FileM")]

    public class FileM
    {
        [Key] // FileCode là key
        public string sFileCode { get; set; } // Ma so File

        public string sTitle { get; set; }

        public string sCategory { get; set; }

        public DateTime? dtDateUpdate { get; set; } // dau ? de chi ra truong nay co the null

        public string sNote { get; set; }

        public string sLinkPic { get; set; }
        
        public string sLinkFile { get; set; }
        public override string ToString()
        {
            return this.sTitle;
        }
    }
}
