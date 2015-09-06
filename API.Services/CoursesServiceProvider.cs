using API.Models;
using System.Collections.Generic;
using API.Services.Repositories;
using System.Linq;

namespace API.Services
{
    public class CoursesServiceProvider
    {

        public readonly AppDataContext _db;

        public CoursesServiceProvider()
        {
            _db = new AppDataContext();
        }

        /// <summary>
        /// Returns a list of courses belonging to a given semester.
        /// If no semester is provided, the "current" semester
        /// will be used.
        /// </summary>
        /// <param name="semester"></param>
        /// <returns></returns>
        public List<CourseDTO> GetCoursesBySemester(string semester = null)
        {
            if (string.IsNullOrEmpty(semester))
            {
                semester = "20153";
            }

            // A: Method Syntax
            var result = _db.Courses
                .Where(x => x.Semester == semester)
                .ToList();

            // B: Query Syntax
            var result2 = (from c in _db.Courses
                          where c.Semester == semester
                          select new CourseDTO
                         {
                             ID = c.ID,
                             StartDate = c.StartDate,
                             EndDate = c.EndDate
                             //Name = c.N
                         }).ToList();
                         
            
                         
            return null;
        }
    }
}
