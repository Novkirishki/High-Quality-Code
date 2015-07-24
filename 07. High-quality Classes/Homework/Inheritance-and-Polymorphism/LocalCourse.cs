namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class representing a local course
    /// </summary>
    public class LocalCourse : Course
    {
        private string lab;

        /// <summary>
        /// Initializes a new instance of the LocalCourse class
        /// </summary>
        /// <param name="courseName">Course name</param>
        /// <param name="teacherName">Teacher name</param>
        public LocalCourse(string courseName, string teacherName = null)
            : base(courseName, teacherName)
        {
            this.Lab = null;
        }

        /// <summary>
        /// Initializes a new instance of the LocalCourse class
        /// </summary>
        /// <param name="courseName">Course name</param>
        /// <param name="teacherName">Teacher name</param>
        /// <param name="students">Array of students</param>
        public LocalCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
            this.Lab = null;
        }

        /// <summary>
        /// Gets or sets course's lab. Value must not be empty string 
        /// </summary>
        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Invalid lab name");
                }

                this.lab = value;
            }
        }

        /// <summary>
        /// Gets course's info as string
        /// </summary>
        /// <returns>Returns course info</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse");
            result.Append(base.ToString());

            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");

            return result.ToString();
        }
    }
}
