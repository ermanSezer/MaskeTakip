using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Person //Default erişim bildirgeci internal- Ctrl+k+d ile kodları düzenleyebilirsin
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalIdentity { get; set; }
        public int DateOfBirthYear { get; set; }
    }
}
//SOLID Kodlama Standartları
//Tek sorumluluk prensibi her katman her if bloğu sadece bir iş yapar her methot sadece bir iş yapar.
//Entitites varlık nesnelerini tutar
//Business iş kurallarını tutar İf bloğu en çok burada kullanılır.
//Abstract soyut nesneleri tutacak - Concrete somut nesneleri tutacak
//Katmanlar arası kullanımlarda şekillenecek.