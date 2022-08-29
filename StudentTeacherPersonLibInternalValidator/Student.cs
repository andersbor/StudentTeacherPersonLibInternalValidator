using System;

namespace StudentTeacherPersonLibInternalValidator
{
    public class Student : Person
    {
        public int Semester { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + Semester;
        }
        public void ValidateSemester()
        {
            if (Semester < 1)
                throw new ArgumentOutOfRangeException("Semester must be at least 1: " + Semester);
            if (Semester > 8)
                throw new ArgumentOutOfRangeException("Semester must be at most 8: " + Semester);
        }

        public override void Validate()
        {
            base.Validate();
            ValidateSemester();
        }
    }
}
