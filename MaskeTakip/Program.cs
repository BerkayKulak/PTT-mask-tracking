using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using System;

namespace MaskeTakip
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.FirstName = "ENGİN";
            person1.LastName = "DEMİROĞ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 123;




            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

        }

        

        


    }
}
    