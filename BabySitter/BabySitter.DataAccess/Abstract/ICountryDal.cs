using BabySitter.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.DataAccess.Abstract
{
    public interface ICountryDal
    {
        IEnumerable<Country> GetAll();
    }
}
