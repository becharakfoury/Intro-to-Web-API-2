using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    /// <summary>
    /// Represent One specific person
    /// </summary>
    public class Person
    {

        /// <summary>
        ///  ID from SQL   
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///  users first name
        /// </summary>
        public string  FirstName { get; set; }

        /// <summary>
        ///  user last name
        /// </summary>
        public string  LastName { get; set; }        

    }
}