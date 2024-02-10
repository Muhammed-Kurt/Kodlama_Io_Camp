using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {

        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //Constructor new yapıldığında çalışır
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            //Bir sınıf başka bir sınıfı new liyorsa ileri dönük sıkıntı yapar başka bir sınıfa bağımlılık duyduğu için            
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi");
            }
        }
    }
}
