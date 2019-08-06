namespace WebApplication1
{
    public interface IAccessPolicyService<TClass> where TClass : class, new()
    {
        TClass Policy { get; }
    }
}