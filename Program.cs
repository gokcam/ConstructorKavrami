using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Gökhan";
            calisan1.soyAd = "Çam";
            calisan1.No=55;
            calisan1.Departman="Yazılım";

            calisan1.CalisanBilgileri();
            Calisan calisan2 = new Calisan("Ali","Ozen",26,"Matematikçi");
            calisan2.CalisanBilgileri();

            Calisan calisan3 = new Calisan("Gamze","Özkarakaşoğlu");
            calisan3.CalisanBilgileri();

        }
    }
    

    class Calisan
    {

        public Calisan(){}
        public string Ad;
        public string soyAd;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.soyAd = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan(string ad,string soyad)
        {
            this.Ad = ad;
            this.soyAd= soyad;
        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisan Adi: {0}",Ad);
            Console.WriteLine("Calisan Adi: {0}",soyAd);
            Console.WriteLine("Calisan Adi: {0}",No);
            Console.WriteLine("Calisan Adi: {0}",Departman);
        }

    }
}