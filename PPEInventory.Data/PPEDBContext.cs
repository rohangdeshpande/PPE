using PPEInventory.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPEInventory.Data
{
    public class PPEDBContext : DbContext
    {
        
        public PPEDBContext() : base("name=DefaultConnection")
        {
            Database.SetInitializer<PPEDBContext>(null);
        }

        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Instrument> Instruments { get; set; }
        public virtual DbSet<VendorInventory> VendorInventories { get; set; }
        public virtual DbSet<VendorInventoryDetail> VendorInventoryDetails { get; set; }
    }
}
