
using System;
using System.Collections.Generic;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Aziz Devrim";
            person1.LastName = "YAYLA";
            person1.DateOfBirthYear = 1998;
            person1.NationalIdentity = 12345678910;
            

        }

        //resharper
        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc.ToString());
            return sonuc;
        }

    }
}
