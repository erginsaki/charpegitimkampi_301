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
    public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {
        #region NOT
        /*
         ileride sadece admin sınıfına özgü metoto yazılabilir IadminDal sınıfı içinde de işlem yapabilmek için ıadmindal da miras alındı    
         Entity e özgü olmayan metotlar : ekle sil güncelle listele ve id ye göre getir
         bütün entity ler için geçerli fakat içinde a harfi geçmeyen kullanıcı listele gibi metotlar sadece bir
         entity için çalışır.
         */

        #endregion


    }
}
