using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKampi301_dataaccesslayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {

        void Insert(T entity); 

        void Update(T entity);

        void delete(T entity);

        List<T> GetAll();

        T GetById(int id);

    }
}
