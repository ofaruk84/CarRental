using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public interface IControllerRepository<T>
    {

        IActionResult GetAll();

        IActionResult GetById(int id);


        IActionResult Add(T entity);


        IActionResult Update(T entity);


        IActionResult Delete(T entity);
    }
}
