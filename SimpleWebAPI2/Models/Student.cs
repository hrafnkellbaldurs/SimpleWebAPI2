using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebAPI2.Models
{
    /// <summary>
    /// This class represents a single student at a school
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The ID of a student.
        /// Example: 32
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        ///  The name of a student.
        ///  Example: "Gunnar Atlason"
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// The Social Security Number of a student. 
        /// Used as a unique identifier.
        /// Example: "3012933419"
        /// </summary>
        public String SSN { get; set; }
    }
}