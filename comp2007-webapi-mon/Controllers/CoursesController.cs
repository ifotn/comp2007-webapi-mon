using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//reference our db
using comp2007_webapi_mon.Models;

namespace comp2007_webapi_mon.Controllers
{
    public class CoursesController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Course> Get()
        {
            //connect
            using (DefaultConnectionEF db = new DefaultConnectionEF())
            {
                //make sure json parsing works with the ef object
                db.Configuration.ProxyCreationEnabled = false;

                //query
                var objC = from c in db.Courses 
                           orderby c.Title
                           select c;

                return objC.ToList();
            }

            //return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public Course Get(int id)
        {
            //connect
            using (DefaultConnectionEF db = new DefaultConnectionEF())
            {
                db.Configuration.ProxyCreationEnabled = false;

                Course objC = (from c in db.Courses
                          where c.CourseID == id
                          select c).FirstOrDefault();

                return objC;

            }


            //return "value";
        }

        // GET api/<controller>/math
        //public string Get(string title)
        //{
        //    return "Course title is: " + title;
        //}

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}