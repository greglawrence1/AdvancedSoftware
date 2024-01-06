using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace GraphicsAssignment
{
    /// <summary>
    /// This is the class for parsing my commands
    /// </summary>
    public class Parser
    {
        private errorCheck errorCheck;
        private bool isAcceptedCommand;
        private Dictionary<string, int> variables;
        /// <summary>
        /// creating an instance of the MoveTo class
        /// </summary>
        private MoveTo moveto;
        /// <summary>
        /// the point tracking the current position
        /// </summary>
        private Point currentPosition;
        Pen p;
        /// <summary>
        /// the graphics object used for drawing
        /// </summary>
        Graphics g;
        /// <summary>
        /// Indicates whether to fill shapes for drawing
        /// </summary>
        private bool Fill;
        /// <summary>
        /// Object used for positioning
        /// </summary>
        /// <summary>
        /// Initializes the parser class
        /// </summary>
        /// <param name="g"> the graphic used for drawing</param>
        public Parser(Graphics g)
        {
            this.g = g;
            this.moveto = new MoveTo();
            this.moveto.InitialCursor(g);
            this.currentPosition = new Point(0, 0);
            p = PenSort.GetStarterPen();
            this.variables = new Dictionary<string, int>();
            this.errorCheck = new errorCheck();
        }

        public List<string> CheckSyntax(string commands)
        {
            return errorCheck.checkSyntax(commands);
        }
        public void setAcceptedCommand(bool value)
        {
            isAcceptedCommand = value;
        }
        /// <summary>
        /// Dictates Whether Shapes should be filled by getting a value of true or false
        /// </summary>
        public bool Filled
        {
            get { return Fill; }
            set { Fill = value; }
        }
        public void setPen(Color colour, int width)
        {
            p = PenSort.GetPen(colour, width);
        }
        /// <summary>
        /// Parses the commands
        /// </summary>
        /// <param name="commands">what gets parsed and is split when a new line occurs</param>
        public void parserCommand(string commands)
        {
            isAcceptedCommand = true;
            String[] commandList = commands.Split('\n');
            for (int i = 0; i < commandList.Length; i++)
            {
                try
                {
                    if(isAcceptedCommand)
                    {
                        parseCommand(commandList[i], i + 1);
                    }                 
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error on line " + (i + 1) + ": " + e.Message);
                }
            }

        }

        public int expressionParser(string[] expression)
        {
            int result = 0;

            string currentOperator = "+";

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == "+" || expression[i] == "-" || expression[i] == "*" || expression[i] == "/")
                {
                    currentOperator = expression[i];
                }
                else
                {
                    int currentNumber;
                    if (this.variables.TryGetValue(expression[i], out currentNumber))
                    {

                    }
                    else
                    {
                        int.TryParse(expression[i], out currentNumber);
                    }



                    if (currentOperator == "+")
                    {
                        result += currentNumber;
                    }
                    else if (currentOperator == "-")
                    {
                        result -= currentNumber;
                    }
                    else if (currentOperator == "*")
                    {
                        result *= currentNumber;
                    }
                    else if (currentOperator == "/")
                    {
                        result /= currentNumber;
                    }
                }
            }
            return result;
        }

        public bool operatorCheck(string[] command,int startIndex, int lineNumber)
        {
            string variable = command[startIndex + 1];
            string operatorVariable = command[startIndex + 2];
            int comparisonValue;

            if (int.TryParse(command[startIndex + 3], out comparisonValue) || variables.TryGetValue(command[startIndex + 3], out comparisonValue))
            {
                if (variables.TryGetValue(variable, out int variableValue))
                {

                    switch (operatorVariable)
                    {
                        case ">":
                            return variableValue > comparisonValue;
                        case "<":
                            return variableValue < comparisonValue;
                        case ">=":
                            return variableValue >= comparisonValue;
                        case "<=":
                            return variableValue <= comparisonValue;
                        case "==":
                            return variableValue == comparisonValue;
                        case "!=":
                            return variableValue != comparisonValue;
                        default:
                            Console.WriteLine("You have entered an incorrect operator");
                            return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Console.WriteLine("You have entered an incorrect variable");
                return false;
            }
        }


        public void executeIf(string[] command, int startIndex, int lineNumber)
        {
            if (command.Length < 4)
            {
                Console.WriteLine("You have entered an incorrect if statement on linenumber " + lineNumber);
                return;
            }

            string variable = command[startIndex + 1];
            string comparisonOperator = command[startIndex + 2];
            int comparisonValue;

            if (!int.TryParse(command[startIndex + 3], out comparisonValue) && !variables.TryGetValue(command[startIndex + 3], out comparisonValue))
            {
                Console.WriteLine("You have entered an incorrect if statement on linenumber " + lineNumber);
                return;
            }

            if(variables.TryGetValue(variable, out int variableValue))
            {
            bool condition = operatorCheck(command, startIndex, lineNumber);
                setAcceptedCommand(condition);

            if (isAcceptedCommand)
                {
                    
                    for(int i = startIndex + 4; i < command.Length; i++)
                    {
                        if (command[i] == "endif" || !isAcceptedCommand)
                        {
                            break;
                        }
                        parseCommand(command[i], lineNumber);
                    }
                }
            }
            else
            {
                Console.WriteLine("You have entered an incorrect variable on linenumber " + lineNumber);              
            
            }
        }


        public void executeWhile(string[] command, int startIndex, int lineNumber)
        {
            if (command.Length < 4)
            {
                Console.WriteLine("You have entered an incorrect if statement on linenumber " + lineNumber);
                return;
            }

            string variable = command[startIndex + 1];
            string comparisonOperator = command[startIndex + 2];
            int comparisonValue;

            if (!int.TryParse(command[startIndex + 3], out comparisonValue) && !variables.TryGetValue(command[startIndex + 3], out comparisonValue))
            {
                Console.WriteLine("You have entered an incorrect if statement on linenumber " + lineNumber);
                return;
            }

            if (variables.TryGetValue(variable, out int variableValue))
            {
                                                      
                while (isAcceptedCommand && operatorCheck(command, startIndex, lineNumber))
                {

                    for (int i = startIndex + 4; i < command.Length; i++)
                    {
                        if (command[i] == "endloop" || !isAcceptedCommand)
                        {
                            break;
                        }
                        parseCommand(command[i], lineNumber);
                    }
                    if (!isAcceptedCommand)
                    {
                        break;                                                      
                    }
                    variables[variable] = variableValue;
                    
                }
            }
            else
            {
                Console.WriteLine("You have entered an incorrect variable on linenumber " + lineNumber);

            }
        }

        /// <summary.>
        /// Parses a single command
        /// </summary>
        /// <param name="command">command gets parsed split with a space</param>
        public void parseCommand(string command, int lineNumber)
        {
            command.Trim().ToLower();
            String[] commands = command.Split(' ');
            ValidateCommands validate = new ValidateCommands();
            String firstcommand = commands[0];
            try
            {
                /*try
                 {
                     if (validate.IsAcceptedCommand(firstcommand) == false)
                     {

                         throw new InvalidOperationException("You have entered an incorrect command");
                     }
                 }
                 catch (InvalidOperationException)
                 {
                     Console.WriteLine("You have entered an incorrect command");
                 }
                 */
                if (commands[0] == "while")
                {
                    executeWhile(commands, 0, lineNumber);
                }   
                if (commands[0] == "if")
                {
                    executeIf(commands, 0, lineNumber);
                }

                if (commands[1] == "=")
                {
                    string variable = commands[0];

                    if (commands.Length > 2)
                    {
                        if (commands.Contains("+"))
                        {
                            int result = expressionParser(commands.Skip(2).ToArray());
                            this.variables[variable] = result;
                        }
                        else if (commands.Contains("-"))
                        {
                            int result = expressionParser(commands.Skip(2).ToArray());
                            this.variables[variable] = result;
                        }
                        else if (commands.Contains("*"))
                        {
                            int result = expressionParser(commands.Skip(2).ToArray());
                            this.variables[variable] = result;
                        }
                        else if (commands.Contains("/"))
                        {
                            int result = expressionParser(commands.Skip(2).ToArray());
                            this.variables[variable] = result;
                        }
                        else
                        {
                            int value = int.Parse(commands[2]);
                            this.variables.Add(variable, value);
                        }
                    }
                }

                if (commands[0] == "fillon")
                {
                    Filled = true;
                }
                if (commands[0] == "filloff")
                {
                    Filled = false;
                }
                if (commands[0] == "setpen")
                {
                    try
                    {
                        if (commands[1] == "black")
                        {
                            setPen(Color.Black, 2);
                        }
                        if (commands[1] == "red")
                        {
                            setPen(Color.Red, 2);
                        }
                        if (commands[1] == "blue")
                        {
                            setPen(Color.Blue, 2);
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("You need to choose either black, red or blue for your pen");
                    }
                }
                if (commands[0] == "circle")
                {
                    try
                    {
                        if (commands.Length != 2)
                        {
                            throw new FormatException("You need to insert a single number for your circle error is on line " + lineNumber);
                        }
                        int e;
                        if (int.TryParse(commands[1], out e))
                        {

                        }
                        else if (this.variables.ContainsKey(commands[1]))
                        {
                            e = this.variables[commands[1]];
                        }
                        else
                        {
                            throw new FormatException("You need to insert a single number for your circle error is on line " + lineNumber);
                        }
                        Circle c = new Circle(Color.Snow, currentPosition.X, currentPosition.Y, e, Filled);
                        c.draw(g, p);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error on line " + lineNumber + " You need to insert a single number for your circle");
                    }

                }
                if (commands[0] == "rectangle")
                {
                    try
                    {
                        int q1 = int.Parse(commands[1]);
                        int q2 = int.Parse(commands[2]);
                        Rectangle r = new Rectangle(Color.AliceBlue, currentPosition.X, currentPosition.Y, q1, q2, Filled);
                        r.draw(g, p);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error on line " + lineNumber + " You need to insert numbers for your Rectangle");
                    }
                }
                if (commands[0] == "triangle")
                {
                    try
                    {
                        int t1 = int.Parse(commands[1]);
                        int t2 = int.Parse(commands[2]);
                        int t3 = int.Parse(commands[3]);

                        Triangle t = new Triangle(Color.AliceBlue, t1, t2, t3, Filled);
                        t.draw(g, p);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("You need to insert numbers for your triangle");
                    }
                }
                if (commands[0] == "clear")
                {
                    Clear clear = new Clear(g);
                    clear.ClearImage();
                }
                if (commands[0] == "drawto")
                {
                    try
                    {
                        int i = int.Parse(commands[1]);
                        int f = int.Parse(commands[2]);
                        g.DrawLine(p, currentPosition.X, currentPosition.Y, i, f);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("You need to insert numbers following your drawline");
                    }
                }
                if (commands[0] == "moveto")
                {

                    try
                    {
                        if (commands.Length > 3 || commands.Length <= 2)
                        {
                            throw new FormatException("You need to insert two numbers for your moveto");
                        }
                        {
                            int m1 = int.Parse(commands[1]);
                            int m2 = int.Parse(commands[2]);
                            moveto.ClearPrevious(g);
                            currentPosition = new Point(m1, m2);
                            moveto.Move(g, m1, m2);
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("You need to insert two numbers following your moveto");
                    }

                }
                if (commands[0] == "reset")
                {
                    moveto.ClearPrevious(g);
                    moveto.ResetCursor(g);
                    currentPosition = new Point(0, 0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error on Line " + lineNumber);
            }
        }
    }
}