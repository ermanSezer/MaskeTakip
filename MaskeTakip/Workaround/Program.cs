using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {   //Değişkenler   
        //string mesaj = "Selam";
        //double tutar = 100000; //Ondalıklı veri tutmak için
        //int sayi = 100; //Tam sayı tutmak için
        //bool girisYapmisMi = false; //Doğru ya da yanlış - Uygulamayı dallandırmak için kullanılır.
        //string ad = "Erman";
        //string soyAd = "Sezer";
        //int dogumYili = 1990;
        //long tcNo = 12345678910; //11 sayı tutacak kadar bir veri tipi

        //Console.WriteLine(mesaj); //Ctrl+K+C yorum satırına dönüştürme.
        SelamVer(isim:"Erman");
    
        Vatandas vatandas1 = new Vatandas();
        int sonuc = Topla(3,5);
        //Diziler / Arrays
        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Erman";
        ogrenciler[1] = "Sezer";
        ogrenciler[2] = "Davut";
        ogrenciler = new string[4]; //Stack ve Heap (Bellekteki yapılar.) null reference expection hatası
        //Garbage Collector-Çöp Toplayıcı 
        //Array, Class, İnterface, Abstract bunlar refence tip.
        //Döngüler birbirine benzeyen işleri tekrar tekrar yazmak yerine bir kere de yapma sürecidir.
        for(int i = 0; i < ogrenciler.Length; i++) {
            //int i sayaçtır index ten gelir. Diziler 0 dan başlar. i++ ile i=i+1 aynı şey.
            Console.WriteLine(ogrenciler[i]);
        }
        string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
        string[] sehirler2 = new[] { "Kırklareli", "Tekirdağ", "Edirne" };
        sehirler2 = sehirler1;
        sehirler1[0] = "Adana";
        Console.WriteLine(sehirler2[0]);
        Person person1 = new Person();
        person1.FirstName = "Erman";
        person1.LastName = "Sezer";
        person1.DateOfBirthYear = 1990;
        person1.NationalIdentity = 123;
        Person person2 = new Person();
        person2.FirstName = "Davut";

        //int, double, bool değer tiplerdir.
        int sayi1 = 10;
        int sayi2 = 20;
        sayi2 = sayi1;
        sayi1 = 30;
        //sayi2 kaç olur? Cevap 10 olur.
        foreach (string sehir in sehirler1) //sehir takma isim burdaki
        {
            //Dizi formatındaki yapıları dönüyoruz.
            Console.WriteLine(sehir); //Genelde çoğulun tekil hali yazılır.
        }
        //Array yerine bu daha çok kullanılıyor.
        //MyList
        List<string> yeniSehirler1 = new List<string> { "Ankara", "İzmir", "İstanbul" };
        yeniSehirler1.Add("Tekirdağ");
        foreach (var sehir in yeniSehirler1)
        {
            Console.WriteLine(sehir);
        }
        PttManager pttManager = new PttManager(new ForeignerManager());
        Console.ReadLine();
        //string referans tip. Char Alley yani kelime dizisi.
     
    }
    //resharper
    static void SelamVer(string isim="isimsiz") //void herhangi bir şey döndürmez. Sadece işi yapar. Herhangi bilgi vermez.
    {                      //Emir ile çalışmaz.  
        Console.WriteLine("Merhaba " + isim);

    }
    static int Topla(int sayi1, int sayi2) //Bir hesap yap bir şeyler yap bana değer ver dediğin zaman
    {
        int sonuc = sayi1 + sayi2; //break point kırma noktası
        Console.WriteLine("Toplam: " + sonuc.ToString() );            //return olayını kullanıyorsun.
        return sonuc; //Değişkene vereceği değer.
    }
}

public class Vatandas
{
    //string ad = "Erman";
    //string soyAd = "Sezer";
    //int dogumYili = 1990;
    //long tcNo = 12345678910; //11 sayı tutacak kadar bir veri tipi
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; } //prop kullandık.
    public long TcNo { get; set; } //pascal casing
}