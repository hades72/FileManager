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
    public class CategoryController
    {
        public static int getCategoryCodeFromDB()
        {
            using (var _context = new DBFileContext())
            {
                var categorycode = (from f in _context.tbCategory
                                select f.iCategoryCode).ToList();

                if (categorycode.Count <= 0)
                {
                    return 1;
                }
                else
                {
                    for (int i = 0; i < categorycode.Count(); i++)
                    {
                        if (categorycode[i] != (i + 1))
                            return i + 1;
                    }
                    return categorycode.Max() + 1;
                }
            }
        }
        public static bool AddCategory(Category category)
        {
            try
            {
                using (var _context = new DBFileContext())
                {
                    _context.tbCategory.Add(category);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static Category getCategory(int categorycode)
        {
            using (var _context = new DBFileContext())
            {
                var catg = (from f in _context.tbCategory
                            where f.iCategoryCode == categorycode
                            select f).ToList();
                if (catg.Count == 1)
                {
                    return catg[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public static List<Category> getListCategory()
        {
            using (var _context = new DBFileContext())
            {
                var catg = (from f in _context.tbCategory.AsEnumerable()
                            select f)
                            .Select(x => new Category
                            {
                                iCategoryCode = x.iCategoryCode,
                                sCategoryName = x.sCategoryName,
                                
                            }).ToList();
                return catg;
            }
        }
        public static bool DeleteCategory(Category catg)
        {
            using (var _context = new DBFileContext())
            {
                var dbcatg = (from f in _context.tbCategory
                              where f.iCategoryCode == catg.iCategoryCode
                              select f).SingleOrDefault();
                _context.tbCategory.Remove(dbcatg);
                _context.SaveChanges();
                return true;
            }
        }
        public static bool UpdateCategory(Category catg)
        {
            try
            {
                using (var _context = new DBFileContext())
                {
                    _context.tbCategory.AddOrUpdate(catg);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }
    }
}
