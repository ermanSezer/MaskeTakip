using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
        //Bir class ı çıplak bırakma kuralı zorunlu kural.
    {   //Bir tasarım deseni kullanılır. Sınıfların interface ini yazıyoruz. Bunlar field
        //Yeni bir özellik geldiğinde mevcut hiç bir koda dokunmaman lazım.!!!! DİKKAT SOLİD in o harfi.
        private IApplicantService _applicantService;
        public PttManager(IApplicantService applicantService) //constructor =oluşturucu- new yapıldığında çalışır.
        {
            _applicantService = applicantService; //iki tane sınıfın referansını tutabiliyor.
            //interfaceler new lenemez.
        }
        public void GiveMask(Person person)
        {
            /*PersonManager personManager = new PersonManager();*/ // Burada bir bağımlılık var.
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için maske verildi. ");
                //şart bloğu şart doğruysa o bloğa girer.
            }
            else
            {
                Console.WriteLine(person.FirstName + "için maske verilemedi. ");
            }
        }
    }
}
