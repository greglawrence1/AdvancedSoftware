using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment
{
    public class ValidateCommands
    {
        private String[] ACCEPTED_COMMANDS =
        {"reset", "clear", "circle", "rectangle", "triangle"
            , "drawto", "moveto", "fillon", "filloff"};

        public ValidateCommands()
        {

        }


        public bool IsAcceptedCommand(String command)
        {
            bool valid = ACCEPTED_COMMANDS.Any(c => c.Equals(command));

            return valid;
        }
    }
}
