namespace eCommerceSoa.DataAccess.Contract
{
    public interface ICommandHandler
    {
        void Execute<TInput>(TInput input);
        TOutput Execute<TInput, TOutput>(TInput input);
    }
}