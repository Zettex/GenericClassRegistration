namespace WebApplication1
{
    public class AccessPolicyService<TClass> : IAccessPolicyService<TClass> where TClass : class, new()
    {
        public TClass Policy { get; } = new TClass();
    }
}
