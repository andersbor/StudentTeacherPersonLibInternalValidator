using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentTeacherPersonLibInternalValidator;
using System;

namespace StudentTeacherPersonLibInternalValidator.Tests
{
    [TestClass()]
    public class PersonTests
    {
        private Person person = new Person { Id = 1, Name = "Y" };
        private Person personNameNull = new Person { Id = 1, Name = null };
        private Person personNameShort = new Person { Id = 1, Name = "" };

        [TestMethod()]
        public void ToStringTest()
        {
            String str = person.ToString(); // act
            Assert.AreEqual("1 Y", str);    // assert
        }

        [TestMethod()]
        public void ValidateNameTest()
        {
            person.ValidateName();
            Assert.ThrowsException<ArgumentNullException>(() => personNameNull.ValidateName());
            Assert.ThrowsException<ArgumentException>(() => personNameShort.ValidateName());
        }

        [TestMethod()]
        public void ValidateTest()
        {
            person.Validate();
            Assert.ThrowsException<ArgumentNullException>(() => personNameNull.Validate());
            Assert.ThrowsException<ArgumentException>(() => personNameShort.Validate());
        }
    }
}