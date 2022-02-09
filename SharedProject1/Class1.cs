namespace SharedProject1
{
    public class Person
    {
        internal string Name { get; set; } // Auto-property can be made get-only

        public Person(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public override string ToString()
        {
            return $"NAME: {Name.ToUpper()}";
        }
    }
}