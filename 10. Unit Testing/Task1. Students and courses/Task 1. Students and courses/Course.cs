namespace Task_1.Students_and_courses
{
    using System.Collections.Generic;

    public class Course
    {
        private IList<Student> students = new List<Student>();

        public IList<Student> Students
        {
            get { return this.students; }
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }
    }
}
