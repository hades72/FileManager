using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Models
{
    [Table("Category")]
    public class Category
    {
        [Key] // FileCode là key
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // Tắt tự động nhận dạng
        public int iCategoryCode { get; set; } // Mã thể loại
        public string sCategoryName { get; set; } // Tên thể loại
    }
}
