using BabySitter.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BabySitter.Entities.Entity;

namespace BabySitter.DataAccess.Concrete.EntityFramework
{
    public class EfContactInformationDal : IContactInformationDal
    { 

        public ContactInformation Add(ContactInformation contactInformation)
        {
            using (var ctx = new BabySitterContext())
            {
                var entry = ctx.ContactInformation.Add(contactInformation);

                ctx.SaveChanges();

                return entry;
            }
        } 

        public void Delete(ContactInformation contactInformation)
        {
            using (var ctx = new BabySitterContext())
            {
                ctx.ContactInformation.Remove(contactInformation);

                ctx.SaveChanges();
            }
        }

        public ContactInformation GetByResume(Resume resume)
        {
            using (var ctx = new BabySitterContext())
            {
                return ctx.ContactInformation.SingleOrDefault(p => p.ResumeId == resume.Id);
            }
        }
         
        public void Update(ContactInformation contactInformation)
        {
            using (var ctx = new BabySitterContext())
            {
                var entry = ctx.Entry(contactInformation);

                entry.State = System.Data.Entity.EntityState.Modified;                

                ctx.SaveChanges();
            }
        }
    }
}
