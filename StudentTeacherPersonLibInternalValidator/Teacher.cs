using System;

namespace StudentTeacherPersonLibInternalValidator
{
    public class Teacher : Person
    {
        public int Salary { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + Salary;
        }

        public void ValidateSalary()
        {
            if (Salary < 0)
                throw new ArgumentOutOfRangeException("Salary must be at least 0: " + Salary);
        }

        public override void Validate()
        {
            base.Validate();
            ValidateSalary();
        }
    }
}
