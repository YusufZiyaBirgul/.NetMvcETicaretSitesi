using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface IProductService
    {
        List<Book> GetBookList();
        List<Book> GetListByID(int id);
        Book GetByID(int id);

        void BookAdd(Book book);
        void BookDelete(Book book);
        void BookUpdate(Book book);



    }
}
