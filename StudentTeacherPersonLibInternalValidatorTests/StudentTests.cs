using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentTeacherPersonLibInternalValidator;
using System;

namespace StudentTeacherPersonLibInternalValidator.Tests
{
    [TestClass()]
    public class StudentTests
    {
        private Student studentSemester1 = new Student { Id = 1, Name = "Y", Semester = 1 };
        private Student studentSemester8 = new Student { Id = 1, Name = "Y", Semester = 8 };
        private Student studentSemesterLow = new Student { Id = 1, Name = "Y", Semester = 0 };
        private Student studentSemesterHigh = new Student { Id = 1, Name = "Y", Semester = 9 };

        [TestMethod()]
        public void ToStringTest()
        {
            string str = studentSemester1.ToString();    // act
            Assert.AreEqual("1 Y 1", str);      // assert
        }

        [TestMethod()]
        [DataRow(1)]
        [DataRow(8)]
        public void ValidateSemesterTest(int sem)
        {
            Student st = new Student { Id = 1, Name = "Y", Semester = sem };
            st.ValidateSemester();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => studentSemesterLow.ValidateSemester());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => studentSemesterHigh.ValidateSemester());
        }

        [TestMethod()]
        public void ValidateTest()
        {
            studentSemester1.Validate();
            studentSemester8.ValidateSemester();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => studentSemesterLow.Validate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => studentSemesterHigh.Validate());
        }
    }
}