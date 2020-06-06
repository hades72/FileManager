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
        public DbSet<FileM> tbFileMs { get; set; }
    }
}
