using clinica.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        static List<Doctor> doctors = new List<Doctor>(); 
        // GET: api/<DoctorController>
        [HttpGet]
        public ActionResult<Doctor> Get()
        {
            return Ok(doctors);
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            foreach (Doctor item in doctors)
            {
                if (item.id == id)
                    return Ok(item);
            }

            return NotFound(new { message = "doctor not found:(" });

        }

        // POST api/<DoctorController>
        //הוספת ערך חדש
        [HttpPost]
        public void Post(Doctor d)
        {
            doctors.Add(d);
           // return doctor;
        }

        // PUT api/<DoctorController>/5
        //עדכון
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] string name)
        {
            foreach (Doctor doctor in doctors)
            {
                if (id == doctor.id)
                {
                    doctor.name= name;
                }
            }
           return NotFound();

        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            for (int i = 0; i < doctors.Count; i++)
            {
                if (doctors[i].id == id)
                {
                    doctors.Remove(doctors[i]);
                }
            } 
           
        }
    }
}
