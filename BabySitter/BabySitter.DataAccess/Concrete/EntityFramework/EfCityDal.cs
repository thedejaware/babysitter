using BabySitter.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BabySitter.Entities.Entity;

namespace BabySitter.DataAccess.Concrete.EntityFramework
{
    public class EfCityDal : ICityDal
    {
        public IEnumerable<City> GetCityByCountry(int id)
        {
            using (var ctx = new BabySitterContext())
            {
                return ctx.City.Where(p => p.CountryId == id).ToList();
            }
        }
    }
}
