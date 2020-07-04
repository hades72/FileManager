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
        // Sinh mã thể loại
        public static int getCategoryCodeFromDB()
        {
            using (var _context = new DBFileContext())
            {
                var categorycode = (from f in _context.tbCategories
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

        // Lấy một thể loại
        public static Category getCategory(int categorycode)
        {
            using (var _context = new DBFileContext())
            {
                var catg = (from f in _context.tbCategories
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
        
        // Lấy danh sách thể loại
        public static List<Category> getListCategory()
        {
            using (var _context = new DBFileContext())
            {
                var catg = (from f in _context.tbCategories.AsEnumerable()
                            select f)
                            .Select(x => new Category
                            {
                                iCategoryCode = x.iCategoryCode,
                                sCategoryName = x.sCategoryName,
                                
                            }).ToList();
                return catg;
            }
        }

        // Thêm thể loại
        public static bool addCategory(Category category)
        {
            try
            {
                using (var _context = new DBFileContext())
                {
                    _context.tbCategories.Add(category);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        // Cập nhật thể loại
        public static bool updateCategory(Category catg)
        {
            try
            {
                using (var _context = new DBFileContext())
                {
                    _context.tbCategories.AddOrUpdate(catg);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        // Xóa thể loại
        public static bool deleteCategory(Category catg)
        {
            using (var _context = new DBFileContext())
            {
                var dbcatg = (from f in _context.tbCategories
                              where f.iCategoryCode == catg.iCategoryCode
                              select f).SingleOrDefault();
                _context.tbCategories.Remove(dbcatg);
                _context.SaveChanges();
                return true;
            }
        }

    }
}
