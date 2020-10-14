using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpressions;

namespace MSTestUserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstName()
        {
            //Arrange
            EntryValidation tool = new EntryValidation();
            string pattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";

            //Act
            bool actual = tool.IsValid(pattern, "Akash");
            bool expected = true;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@abc.com.au")]
        public void ValidateEmailTest(string name)
        {
            EntryValidation tool = new EntryValidation();
            string pattern = @"^[a-zA-Z0-9]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.][a-zA-Z]{3})+([.][a-zA-Z]{2})?$";
            bool actual = tool.IsValid(pattern, name);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        [DataRow("91 4648924567")]
        [DataRow("34 2598674945")]
        public void ValidateMobileNumberTest(string name)
        {
            EntryValidation validEntry = new EntryValidation();
            string pattern = @"^[0-9]{2}[ ][0-9]{10}$";
            bool actual = validEntry.IsValid(pattern, name);
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        [DataRow("hcAggfG13436@")]
        [DataRow("gchgcL#4675")]
        public void ValidatePasswordTest(string name)
        {
           EntryValidation tool = new EntryValidation();
            string pattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";
            bool actual = tool.IsValid(pattern, name);
            Assert.AreEqual(true, actual);
        }
    }
}
