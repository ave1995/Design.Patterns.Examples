namespace DesignPatterns.Prototype.Inheritance
{
    public class Person : IDeepCopyable<Person>
    {
        public string[] Names;
        public Address Address;

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(",", Names)}, {nameof(Address)}: {Address}";
        }

        public void CopyTo(Person target)
        {
            target.Names = (string[])Names.Clone();
            target.Address = Address.DeepCopy();
        }
    }
}
