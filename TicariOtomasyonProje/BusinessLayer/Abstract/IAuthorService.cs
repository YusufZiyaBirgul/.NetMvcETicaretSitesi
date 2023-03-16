using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAuthorService
    {
        List<Author> GetAuthorList();
        List<Author> GetListById(int id);
        void AuthorAdd(Author author);
        Author GetByID(int id);
        void AuthorDelete(Author author);
        void AuthorUpdate(Author author);
    }
}
