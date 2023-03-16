using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetCategoryList();
        List<Category> GetListById(int id);
       
        void categoryAdd(Category category);
        Category GetByID(int id);
        void categoryDelete(Category category);

        void categoryUpdate(Category category);
    }
}
