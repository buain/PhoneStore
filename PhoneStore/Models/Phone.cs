using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneStore.Models
{
    public class Phone
    {
        //phone model
        public int Id { get; set;}
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public int Price { get; set; }
    }
}