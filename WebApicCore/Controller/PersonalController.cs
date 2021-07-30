using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApicCore.Model;

namespace WebApicCore.Controller
{
    [ApiController]
    public class PersonalController : ControllerBase
    {
        [Route("api/[controller]")]
        [HttpGet]
        public List<Personal> Personals()
        {
            return PersonalList.pers;
        }
        [Route("api/[controller]/{id}")]
        [HttpGet]
        public Personal Personals(int id)
        {
            Personal ischi = PersonalList.pers.Where(o => o.id == id).FirstOrDefault();
            return ischi;
        }
    }
}
