using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Services.Entities
{
    /// <summary>
    /// This class represents a single course template for a course
    /// </summary>
    [Table("CourseTemplates")]
    class CourseTemplate
    {
        /// <summary>
        /// The ID of a course template.
        /// Example: "T-514-VEFT"
        /// </summary>
        public String ID { get; set; }

        /// <summary>
        /// The name of a course
        /// Example: "Vefþjónustur"
        /// </summary>
        public String Name { get; set; }
    }
}
