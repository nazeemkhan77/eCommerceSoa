namespace Framework.Validator
{
    public class FluentValidatorImpl<T> : IObjectValidator<T> where T : class 
    {
        public ValidationResult Validate(T obj)
        {
            throw new System.NotImplementedException();
        }
    }

    public class FluentValidatorImpl : IObjectValidator
    {
        public ValidationResult Validate(object obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
