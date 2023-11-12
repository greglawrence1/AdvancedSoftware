using GraphicsAssignment;

namespace GraphicsUnitTesting
{
    [TestClass]
    public class ValidateCommandTests
    {
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