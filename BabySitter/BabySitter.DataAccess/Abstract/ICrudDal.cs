﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.DataAccess.Abstract
{
    public interface ICrudDal
    {
        object Add(object entity);

        void Update(object entity);

        void Delete(object entity);
    }
}
