using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebAPI2.Models
{
    /// <summary>
    /// This class represents a link between a course and a student
    /// </summary>
    public class CourseRegistration
    {
        /// <summary>
        /// The ID of a single course registration.
        /// Example: 42
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The ID of a course linked with a student.
        /// Example: 1
        /// </summary>
        public int CourseID { get; set; }

        /// <summary>
        /// The ID of a student linked with a course.
        /// Example: 30
        /// </summary>
        public int StudentID { get; set; }
    }
}