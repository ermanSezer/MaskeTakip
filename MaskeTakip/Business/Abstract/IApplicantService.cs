using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService //interface=Arayüz
    {
        void ApplyForMask(Person person); //Fonksiyon-method-prosedür
        
        List<Person> GetList(); //İçerisinde verdiğimiz tipte liste- List of Person
       
        bool CheckPerson(Person person);
        //Buna methodun imzası deniyor.
    }

}
