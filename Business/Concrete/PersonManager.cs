using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;

namespace Business.Concrete

{
    public class PersonManager : IApplicantService
    {

        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {

            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient(MernisServiceReference.
                KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);


            return client.TCKimlikNoDogrulaAsync(new MernisServiceReference.TCKimlikNoDogrulaRequest
                (new MernisServiceReference.TCKimlikNoDogrulaRequestBody(123, "ENGİN", "DEMİROĞ", 1985))).Result.Body.TCKimlikNoDogrulaResult;
        }


    }
}
