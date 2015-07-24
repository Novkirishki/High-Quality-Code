namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Abstract class representing a course
    /// </summary>
    public abstract class Course
    {
        private string name;
        private string teacherName;
        private IList<string> students;

        /// <summary>
        /// Initializes a new instance of the Course class
        /// </summary>
        /// <param name="courseName">Course name</param>
        /// <param name="teacherName">Teacher name</param>
        public Course(string courseName, string teacherName = null)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = new List<string>();
        }

        /// <summary>
        /// Initializes a new instance of the Course class
        /// </summary>
        /// <param name="courseName">Course name</param>
        /// <param name="teacherName">Teacher name</param>
        /// <param name="students">Array of students</param>
        public Course(string courseName, string teacherName, IList<string> students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        /// <summary>
        /// Gets or sets course's name. Value must not be empty string
        /// </summary>
        public string Name 
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == string.Empty || value == null)
                {
                    throw new ArgumentException("Invalid course name");
                }

                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets teacher's name. Value must not be empty string
        /// </summary>
        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Invalid teacher name");
                }

                this.teacherName = value;
            }
        }

        /// <summary>
        /// Gets or sets students array
        /// </summary>
        public IList<string> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        /// <summary>
        /// Gets course's info as string
        /// </summary>
        /// <returns>Returns course info</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(" { Name = ");
            result.Append(this.Name);

            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            return result.ToString();
        }

        /// <summary>
        /// Gets students names as string separated by comma
        /// </summary>
        /// <returns>Students names</returns>
        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
