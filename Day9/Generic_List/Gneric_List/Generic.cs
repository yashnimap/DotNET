namespace Gneric_List
{
    public class Generic
    {
        public bool comapare<T>(T t1, T t2)
        {
            if (t1.Equals(t2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
