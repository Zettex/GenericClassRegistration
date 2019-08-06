namespace WebApplication1
{
    public interface IBaseClass<T> where T : BaseEntity
    {
        bool GetFalse();
        bool GetTrue();
    }
}