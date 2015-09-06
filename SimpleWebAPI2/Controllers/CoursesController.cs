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
        /// <returns>A list of course objects</returns>
        [HttpGet]
        [Route("")]
        public List<CourseDTO> GetCourses(String semester = null)
        {
            return _service.GetCoursesBySemester(semester);
        }

        /// <summary>
        /// Gets a list of students in a particular course
        /// </summary>
        /// <param name="id">ID of course</param>
        /// <returns>An ArrayList of Students in the given course</returns>
        [HttpGet]
        [Route("{id:int}/students")]
        public List <StudentDTO> GetStudentsInCourse(int id)
        {   
           /* foreach (CourseDTO c in _courses)
            {
                if (c.ID == id)
                {
                    //return student
                }
            }*/

            //return 404
            throw new HttpResponseException(HttpStatusCode.NotFound);
        }

        /// <summary>
        /// Adds a course to the list of active courses
        /// </summary>
        /// <param name="c">Course object</param>
        /// <returns>The created course</returns>
        [HttpPost]
        [Route("")]
        [ResponseType(typeof(Course))]
        public IHttpActionResult AddCourse(CourseDTO c)
        {
            //checking if the course being added is not of the right data type
            if (c == null)
            {
                throw new HttpResponseException(HttpStatusCode.PreconditionFailed);
            }

            //setting location url
            var location = Url.Link("GetCourse", new { id = c.ID });

            //adding course to list
            //_courses.Add(c);

            return Created(location, c);
        }

        /// <summary>
        /// Replaces the existing course with the given ID with the given Course object
        /// </summary>
        /// <param name="id">ID of the course to replace</param>
        /// <param name="course">The Course replace the old Course</param>
        /// <returns>Updated Course or an appropriate error</returns>
        [HttpPut]
        [Route("{id:int}")]
        public IHttpActionResult UpdateCourse(int id, CourseDTO course)
        {
            //checking if the course being added is not of the right data type
            if (course == null)
            {
                throw new HttpResponseException(HttpStatusCode.PreconditionFailed);
            }

            //update right course
            /*
            foreach (CourseDTO c in _courses)
            {
                if (c.ID == id)
                {
                    var temp = _courses.SingleOrDefault(x=>x.ID == course.ID);
                    temp.Name = course.Name;
                    temp.StartDate = course.StartDate;
                    temp.EndDate = course.EndDate;

                    //201 successfully created
                    var location = Url.Link("GetCourse", new { id = course.ID });
                    return Created(location, temp);
                }
            }*/

            //404 id not found
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
            /*
            foreach (CourseDTO c in _courses)
            {
                if (c.ID == id)
                {
                    _courses.Remove(c);
                    throw new HttpResponseException(HttpStatusCode.NoContent);
                }
            }*/

            //return 404
            return NotFound();
        }

        /// <summary>
        /// Gets the Course with the given ID
        /// </summary>
        /// <param name="id">ID of Course to get</param>
        /// <returns>The Course with the given ID, else HTTP status code 404 if ID is not found</returns>
        [HttpGet]
        [Route("{id:int}", Name ="GetCourse")]
        public CourseDTO GetCourseById(int id)
        {
            /*
            foreach (CourseDTO c in _courses)
            {
                if (c.ID == id) return c; 
            }*/

            //return 404
            throw new HttpResponseException(HttpStatusCode.NotFound);
        }

        /// <summary>
        /// Adds the given Student to the Course with the given ID
        /// </summary>
        /// <param name="id">ID of Course to add the Student to</param>
        /// <param name="student">Student object</param>
        /// <returns>The added Student, else HTTP status code 404</returns>
        [HttpPost]
        [Route("{id:int}/students")]
        public IHttpActionResult AddStudentToCourse(int id, StudentDTO student)
        {
            //checking if the student being added is not of the right data type
            if (student == null)
            {
                throw new HttpResponseException(HttpStatusCode.PreconditionFailed);
            }

            /*
            foreach (CourseDTO c in _courses)
            {
                if (c.ID == id) {
                    //add student here
                    var location = Url.Link("GetCourse", new { id = c.ID });
                    return Created(location, student);
                } 
            }*/

            //return 404
            return NotFound();
        }
    }
}
