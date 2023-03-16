using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositores;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PersonnelManager :IPersonnelService
    {

        IPersonnelDal _repository;

        public PersonnelManager(IPersonnelDal repository)
        {
            _repository = repository;
        }
      
        public List<Personnel> GetList()
        {
            return _repository.List();
        }

      

        public void PersonelInsert(Personnel personel)
        {
            _repository.Insert(personel);
        }

        public void PersonelDelete(Personnel personel)
        {
            _repository.Delete(personel);
        }

        public void PersonelUpdate(Personnel personel)
        {
            _repository.Update(personel);
        }

        public Personnel GetByID(int id)
        {
            return _repository.Get(x => x.PersonelID == id);
        }

        public List<Personnel> GetListByPeronelId(int id)
        {
            return _repository.List(x => x.PersonelID == id);
        }
    }
}
