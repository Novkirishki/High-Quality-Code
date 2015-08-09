namespace Task_1.Students_and_courses
{  
    using System.Collections.Generic;

    public class School
    {
        private IList<Course> courses = new List<Course>();
        private int identifier = 9999;

        public IList<Course> Courses
        {
            get { return this.courses; }
        }

        public void AddCourse(Course course)
        {
            this.courses.Add(course);
        }

        public int GetID()
        {
            return ++this.identifier;
        }
    }
}
