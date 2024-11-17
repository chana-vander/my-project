using clinica.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class prescriptionController : ControllerBase
    {
        static List<Prescription> prescriptions = new List<Prescription>();

        // GET: api/<prescriptionController>
        [HttpGet]
        public List<Prescription> Get()
        {
            return prescriptions;
        }

        // GET api/<prescriptionController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            foreach (Prescription pres in prescriptions)
            {
                if (pres.id == id)
                    return Ok(pres);
            }
            return NotFound();
        }

        // POST api/<prescriptionController>
        [HttpPost]
        //add
        public void Post(Prescription p)
        {
            prescriptions.Add(p);
        }

        // PUT api/<prescriptionController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, string value)
        {
            foreach (Prescription p in prescriptions)
            {
                if (p.id == id)
                    p.status = value;
            }
            return NotFound();
        }

        // DELETE api/<prescriptionController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            foreach(Prescription p in prescriptions)
            {
                if (p.id == id)
                    prescriptions.Remove(p);
            }
            return NotFound();
        }
    }
}
