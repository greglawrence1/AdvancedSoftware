﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment
{
    public class errorCheck
    {
        private Dictionary<string, int> variables;
        public errorCheck()
        {
            this.variables = new Dictionary<string, int>();
        }
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


                    if (words[1] == "=")
                    {
                        string variable = words[0];

                        if (words.Length > 2)
                        {
                            if (words.Contains("+"))
                            {
                                int result = expressionParser(words.Skip(2).ToArray());
                                this.variables[variable] = result;
                            }
                            else if (words.Contains("-"))
                            {
                                int result = expressionParser(words.Skip(2).ToArray());
                                this.variables[variable] = result;
                            }
                            else if (words.Contains("*"))
                            {
                                int result = expressionParser(words.Skip(2).ToArray());
                                this.variables[variable] = result;
                            }
                            else if (words.Contains("/"))
                            {
                                int result = expressionParser(words.Skip(2).ToArray());
                                this.variables[variable] = result;
                            }
                            else
                            {
                                int value = int.Parse(words[2]);
                                this.variables.Add(variable, value);
                            }
                        }
                    }
                    if (words.Length > 0)
                    {
                        string firstWord = words[0];

                        if (firstWord == "circle")
                        {
                            if (words.Skip(1).ToArray().Length != 1)
                            {
                                errors.Add("Error on line " + (i + 1) + ": " + "Circle command must have 1 parameters");
                                continue;
                            }
                            if (!this.variables.ContainsKey(words[1]))
                            {
                                errors.Add("Error on line " + (i + 1) + ": " + "Circle command must have a correct number or variable");
                                continue;
                            }
                            int e;
                            if (int.TryParse(words[1], out e))
                            {
                                if (e > 50 || e < 0)
                                {
                                    errors.Add("Error on line " + (i + 1) + ": " + "Circle command must have a correct number or variable");
                                    continue;
                                }

                            }
                        }
                        else if (firstWord == "if")
                        {
                            if (words.Length <= 2)
                            {
                                errors.Add("Error on line " + (i + 1) + ": " + "If command must have at least 2 parameters");
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

    }
}
