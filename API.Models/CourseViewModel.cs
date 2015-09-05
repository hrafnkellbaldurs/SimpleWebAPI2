using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class CourseViewModel
    {
        /// <summary>
        /// The ID of the course being created
        /// Example: "T-514-VEFT"
        /// </summary>
        /// [Required]
        public String CourseID { get; set; }

        /// <summary>
        /// The semester in which the course is taught
        /// Example: "20153"
        /// </summary>
        public String Semester { get; set; }

        /// <summary>
        /// Start date of the course being ceated
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// End date of the course being created
        /// </summary>
        public DateTime EndDate { get; set; }
    }
}
