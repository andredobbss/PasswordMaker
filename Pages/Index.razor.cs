using Microsoft.AspNetCore.Components;
using System.Text;

namespace PasswordMaker.Pages;

public partial class IndexBack : ComponentBase
{
    #region Propreties  
    const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    const string lowercase = "abcdefghijklmnopqrstuvwxyz";
    const string number = "1234567890";
    const string especial = "(!@#$%&*()-+.,;?{[}]^><:)";
    #endregion

    #region Methods

    public static List<string> GenerateRandomPassword(bool _uppercase, bool _lowercase, bool _number, bool _especial, int intValueSize, int intValueNumber)
    {
        string? validChars = null;

        try
        {
            if (_uppercase == true && _lowercase == false && _number == false && _especial == false)
            {
                validChars = uppercase;
            }
            else if (_uppercase == false && _lowercase == true && _number == false && _especial == false)
            {
                validChars = lowercase;
            }
            else if (_uppercase == false && _lowercase == false && _number == true && _especial == false)
            {
                validChars = number;
            }
            else if (_uppercase == false && _lowercase == false && _number == false && _especial == true)
            {
                validChars = especial;
            }
            else if (_uppercase == true && _lowercase == true && _number == false && _especial == false)
            {
                validChars = uppercase + lowercase;
            }
            else if (_uppercase == true && _lowercase == false && _number == true && _especial == false)
            {
                validChars = uppercase + number;
            }
            else if (_uppercase == true && _lowercase == false && _number == false && _especial == true)
            {
                validChars = uppercase + especial;
            }
            else if (_uppercase == false && _lowercase == true && _number == true && _especial == false)
            {
                validChars = lowercase + number;
            }
            else if (_uppercase == false && _lowercase == true && _number == false && _especial == true)
            {
                validChars = lowercase + especial;
            }
            else if (_uppercase == false && _lowercase == false && _number == true && _especial == true)
            {
                validChars = number + especial;
            }
            else if (_uppercase == true && _lowercase == true && _number == true && _especial == false)
            {
                validChars = uppercase + lowercase + number;
            }
            else if (_uppercase == true && _lowercase == false && _number == true && _especial == true)
            {
                validChars = uppercase + number + especial;
            }
            else if (_uppercase == true && _lowercase == true && _number == false && _especial == true)
            {
                validChars = uppercase + lowercase + especial;
            }
            else if (_uppercase == false && _lowercase == true && _number == true && _especial == true)
            {
                validChars = lowercase + number + especial;
            }
            else if (_uppercase == true && _lowercase == true && _number == true && _especial == true)
            {
                validChars = uppercase + lowercase + number + especial;
            }
            else
            {
                validChars = null;
            }


            Random random = new Random();

            List<string> chars = new List<string>();

            if (string.IsNullOrEmpty(validChars))
            {
                return null;
            }
            else
            {
                for (int j = 0; j < intValueNumber; j++)
                {
                    StringBuilder password = new StringBuilder();

                    for (int i = 0; i < intValueSize; i++)
                    {
                        int index = random.Next(validChars.Length);
                        password.Append(validChars[index]);
                    }
                    chars.Add(password.ToString());
                }

                return chars;
            }
        }
        catch
        {
            throw;
        }
    }

    #endregion
}

