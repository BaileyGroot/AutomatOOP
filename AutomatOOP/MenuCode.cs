using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AutomatOOP
{
    class MenuCode
    {
            // Properties
            private int SelectedIndex;
            private string[] Options;

            // Consturctor
            public MenuCode(string[] options)
            {
                Options = options;
                SelectedIndex = 0;
            }

            // Methods

            public void DisplayOptions()
            {
                for (int i = 0; i < Options.Length; i++)
                {
                    string currentOption = Options[i];
                    string prefix;

                    if (i == SelectedIndex)
                    {
                        prefix = ">";
                        ForegroundColor = ConsoleColor.Black;
                        BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        prefix = " ";
                        BackgroundColor = ConsoleColor.Black;
                        ForegroundColor = ConsoleColor.White;
                    }
                    WriteLine($"{prefix} {currentOption}");
                }
                ResetColor();
            }
            public int Run()
            {
                ConsoleKey keyPressed;
                do
                {
                    Clear();
                    DisplayOptions();

                    ConsoleKeyInfo keyInfo = ReadKey(true);
                    keyPressed = keyInfo.Key;

                    // Update SelectedIndex based on arrow keys.

                    if (keyPressed == ConsoleKey.UpArrow)
                    {
                        SelectedIndex--;
                        if (SelectedIndex == -1)
                        {
                            SelectedIndex = Options.Length - 1;
                        }
                    }
                    else if (keyPressed == ConsoleKey.DownArrow)
                    {
                        SelectedIndex++;
                        if (SelectedIndex == Options.Length)
                        {
                            SelectedIndex = 0;
                        }
                    }

                } while (keyPressed != ConsoleKey.Enter);

                return SelectedIndex;
            }
        }
    }

