using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */
       


            var Courses = new List<Course>()
            {
                new Course { CourseId = 112, Name = "Math 221", Students = new List<Student>()
                   {new Student { Name = "Chris Connell", StudentId = 1123 },
                    new Student {Name = "Terry Love", StudentId = 0900 } } },
                new Course { CourseId = 120, Name = "Biology 2", Students = new List<Student>()
                   {new Student {Name = "Terry Love", StudentId = 0900 },
                   new Student {Name = "John Lyden", StudentId = 1234 }} },
                new Course {CourseId = 115, Name = "Physics 300", Students = new List<Student>()
                    {new Student {Name = "Chris Connell", StudentId = 1123 },
                    new Student {Name = "John Lyden", StudentId = 1234 } } }
            };


            foreach (var course in Courses)
            {
                resultLabel.Text += String.Format("<br />Courses: {0} - {1}", course.CourseId, course.Name);
                foreach (var student in course.Students)
                {
                    resultLabel.Text += String.Format("<br />&nbsp&nbsp Student: {0} - {1}", student.StudentId, student.Name);
                }
            }





        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */

            Course course1 = new Course { Name = "Biology 3", CourseId = 100 };
            Course course2 = new Course { Name = "Calculus AB", CourseId = 201 };
            Course course3 = new Course { Name = "Physics 2", CourseId = 221 };

            var Students = new Dictionary<int, Student>
                {
                {100, new Student {Name = "Chris Connell", StudentId = 1122, Courses = new List<Course>() {course1, course2 } } },
                {101, new Student {Name = "John Lyden", StudentId = 1234, Courses = new List<Course>() {course2, course3 } } },
                {102, new Student {Name = "Terry Love", StudentId = 9999, Courses = new List<Course>() {course1, course3 } } }
                };


            foreach (var student in Students)
            {
                resultLabel.Text += String.Format("<br />{0} (ID#: {1}) is enrolled in: ", student.Value.Name, student.Value.StudentId);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("<br />{0} - {1}", course.CourseId, course.Name);
                }
            }

        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */
            Student student = new Student();
            student.Name = "Chris Connell";
            student.StudentId = 102;

            student.Enrollment = new List<Enrollments>()
            {
                new Enrollments {Grade = 93, Course = new Course() {Name = "Biology 3", CourseId = 113 } },
                new Enrollments {Grade = 86, Course = new Course() {Name = "Physics 2", CourseId = 110 } }
            };

            resultLabel.Text += String.Format("Student: {0}", student.Name);
            foreach (var enrollment in student.Enrollment)
            {
                resultLabel.Text += String.Format("<br /><br />Course name: {0}<br />Grade: {1}", enrollment.Course.Name, enrollment.Grade);
            }



        }
    }
}