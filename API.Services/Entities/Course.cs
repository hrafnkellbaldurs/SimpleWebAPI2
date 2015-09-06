using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Services.Entities
{
    [Table("Courses")]
    class Course
    {
        /// <summary>
        /// ID of course
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// TemplateID of the course
        /// Example: "T-514-VEFT"
        /// </summary>
        public string TemplateID { get; set; }

        /// <summary>
        /// Start date of the course
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// End date of the course
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Semester that the course is tought
        /// Example: "20153"
        /// </summary>
        public string Semester { get; set; }
    }
}
