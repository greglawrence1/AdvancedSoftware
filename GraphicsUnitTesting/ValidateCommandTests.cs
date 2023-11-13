using GraphicsAssignment;

namespace GraphicsUnitTesting
{
    /// <summary>
    /// This is a test class for validating commands
    /// </summary>
    [TestClass]
    public class ValidateCommandTests
    {
        /// <summary>
        /// Tests the validate commands is accepted method to see if it returns true when expected
        /// </summary>
        [TestMethod]
        public void isAcceptedCommand_valid_returningTrue()
        {

            ValidateCommands validate = new ValidateCommands();
            string valid = "fillon";

            //Act
            bool result = validate.IsAcceptedCommand(valid);

            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// testing the is accepted method of the validate commands class to see if it is false
        /// </summary>
        [TestMethod]
        public void isAcceptedCommand_invalid_returningFalse()
        {

            ValidateCommands validate = new ValidateCommands();
            string valid = "invalid";

            //Act
            bool result = validate.IsAcceptedCommand(valid);

            //Assert
            Assert.IsFalse(result);
        }
    }
}