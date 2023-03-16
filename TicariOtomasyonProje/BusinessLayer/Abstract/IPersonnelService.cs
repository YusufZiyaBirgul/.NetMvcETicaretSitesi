using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPersonnelService
    {


        List<Personnel> GetList();
        List<Personnel> GetListByPeronelId(int id);
        void PersonelInsert(Personnel personel);
        Personnel GetByID(int id);
        void PersonelDelete(Personnel personel);
        void PersonelUpdate(Personnel personel);
    }
}
