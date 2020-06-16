using FileManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FileManager.Controllers
{
    public class FileController
    {
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

        public static List<FileM> getListUsers()
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
                                iRead = x.iRead
                            }).ToList();
                return file;
            }
        }

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
        
        public static List<FileM> SearchFile(string search)
        {
            using (var _context = new DBFileContext())
            {

                var file = (from f in _context.tbFileMs.AsEnumerable()
                             where f.sTitle.StartsWith(search) || f.sCategory.StartsWith(search)
                             select f).Select(x => new FileM
                             {
                                 iFileCode = x.iFileCode,
                                 sTitle = x.sTitle,
                                 sCategory = x.sCategory,
                                 sNote = x.sNote,
                                 dtDateUpdate = x.dtDateUpdate,
                                 sLinkFile = x.sLinkFile,
                                 sLinkPic = x.sLinkPic,
                                 iRead = x.iRead
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
