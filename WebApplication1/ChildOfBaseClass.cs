namespace WebApplication1
{
    public class ChildOfBaseClass<T> : BaseClass<T> where T : Child2OfEntity
    {
        public bool GetSuperFalse()
        {
            return true;
        }
    }
}