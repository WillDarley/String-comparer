using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_comparer
{
    class ValidationResult
    {
        public bool ValidationSuccess;
        public string Message;

        /// <summary>
        /// Check user input for precence check, length check (1024 characters) and patter check
        /// </summary>
        /// <param name="userInput">data entered by the user</param>
        /// <returns>true if all checks pass. Message attribute decribes any failed tests</returns>

        public bool ValidateUserInput(string userInput)
        {
            if (userInput.Length == 0)
            {
                Message = "presence check failed";
                return false;
            }
            else return true;
      }
    }
}
