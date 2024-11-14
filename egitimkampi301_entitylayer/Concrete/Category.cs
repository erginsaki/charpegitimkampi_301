using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egitimkampi301_entitylayer.Concrete
{
    public class Category // internal erişim belirleyicisidir (access modifier) oluşturulan bir sınıf veya interface in erişim durumunu belirler.
    {                                                                            // public, private, internal, protected
                                                                                 // field : bir değişken direkt sınıf içinde tanımlıysa,
                                                                                 // variable : değer metot içinde tanımlıysapro
                                                                                 // property : get set şeklinde tanımlanır:
        public string CategoryName { get; set; }  //(property tanımı)

        public int CategoryId { get; set; } // birincil anahtar ve otomatik artan olması için id ismi gerçek ismiyle tanımlanmalı

        public bool CategoryStatus { get; set; } 

        public List<Product> Products { get; set; }
    }
}
