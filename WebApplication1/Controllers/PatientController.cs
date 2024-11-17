using clinica.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        static List<Patient> patients = new List<Patient>();

        // GET: api/<PatientController>
        [HttpGet]
        public List<Patient> Get()
        {
            return patients;
        }

        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            foreach (Patient item in patients)
            {
                if (item.id == id)
                    return Ok(item);
            }

            return NotFound(new { message = "patient not found:(" });
        }

        // POST api/<PatientController>
        [HttpPost]
        //add
        public void Post(Patient p)
        {
            patients.Add(p);

        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        //עדכון
        public ActionResult Put(int id, string phone1)
        {
            foreach (Patient p in patients)
            {
                if (p.id == id)
                    p.phone=phone1;
            }
            return NotFound();  
        }

        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            foreach (Patient p in patients)
            {
                if (p.id == id)
                    patients.Remove(p);
            }
            return NotFound();
        }
    }
}
