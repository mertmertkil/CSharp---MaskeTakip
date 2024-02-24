using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
	public class PttManager : ISupplierService // class'ı çıplak bırakma. mesela ptt dağıtıyor, başka biri de dağıtabilir.
	{
		private IApplicantService _applicantService;

		public PttManager(IApplicantService applicantService) // Constructor: class oluştuğunda çalışan metodlar.
		{
			_applicantService = applicantService; // set edebilmek içn yukarıda _ ile başladım.
		}

		public void GiveMask(Person person)
		{
			if (_applicantService.CheckPerson(person)) 
			{
				Console.WriteLine(person.FirstName + " için maske verildi.");
			}
		}

		
	}
}

