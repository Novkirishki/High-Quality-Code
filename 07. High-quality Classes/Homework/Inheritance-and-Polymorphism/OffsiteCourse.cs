namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class representing an offsite course
    /// </summary>
    public class OffsiteCourse : Course
    {
        private string town;

        /// <summary>
        /// Initializes a new instance of the OffsiteCourse class
        /// </summary>
        /// <param name="courseName">Course name</param>
        /// <param name="teacherName">Teacher name</param>
        public OffsiteCourse(string courseName, string teacherName = null) 
            : base(courseName, teacherName)
        {
            this.Town = null;
        }

        /// <summary>
        /// Initializes a new instance of the OffsiteCourse class
        /// </summary>
        /// <param name="courseName">Course name</param>
        /// <param name="teacherName">Teacher name</param>
        /// <param name="students">Array of students</param>
        public OffsiteCourse(string courseName, string teacherName, IList<string> students) 
            : base(courseName, teacherName, students)
        {
            this.Town = null;
        }

        /// <summary>
        /// Gets or sets course's town. Value must not be empty string 
        /// </summary>
        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Invalid town name");
                }

                this.town = value;
            }
        }

        /// <summary>
        /// Gets course's info as string
        /// </summary>
        /// <returns>Returns course info</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse");
            result.Append(base.ToString());
           
            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");

            return result.ToString();
        }
    }
}
