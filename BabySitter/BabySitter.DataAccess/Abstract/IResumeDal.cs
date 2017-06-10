using BabySitter.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.DataAccess.Abstract
{
    public interface IResumeDal
    {
        IEnumerable<Resume> GetAll();

        Resume GetByUserId(int id);

        Resume Add(Resume resume);

        void Update(Resume resume);

        void Delete(Resume resume);

    }
}
