// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;

Console.WriteLine("Hello, World!");

//Degiskenler();

//Vatandas vatandas1 = new Vatandas();
//vatandas1.Ad = "Engin";

SelamVer(isim: "Engin");
SelamVer(isim: "Ahmet");
SelamVer(isim: "Ayşe");
SelamVer();

Topla(50);

//Diziler / Arrays

string ogrenci1 = "Engin";
string ogrenci2 = "Kerem";
string ogrenci3 = "Berkay";

//Console.WriteLine(ogrenci1);
//Console.WriteLine(ogrenci2);
//Console.WriteLine(ogrenci3);

//Refrance Types = Array,Class,Interface,Abstract

string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Berkay";

ogrenciler = new string[4];
ogrenciler[3] = "İlker";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Konya" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

//Value Types = int, double, bool

int sayi1 = 10;
int sayi2 = 20;
sayi2 = sayi1;
sayi1 = 30;

Person person1 = new Person();
person1.FirstName = "ENGİN";
person1.LastName = "DEMİROĞ";
person1.DataOfBirthYear = 1985;
person1.NationalIdentity = 123;

Person person2 = new Person();
person2.FirstName = "MUHAMMED";
person2.LastName = "KURT";
person2.DataOfBirthYear = 1999;
person2.NationalIdentity = 42205688386;

foreach (var sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
yeniSehirler1.Add("İzmir");

foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person2);

static void SelamVer(string isim = "isimsiz"/*isimsiz burada default değerdir*/)
{
    Console.WriteLine("Merhaba");
}

static int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : "+ sonuc.ToString());
    return sonuc;
}

static void Degiskenler()
{
    string mesaj = "Merhaba";
    double tutar = 100000; //db den gelir
    int sayi = 100;
    bool girisYapmisMi = false;

    string ad = "Engin";
    string soyad = "Demiroğ";
    int dogumYili = 1985;
    long tcNo = 12345678910;

    Console.WriteLine(tutar * 1.18);
}

public class Vatandas()
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}