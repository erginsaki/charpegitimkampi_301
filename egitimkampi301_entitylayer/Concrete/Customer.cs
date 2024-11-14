using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egitimkampi301_entitylayer.Concrete
{
    public class Customer
    {

        public int CustomerId { get; set; }                  //SOLID : 
                                                             // Single Responsibility : tek sorumluluk ilkesi bir metot belli işleri yapmalı
        public string CustomerName { get; set; }

        public string CustomerSurname { get; set; }

        public string CustomerDistrict { get; set; }

        public string CustomerCity { get; set; }

        public List<Order> Orders { get; set; }

        public bool CustomerStatus { get; set; }

    }
}
