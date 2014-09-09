namespace Framework.Validator
{
    public class ValidationResult
    {
        public ValidationResult(bool success, Error[] errors)
        {
            this.Success = success;
            this.Errors = errors;
        }

        public bool Success { private set;  get; }
        public Error[] Errors { private set; get; }
    }
}