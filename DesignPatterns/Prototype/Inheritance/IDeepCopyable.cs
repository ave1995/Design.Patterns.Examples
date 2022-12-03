namespace DesignPatterns.Prototype.Inheritance
{
    public interface IDeepCopyable<T>
        where T : new()
    {
        void CopyTo(T target);
        public T DeepCopy()
        {
            T t = new();
            CopyTo(t);
            return t;
        }
    }
}
