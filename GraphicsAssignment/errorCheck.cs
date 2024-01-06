using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment
{
    public class errorCheck
    {
        public List<string> checkSyntax(string commands)
        {
            List<string> errors = new List<string>();
            string[] lines = commands.Split('\n');

            for(int i = 0; i < lines.Length; i++)
            {
                try
                {
                    string command = lines[i].Trim().ToLower();
                    string[] words = command.Split(' ');

                    if (words.Length > 0)
                    {
                        string firstWord = words[0];

                        if (firstWord == "circle")
                        {
                            if (words.Length != 2)
                            {
                                errors.Add("Error on line " + (i + 1) + ": " + "Circle command must have 1 parameters");
                                continue;
                            }
                        }
                    }

                }catch(Exception e)
                {
                    errors.Add("Error on line " + (i + 1) + ": " + e.Message);
                }
            }
            return errors;
        }
    }
}
