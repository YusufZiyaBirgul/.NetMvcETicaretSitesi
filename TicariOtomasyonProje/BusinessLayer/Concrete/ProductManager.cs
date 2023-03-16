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
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void BookAdd(Book book)
        {
            _productDal.Insert(book);
        }

        public void BookDelete(Book book)
        {
            _productDal.Delete(book);

        }

        public void BookUpdate(Book book)
        {
            _productDal.Update(book);

        }

        public List<Book> GetBookList()
        {
            return _productDal.List();
        }

        public Book GetByID(int id)
        {
            return _productDal.Get(x => x.BookID == id);
        }

        public List<Book> GetListByID(int id)
        {
            return _productDal.List(x => x.BookID == id);
        }
    }
}
