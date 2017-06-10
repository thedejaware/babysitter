using BabySitter.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BabySitter.Entities.Entity;

namespace BabySitter.DataAccess.Concrete.EntityFramework
{
    public class EfCountryDal : ICountryDal
    {
        public IEnumerable<Country> GetAll()
        {
            using (var ctx = new BabySitterContext())
            {
                return ctx.Country.ToList();
            }
        }
    }
}
