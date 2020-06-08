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

        public static FileM getFileM(string filecode)
        {
            using (var _context = new DBFileContext())
            {
                var file = (from f in _context.tbFileMs
                            where f.sFileCode == filecode
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
                                sFileCode = x.sFileCode,
                                sTitle = x.sTitle,
                                sCategory = x.sCategory,
                                sNote = x.sNote,
                                dtDateUpdate = x.dtDateUpdate,
                                sLinkFile = x.sLinkFile,
                                sLinkPic = x.sLinkPic
                            }).ToList();
                return file;
            }
        }

        public static bool DeleteFile(FileM file)
        {
            using (var _context = new DBFileContext())
            {
                var dbfile = (from f in _context.tbFileMs
                              where f.sFileCode == file.sFileCode
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
                             where f.sTitle.StartsWith(search) || f.sFileCode.StartsWith(search)
                             select f).Select(x => new FileM
                             {
                                 sFileCode = x.sFileCode,
                                 sTitle = x.sTitle,
                                 sCategory = x.sCategory,
                                 sNote = x.sNote,
                                 dtDateUpdate = x.dtDateUpdate,
                                 sLinkFile = x.sLinkFile,
                                 sLinkPic = x.sLinkPic
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
