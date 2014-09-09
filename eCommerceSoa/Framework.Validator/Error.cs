namespace Framework.Validator
{
    public class Error
    {
        public Error(string fieldName, string errorMessage)
        {
            this.FieldName = fieldName;
            this.ErrorMessage = errorMessage;
        }

        public string FieldName { get; set; }
        public string ErrorMessage { get; set; }
    }
}