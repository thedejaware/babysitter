using BabySitter.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BabySitter.Entities.Entity;

namespace BabySitter.DataAccess.Concrete.EntityFramework
{
    public class EfPersonalInformationDal : IPersonalInformationDal
    {
        public PersonalInformation Add(PersonalInformation personalInformation)
        {
            using (var ctx = new BabySitterContext())
            {
                var entry = ctx.PersonelInformation.Add(personalInformation);

                ctx.SaveChanges();

                return entry;
            }
        }

        public void Delete(PersonalInformation personalInformation)
        {
            using (var ctx = new BabySitterContext())
            {
                ctx.PersonelInformation.Remove(personalInformation);

                ctx.SaveChanges();
            }
        }

        public PersonalInformation GetByResume(Resume resume)
        {
            using (var ctx = new BabySitterContext())
            {
                return ctx.PersonelInformation.SingleOrDefault(p => p.ResumeId == resume.Id);
            }
        }

        public void Update(PersonalInformation personalInformation)
        {
            using (var ctx = new BabySitterContext())
            {
                var entry = ctx.Entry(personalInformation);

                entry.State = System.Data.Entity.EntityState.Modified;

                ctx.SaveChanges();

            }
        }
    }
}
