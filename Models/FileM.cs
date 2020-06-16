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
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // Tắt tự động nhận dạng
        public int iFileCode { get; set; } // Mã số tài liệu

        public string sTitle { get; set; }

        public string sCategory { get; set; }

        public DateTime dtDateUpdate { get; set; } 

        public string sNote { get; set; }

        public string sLinkPic { get; set; }
        
        public string sLinkFile { get; set; }

        public int iRead { get; set; } // Kiểm tra đã đọc trang nào trong tài liệu chưa

        public override string ToString()
        {
            return this.sTitle;
        }
    }
}
