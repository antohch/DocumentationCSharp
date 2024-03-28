using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorConsole
{
    public interface IService
    {
        Distance GetDistance();
    }
    public class ExampleController(IService service) : ControllerBase
    {
        [HttpGet]
        public ActionResult<Distance> Get()
        {
            return service.GetDistance();
        }
    }
}
