using BabySitter.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.DataAccess.Abstract
{
    public interface IContactInformationDal
    {
        ContactInformation GetByResume(Resume resume);

        ContactInformation Add(ContactInformation contactInformation);

        void Update(ContactInformation contactInformation);

        void Delete(ContactInformation contactInformation);

    }
}
