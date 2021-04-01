using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;


namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {

        IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)//constructor new yapıldığında çalışır
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName+ " için maske verildi. ");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi. ");
            }
        }
    }
}
