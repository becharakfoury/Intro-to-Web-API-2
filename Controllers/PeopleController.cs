using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DemoAPI.Models;

namespace DemoAPI.Controllers
{
    /// <summary>
    /// This is where i give all information about my peoples    
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController() //constructr that initialize people
        {
            people.Add(new Person { FirstName= "Amine", LastName = "Daher", Id = 1 });
            people.Add(new Person { FirstName = "Tony", LastName = "Yammine", Id = 2 });
            people.Add(new Person { FirstName = "Alfred", LastName = "Ashkar", Id = 3 });
        }

        /// <summary>
        ///     Get list of last names of all users
        /// </summary>
        /// <returns>List of last names</returns>
        [Route("api/people/lastnames")]
        [HttpGet]
        public List<string> Getlastnames()
        {
            List<string> output = new List<string>();
            foreach (var item in people)
            {
                output.Add(item.LastName);
            }

            return output;
        }

        /// <summary>
        /// retrun a formated string based on id and age    
        /// </summary>
        /// <param name="userid">unique identifier for this person</param>
        /// <param name="age">we want to know his age</param>
        /// <returns>Return formated string</returns>
        [Route("api/people/firstnames/{userid:int}/{age:int}")]
        [HttpGet]
        public string GetFirstnames(int userid, int age)
        {
            ////http://192.168.0.15:801/api/people/firstnames/5/25
            string output = "";

            output = "my id:" + userid + " - and my age is:" + age;
            
            return output;
        }




        // GET api/people
        public List<Person> Get()
        {
            return people;
        }

        // GET api/people/5
        public Person Get(int id)
        {    
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST api/people
        public void Post(Person val)
        {
            people.Add(val);
        }

        // PUT api/people/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/people/5
        public void Delete(int id)
        {
        }
    }
}
