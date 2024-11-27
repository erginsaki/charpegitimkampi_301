using EgitimKampi301_dataaccesslayer.Abstract;
using EgitimKampi301_dataaccesslayer.Repositories;
using egitimkampi301_entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKampi301_dataaccesslayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {



    }
}
