using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CarManager carManager = new CarManager(new EfCarDal());

            var res = carManager.GetAll().Data;

            foreach (var p in res)
            {
                Console.WriteLine(p.CarName);
            }
        }
    }
}
