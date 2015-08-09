using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_1.Students_and_courses;

namespace StudentAndCoursesUnitTests
{
    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void CheckThatSchoolReturnsValidId()
        {
            School school = new School();
            var id = school.GetID();

            var isIdValid = (10000 >= id) && (id <= 99999);

            Assert.IsTrue(isIdValid, "School returns invalid id");
        }

        [TestMethod]
        public void CheckThatSchoolReturnsDifferentIDs()
        {
            School school = new School();
            var id1 = school.GetID();
            var id2 = school.GetID();

            Assert.AreNotEqual(id1, id2, "School returns the same id");
        }

        [TestMethod]
        public void ChechThatSchoolAddsCourse()
        {
            School school = new School();
            Course course = new Course();

            school.AddCourse(course);

            Assert.AreSame(course, school.Courses[0], "School does not add course");
        }

        [TestMethod]
        public void ChechThatCourseAddsStudent()
        {
            Student student = new Student("ivan", 10000);
            Course course = new Course();

            course.AddStudent(student);

            Assert.AreSame(student, course.Students[0], "Course does not add student");
        }

        [TestMethod]
        public void ChechThatCourseRemovesStudent()
        {
            Student student = new Student("ivan", 10000);
            Course course = new Course();

            course.AddStudent(student);
            course.RemoveStudent(student);

            Assert.AreEqual(0, course.Students.Count, "Course does not remove student");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckThatStudentThrowsIfNameIsEmpty()
        {
            Student student = new Student("", 10000);
        }
    }
}
