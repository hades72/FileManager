using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Models
{
    public class DBFileContext : DbContext
    {
        public DBFileContext() : base("name = DBEntityFileManager")
        {

        }
        public DbSet<FileM> tbFileMs { get; set; } // Tạo bảng danh sách các file
        public DbSet<Category> tbCategories { get; set; } // Tạo bảng danh sách các thể loại
    }
}
