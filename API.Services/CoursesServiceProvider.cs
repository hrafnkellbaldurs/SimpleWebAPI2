using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Services
{
    public class CoursesServiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="semester"></param>
        /// <returns></returns>
        public List<CourseDTO> GetCoursesBySemester(string semester = null)
        {
            if (string.IsNullOrEmpty(semester))
            {
                semester = "20153";
            }

        }
    }
}
