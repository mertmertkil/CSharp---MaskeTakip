using System;
using Business;
using Business.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {


            PttManager pttManager = new PttManager(new ForeignerManager());
            pttManager.GiveMask(person1);



            Console.ReadLine();
        }

  
    }
}