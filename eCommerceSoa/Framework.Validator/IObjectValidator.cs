namespace Framework.Validator
{
    public interface IObjectValidator
    {
        ValidationResult Validate(object obj);
    }

    public interface IObjectValidator<in T> where T : class
    {
        ValidationResult Validate(T obj);
    }
}
