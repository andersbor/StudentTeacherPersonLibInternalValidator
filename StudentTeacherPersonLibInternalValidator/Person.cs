namespace StudentTeacherPersonLibInternalValidator
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public override string ToString()
        {
            return Id + " " + Name;
        }

        public void ValidateName()
        {
            if (Name == null)
                throw new ArgumentNullException("name is null");
            if (Name.Length < 1)
                throw new ArgumentException("name must be at least 1 character");
        }

        public virtual void Validate()
        {
            ValidateName();
        }
    }
}