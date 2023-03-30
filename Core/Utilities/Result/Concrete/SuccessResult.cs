﻿namespace Core.Utilities.Result.Concrete
{
    public class SuccessResult : Result
    {
        public SuccessResult() : base(true)
        {
        }

        public SuccessResult(string message) : base(true, message)
        {
        }

        public SuccessResult(string message, int statusCode) : base(true, message, statusCode)
        {
        }

        public SuccessResult(int statusCode) : base(true, "", statusCode)
        {

        }
    }
}
