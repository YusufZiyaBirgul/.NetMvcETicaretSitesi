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
    public class PublisherManager : IPublisherService
    {
        IPublisherDal _publisher;

        public PublisherManager(IPublisherDal publisher)
        {
            _publisher = publisher;
        }

        public Publisher GetByID(int id)
        {
            return _publisher.Get(x => x.PublisherID == id);
        }

        public List<Publisher> GetListByID(int id)
        {
            return _publisher.List(x => x.PublisherID == id);
        }

        public List<Publisher> GetPublisherList()
        {
            return _publisher.List();
        }

        public void PublisherAdd(Publisher publisher)
        {
            _publisher.Insert(publisher);
        }

        public void PublisherDelete(Publisher publisher)
        {
            _publisher.Delete(publisher);
        }

        public void PublisherUpdate(Publisher publisher)
        {
            _publisher.Update(publisher);
        }
    }
}
