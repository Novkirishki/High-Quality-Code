namespace Methods
{
    using System;

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherInfo { get; set; }

        public string Birthdate { get; set; }

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate = DateTime.Parse(this.Birthdate);
            DateTime secondDate = DateTime.Parse(other.Birthdate);
            return firstDate < secondDate;
        }
    }
}
