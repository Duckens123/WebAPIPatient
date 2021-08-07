using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIPatient.Models;

namespace WebAPIPatient.Controllers
{
    public class ValuesController : ApiController
    {
        
        // GET api/values
        public IEnumerable<tbpersonne> Get()
        {
            

            using (PATIENTDBEntities2 db=new PATIENTDBEntities2())
            {
                var list =db.tbpersonnes.ToList();
                return list;
            }
           // return new string[] { "value1", "value2" };
            
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] tbpersonne obj)
        {
            using (PATIENTDBEntities2 db = new PATIENTDBEntities2())
            {
                tbpersonne pers = new tbpersonne();
                pers.id = obj.id;
                pers.nom = obj.nom;
                pers.prenom = obj.prenom;
                pers.sexe = obj.sexe;
                db.tbpersonnes.Add(pers);
                db.SaveChanges();
            }
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

    public class personne
    {
    }
}
