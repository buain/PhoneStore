using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhoneStore.Models
{
    public class PhoneDbInitializer : DropCreateDatabaseAlways<PhoneContext>
    {
        protected override void Seed(PhoneContext db)
        {
            db.Phones.Add(new Phone { BrandName = "Samsung", ModelName = "Galaxy S10", Price = 500 });
            db.Phones.Add(new Phone { BrandName = "Apple", ModelName = "11", Price = 600 });
            db.Phones.Add(new Phone { BrandName = "Nokia", ModelName = "Lumia", Price = 200 });

            base.Seed(db);
        }
    }
}