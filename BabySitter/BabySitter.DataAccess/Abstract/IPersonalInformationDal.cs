using BabySitter.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.DataAccess.Abstract
{
    public interface IPersonalInformationDal
    {
        PersonalInformation GetByResume(Resume resume);

        PersonalInformation Add(PersonalInformation personalInformation);

        void Update(PersonalInformation personalInformation);

        void Delete(PersonalInformation personalInformation);

    }
}
