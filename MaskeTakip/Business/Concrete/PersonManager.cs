using Business.Abstract;
using Entities.Concrete; //import etmek..
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{   //Çıplak class kalmasın.
    public class PersonManager:IApplicantService //iş sınıfı Bir sınıf sadece özellik tutabilir ya da bir sınıf sadece operasyon tutabilir.
    {                          //Single Responsbility 
        public void ApplyForMask(Person person) //Fonksiyon-method-prosedür
        {
            
        }
        public List<Person> GetList() //İçerisinde verdiğimiz tipte liste- List of Person
        {
            return null;
        }
        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client=new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
//Servis olarakta görebilirsiniz.
//Sıklıkla kullacanağımız operasyonları fonsiyonların yani methodların içine yazıyoruz.
//Encapsulation