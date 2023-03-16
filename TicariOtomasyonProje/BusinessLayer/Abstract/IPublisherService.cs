using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPublisherService
    {
        List<Publisher> GetPublisherList();
        List<Publisher> GetListByID(int id);
        Publisher GetByID(int id);

        void PublisherAdd(Publisher publisher);
        void PublisherDelete(Publisher publisher);
        void PublisherUpdate(Publisher publisher);
    }
}
