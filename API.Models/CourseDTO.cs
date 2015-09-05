using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    /// <summary>
    /// This class represents an item in a list of courses
    /// </summary>
    public class CourseDTO
    {
        /// <summary>
        /// Database-generated unique identifier of the course
        /// Example: 1087
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The name of the course
        /// Example: Vefþjónustur
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Startdate of the course
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Enddate of the course
        /// </summary>
        public DateTime EndDate { get; set; }
    }
}
