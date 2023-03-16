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
    public class AuthorManager : IAuthorService
    {
        IAuthorDal _author;

        public AuthorManager(IAuthorDal author)
        {
            _author = author;
        }

        public void AuthorAdd(Author author)
        {
            _author.Insert(author);
        }

        public void AuthorDelete(Author author)
        {
            _author.Delete(author);
        }

        public void AuthorUpdate(Author author)
        {
            _author.Update(author);
        }

        public List<Author> GetAuthorList()
        {
            return _author.List();
        }

        public Author GetByID(int id)
        {
            return _author.Get(x=>x.AuthorID==id);
        }

        public List<Author> GetListById(int id)
        {
            return _author.List(x => x.AuthorID == id);
        }
    }
}
