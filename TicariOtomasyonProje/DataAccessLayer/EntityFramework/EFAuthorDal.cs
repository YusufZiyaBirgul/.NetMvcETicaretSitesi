﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositores;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
   public class EFAuthorDal: GenericRepository<Author>, IAuthorDal
    {
    }
}
