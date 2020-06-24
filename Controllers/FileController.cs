using FileManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager.Controllers
{
    public class FileController
    {
        // Sinh mã file tự động
        public static int getFileCodeFromDB() 
        {
            using (var _context = new DBFileContext())
            {
                var filecode = (from f in _context.tbFileMs
                          select f.iFileCode).ToList();

                if (filecode.Count <= 0)
                {
                    return 1;
                }
                else
                {
                    for (int i = 0; i < filecode.Count(); i++)
                    {
                        if (filecode[i] != (i + 1))
                            return i + 1;
                    }
                    return filecode.Max() + 1;
                }
            }
        }

        // Thêm File
        public static bool AddFile(FileM file)
        {
            try
            {
                using (var _context = new DBFileContext())
                {
                    _context.tbFileMs.Add(file);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        // Lấy File cụ thể
        public static FileM getFileM(int filecode)
        {
            using (var _context = new DBFileContext())
            {
                var file = (from f in _context.tbFileMs
                            where f.iFileCode == filecode
                            select f).ToList();
                if (file.Count == 1)
                {
                    return file[0];
                }
                else
                {
                    return null;
                }
            }
        }

        // Lấy danh sách File
        public static List<FileM> getListFile()
        {
            using (var _context = new DBFileContext())
            {
                var file = (from f in _context.tbFileMs.AsEnumerable()
                            select f)
                            .Select(x => new FileM
                            {
                                iFileCode = x.iFileCode,
                                sTitle = x.sTitle,
                                sCategory = x.sCategory,
                                sNote = x.sNote,
                                dtDateUpdate = x.dtDateUpdate,
                                sLinkFile = x.sLinkFile,
                                sLinkPic = x.sLinkPic,
                                iRead = x.iRead,
                                dtRecentlyRead = x.dtRecentlyRead,
                                sFilePreview = x.sFilePreview
                            }).ToList();
                return file;
            }
        }

        // Xóa file
        public static bool DeleteFile(FileM file)
        {
            using (var _context = new DBFileContext())
            {
                var dbfile = (from f in _context.tbFileMs
                              where f.iFileCode == file.iFileCode
                              select f).SingleOrDefault();
                _context.tbFileMs.Remove(dbfile);
                _context.SaveChanges();
                return true;
            }
        }

        // Cập nhật file
        public static bool UpdateFile(FileM file)
        {
            try
            {
                using (var _context = new DBFileContext())
                {
                    _context.tbFileMs.AddOrUpdate(file);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }
        
        // Tìm kiếm theo tên
        public static List<FileM> SearchFile(string search) 
        {
            using (var _context = new DBFileContext())
            {
                var file = (from f in _context.tbFileMs.AsEnumerable()
                             where f.sTitle.StartsWith(search)
                             select f).Select(x => new FileM
                             {
                                 iFileCode = x.iFileCode,
                                 sTitle = x.sTitle,
                                 sCategory = x.sCategory,
                                 sNote = x.sNote,
                                 dtDateUpdate = x.dtDateUpdate,
                                 sLinkFile = x.sLinkFile,
                                 sLinkPic = x.sLinkPic,
                                 iRead = x.iRead,
                                 dtRecentlyRead = x.dtRecentlyRead,
                                 sFilePreview = x.sFilePreview
                             }).ToList();
                if (file.Count >= 1)
                {
                    return file;
                }
                else return null;
            }
        }

        // Hiện file Add gần nhất
        public static List<FileM> ShowAddRecently() 
        {
            using (var _context = new DBFileContext())
            {
                var file = (from f in _context.tbFileMs.AsEnumerable()
                            orderby f.dtDateUpdate descending
                            select f).Select(x => new FileM
                            {
                                iFileCode = x.iFileCode,
                                sTitle = x.sTitle,
                                sCategory = x.sCategory,
                                sNote = x.sNote,
                                dtDateUpdate = x.dtDateUpdate,
                                sLinkFile = x.sLinkFile,
                                sLinkPic = x.sLinkPic,
                                iRead = x.iRead,
                                dtRecentlyRead = x.dtRecentlyRead,
                                sFilePreview = x.sFilePreview
                            }).ToList();
                if (file.Count >= 1)
                {
                    return file;
                }
                else return null;
            }
        }

        public static List<FileM> ShowCategory(string ctg)
        {
            using (var _context = new DBFileContext())
            {
                var file = (from f in _context.tbFileMs.AsEnumerable()
                            where f.sCategory == ctg
                            select f).Select(x => new FileM
                            {
                                iFileCode = x.iFileCode,
                                sTitle = x.sTitle,
                                sCategory = x.sCategory,
                                sNote = x.sNote,
                                dtDateUpdate = x.dtDateUpdate,
                                sLinkFile = x.sLinkFile,
                                sLinkPic = x.sLinkPic,
                                iRead = x.iRead,
                                dtRecentlyRead = x.dtRecentlyRead,
                                sFilePreview = x.sFilePreview
                            }).ToList();
                if (file.Count >= 1)
                {
                    return file;
                }
                else return null;
            }
        }
    }
}
