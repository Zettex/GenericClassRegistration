namespace WebApplication1
{
    public class ChildOfBaseClass<T> : BaseClass<T> where T : BaseChildOfEntity
    {
        public string GetSuperFalse(T entity)
        {
            return typeof(T).ToString();
        }
    }
}