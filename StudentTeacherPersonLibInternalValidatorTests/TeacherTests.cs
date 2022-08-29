using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentTeacherPersonLibInternalValidator;
using System;

namespace StudentTeacherPersonLibInternalValidator.Tests
{
    [TestClass()]
    public class TeacherTests
    {
        private Teacher teacher = new Teacher { Id = 1, Name = "Y", Salary = 0 };
        private Teacher teacherIllegalSalary = new Teacher { Id = 2, Name = "A", Salary = -1 };
        private Teacher teacherIllegalName = new Teacher { Id = 3, Name = "", Salary = 0 };
        
        [TestMethod()]
        public void ToStringTest()
        {
            Assert.AreEqual("1 Y 0", teacher.ToString());
        }

        [TestMethod()]
        public void ValidateSalary()
        {
            teacher.ValidateSalary();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => teacherIllegalSalary.ValidateSalary());
        }

        [TestMethod()]
        public void ValidateTest()
        {
            teacher.Validate();
            Assert.ThrowsException<ArgumentException>(() => teacherIllegalName.Validate());
        }
    }
}