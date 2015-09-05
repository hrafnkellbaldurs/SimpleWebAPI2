using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebAPI2.Models
{
    public class CourseTemplate
    {
        /// <summary>
        /// The ID of a course template.
        /// Example: "T-514-VEFT"
        /// </summary>
        public String ID { get; set; }

        /// <summary>
        /// The name of a course in the template.
        /// Example: "Vefþjónustur"
        /// </summary>
        public String Name { get; set; }
    }
}