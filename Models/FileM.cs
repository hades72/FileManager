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
        public int iFileCode { get; set; } // Mã số file

        public string sTitle { get; set; } // Tên file

        public string sCategory { get; set; } // Tên thể loại

        public DateTime dtDateUpdate { get; set; } // Thời gian thêm vào

        public string sNote { get; set; } // Ghi chú bằng chữ

        public string sLinkPic { get; set; } // Đường dẫn bìa file
        
        public string sLinkFile { get; set; } // Đường dẫn file

        public int iRead { get; set; } // Kiểm tra đã đọc trang nào trong tài liệu chưa

        public DateTime? dtRecentlyRead { get; set; } // Lịch sử mở đọc gần đây

        public string sFilePreview { get; set; } // Các file cần đọc trước

        //public override string ToString()
        //{
        //    return this.sTitle;
        //}
    }
}
