using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserComputation
{
    public class MoodAnalyzerCustomException:Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            NO_SUCH_FIELD,
            NO_SUCH_METHOD,
            NO_SUCH_CLASS,
            OBJECT_CREATION_ISSUE
        }
        //Creating 'type' variable of type Exceptiontype
        private readonly ExceptionType type;
        
        /// Parameterized constructor sets the Exception Type and message.
        
        /// <param name="Type"></param>
        /// <param name="message"></param>
        public MoodAnalyzerCustomException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
    