using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment
{
    /// <summary>
    /// this is a class which validates certain commands
    /// </summary>
    public class ValidateCommands
    {
    /// <summary>
    /// this is an array of all the accepted commands 
    /// </summary>
        private String[] ACCEPTED_COMMANDS =
        {"reset", "clear", "circle", "rectangle", "triangle"
            , "drawto", "moveto", "fillon", "filloff"};

        /// <summary>
        /// Initializes a new instance of the validate commands
        /// </summary>
        public ValidateCommands()
        {

        }

        /// <summary>
        /// This checks whether a specificed command is accepted by seeing if there is a match
        /// </summary>
        /// <param name="command">this is the command to be validated</param>
        /// <returns></returns>
        public bool IsAcceptedCommand(String command)
        {
            bool valid = ACCEPTED_COMMANDS.Any(c => c.Equals(command));

            return valid;
        }
    }
}
