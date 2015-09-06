using SimpleWebAPI2.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using System.Linq;
using API.Models;
using API.Services;

namespace SimpleWebAPI.Controllers
{
    
    /// <summary>
    /// This is the Courses Controller
    /// </summary>
    [RoutePrefix("api/courses")]
    public class CoursesController : ApiController
    {
        private readonly CoursesServiceProvider _service;

        /// <summary>
        /// This is the main course method
        /// </summary>
        public CoursesController()
        {
            _service = new CoursesServiceProvider();
        }

        /// <summary>
        /// Gets courses currently available
        /// </summary>
        /// <returns>An ArrayList of Courses</returns>
        [HttpGet]
        [Route("")]
        public List<CourseDTO> GetCourses(string semester = null)
        {
            return _service.GetCoursesBySemester();
        }

        /// <summary>
        /// Gets a list of students in a particular course
        /// </summary>
        /// <param name="id">ID of course</param>
        /// <returns>An ArrayList of Students in the given course</returns>
        [HttpGet]
        [Route("{id:int}/students")]
        public List <Student> GetStudentsInCourse(int id)
        {
            return null;
        }

        /// <summary>
        /// Adds a course to the list of active courses
        /// </summary>
        /// <param name="c">Course object</param>
        /// <returns>The created course</returns>
        [HttpPost]
        [Route("")]
        [ResponseType(typeof(Course))]
        public IHttpActionResult AddCourse(Course c)
        {
            return null;
        }

        /// <summary>
        /// Replaces the existing course with the given ID with the given Course object
        /// </summary>
        /// <param name="id">ID of the course to replace</param>
        /// <param name="course">The Course replace the old Course</param>
        /// <returns>Updated Course or an appropriate error</returns>
        [HttpPut]
        [Route("{id:int}")]
        public IHttpActionResult UpdateCourse(int id, Course course)
        {
            return NotFound();
        }

        /// <summary>
        /// Removes the Course with the given ID from the list of Courses
        /// </summary>
        /// <param name="id">ID of Course to remove</param>
        /// <returns>If succeeded: HTTP status code 204, else HTTP status code 404</returns>
        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult DeleteCourse(int id)
        {
            return NotFound();
        }

        /// <summary>
        /// Gets the Course with the given ID
        /// </summary>
        /// <param name="id">ID of Course to get</param>
        /// <returns>The Course with the given ID, else HTTP status code 404 if ID is not found</returns>
        [HttpGet]
        [Route("{id:int}", Name ="GetCourse")]
        public Course GetCourseById(int id)
        {
            return null;
        }

        /// <summary>
        /// Adds the given Student to the Course with the given ID
        /// </summary>
        /// <param name="id">ID of Course to add the Student to</param>
        /// <param name="student">Student object</param>
        /// <returns>The added Student, else HTTP status code 404</returns>
        [HttpPost]
        [Route("{id:int}/students")]
        public IHttpActionResult AddStudentToCourse(int id, Student student)
        {
            return NotFound();   
        }
    }
    
}
