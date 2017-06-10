using BabySitter.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.DataAccess.Concrete.EntityFramework
{
    public partial class BabySitterContext : DbContext
    {
        static BabySitterContext()
        {
            Database.SetInitializer<BabySitterContext>(null);
        }

        public BabySitterContext()
            : base("Name=BabySitterContext")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Tablo isimlerinin sonundaki S takısını siler
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        //DB Setlerimizi oluşturuyoruz

        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<ContactInformation> ContactInformation { get; set; }
        public DbSet<PersonalInformation> PersonelInformation { get; set; }
        public DbSet<Resume> Resume { get; set; }

    }
}
