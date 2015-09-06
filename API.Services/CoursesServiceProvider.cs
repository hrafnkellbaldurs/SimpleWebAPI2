using API.Models;
using API.Services.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace API.Services
{
    public class CoursesServiceProvider
    {
        private readonly AppDataContext _db;

        public CoursesServiceProvider()
        {
            _db = new AppDataContext();
        }

        /// <summary>
        /// Finds and returns a list of course objects, given a semester. 
        /// If no semester is provided, the "current" semester will be
        /// used.
        /// </summary>
        /// <param name="semester">The semester to get the courses from </param>
        /// <returns>A list of course objects being taught in a given semester</returns>
        public List<CourseDTO> GetCoursesBySemester(string semester = null)
        {
            if (string.IsNullOrEmpty(semester))
            {
                semester = "20153";
            }

            // A:
            //var result = _db.Courses.Where(x => x.Semester == semester).ToList();

            // B:
            var result = (from c in _db.Courses
                          join ct in _db.CourseTemplates
                            on c.TemplateID equals ct.TemplateID
                         where c.Semester == semester
                         select new CourseDTO
                         {
                             ID = c.ID,
                             StartDate = c.StartDate,
                             EndDate = c.EndDate,
                             Name = ct.Name

                         }).ToList();

            

            return result;
        }
    }
}
