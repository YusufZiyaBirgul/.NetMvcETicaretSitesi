using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _category;

        public CategoryManager(ICategoryDal category)
        {
            _category = category;
        }

        public void categoryAdd(Category category)
        {
            _category.Insert(category);
        }

        public void categoryDelete(Category category)
        {
            _category.Delete(category);
        }

        public void categoryUpdate(Category category)
        {
            _category.Update(category);
        }

        public Category GetByID(int id)
        {
            return _category.Get(x=>x.CategoryID==id);
        }

        public List<Category> GetCategoryList()
        {
            return _category.List();
        }

        public List<Category> GetListById(int id)
        {
            return _category.List(x=>x.CategoryID==id);
        }
    }
}
