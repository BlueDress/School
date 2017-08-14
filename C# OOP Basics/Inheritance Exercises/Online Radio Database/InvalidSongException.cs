

using System;

namespace Online_Radio_Database
{
    public class InvalidSongException : Exception
    {
        private string exceptionMessage = "Invalid song.";

        protected virtual string ExceptionMessage
        {
            get
            {
                return this.exceptionMessage;
            }
            set
            {
                this.exceptionMessage = value;
            }
        }

        public override string Message
        {
            get
            {
                return this.ExceptionMessage;
            }
        }  
    }
}
