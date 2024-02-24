using System;
using Entities.Concrete;

//Interface içerisinde publlic kısımları ve parantezleri kullanmıyoruz.
//Sadece imzaları yazdım.


namespace Business.Abstract
{
	public interface IApplicantService
	{

        void ApplyForMask();

        List<Person> GetList();

        bool CheckPerson();
        bool CheckPerson(Person person);
    }
}

